using Tingee.Sdk.Http;
using Tingee.Sdk.Signature;
using Tingee.Sdk.Types;

namespace Tingee.Sdk.Client;

public enum TingeeEnvironment
{
    Production,
    Uat
}

public sealed class TingeeClientOptions
{
    public string SecretKey { get; init; } = null!;
    public string ClientId { get; init; } = null!;
    public TingeeEnvironment Environment { get; init; } = TingeeEnvironment.Production;
    /// <summary>Custom base URL. If set, overrides Environment.</summary>
    public string? BaseUrl { get; init; }
    /// <summary>Request timeout in milliseconds. Default 90000 (90s).</summary>
    public int TimeoutMilliseconds { get; init; } = 90_000;
}

public sealed partial class TingeeClient
{
    private static readonly IReadOnlyDictionary<TingeeEnvironment, string> EnvironmentUrls =
        new Dictionary<TingeeEnvironment, string>
        {
            { TingeeEnvironment.Production, "https://open-api.tingee.vn" },
            { TingeeEnvironment.Uat, "https://uat-open-api.tingee.vn" }
        };

    private readonly TingeeHttpClient _httpClient;
    private readonly string _secretKey;

    public string BaseUrl { get; }
    
    public TingeeV1CustomMethods V1 { get; }

    public TingeeClient(TingeeClientOptions options)
    {
        if (string.IsNullOrWhiteSpace(options.SecretKey))
        {
            throw new ArgumentException("SecretKey is required", nameof(options));
        }

        if (string.IsNullOrWhiteSpace(options.ClientId))
        {
            throw new ArgumentException("ClientId is required", nameof(options));
        }

        BaseUrl = options.BaseUrl ?? EnvironmentUrls[options.Environment];
        _secretKey = options.SecretKey;

        _httpClient = new TingeeHttpClient(
            BaseUrl,
            options.SecretKey,
            options.ClientId,
            options.TimeoutMilliseconds);

        V1 = new TingeeV1CustomMethods(_httpClient);
    }

    /// <summary>Verify an incoming Tingee webhook signature using the secretKey already set on this instance.</summary>
    public WebhookVerifyResult VerifyWebhookSignature(
        string?                     signature,
        string?                     timestamp,
        Dictionary<string, object>? body)
        => TingeeSigner.VerifyWebhookSignature(_secretKey, signature, timestamp, body);
}
