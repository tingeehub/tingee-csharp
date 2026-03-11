using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using Tingee.Sdk.Signature;
using Tingee.Sdk.Types;

namespace Tingee.Sdk.Http;

public enum HttpMethod
{
    Get,
    Post,
    Put,
    Patch,
    Delete
}

public sealed class HttpRequestOptions
{
    public HttpMethod Method { get; init; }
    public string Path { get; init; } = null!;
    public object? Body { get; init; }
    public IDictionary<string, string?>? Query { get; init; }
    public IDictionary<string, string>? Headers { get; init; }
    public int? TimeoutMilliseconds { get; init; }
}

public sealed class HttpResponse<T>
{
    public int StatusCode { get; init; }
    public T? Data { get; init; }
    public IDictionary<string, string> Headers { get; init; } = new Dictionary<string, string>();
}

public sealed class TingeeHttpClient
{
    private static readonly JsonSerializerOptions JsonOptions = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = { new Tingee.Sdk.Types.JsonEnumMemberConverterFactory() }
    };

    private readonly string _baseUrl;
    private readonly string _secretKey;
    private readonly string _clientId;
    private readonly int _defaultTimeoutMilliseconds;
    private readonly System.Net.Http.HttpClient _httpClient;

    public TingeeHttpClient(
        string baseUrl,
        string secretKey,
        string clientId,
        int timeoutMilliseconds = 90_000)
    {
        _baseUrl = baseUrl.TrimEnd('/');
        _secretKey = secretKey;
        _clientId = clientId;
        _defaultTimeoutMilliseconds = timeoutMilliseconds;

        _httpClient = new System.Net.Http.HttpClient
        {
            Timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds)
        };
    }

    public async Task<HttpResponse<T>> RequestAsync<T>(
        HttpMethod method,
        string path,
        object? body = null,
        IDictionary<string, string?>? query = null,
        IDictionary<string, string>? headers = null,
        CancellationToken cancellationToken = default)
    {
        var options = new HttpRequestOptions
        {
            Method = method,
            Path = path,
            Body = body,
            Query = query,
            Headers = headers
        };

        return await RequestAsync<T>(options, cancellationToken);
    }

    public async Task<HttpResponse<T>> RequestAsync<T>(
        HttpRequestOptions options,
        CancellationToken cancellationToken = default)
    {
        var method = options.Method;
        var path = options.Path;
        var body = options.Body;

        // CRITICAL: serialize body ONCE and use the same JSON for both signature and HTTP body.
        // Previously body was serialized twice with different options, causing signature mismatch.
        // When body is null: sign with "{}" to match Node.js (body || {}) and Java (body != null ? body : new HashMap<>())
        var jsonBody = body is not null
            ? JsonSerializer.Serialize(body, JsonOptions)
            : null;



        var timestamp = SignatureUtils.FormatTimestamp();
        var signature = SignatureUtils.GenerateSignature(_secretKey, timestamp, jsonBody ?? "{}");

        var urlBuilder = new StringBuilder();
        urlBuilder.Append(_baseUrl);
        urlBuilder.Append(path.StartsWith('/') ? path : "/" + path);

        if (options.Query is { Count: > 0 })
        {
            var first = true;
            foreach (var kv in options.Query)
            {
                if (kv.Value is null) continue;
                urlBuilder.Append(first ? '?' : '&');
                first = false;
                urlBuilder.Append(Uri.EscapeDataString(kv.Key));
                urlBuilder.Append('=');
                urlBuilder.Append(Uri.EscapeDataString(kv.Value));
            }
        }

        var url = urlBuilder.ToString();

        using var request = new System.Net.Http.HttpRequestMessage(
            ToHttpMethod(method),
            url);

        request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        request.Headers.Add("x-signature", signature);
        request.Headers.Add("x-request-timestamp", timestamp);
        request.Headers.Add("x-client-id", _clientId);
        request.Headers.Add("x-sdk-version", $"tingee-sdk/csharp/{SdkVersion.Version}");

        if (options.Headers is not null)
        {
            foreach (var kv in options.Headers)
            {
                request.Headers.TryAddWithoutValidation(kv.Key, kv.Value);
            }
        }

        if (jsonBody is not null)
        {
            request.Content = new StringContent(jsonBody, Encoding.UTF8, "application/json");
        }

        try
        {
            using var response = await _httpClient.SendAsync(request, cancellationToken);

            var responseContent = response.Content is null
                ? null
                : await response.Content.ReadAsStringAsync(cancellationToken);

            var headers = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            foreach (var header in response.Headers)
            {
                headers[header.Key] = string.Join(",", header.Value);
            }
            if (response.Content?.Headers is not null)
            {
                foreach (var header in response.Content.Headers)
                {
                    headers[header.Key] = string.Join(",", header.Value);
                }
            }

            if (!response.IsSuccessStatusCode)
            {
                throw new TingeeHttpException(
                    $"Request failed with status {(int)response.StatusCode}",
                    (int)response.StatusCode,
                    responseContent,
                    headers);
            }

            T? data = default;
            if (!string.IsNullOrWhiteSpace(responseContent))
            {
                try
                {
                    data = JsonSerializer.Deserialize<T>(responseContent, JsonOptions);
                }
                catch (JsonException)
                {
                    // Fallback to raw string if target type is object or string
                    if (typeof(T) == typeof(string) || typeof(T) == typeof(object))
                    {
                        data = (T?)(object?)responseContent;
                    }
                    else
                    {
                        throw;
                    }
                }
            }

            return new HttpResponse<T>
            {
                StatusCode = (int)response.StatusCode,
                Data = data,
                Headers = headers
            };
        }
        catch (TaskCanceledException ex) when (!cancellationToken.IsCancellationRequested)
        {
            throw new TingeeHttpException(
                $"Request timeout after {options.TimeoutMilliseconds ?? _defaultTimeoutMilliseconds}ms",
                0,
                null,
                new Dictionary<string, string>(),
                ex);
        }
        catch (TingeeHttpException)
        {
            throw;
        }
        catch (Exception ex)
        {
            throw new TingeeHttpException(
                ex.Message,
                0,
                null,
                new Dictionary<string, string>(),
                ex);
        }
    }

    private static System.Net.Http.HttpMethod ToHttpMethod(HttpMethod method) =>
        method switch
        {
            HttpMethod.Get => System.Net.Http.HttpMethod.Get,
            HttpMethod.Post => System.Net.Http.HttpMethod.Post,
            HttpMethod.Put => System.Net.Http.HttpMethod.Put,
            HttpMethod.Patch => System.Net.Http.HttpMethod.Patch,
            HttpMethod.Delete => System.Net.Http.HttpMethod.Delete,
            _ => throw new ArgumentOutOfRangeException(nameof(method), method, null)
        };
}

