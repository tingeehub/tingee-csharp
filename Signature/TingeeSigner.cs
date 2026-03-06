using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace Tingee.Sdk.Signature;

/// <summary>Result of <see cref="TingeeSigner.VerifyWebhookSignature(string, string?, string?, Dictionary{string, object}?)"/>.</summary>
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
        ["clientId", "transactionCode", "amount", "bank", "transactionDate"];

    // ── Helpers ───────────────────────────────────────────────────────────────

    /// <summary>
    /// Generate HMAC-SHA512 signature for a Tingee API request.
    /// message = "{timestamp}:{json_body}"
    /// </summary>
    public static string GenerateSignature(string secretKey, string timestamp, object body)
    {
        var bodyJson = JsonSerializer.Serialize(body);
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
    ///     body:        await Request.ReadFromJsonAsync&lt;Dictionary&lt;string, object&gt;&gt;()
    /// );
    /// if (!result.IsValid)
    ///     return Unauthorized(result);
    /// </code>
    /// </example>
    public static WebhookVerifyResult VerifyWebhookSignature(
        string                      secretToken,
        string?                     signature,
        string?                     timestamp,
        string?                     body)
    {
        if (body is null)
            return new() { Code = "MISSING_BODY", Message = "body is required and must be an object" };

        Dictionary<string, object>? parsed;
        try
        {
            parsed = JsonSerializer.Deserialize<Dictionary<string, object>>(body);
        }
        catch
        {
            return new() { Code = "INVALID_BODY", Message = "body string is not valid JSON" };
        }

        return VerifyWebhookSignature(secretToken, signature, timestamp, parsed);
    }

    public static WebhookVerifyResult VerifyWebhookSignature(
        string                      secretToken,
        string?                     signature,
        string?                     timestamp,
        Dictionary<string, object>? body)
    {
        if (string.IsNullOrEmpty(signature))
            return new() { Code = "MISSING_SIGNATURE", Message = "x-signature header is required" };

        if (string.IsNullOrEmpty(timestamp))
            return new() { Code = "MISSING_TIMESTAMP", Message = "x-request-timestamp header is required" };

        if (!System.Text.RegularExpressions.Regex.IsMatch(timestamp, @"^\d{17}$"))
            return new() { Code = "INVALID_TIMESTAMP", Message = "x-request-timestamp must be in yyyyMMddHHmmssSSS format (17 digits)" };

        if (body is null || body.Count == 0)
            return new() { Code = "MISSING_BODY", Message = "body is required and must be an object" };

        foreach (var field in RequiredBodyFields)
        {
            if (!body.TryGetValue(field, out var val) || val is null || string.IsNullOrEmpty(val.ToString()))
                return new() { Code = "MISSING_BODY_FIELD", Message = $"body.{field} is required" };
        }

        var expected = GenerateSignature(secretToken, timestamp, body);

        // Timing-safe comparison
        var expectedBytes = Encoding.UTF8.GetBytes(expected);
        var actualBytes   = Encoding.UTF8.GetBytes(signature.ToLowerInvariant());

        if (!CryptographicOperations.FixedTimeEquals(expectedBytes, actualBytes))
            return new() { Code = "INVALID_SIGNATURE", Message = "Signature does not match" };

        return new() { Code = "00", Message = "Success" };
    }
}
