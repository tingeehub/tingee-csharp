using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Tingee.Sdk.Types;

/// <summary>
/// Shape of the JSON body sent by Tingee webhook callbacks.
/// Compatible with ASP.NET Core [FromBody] / System.Text.Json deserialization.
///
/// Usage in ASP.NET Core controller:
/// <code>
/// [HttpPost("webhook")]
/// public IActionResult Webhook(
///     [FromHeader(Name = "x-signature")] string signature,
///     [FromHeader(Name = "x-request-timestamp")] string timestamp,
///     [FromBody] TingeeWebhookBody body)
/// {
///     var result = TingeeSigner.VerifyWebhookSignature(secretToken, signature, timestamp, body);
///     if (!result.IsValid) return Unauthorized(result);
///     // process ...
/// }
/// </code>
/// </summary>
public class TingeeWebhookBody
{
    public class TingeeWebhookAdditionalData
    {
        [JsonPropertyName("name")]
        public string Name  { get; set; } = string.Empty;

        [JsonPropertyName("value")]
        public string Value { get; set; } = string.Empty;
    }

    [JsonPropertyName("clientId")]
    public string ClientId { get; set; } = string.Empty;

    [JsonPropertyName("transactionCode")]
    public string TransactionCode { get; set; } = string.Empty;

    [JsonPropertyName("amount")]
    public decimal Amount { get; set; }

    [JsonPropertyName("content")]
    public string? Content { get; set; }              // optional

    [JsonPropertyName("bank")]
    public string Bank { get; set; } = string.Empty;

    [JsonPropertyName("bankBin")]
    public string? BankBin { get; set; }              // optional

    [JsonPropertyName("accountNumber")]
    public string AccountNumber { get; set; } = string.Empty;

    [JsonPropertyName("vaAccountNumber")]
    public string? VaAccountNumber { get; set; }      // optional

    /// <summary>Format: yyyyMMddHHmmss</summary>
    [JsonPropertyName("transactionDate")]
    public string TransactionDate { get; set; } = string.Empty;

    [JsonPropertyName("additionalData")]
    public List<TingeeWebhookAdditionalData>? AdditionalData { get; set; } // optional
}
