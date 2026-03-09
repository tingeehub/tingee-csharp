using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace Tingee.Sdk.Signature;

/// <summary>Result of <see cref="TingeeSigner.VerifyWebhookSignature(string, string?, string?, string?)"/>.</summary>
public sealed class WebhookVerifyResult
{
    public string Code    { get; init; } = string.Empty;
    public string Message { get; init; } = string.Empty;

    /// <summary>True when Code == "00".</summary>
    public bool IsValid => Code == "00";

    public override string ToString() => $"{{code: \"{Code}\", message: \"{Message}\"}}";
}

/// <summary>Tingee webhook signature utilities.</summary>
public static class TingeeSigner
{
    private static readonly string[] RequiredBodyFields =
        ["clientId", "transactionCode", "amount", "bank", "accountNumber", "transactionDate"];

    // ── Helpers ───────────────────────────────────────────────────────────────

    /// <summary>
    /// Generate HMAC-SHA512 signature for a Tingee API request.
    /// message = "{timestamp}:{json_body}"
    /// </summary>
    public static string GenerateSignature(string secretKey, string timestamp, object body)
        => GenerateSignature(secretKey, timestamp, JsonSerializer.Serialize(body));

    /// <summary>Generate HMAC-SHA512 signature from raw JSON string body.</summary>
    public static string GenerateSignature(string secretKey, string timestamp, string bodyJson)
    {
        var message  = $"{timestamp}:{bodyJson}";
        var keyBytes = Encoding.UTF8.GetBytes(secretKey);
        var msgBytes = Encoding.UTF8.GetBytes(message);

        using var hmac = new HMACSHA512(keyBytes);
        var hash = hmac.ComputeHash(msgBytes);
        return Convert.ToHexString(hash).ToLowerInvariant();
    }

    /// <summary>Format a DateTime to Tingee timestamp format: yyyyMMddHHmmssSSS.</summary>
    public static string FormatTimestamp(DateTime? dt = null) =>
        (dt ?? DateTime.Now).ToString("yyyyMMddHHmmssSSS");

    // ── Verify ────────────────────────────────────────────────────────────────

    /// <summary>
    /// Verify the HMAC-SHA512 signature of an incoming Tingee webhook callback.
    /// </summary>
    /// <example>
    /// <code>
    /// var result = TingeeSigner.VerifyWebhookSignature(
    ///     secretToken: Environment.GetEnvironmentVariable("TINGEE_SECRET_TOKEN")!,
    ///     signature:   Request.Headers["x-signature"],
    ///     timestamp:   Request.Headers["x-request-timestamp"],
    ///     body:        await Request.ReadFromJsonAsync&lt;TingeeWebhookBody&gt;()
    /// );
    /// if (!result.IsValid)
    ///     return Unauthorized(result);
    /// </code>
    /// </example>

    private static readonly System.Text.RegularExpressions.Regex TimestampRegex =
        new(@"^\d{17}$", System.Text.RegularExpressions.RegexOptions.Compiled);

    /// <summary>Verify webhook signature from a raw JSON string body.</summary>
    public static WebhookVerifyResult VerifyWebhookSignature(
        string  secretToken,
        string? signature,
        string? timestamp,
        string? bodyJson)
    {
        if (string.IsNullOrEmpty(signature))
            return new() { Code = "MISSING_SIGNATURE", Message = "x-signature header is required" };
        if (string.IsNullOrEmpty(timestamp))
            return new() { Code = "MISSING_TIMESTAMP", Message = "x-request-timestamp header is required" };
        if (!TimestampRegex.IsMatch(timestamp))
            return new() { Code = "INVALID_TIMESTAMP", Message = "x-request-timestamp must be in yyyyMMddHHmmssSSS format (17 digits)" };

        if (string.IsNullOrEmpty(bodyJson))
            return new() { Code = "MISSING_BODY", Message = "body is required and must be an object" };

        // Validate required fields using JsonDocument (no dependency on TingeeWebhookBody)
        try
        {
            using var doc = JsonDocument.Parse(bodyJson);
            var root = doc.RootElement;
            foreach (var field in RequiredBodyFields)
            {
                if (!root.TryGetProperty(field, out var prop)
                    || prop.ValueKind == JsonValueKind.Null
                    || (prop.ValueKind == JsonValueKind.String && string.IsNullOrEmpty(prop.GetString())))
                {
                    return new() { Code = "MISSING_BODY_FIELD", Message = $"body.{field} is required" };
                }
            }
        }
        catch
        {
            return new() { Code = "INVALID_BODY", Message = "body string is not valid JSON" };
        }

        // Compute HMAC-SHA512 on raw string: "{timestamp}:{bodyJson}" — same as Node.js
        var expected = GenerateSignature(secretToken, timestamp, bodyJson);

        // Constant-time comparison
        try
        {
            var expectedBytes = Convert.FromHexString(expected);
            var actualBytes   = Convert.FromHexString(signature);
            if (expectedBytes.Length != actualBytes.Length
                || !CryptographicOperations.FixedTimeEquals(expectedBytes, actualBytes))
            {
                return new() { Code = "INVALID_SIGNATURE", Message = "Signature does not match" };
            }
        }
        catch
        {
            return new() { Code = "INVALID_SIGNATURE", Message = "Signature format is invalid" };
        }

        return new() { Code = "00", Message = "OK" };
    }

    /// <summary>Verify webhook signature from a typed object (any POCO, Dictionary, etc.).</summary>
    public static WebhookVerifyResult VerifyWebhookSignature(
        string  secretToken,
        string? signature,
        string? timestamp,
        object? body)
    {
        if (body is null)
            return new() { Code = "MISSING_BODY", Message = "body is required and must be an object" };

        // Serialize to canonical JSON then validate via the string overload
        var json = JsonSerializer.Serialize(body);
        return VerifyWebhookSignature(secretToken, signature, timestamp, json);
    }
}
