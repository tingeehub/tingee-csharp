using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace Tingee.Sdk.Signature;

public static class SignatureUtils
{
    private static readonly JsonSerializerOptions JsonOptions = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        Converters = { new Tingee.Sdk.Types.JsonEnumMemberConverterFactory() }
    };

    /// <summary>
    /// Generate signature for Tingee API request.
    /// Signature format: HMAC-SHA512(secretKey, timestamp:JSON.stringify(body))
    /// body=null → "{}" to match Node.js/Java: body || {} / body != null ? body : new HashMap
    /// </summary>
    public static string GenerateSignature(string secretKey, string timestamp, object? body)
    {
        // Node.js: body || {}  →  JSON.stringify({}) === "{}"
        // Java:    body != null ? body : new HashMap<>()  →  "{}"
        var jsonBody = body is not null
            ? JsonSerializer.Serialize(body, JsonOptions)
            : "{}";
        return GenerateSignature(secretKey, timestamp, jsonBody);
    }

    /// <summary>Generate HMAC-SHA512 signature from an already-serialized JSON string body.</summary>
    public static string GenerateSignature(string secretKey, string timestamp, string bodyJson)
    {
        var message = $"{timestamp}:{bodyJson}";
        using var hmac = new HMACSHA512(Encoding.UTF8.GetBytes(secretKey));
        var hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(message));
        var sb = new StringBuilder(hash.Length * 2);
        foreach (var b in hash)
        {
            sb.Append(b.ToString("x2"));
        }
        return sb.ToString();
    }

    /// <summary>
    /// Format current Vietnam time (UTC+7) to yyyyMMddHHmmssfff.
    /// Tingee API validates timestamps within ±10 minutes of server time (Vietnam timezone).
    /// </summary>
    public static string FormatTimestamp()
    {
        // Vietnam Standard Time = UTC+7, no DST
        var vnZone = TimeZoneInfo.FindSystemTimeZoneById("Asia/Ho_Chi_Minh");
        var vnTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, vnZone);
        return FormatTimestamp(new DateTimeOffset(vnTime));
    }

    public static string FormatTimestamp(DateTimeOffset dateTime)
    {
        var basePart = dateTime.ToString("yyyyMMddHHmmss");
        var millis   = dateTime.Millisecond.ToString("D3");
        return basePart + millis;
    }
}

