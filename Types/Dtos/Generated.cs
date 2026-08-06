// Auto-generated from openapi/sdk.json
// DO NOT EDIT MANUALLY

#nullable enable

namespace Tingee.Sdk.Types.Dtos;

public sealed class OpenApiOuputDto
{
    [System.Text.Json.Serialization.JsonPropertyName("code")]
    public required string Code { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("message")]
    public required string Message { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("data")]
    public required object Data { get; set; }
}

public sealed class GenerateVietQROuputDto
{
    [System.Text.Json.Serialization.JsonPropertyName("qrCode")]
    public string? QrCode { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("qrCodeImage")]
    public string? QrCodeImage { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("qrAccount")]
    public string? QrAccount { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("referenceLabelCode")]
    public string? ReferenceLabelCode { get; set; }
}

[System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
public enum BankNameEnum
{
    [System.Runtime.Serialization.EnumMember(Value = "OCB")] OCB,
    [System.Runtime.Serialization.EnumMember(Value = "BIDV")] BIDV,
    [System.Runtime.Serialization.EnumMember(Value = "MBB")] MBB,
    [System.Runtime.Serialization.EnumMember(Value = "ACB")] ACB,
    [System.Runtime.Serialization.EnumMember(Value = "VPB")] VPB,
    [System.Runtime.Serialization.EnumMember(Value = "PGB")] PGB,
    [System.Runtime.Serialization.EnumMember(Value = "VIB")] VIB,
    [System.Runtime.Serialization.EnumMember(Value = "STB")] STB,
    [System.Runtime.Serialization.EnumMember(Value = "CTG")] CTG,
    [System.Runtime.Serialization.EnumMember(Value = "VCB")] VCB,
    [System.Runtime.Serialization.EnumMember(Value = "AGRIBANK")] AGRIBANK,
    [System.Runtime.Serialization.EnumMember(Value = "SHINHAN")] SHINHAN,
    [System.Runtime.Serialization.EnumMember(Value = "COB")] COB,
    [System.Runtime.Serialization.EnumMember(Value = "MSB")] MSB,
    [System.Runtime.Serialization.EnumMember(Value = "NEXTPAY")] NEXTPAY,
    [System.Runtime.Serialization.EnumMember(Value = "PAYOO")] PAYOO,
    [System.Runtime.Serialization.EnumMember(Value = "BAOKIM")] BAOKIM,
    [System.Runtime.Serialization.EnumMember(Value = "TPB")] TPB
}

public sealed class OpenApiGenerateVietQRInputDto
{
    /// <summary>Bank BIN. Use <see cref="Tingee.Sdk.Types.BankBin"/> constants.</summary>
    [System.Text.Json.Serialization.JsonPropertyName("bankBin")]
    public string? BankBin { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("bankName")]
    public BankNameEnum? BankName { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("accountNumber")]
    public required string AccountNumber { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("amount")]
    public long? Amount { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("content")]
    public string? Content { get; set; }
}

public sealed class GenerateDynamicQROuputDto
{
    [System.Text.Json.Serialization.JsonPropertyName("qrCode")]
    public string? QrCode { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("qrAccount")]
    public string? QrAccount { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("billId")]
    public string? BillId { get; set; }
}

[System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
public enum QRCodeTypeEnum
{
    [System.Runtime.Serialization.EnumMember(Value = "dynamic-one-time-payment")] DYNAMIC_ONE_TIME_PAYMENT,
    [System.Runtime.Serialization.EnumMember(Value = "dynamic-recurring-payment")] DYNAMIC_RECURRING_PAYMENT
}

public sealed class GenerateDynamicQRInputDto
{
    [System.Text.Json.Serialization.JsonPropertyName("merchantId")]
    public int? MerchantId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("vaAccountNumber")]
    public required string VaAccountNumber { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("qrCodeType")]
    public required QRCodeTypeEnum QrCodeType { get; set; }
    /// <summary>Bank BIN. Use <see cref="Tingee.Sdk.Types.BankBin"/> constants.</summary>
    [System.Text.Json.Serialization.JsonPropertyName("bankBin")]
    public string? BankBin { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("bankName")]
    public BankNameEnum? BankName { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("name")]
    public string? Name { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("amount")]
    public long? Amount { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("purpose")]
    public string? Purpose { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("expireInMinute")]
    public int? ExpireInMinute { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("extraInfo")]
    public string? ExtraInfo { get; set; }
}

public sealed class EmptyDto
{

}

public sealed class OpenApiDeleteDynamicQRInputDto
{
    [System.Text.Json.Serialization.JsonPropertyName("merchantId")]
    public int? MerchantId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("qrAccount")]
    public required string QrAccount { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("billId")]
    public required string BillId { get; set; }
}

public sealed class OpenApiOnVADto
{
    [System.Text.Json.Serialization.JsonPropertyName("merchantId")]
    public int? MerchantId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("vaAccountNumber")]
    public required string VaAccountNumber { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("qrCodeType")]
    public required QRCodeTypeEnum QrCodeType { get; set; }
    /// <summary>Bank BIN. Use <see cref="Tingee.Sdk.Types.BankBin"/> constants.</summary>
    [System.Text.Json.Serialization.JsonPropertyName("bankBin")]
    public string? BankBin { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("bankName")]
    public BankNameEnum? BankName { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("name")]
    public string? Name { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("amount")]
    public long? Amount { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("purpose")]
    public string? Purpose { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("expireInMinute")]
    public int? ExpireInMinute { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("extraInfo")]
    public string? ExtraInfo { get; set; }
}

public sealed class OpenApiOffVADto
{
    [System.Text.Json.Serialization.JsonPropertyName("merchantId")]
    public int? MerchantId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("billId")]
    public required string BillId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("vaAccountNumber")]
    public required string VaAccountNumber { get; set; }
}

public sealed class OpenApiBillInfoDto
{
    [System.Text.Json.Serialization.JsonPropertyName("billId")]
    public required string BillId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("qrCodeType")]
    public required string QrCodeType { get; set; }
    /// <summary>Bank BIN. Use <see cref="Tingee.Sdk.Types.BankBin"/> constants.</summary>
    [System.Text.Json.Serialization.JsonPropertyName("bankBin")]
    public required string BankBin { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("accountNumber")]
    public required string AccountNumber { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("vaAccountNumber")]
    public required string VaAccountNumber { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("qrAccount")]
    public required string QrAccount { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("amount")]
    public required long Amount { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("purpose")]
    public string? Purpose { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("totalAmountPaid")]
    public long? TotalAmountPaid { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("totalPaymentsCount")]
    public required int TotalPaymentsCount { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("expiredTime")]
    public required string ExpiredTime { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("expireInMinute")]
    public double? ExpireInMinute { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("extraInfo")]
    public string? ExtraInfo { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("status")]
    public required string Status { get; set; }
}

[System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
public enum CashFlowSourceEnum
{
    [System.Runtime.Serialization.EnumMember(Value = "bank-transfer")] BANK_TRANSFER,
    [System.Runtime.Serialization.EnumMember(Value = "card")] CARD,
    [System.Runtime.Serialization.EnumMember(Value = "cash")] CASH
}

public sealed class OpenApiTransactionPagedOuputDto
{
    [System.Text.Json.Serialization.JsonPropertyName("transactionId")]
    public required string TransactionId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("merchantId")]
    public required int MerchantId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("shopId")]
    public required int ShopId { get; set; }
    /// <summary>Bank BIN. Use <see cref="Tingee.Sdk.Types.BankBin"/> constants.</summary>
    [System.Text.Json.Serialization.JsonPropertyName("bankBin")]
    public string? BankBin { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("cashFlowSource")]
    public CashFlowSourceEnum? CashFlowSource { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("code")]
    public required string Code { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("amount")]
    public required long Amount { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("type")]
    public string? Type { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("content")]
    public string? Content { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("currency")]
    public string? Currency { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("accountNumber")]
    public required string AccountNumber { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("vaAccountNumber")]
    public string? VaAccountNumber { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("transactionDate")]
    public string? TransactionDate { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("billId")]
    public string? BillId { get; set; }
}

public sealed class OpenApiGetStatusDynamicQROutputDto
{
    [System.Text.Json.Serialization.JsonPropertyName("billInfo")]
    public required OpenApiBillInfoDto BillInfo { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("transactionInfos")]
    public required IList<OpenApiTransactionPagedOuputDto> TransactionInfos { get; set; }
}

public sealed class OpenApiGetStatusDynamicQRInputDto
{
    [System.Text.Json.Serialization.JsonPropertyName("merchantId")]
    public int? MerchantId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("qrAccount")]
    public required string QrAccount { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("billId")]
    public required string BillId { get; set; }
}

public sealed class Bank
{
    [System.Text.Json.Serialization.JsonPropertyName("code")]
    public BankNameEnum? Code { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("name")]
    public string? Name { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("shortName")]
    public string? ShortName { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("bin")]
    public string? Bin { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("urlLogo")]
    public string? UrlLogo { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("termsAndConditions")]
    public object TermsAndConditions { get; set; }
}

public sealed class PagedResultDto<T>
{
    [System.Text.Json.Serialization.JsonPropertyName("totalCount")]
    public int? TotalCount { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("items")]
    public IList<T> Items { get; set; } = new List<T>();
}

[System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
public enum BankAccountTypeEnum
{
    [System.Runtime.Serialization.EnumMember(Value = "personal-account")] PERSONAL_ACCOUNT,
    [System.Runtime.Serialization.EnumMember(Value = "business-account")] BUSINESS_ACCOUNT,
    [System.Runtime.Serialization.EnumMember(Value = "business-household-account")] BUSINESS_HOUSEHOLD_ACCOUNT
}

[System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
public enum StatusMerchantAccountNumberEnum
{
    [System.Runtime.Serialization.EnumMember(Value = "inactive")] INACTIVE,
    [System.Runtime.Serialization.EnumMember(Value = "active")] ACTIVE,
    [System.Runtime.Serialization.EnumMember(Value = "lock")] LOCK
}

public sealed class OpenApiGetVAPagedOuputDto
{
    [System.Text.Json.Serialization.JsonPropertyName("bankName")]
    public required BankNameEnum BankName { get; set; }
    /// <summary>Bank BIN. Use <see cref="Tingee.Sdk.Types.BankBin"/> constants.</summary>
    [System.Text.Json.Serialization.JsonPropertyName("bankBin")]
    public string? BankBin { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("accountType")]
    public required BankAccountTypeEnum AccountType { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("accountName")]
    public string? AccountName { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("accountNumber")]
    public required string AccountNumber { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("vaAccountNumber")]
    public string? VaAccountNumber { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("shopId")]
    public required int ShopId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("status")]
    public required StatusMerchantAccountNumberEnum Status { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("creationTime")]
    public string? CreationTime { get; set; }
}

[System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
public enum DataAccessFilterEnum
{
    [System.Runtime.Serialization.EnumMember(Value = "referral-only")] REFERRAL_ONLY,
    [System.Runtime.Serialization.EnumMember(Value = "distributor-only")] DISTRIBUTOR_ONLY,
    [System.Runtime.Serialization.EnumMember(Value = "with-package-only")] WITH_PACKAGE_ONLY
}

[System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
public enum TransactionTypeEnum
{
    [System.Runtime.Serialization.EnumMember(Value = "credit")] CREDIT,
    [System.Runtime.Serialization.EnumMember(Value = "debit")] DEBIT
}

public sealed class OpenApiGetVAPagedInputDto
{
    [System.Text.Json.Serialization.JsonPropertyName("filter")]
    public string? Filter { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("sorting")]
    public string? Sorting { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("skipCount")]
    public required int SkipCount { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("maxResultCount")]
    public required int MaxResultCount { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("endTime")]
    public string? EndTime { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("merchantId")]
    public required int MerchantId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("shopId")]
    public int? ShopId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("accountType")]
    public required BankAccountTypeEnum AccountType { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("status")]
    public StatusMerchantAccountNumberEnum? Status { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("agentId")]
    public int? AgentId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("dataAccess")]
    public required DataAccessFilterEnum DataAccess { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("transactionType")]
    public required TransactionTypeEnum TransactionType { get; set; }
    /// <summary>Bank BIN. Use <see cref="Tingee.Sdk.Types.BankBin"/> constants.</summary>
    [System.Text.Json.Serialization.JsonPropertyName("bankBin")]
    public string? BankBin { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("bankName")]
    public BankNameEnum? BankName { get; set; }
}

public sealed class OpenApiGenerateVietQROuputDto
{
    /// <summary>Bank BIN. Use <see cref="Tingee.Sdk.Types.BankBin"/> constants.</summary>
    [System.Text.Json.Serialization.JsonPropertyName("bankBin")]
    public required string BankBin { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("accountNumber")]
    public required string AccountNumber { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("amount")]
    public string? Amount { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("purpose")]
    public string? Purpose { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("vaPrefix")]
    public required string VaPrefix { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("vaSuffix")]
    public required string VaSuffix { get; set; }
}

[System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
public enum OtpStbConfirmMethodEnum
{
    [System.Runtime.Serialization.EnumMember(Value = "SMSTTT")] SMSTTT,
    [System.Runtime.Serialization.EnumMember(Value = "SmartOTP")] SMARTOTP,
    [System.Runtime.Serialization.EnumMember(Value = "mCode")] MCODE
}

public sealed class Provider
{

}

public sealed class Consumer
{

}

public sealed class Merchant
{

}

public sealed class AdditionalData
{

}

public sealed class OneQRDto
{
    [System.Text.Json.Serialization.JsonPropertyName("isValid")]
    public required bool IsValid { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("provider")]
    public required Provider Provider { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("consumer")]
    public required Consumer Consumer { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("merchant")]
    public required Merchant Merchant { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("additionalData")]
    public required AdditionalData AdditionalData { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("version")]
    public required string Version { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("initMethod")]
    public required string InitMethod { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("category")]
    public required string Category { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("currency")]
    public required string Currency { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("nation")]
    public required string Nation { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("city")]
    public required string City { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("crc")]
    public required string Crc { get; set; }
}

public sealed class BankCreateVAOuputDto
{
    [System.Text.Json.Serialization.JsonPropertyName("bankName")]
    public BankNameEnum? BankName { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("merchantAccountNumberId")]
    public int? MerchantAccountNumberId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("shopId")]
    public int? ShopId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("status")]
    public StatusMerchantAccountNumberEnum? Status { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("confirmId")]
    public string? ConfirmId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("vaAccountNumber")]
    public string? VaAccountNumber { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("deepLink")]
    public string? DeepLink { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("authorizeLink")]
    public string? AuthorizeLink { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("otpMethod")]
    public OtpStbConfirmMethodEnum? OtpMethod { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("qrDto")]
    public OneQRDto? QrDto { get; set; }
}

[System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
public enum AppTypeEnum
{
    [System.Runtime.Serialization.EnumMember(Value = "ocb-web")] OCB_WEB,
    [System.Runtime.Serialization.EnumMember(Value = "ocb-app")] OCB_APP,
    [System.Runtime.Serialization.EnumMember(Value = "bidv-web")] BIDV_WEB,
    [System.Runtime.Serialization.EnumMember(Value = "bidv-app")] BIDV_APP,
    [System.Runtime.Serialization.EnumMember(Value = "stb-web")] STB_WEB,
    [System.Runtime.Serialization.EnumMember(Value = "stb-app")] STB_APP,
    [System.Runtime.Serialization.EnumMember(Value = "vcb-web")] VCB_WEB,
    [System.Runtime.Serialization.EnumMember(Value = "vcb-app")] VCB_APP,
    [System.Runtime.Serialization.EnumMember(Value = "tingee-web")] TINGEE_WEB,
    [System.Runtime.Serialization.EnumMember(Value = "tingee-app")] TINGEE_APP,
    [System.Runtime.Serialization.EnumMember(Value = "tingee-merchant-app")] TINGEE_MERCHANT_APP,
    [System.Runtime.Serialization.EnumMember(Value = "loa-hub")] LOA_HUB,
    [System.Runtime.Serialization.EnumMember(Value = "mini-app-mbb")] MINI_APP_MBB,
    [System.Runtime.Serialization.EnumMember(Value = "mini-app-zalo")] MINI_APP_ZALO,
    [System.Runtime.Serialization.EnumMember(Value = "baas")] BAAS
}

[System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
public enum LinkTypeEnum
{
    [System.Runtime.Serialization.EnumMember(Value = "api-exact")] API_EXACT,
    [System.Runtime.Serialization.EnumMember(Value = "manual-exact")] MANUAL_EXACT,
    [System.Runtime.Serialization.EnumMember(Value = "manual-include")] MANUAL_INCLUDE
}

public sealed class OpenApiCreateVAInpuDto
{
    [System.Text.Json.Serialization.JsonPropertyName("name")]
    public string? Name { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("cashFlowSource")]
    public CashFlowSourceEnum? CashFlowSource { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("accountType")]
    public BankAccountTypeEnum? AccountType { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("accountNumber")]
    public string? AccountNumber { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("accountName")]
    public string? AccountName { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("identity")]
    public string? Identity { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("mobile")]
    public string? Mobile { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("masterMerchantId")]
    public int? MasterMerchantId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("shopId")]
    public int? ShopId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("vaPrefix")]
    public string? VaPrefix { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("vaSuffix")]
    public string? VaSuffix { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("merchantName")]
    public string? MerchantName { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("merchantAddress")]
    public string? MerchantAddress { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("serviceId")]
    public int? ServiceId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("isCreateNonOtp")]
    public bool? IsCreateNonOtp { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("code")]
    public string? Code { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("taxCode")]
    public string? TaxCode { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("softposUserName")]
    public string? SoftposUserName { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("softposDeveloperId")]
    public string? SoftposDeveloperId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("softposTid")]
    public string? SoftposTid { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("softposMid")]
    public string? SoftposMid { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("authorizationCode")]
    public string? AuthorizationCode { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("sessionLogin")]
    public string? SessionLogin { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("isNotifyAccountNumber")]
    public bool? IsNotifyAccountNumber { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("appType")]
    public required AppTypeEnum AppType { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("linkType")]
    public LinkTypeEnum? LinkType { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("vaAccountNumber")]
    public string? VaAccountNumber { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("acbUserId")]
    public string? AcbUserId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("minAmount")]
    public required double MinAmount { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("maxAmount")]
    public required double MaxAmount { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("isAbleOnOffByBill")]
    public bool? IsAbleOnOffByBill { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("requestId")]
    public string? RequestId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("transactionType")]
    public TransactionTypeEnum? TransactionType { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("walletId")]
    public string? WalletId { get; set; }
    /// <summary>Bank BIN. Use <see cref="Tingee.Sdk.Types.BankBin"/> constants.</summary>
    [System.Text.Json.Serialization.JsonPropertyName("bankBin")]
    public string? BankBin { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("bankName")]
    public BankNameEnum? BankName { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("merchantId")]
    public int? MerchantId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("redirectUrl")]
    public string? RedirectUrl { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("webhookUrl")]
    public string? WebhookUrl { get; set; }
}

public sealed class OpenApiCreateBatchVaOnOffInputDto
{
    [System.Text.Json.Serialization.JsonPropertyName("masterMerchantId")]
    public double? MasterMerchantId { get; set; }
    /// <summary>Bank BIN. Use <see cref="Tingee.Sdk.Types.BankBin"/> constants.</summary>
    [System.Text.Json.Serialization.JsonPropertyName("bankBin")]
    public string? BankBin { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("bankName")]
    public BankNameEnum? BankName { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("accountType")]
    public required BankAccountTypeEnum AccountType { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("vaPrefix")]
    public string? VaPrefix { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("merchantName")]
    public string? MerchantName { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("name")]
    public string? Name { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("shopId")]
    public double? ShopId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("vaAccountNumbers")]
    public required IList<string> VaAccountNumbers { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("merchantId")]
    public int? MerchantId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("amount")]
    public double? Amount { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("purpose")]
    public string? Purpose { get; set; }
}

public sealed class OpenApiCreateBatchVaOnOffItemOutputDto
{
    [System.Text.Json.Serialization.JsonPropertyName("vaAccountNumber")]
    public required string VaAccountNumber { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("qrData")]
    public required string QrData { get; set; }
}

public sealed class OpenApiCreateBatchVaOnOffOutputDto
{
    [System.Text.Json.Serialization.JsonPropertyName("shopId")]
    public required double ShopId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("qrArray")]
    public required IList<OpenApiCreateBatchVaOnOffItemOutputDto> QrArray { get; set; }
}

public sealed class OpenApiCreateDebitAccountInputDto
{
    [System.Text.Json.Serialization.JsonPropertyName("name")]
    public string? Name { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("cashFlowSource")]
    public CashFlowSourceEnum? CashFlowSource { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("accountType")]
    public BankAccountTypeEnum? AccountType { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("accountNumber")]
    public string? AccountNumber { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("accountName")]
    public string? AccountName { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("identity")]
    public string? Identity { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("mobile")]
    public string? Mobile { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("masterMerchantId")]
    public int? MasterMerchantId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("shopId")]
    public int? ShopId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("vaPrefix")]
    public string? VaPrefix { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("vaSuffix")]
    public string? VaSuffix { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("merchantName")]
    public string? MerchantName { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("merchantAddress")]
    public string? MerchantAddress { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("serviceId")]
    public int? ServiceId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("isCreateNonOtp")]
    public bool? IsCreateNonOtp { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("code")]
    public string? Code { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("taxCode")]
    public string? TaxCode { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("softposUserName")]
    public string? SoftposUserName { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("softposDeveloperId")]
    public string? SoftposDeveloperId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("softposTid")]
    public string? SoftposTid { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("softposMid")]
    public string? SoftposMid { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("authorizationCode")]
    public string? AuthorizationCode { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("sessionLogin")]
    public string? SessionLogin { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("isNotifyAccountNumber")]
    public bool? IsNotifyAccountNumber { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("appType")]
    public required AppTypeEnum AppType { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("linkType")]
    public LinkTypeEnum? LinkType { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("vaAccountNumber")]
    public string? VaAccountNumber { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("acbUserId")]
    public string? AcbUserId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("minAmount")]
    public required double MinAmount { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("maxAmount")]
    public required double MaxAmount { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("isAbleOnOffByBill")]
    public bool? IsAbleOnOffByBill { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("requestId")]
    public string? RequestId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("walletId")]
    public string? WalletId { get; set; }
    /// <summary>Bank BIN. Use <see cref="Tingee.Sdk.Types.BankBin"/> constants.</summary>
    [System.Text.Json.Serialization.JsonPropertyName("bankBin")]
    public string? BankBin { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("bankName")]
    public BankNameEnum? BankName { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("merchantId")]
    public int? MerchantId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("redirectUrl")]
    public string? RedirectUrl { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("webhookUrl")]
    public string? WebhookUrl { get; set; }
}

public sealed class OpenApiConfirmVAOuputDto
{
    [System.Text.Json.Serialization.JsonPropertyName("accountType")]
    public BankAccountTypeEnum? AccountType { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("bankName")]
    public BankNameEnum? BankName { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("accountNumber")]
    public string? AccountNumber { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("vaAccountNumber")]
    public string? VaAccountNumber { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("shopId")]
    public int? ShopId { get; set; }
}

public sealed class OpenApiBankConfirmVAInputDto
{
    [System.Text.Json.Serialization.JsonPropertyName("merchantId")]
    public int? MerchantId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("confirmId")]
    public required string ConfirmId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("otpNumber")]
    public required string OtpNumber { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("bankName")]
    public required BankNameEnum BankName { get; set; }
    /// <summary>Bank BIN. Use <see cref="Tingee.Sdk.Types.BankBin"/> constants.</summary>
    [System.Text.Json.Serialization.JsonPropertyName("bankBin")]
    public required string BankBin { get; set; }
}

public sealed class BankDeleteVAOutputDto
{
    [System.Text.Json.Serialization.JsonPropertyName("confirmId")]
    public string? ConfirmId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("authorizeLink")]
    public string? AuthorizeLink { get; set; }
}

public sealed class OpenApiRegisterNotifyDto
{
    [System.Text.Json.Serialization.JsonPropertyName("merchantId")]
    public int? MerchantId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("vaAccountNumber")]
    public required string VaAccountNumber { get; set; }
    /// <summary>Bank BIN. Use <see cref="Tingee.Sdk.Types.BankBin"/> constants.</summary>
    [System.Text.Json.Serialization.JsonPropertyName("bankBin")]
    public string? BankBin { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("bankName")]
    public BankNameEnum? BankName { get; set; }
}

[System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
public enum EventUrlItemType
{
    [System.Runtime.Serialization.EnumMember(Value = "shop")] SHOP,
    [System.Runtime.Serialization.EnumMember(Value = "accountNumber")] ACCOUNTNUMBER,
    [System.Runtime.Serialization.EnumMember(Value = "all")] ALL,
    [System.Runtime.Serialization.EnumMember(Value = "merchant")] MERCHANT
}

public sealed class UpdateWebhookNotificationDto
{
    [System.Text.Json.Serialization.JsonPropertyName("webhookUrl")]
    public string? WebhookUrl { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("vaAccountNumber")]
    public string? VaAccountNumber { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("targetId")]
    public int? TargetId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("type")]
    public EventUrlItemType? Type { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("isActive")]
    public required bool IsActive { get; set; }
}

[System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
public enum BankLinkSessionTypeEnum
{
    [System.Runtime.Serialization.EnumMember(Value = "bank-link")] BANK_LINK,
    [System.Runtime.Serialization.EnumMember(Value = "bank-config")] BANK_CONFIG
}

public sealed class CreateBankLinkSessionInputDto
{
    [System.Text.Json.Serialization.JsonPropertyName("merchantId")]
    public int? MerchantId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("shopId")]
    public int? ShopId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("merchantAccountNumberId")]
    public int? MerchantAccountNumberId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("allowedBanks")]
    public IList<BankNameEnum>? AllowedBanks { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("disallowedBanks")]
    public IList<BankNameEnum>? DisallowedBanks { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("bankName")]
    public BankNameEnum? BankName { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("type")]
    public BankLinkSessionTypeEnum? Type { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("redirectUrl")]
    public string? RedirectUrl { get; set; }
}

public sealed class OpenApiReadSecurityCodeDto
{
    [System.Text.Json.Serialization.JsonPropertyName("merchantId")]
    public int? MerchantId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("uuid")]
    public required string Uuid { get; set; }
}

[System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
public enum DeviceTypeEnum
{
    [System.Runtime.Serialization.EnumMember(Value = "app-tingee")] APP_TINGEE,
    [System.Runtime.Serialization.EnumMember(Value = "tingee-box-f1")] TINGEE_BOX_F1,
    [System.Runtime.Serialization.EnumMember(Value = "tingee-box-2a")] TINGEE_BOX_2A,
    [System.Runtime.Serialization.EnumMember(Value = "tingee-box-2as")] TINGEE_BOX_2AS,
    [System.Runtime.Serialization.EnumMember(Value = "tingee-box-s1")] TINGEE_BOX_S1,
    [System.Runtime.Serialization.EnumMember(Value = "tingee-box-3ls")] TINGEE_BOX_3LS,
    [System.Runtime.Serialization.EnumMember(Value = "tingee-box-3pro")] TINGEE_BOX_3PRO,
    [System.Runtime.Serialization.EnumMember(Value = "tingee-box-3vn")] TINGEE_BOX_3VN,
    [System.Runtime.Serialization.EnumMember(Value = "tingee-box-3vna")] TINGEE_BOX_3VNA,
    [System.Runtime.Serialization.EnumMember(Value = "tingee-box-4ls")] TINGEE_BOX_4LS,
    [System.Runtime.Serialization.EnumMember(Value = "tingee-box-5s")] TINGEE_BOX_5S,
    [System.Runtime.Serialization.EnumMember(Value = "tingee-box-5sa")] TINGEE_BOX_5SA,
    [System.Runtime.Serialization.EnumMember(Value = "tingee-box-6ls")] TINGEE_BOX_6LS,
    [System.Runtime.Serialization.EnumMember(Value = "tingee-box-6pro")] TINGEE_BOX_6PRO,
    [System.Runtime.Serialization.EnumMember(Value = "tingee-box-6xs")] TINGEE_BOX_6XS,
    [System.Runtime.Serialization.EnumMember(Value = "vn-50")] VN_50,
    [System.Runtime.Serialization.EnumMember(Value = "loa-pay")] LOA_PAY,
    [System.Runtime.Serialization.EnumMember(Value = "trusted-pay")] TRUSTED_PAY,
    [System.Runtime.Serialization.EnumMember(Value = "pay-alert")] PAY_ALERT,
    [System.Runtime.Serialization.EnumMember(Value = "tingee-box-3vn-mbb")] TINGEE_BOX_3VN_MBB,
    [System.Runtime.Serialization.EnumMember(Value = "tingee-box-3pro-mbb")] TINGEE_BOX_3PRO_MBB,
    [System.Runtime.Serialization.EnumMember(Value = "tingee-box-3pro-x")] TINGEE_BOX_3PRO_X,
    [System.Runtime.Serialization.EnumMember(Value = "tingee-box-max")] TINGEE_BOX_MAX,
    [System.Runtime.Serialization.EnumMember(Value = "tingee-box-8pro")] TINGEE_BOX_8PRO
}

public sealed class SendNotifyTingeeBoxDto
{
    [System.Text.Json.Serialization.JsonPropertyName("type")]
    public DeviceTypeEnum? Type { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("uuid")]
    public string? Uuid { get; set; }
}

public sealed class OpenApiAddDeviceToShop
{
    [System.Text.Json.Serialization.JsonPropertyName("uuid")]
    public required string Uuid { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("securityCode")]
    public required string SecurityCode { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("appType")]
    public required AppTypeEnum AppType { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("masterMerchantId")]
    public double? MasterMerchantId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("merchantId")]
    public int? MerchantId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("vaAccountNumbers")]
    public IList<string>? VaAccountNumbers { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("shopIds")]
    public IList<double>? ShopIds { get; set; }
}

public sealed class OpenApiShopLinkToDeviceDto
{
    [System.Text.Json.Serialization.JsonPropertyName("shopName")]
    public required string ShopName { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("shopId")]
    public required int ShopId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("isLinkToDevice")]
    public required bool IsLinkToDevice { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("fullAddress")]
    public required string FullAddress { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("vaAccountNumber")]
    public string? VaAccountNumber { get; set; }
}

public sealed class OpenApiUpdateShopDeviceLinkDto
{
    [System.Text.Json.Serialization.JsonPropertyName("uuid")]
    public required string Uuid { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("appType")]
    public required AppTypeEnum AppType { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("shopsLinkToDeviceDtos")]
    public required IList<OpenApiShopLinkToDeviceDto> ShopsLinkToDeviceDtos { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("type")]
    public DeviceTypeEnum? Type { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("merchantId")]
    public int? MerchantId { get; set; }
}

public sealed class OpenApiPrintReceiptItemDto
{
    [System.Text.Json.Serialization.JsonPropertyName("name")]
    public required string Name { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("quantity")]
    public required int Quantity { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("unitPrice")]
    public required long UnitPrice { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("code")]
    public string? Code { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("unit")]
    public string? Unit { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("lineDiscount")]
    public double? LineDiscount { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("promotionLabel")]
    public string? PromotionLabel { get; set; }
}

public sealed class OpenApiPrintDataDto
{
    [System.Text.Json.Serialization.JsonPropertyName("logo")]
    public string? Logo { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("storeName")]
    public required string StoreName { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("address")]
    public string? Address { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("hotline")]
    public string? Hotline { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("orderCode")]
    public string? OrderCode { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("items")]
    public required IList<OpenApiPrintReceiptItemDto> Items { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("totalAmount")]
    public required long TotalAmount { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("discount")]
    public long? Discount { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("qrCode")]
    public string? QrCode { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("barcode")]
    public string? Barcode { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("footerNote")]
    public string? FooterNote { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("voiceFile")]
    public int? VoiceFile { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("copies")]
    public int? Copies { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("type")]
    public double? Type { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("branchName")]
    public string? BranchName { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("customerName")]
    public string? CustomerName { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("sellerAddressLines")]
    public IList<string>? SellerAddressLines { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("taxCode")]
    public string? TaxCode { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("channelName")]
    public string? ChannelName { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("employeeCode")]
    public string? EmployeeCode { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("customerId")]
    public string? CustomerId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("tax")]
    public double? Tax { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("vatReduction")]
    public double? VatReduction { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("customerPaid")]
    public double? CustomerPaid { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("paymentMethodLabel")]
    public string? PaymentMethodLabel { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("paymentAmount")]
    public double? PaymentAmount { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("note")]
    public string? Note { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("qrHint")]
    public string? QrHint { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("qrData")]
    public string? QrData { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("bankAccountName")]
    public string? BankAccountName { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("bankAccountNo")]
    public string? BankAccountNo { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("bankName")]
    public string? BankName { get; set; }
}

public sealed class OpenApiReadAmountDto
{
    [System.Text.Json.Serialization.JsonPropertyName("merchantId")]
    public int? MerchantId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("uuid")]
    public required string Uuid { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("transactionId")]
    public required string TransactionId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("amount")]
    public required long Amount { get; set; }
    /// <summary>Bank BIN. Use <see cref="Tingee.Sdk.Types.BankBin"/> constants.</summary>
    [System.Text.Json.Serialization.JsonPropertyName("bankBin")]
    public required string BankBin { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("bankName")]
    public BankNameEnum? BankName { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("firstDisplayText")]
    public string? FirstDisplayText { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("secondDisplayText")]
    public string? SecondDisplayText { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("thirdDisplayText")]
    public string? ThirdDisplayText { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("playSound")]
    public bool? PlaySound { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("isPrint")]
    public bool? IsPrint { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("printData")]
    public OpenApiPrintDataDto? PrintData { get; set; }
}

public sealed class OpenApiShowQRCodeDto
{
    [System.Text.Json.Serialization.JsonPropertyName("merchantId")]
    public int? MerchantId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("vaAccountNumber")]
    public string? VaAccountNumber { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("amount")]
    public required long Amount { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("qrCode")]
    public required string QrCode { get; set; }
    /// <summary>Bank BIN. Use <see cref="Tingee.Sdk.Types.BankBin"/> constants.</summary>
    [System.Text.Json.Serialization.JsonPropertyName("bankBin")]
    public string? BankBin { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("bankName")]
    public BankNameEnum? BankName { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("uuid")]
    public required string Uuid { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("deviceType")]
    public DeviceTypeEnum? DeviceType { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("firstText")]
    public string? FirstText { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("secondText")]
    public string? SecondText { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("thirdText")]
    public string? ThirdText { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("showTime")]
    public int? ShowTime { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("isStaticQr")]
    public bool? IsStaticQr { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("playSound")]
    public bool? PlaySound { get; set; }
}

public sealed class OpenApiGetDevicesLinkToShopOrVA
{
    [System.Text.Json.Serialization.JsonPropertyName("merchantId")]
    public int? MerchantId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("vaAccountNumber")]
    public string? VaAccountNumber { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("shopId")]
    public int? ShopId { get; set; }
}

[System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
public enum DeviceStatusEnum
{
    [System.Runtime.Serialization.EnumMember(Value = "waiting-progressing")] WAITING_PROGRESSING,
    [System.Runtime.Serialization.EnumMember(Value = "refuse")] REFUSE,
    [System.Runtime.Serialization.EnumMember(Value = "approved")] APPROVED
}

public sealed class DeviceInfoDto
{

}

public sealed class ShopInfoDto
{
    [System.Text.Json.Serialization.JsonPropertyName("name")]
    public required string Name { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("id")]
    public required int Id { get; set; }
}

public sealed class DeviceDto
{
    [System.Text.Json.Serialization.JsonPropertyName("id")]
    public int? Id { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("creationTime")]
    public string? CreationTime { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("creatorUserId")]
    public double? CreatorUserId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("lastModificationTime")]
    public string? LastModificationTime { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("lastModifierUserId")]
    public double? LastModifierUserId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("deleterUserId")]
    public double? DeleterUserId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("type")]
    public required DeviceTypeEnum Type { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("uuid")]
    public required string Uuid { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("name")]
    public required string Name { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("system")]
    public string? System { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("systemVersion")]
    public string? SystemVersion { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("merchantId")]
    public double? MerchantId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("assignedAgentId")]
    public double? AssignedAgentId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("merchantPhoneNumber")]
    public string? MerchantPhoneNumber { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("employeeName")]
    public string? EmployeeName { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("firebaseToken")]
    public string? FirebaseToken { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("status")]
    public required DeviceStatusEnum Status { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("deviceInfoDto")]
    public DeviceInfoDto? DeviceInfoDto { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("useDate")]
    public string? UseDate { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("securityCode")]
    public string? SecurityCode { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("selectedBankNames")]
    public IList<BankNameEnum>? SelectedBankNames { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("serialNumber")]
    public string? SerialNumber { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("userReferralAncestorIds")]
    public string? UserReferralAncestorIds { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("userReferralLevel")]
    public double? UserReferralLevel { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("deviceDistributorAncestorIds")]
    public string? DeviceDistributorAncestorIds { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("deviceDistributorLevel")]
    public double? DeviceDistributorLevel { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("masterMerchantId")]
    public required double MasterMerchantId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("expirationDate")]
    public string? ExpirationDate { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("latestReferralCode")]
    public string? LatestReferralCode { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("merchantName")]
    public string? MerchantName { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("shopDtos")]
    public IList<ShopInfoDto>? ShopDtos { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("agentName")]
    public string? AgentName { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("agentId")]
    public int? AgentId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("simPhoneNumber")]
    public string? SimPhoneNumber { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("simSerialNumber")]
    public string? SimSerialNumber { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("simProvider")]
    public string? SimProvider { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("simPlan")]
    public string? SimPlan { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("simExpirationDate")]
    public string? SimExpirationDate { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("simActivationDate")]
    public string? SimActivationDate { get; set; }
}

public sealed class OpenApiGetPagingDeviceInputDto
{
    [System.Text.Json.Serialization.JsonPropertyName("filter")]
    public string? Filter { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("sorting")]
    public string? Sorting { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("skipCount")]
    public required int SkipCount { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("maxResultCount")]
    public required int MaxResultCount { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("merchantId")]
    public required int MerchantId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("type")]
    public DeviceTypeEnum? Type { get; set; }
}

public sealed class OpenApiGenerateAndShowDynamicQrCodeDto
{
    [System.Text.Json.Serialization.JsonPropertyName("merchantId")]
    public int? MerchantId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("vaAccountNumber")]
    public required string VaAccountNumber { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("qrCodeType")]
    public required QRCodeTypeEnum QrCodeType { get; set; }
    /// <summary>Bank BIN. Use <see cref="Tingee.Sdk.Types.BankBin"/> constants.</summary>
    [System.Text.Json.Serialization.JsonPropertyName("bankBin")]
    public string? BankBin { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("bankName")]
    public BankNameEnum? BankName { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("name")]
    public string? Name { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("amount")]
    public long? Amount { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("purpose")]
    public string? Purpose { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("expireInMinute")]
    public int? ExpireInMinute { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("extraInfo")]
    public string? ExtraInfo { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("uuid")]
    public required string Uuid { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("deviceType")]
    public DeviceTypeEnum? DeviceType { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("firstText")]
    public string? FirstText { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("secondText")]
    public string? SecondText { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("thirdText")]
    public string? ThirdText { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("showTime")]
    public int? ShowTime { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("playSound")]
    public bool? PlaySound { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("readAmountAfterPay")]
    public bool? ReadAmountAfterPay { get; set; }
}

public sealed class OpenApiPrintReceiptDto
{
    [System.Text.Json.Serialization.JsonPropertyName("logo")]
    public string? Logo { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("storeName")]
    public required string StoreName { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("address")]
    public string? Address { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("hotline")]
    public string? Hotline { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("orderCode")]
    public string? OrderCode { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("items")]
    public required IList<OpenApiPrintReceiptItemDto> Items { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("totalAmount")]
    public required long TotalAmount { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("discount")]
    public long? Discount { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("qrCode")]
    public string? QrCode { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("barcode")]
    public string? Barcode { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("footerNote")]
    public string? FooterNote { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("voiceFile")]
    public int? VoiceFile { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("copies")]
    public int? Copies { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("type")]
    public double? Type { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("branchName")]
    public string? BranchName { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("customerName")]
    public string? CustomerName { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("sellerAddressLines")]
    public IList<string>? SellerAddressLines { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("taxCode")]
    public string? TaxCode { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("channelName")]
    public string? ChannelName { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("employeeCode")]
    public string? EmployeeCode { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("customerId")]
    public string? CustomerId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("tax")]
    public double? Tax { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("vatReduction")]
    public double? VatReduction { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("customerPaid")]
    public double? CustomerPaid { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("paymentMethodLabel")]
    public string? PaymentMethodLabel { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("paymentAmount")]
    public double? PaymentAmount { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("note")]
    public string? Note { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("qrHint")]
    public string? QrHint { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("qrData")]
    public string? QrData { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("bankAccountName")]
    public string? BankAccountName { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("bankAccountNo")]
    public string? BankAccountNo { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("bankName")]
    public string? BankName { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("merchantId")]
    public int? MerchantId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("uuid")]
    public required string Uuid { get; set; }
}

public sealed class OpenApiNfcCommandDto
{
    [System.Text.Json.Serialization.JsonPropertyName("merchantId")]
    public int? MerchantId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("uuid")]
    public required string Uuid { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("enableNfc")]
    public bool? EnableNfc { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("playSound")]
    public bool? PlaySound { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("nfcUrl")]
    public required string NfcUrl { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("nfcPackageName")]
    public required string NfcPackageName { get; set; }
}

public sealed class OpenApiResetDeviceDto
{
    [System.Text.Json.Serialization.JsonPropertyName("uuid")]
    public required string Uuid { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("phoneNumber")]
    public string? PhoneNumber { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("accountNumber")]
    public string? AccountNumber { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("isBankRequest")]
    public bool? IsBankRequest { get; set; }
}

public sealed class OpenApiCreateOrUpdateShopOutputDto
{
    [System.Text.Json.Serialization.JsonPropertyName("shopId")]
    public int? ShopId { get; set; }
}

public sealed class SendNotifyTelegramDto
{
    [System.Text.Json.Serialization.JsonPropertyName("chatId")]
    public required double ChatId { get; set; }
}

public sealed class SendNotifyLarkDto
{
    [System.Text.Json.Serialization.JsonPropertyName("urlWebhook")]
    public required string UrlWebhook { get; set; }
}

[System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
public enum ZaloTypeEnum
{
    [System.Runtime.Serialization.EnumMember(Value = "phone-number")] PHONE_NUMBER,
    [System.Runtime.Serialization.EnumMember(Value = "group")] GROUP
}

public sealed class SendNotifyZaloDto
{
    [System.Text.Json.Serialization.JsonPropertyName("type")]
    public required ZaloTypeEnum Type { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("name")]
    public required string Name { get; set; }
}

public sealed class SendNotifyPlatformDto
{
    [System.Text.Json.Serialization.JsonPropertyName("telegramDtos")]
    public required IList<SendNotifyTelegramDto> TelegramDtos { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("larkDtos")]
    public required IList<SendNotifyLarkDto> LarkDtos { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("zaloDtos")]
    public required IList<SendNotifyZaloDto> ZaloDtos { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("tingeeBoxDtos")]
    public required IList<SendNotifyTingeeBoxDto> TingeeBoxDtos { get; set; }
}

public sealed class OpenApiCreateOrUpdateShopDto
{
    [System.Text.Json.Serialization.JsonPropertyName("id")]
    public int? Id { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("name")]
    public required string Name { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("email")]
    public string? Email { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("phoneNumber")]
    public string? PhoneNumber { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("provinceId")]
    public string? ProvinceId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("districtId")]
    public string? DistrictId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("communeId")]
    public string? CommuneId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("address")]
    public string? Address { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("fullAddress")]
    public string? FullAddress { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("sendNotifyPlatformDto")]
    public SendNotifyPlatformDto? SendNotifyPlatformDto { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("isActive")]
    public required bool IsActive { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("status")]
    public string? Status { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("userReferralAncestorIds")]
    public string? UserReferralAncestorIds { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("userReferralLevel")]
    public int? UserReferralLevel { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("deviceDistributorAncestorMap")]
    public string? DeviceDistributorAncestorMap { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("merchantId")]
    public int? MerchantId { get; set; }
}

public sealed class OpenApiGetShopPagedOuputDto
{
    [System.Text.Json.Serialization.JsonPropertyName("id")]
    public int? Id { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("isActive")]
    public bool? IsActive { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("name")]
    public string? Name { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("address")]
    public string? Address { get; set; }
}

public sealed class OpenApiGetShopPagedInputDto
{
    [System.Text.Json.Serialization.JsonPropertyName("filter")]
    public string? Filter { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("sorting")]
    public string? Sorting { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("skipCount")]
    public required int SkipCount { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("maxResultCount")]
    public required int MaxResultCount { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("merchantId")]
    public int? MerchantId { get; set; }
}

public sealed class OpenApiDeepLinkDto
{
    [System.Text.Json.Serialization.JsonPropertyName("merchantId")]
    public int? MerchantId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("type")]
    public required string Type { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("qrCode")]
    public required string QrCode { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("redirectUrl")]
    public string? RedirectUrl { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("callbackUrl")]
    public string? CallbackUrl { get; set; }
    /// <summary>Bank BIN. Use <see cref="Tingee.Sdk.Types.BankBin"/> constants.</summary>
    [System.Text.Json.Serialization.JsonPropertyName("bankBin")]
    public required string BankBin { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("destinationBankBin")]
    public required string DestinationBankBin { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("accountName")]
    public required string AccountName { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("accountNumber")]
    public required string AccountNumber { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("amount")]
    public long? Amount { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("content")]
    public string? Content { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("billNumber")]
    public required string BillNumber { get; set; }
}

public sealed class OpenApiDeepLinkBIDVTESTDto
{
    [System.Text.Json.Serialization.JsonPropertyName("type")]
    public required string Type { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("qrCode")]
    public required string QrCode { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("redirectUrl")]
    public string? RedirectUrl { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("callbackUrl")]
    public string? CallbackUrl { get; set; }
    /// <summary>Bank BIN. Use <see cref="Tingee.Sdk.Types.BankBin"/> constants.</summary>
    [System.Text.Json.Serialization.JsonPropertyName("bankBin")]
    public required string BankBin { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("destinationBankBin")]
    public required string DestinationBankBin { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("accountName")]
    public required string AccountName { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("accountNumber")]
    public required string AccountNumber { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("amount")]
    public long? Amount { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("content")]
    public string? Content { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("billNumber")]
    public required string BillNumber { get; set; }
}

public sealed class OpenApiTransactionPagedInputDto
{
    [System.Text.Json.Serialization.JsonPropertyName("filter")]
    public string? Filter { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("sorting")]
    public string? Sorting { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("skipCount")]
    public required int SkipCount { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("maxResultCount")]
    public required int MaxResultCount { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("merchantId")]
    public int? MerchantId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("shopIds")]
    public IList<double>? ShopIds { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("vaAccountNumbers")]
    public IList<string>? VaAccountNumbers { get; set; }
    /// <summary>Bank BIN. Use <see cref="Tingee.Sdk.Types.BankBin"/> constants.</summary>
    [System.Text.Json.Serialization.JsonPropertyName("bankBin")]
    public string? BankBin { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("billId")]
    public string? BillId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("endTime")]
    public string? EndTime { get; set; }
}

public sealed class OpenApiRegisterDto
{
    [System.Text.Json.Serialization.JsonPropertyName("requestId")]
    public required string RequestId { get; set; }
    /// <summary>Bank BIN. Use <see cref="Tingee.Sdk.Types.BankBin"/> constants.</summary>
    [System.Text.Json.Serialization.JsonPropertyName("bankBin")]
    public string? BankBin { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("accountName")]
    public string? AccountName { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("phone")]
    public required string Phone { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("returnUrl")]
    public required string ReturnUrl { get; set; }
}

[System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
public enum DirectDebitTransactionStatusEnum
{
    [System.Runtime.Serialization.EnumMember(Value = "success")] SUCCESS,
    [System.Runtime.Serialization.EnumMember(Value = "failure")] FAILURE,
    [System.Runtime.Serialization.EnumMember(Value = "pending")] PENDING,
    [System.Runtime.Serialization.EnumMember(Value = "pending-confirm")] PENDING_CONFIRM,
    [System.Runtime.Serialization.EnumMember(Value = "confirmed-and-sent-to-direct-debit")] CONFIRMED_AND_SENT_TO_DIRECT_DEBIT,
    [System.Runtime.Serialization.EnumMember(Value = "insufficient-balance")] INSUFFICIENT_BALANCE,
    [System.Runtime.Serialization.EnumMember(Value = "exceed-daily-limit")] EXCEED_DAILY_LIMIT,
    [System.Runtime.Serialization.EnumMember(Value = "refunded")] REFUNDED
}

public sealed class PaymentBillResponseDto
{
    [System.Text.Json.Serialization.JsonPropertyName("code")]
    public string? Code { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("status")]
    public DirectDebitTransactionStatusEnum? Status { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("transactionCode")]
    public string? TransactionCode { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("isSentConfirmEmail")]
    public bool? IsSentConfirmEmail { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("isSentConfirmZalo")]
    public bool? IsSentConfirmZalo { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("returnUrl")]
    public string? ReturnUrl { get; set; }
}

[System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
public enum DirectDebitPartnerEnum
{
    [System.Runtime.Serialization.EnumMember(Value = "one-pay")] ONE_PAY
}

public sealed class OpenApiPaymentBillDto
{
    [System.Text.Json.Serialization.JsonPropertyName("requestId")]
    public required string RequestId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("clientId")]
    public string? ClientId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("subscriptionId")]
    public required string SubscriptionId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("amount")]
    public required string Amount { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("description")]
    public required string Description { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("expirationTime")]
    public string? ExpirationTime { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("signature")]
    public string? Signature { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("token")]
    public string? Token { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("additionalData")]
    public object AdditionalData { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("tokenRef")]
    public string? TokenRef { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("partnerCode")]
    public required DirectDebitPartnerEnum PartnerCode { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("accountNumber")]
    public string? AccountNumber { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("serviceProviderName")]
    public required string ServiceProviderName { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("returnUrl")]
    public string? ReturnUrl { get; set; }
}

public sealed class DeleteSubscriptionOutputDto
{
    [System.Text.Json.Serialization.JsonPropertyName("confirmUrl")]
    public string? ConfirmUrl { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("code")]
    public string? Code { get; set; }
}

public sealed class OpenApiDeleteSubscriptionDto
{
    [System.Text.Json.Serialization.JsonPropertyName("requestId")]
    public required string RequestId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("returnUrl")]
    public required string ReturnUrl { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("subscriptionId")]
    public required string SubscriptionId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("tokenRef")]
    public required string TokenRef { get; set; }
}

[System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
public enum DirectDebitRefundStatusEnum
{
    [System.Runtime.Serialization.EnumMember(Value = "success")] SUCCESS,
    [System.Runtime.Serialization.EnumMember(Value = "failure")] FAILURE,
    [System.Runtime.Serialization.EnumMember(Value = "Pending")] PENDING
}

public sealed class RefundOutputDto
{
    [System.Text.Json.Serialization.JsonPropertyName("refundAmount")]
    public long? RefundAmount { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("transactionId")]
    public string? TransactionId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("status")]
    public DirectDebitRefundStatusEnum? Status { get; set; }
}

public sealed class OpenApiRefundInputDto
{
    [System.Text.Json.Serialization.JsonPropertyName("subscriptionId")]
    public required string SubscriptionId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("tokenRef")]
    public required string TokenRef { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("transactionId")]
    public required string TransactionId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("amount")]
    public required long Amount { get; set; }
}

public sealed class OpenApiEditConfirmBeforePaymentMethodDto
{
    [System.Text.Json.Serialization.JsonPropertyName("requestId")]
    public required string RequestId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("returnUrl")]
    public required string ReturnUrl { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("subscriptionId")]
    public required string SubscriptionId { get; set; }
}

[System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
public enum DirectDebitStatusEnum
{
    [System.Runtime.Serialization.EnumMember(Value = "active")] ACTIVE,
    [System.Runtime.Serialization.EnumMember(Value = "inactive")] INACTIVE
}

public sealed class OpenApiSubscriptionStatusResponseDto
{
    [System.Text.Json.Serialization.JsonPropertyName("lastModificationTime")]
    public string? LastModificationTime { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("lastModifierUserId")]
    public double? LastModifierUserId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("email")]
    public string? Email { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("bankName")]
    public required BankNameEnum BankName { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("accountName")]
    public string? AccountName { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("accountNumber")]
    public required string AccountNumber { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("phone")]
    public required string Phone { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("confirmPaymentByEmail")]
    public required bool ConfirmPaymentByEmail { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("confirmEmail")]
    public string? ConfirmEmail { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("confirmPaymentByZalo")]
    public required bool ConfirmPaymentByZalo { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("confirmPhoneNumber")]
    public required string ConfirmPhoneNumber { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("tokenRef")]
    public string? TokenRef { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("status")]
    public required DirectDebitStatusEnum Status { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }
    /// <summary>Bank BIN. Use <see cref="Tingee.Sdk.Types.BankBin"/> constants.</summary>
    [System.Text.Json.Serialization.JsonPropertyName("bankBin")]
    public string? BankBin { get; set; }
}

public sealed class CustomerInfoDto
{
    [System.Text.Json.Serialization.JsonPropertyName("onepayAccountId")]
    public required string OnepayAccountId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("name")]
    public required string Name { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("phone")]
    public required string Phone { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("email")]
    public string? Email { get; set; }
}

[System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
public enum WebhookStatusEnum
{
    [System.Runtime.Serialization.EnumMember(Value = "success")] SUCCESS,
    [System.Runtime.Serialization.EnumMember(Value = "failed")] FAILED,
    [System.Runtime.Serialization.EnumMember(Value = "pending")] PENDING,
    [System.Runtime.Serialization.EnumMember(Value = "insufficient-balance")] INSUFFICIENT_BALANCE,
    [System.Runtime.Serialization.EnumMember(Value = "exceed-daily-limit")] EXCEED_DAILY_LIMIT,
    [System.Runtime.Serialization.EnumMember(Value = "confirm-va-success")] CONFIRM_VA_SUCCESS,
    [System.Runtime.Serialization.EnumMember(Value = "confirm-va-failed")] CONFIRM_VA_FAILED,
    [System.Runtime.Serialization.EnumMember(Value = "delete-va-success")] DELETE_VA_SUCCESS,
    [System.Runtime.Serialization.EnumMember(Value = "delete-va-failed")] DELETE_VA_FAILED,
    [System.Runtime.Serialization.EnumMember(Value = "bank-link-success")] BANK_LINK_SUCCESS,
    [System.Runtime.Serialization.EnumMember(Value = "bank-link-failed")] BANK_LINK_FAILED
}

public sealed class OpenApiPaymentTransactionStatusResponseDto
{
    [System.Text.Json.Serialization.JsonPropertyName("transactionId")]
    public string? TransactionId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("customerKey")]
    public string? CustomerKey { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("tokenRef")]
    public required string TokenRef { get; set; }
    /// <summary>Bank BIN. Use <see cref="Tingee.Sdk.Types.BankBin"/> constants.</summary>
    [System.Text.Json.Serialization.JsonPropertyName("bankBin")]
    public required string BankBin { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("customer")]
    public required CustomerInfoDto Customer { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("accountNumber")]
    public string? AccountNumber { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("accountName")]
    public string? AccountName { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("code")]
    public string? Code { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("amount")]
    public double? Amount { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("currency")]
    public string? Currency { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("content")]
    public string? Content { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("transactionDate")]
    public string? TransactionDate { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("status")]
    public required WebhookStatusEnum Status { get; set; }
}

public sealed class OpenApiPaymentTransactionsPagedOutputDto
{
    [System.Text.Json.Serialization.JsonPropertyName("transactionId")]
    public required string TransactionId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("code")]
    public required string Code { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("bankName")]
    public required BankNameEnum BankName { get; set; }
    /// <summary>Bank BIN. Use <see cref="Tingee.Sdk.Types.BankBin"/> constants.</summary>
    [System.Text.Json.Serialization.JsonPropertyName("bankBin")]
    public required string BankBin { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("amount")]
    public required string Amount { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("content")]
    public required string Content { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("accountNumber")]
    public required string AccountNumber { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("transactionDate")]
    public required string TransactionDate { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("subscriptionId")]
    public required string SubscriptionId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("tokenRef")]
    public required string TokenRef { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("status")]
    public required DirectDebitTransactionStatusEnum Status { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("additionalData")]
    public object AdditionalData { get; set; }
}

public sealed class MerchantBankConfigPagedOutputDto
{
    [System.Text.Json.Serialization.JsonPropertyName("id")]
    public required int Id { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("creationTime")]
    public string? CreationTime { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("creatorUserId")]
    public double? CreatorUserId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("lastModificationTime")]
    public string? LastModificationTime { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("lastModifierUserId")]
    public double? LastModifierUserId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("deleterUserId")]
    public double? DeleterUserId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("merchantId")]
    public required int MerchantId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("accountType")]
    public required BankAccountTypeEnum AccountType { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("configDto")]
    public object ConfigDto { get; set; }
    /// <summary>Bank BIN. Use <see cref="Tingee.Sdk.Types.BankBin"/> constants.</summary>
    [System.Text.Json.Serialization.JsonPropertyName("bankBin")]
    public string? BankBin { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("bankName")]
    public BankNameEnum? BankName { get; set; }
}

public sealed class OpenApiMerchantBankConfigPagedInputDto
{
    [System.Text.Json.Serialization.JsonPropertyName("filter")]
    public string? Filter { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("sorting")]
    public string? Sorting { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("skipCount")]
    public required int SkipCount { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("maxResultCount")]
    public required int MaxResultCount { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("accountType")]
    public BankAccountTypeEnum? AccountType { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("merchantId")]
    public int? MerchantId { get; set; }
    /// <summary>Bank BIN. Use <see cref="Tingee.Sdk.Types.BankBin"/> constants.</summary>
    [System.Text.Json.Serialization.JsonPropertyName("bankBin")]
    public string? BankBin { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("bankName")]
    public BankNameEnum? BankName { get; set; }
}

public sealed class BIDVConfigDto
{
    [System.Text.Json.Serialization.JsonPropertyName("vaPrefix")]
    public required string VaPrefix { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("bankPartnerId")]
    public required string BankPartnerId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("accountNumber")]
    public required string AccountNumber { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("accountName")]
    public required string AccountName { get; set; }
}

public sealed class FileUploadDto
{
    [System.Text.Json.Serialization.JsonPropertyName("fileLogId")]
    public required string FileLogId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("path")]
    public required string Path { get; set; }
}

public sealed class VIBConfigDto
{
    [System.Text.Json.Serialization.JsonPropertyName("vaPrefix")]
    public required string VaPrefix { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("pathPublicKey")]
    public FileUploadDto? PathPublicKey { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("pathPrivateKey")]
    public FileUploadDto? PathPrivateKey { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("basicAuthToken")]
    public required string BasicAuthToken { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("cif")]
    public required string Cif { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("clientId")]
    public required string ClientId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("clientSecret")]
    public required string ClientSecret { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("accountNumber")]
    public required string AccountNumber { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("vaCharactersNumber")]
    public required int VaCharactersNumber { get; set; }
}

public sealed class CTGConfigDto
{
    [System.Text.Json.Serialization.JsonPropertyName("accountNumber")]
    public required string AccountNumber { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("accountName")]
    public required string AccountName { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("vaPrefix")]
    public required string VaPrefix { get; set; }
}

public sealed class ACBConfigBusinessDto
{
    [System.Text.Json.Serialization.JsonPropertyName("accountNumber")]
    public required string AccountNumber { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("accountName")]
    public required string AccountName { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("vaPrefix")]
    public required string VaPrefix { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("mobile")]
    public required string Mobile { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("acbUserId")]
    public required string AcbUserId { get; set; }
}

public sealed class VCBConfigBusinessDto
{
    [System.Text.Json.Serialization.JsonPropertyName("accountNumber")]
    public required string AccountNumber { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("accountName")]
    public required string AccountName { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("merchantId")]
    public required string MerchantId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("terminalId")]
    public required string TerminalId { get; set; }
}

public sealed class MSBConfigBusinessDto
{
    [System.Text.Json.Serialization.JsonPropertyName("accountNumber")]
    public required string AccountNumber { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("vaPrefix")]
    public required string VaPrefix { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("mobile")]
    public required string Mobile { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("merchantId")]
    public required string MerchantId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("terminalId")]
    public required string TerminalId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("accessCode")]
    public required string AccessCode { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("referralCode")]
    public required string ReferralCode { get; set; }
}

public sealed class BaoKimConfigDto
{
    [System.Text.Json.Serialization.JsonPropertyName("mid")]
    public string? Mid { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("accountName")]
    public string? AccountName { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("walletId")]
    public string? WalletId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("privateKey")]
    public string? PrivateKey { get; set; }
}

public sealed class PayooConfigDto
{
    [System.Text.Json.Serialization.JsonPropertyName("accountName")]
    public required string AccountName { get; set; }
}

public sealed class OpenApiBankCreateOrUpdateConfigDto
{
    [System.Text.Json.Serialization.JsonPropertyName("bidvConfigDto")]
    public BIDVConfigDto? BidvConfigDto { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("vibConfigDto")]
    public VIBConfigDto? VibConfigDto { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("ctgConfigDto")]
    public CTGConfigDto? CtgConfigDto { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("acbConfigDto")]
    public ACBConfigBusinessDto? AcbConfigDto { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("vcbConfigDto")]
    public VCBConfigBusinessDto? VcbConfigDto { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("msbConfigDto")]
    public MSBConfigBusinessDto? MsbConfigDto { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("baokimConfigDto")]
    public BaoKimConfigDto? BaokimConfigDto { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("payooConfigDto")]
    public PayooConfigDto? PayooConfigDto { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("accountType")]
    public required BankAccountTypeEnum AccountType { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("id")]
    public int? Id { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("otpNumber")]
    public string? OtpNumber { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("confirmId")]
    public string? ConfirmId { get; set; }
    /// <summary>Bank BIN. Use <see cref="Tingee.Sdk.Types.BankBin"/> constants.</summary>
    [System.Text.Json.Serialization.JsonPropertyName("bankBin")]
    public string? BankBin { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("bankName")]
    public BankNameEnum? BankName { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("merchantId")]
    public int? MerchantId { get; set; }
}

public sealed class OpenApiDeleteConfigDto
{
    [System.Text.Json.Serialization.JsonPropertyName("otpNumber")]
    public string? OtpNumber { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("confirmId")]
    public string? ConfirmId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("id")]
    public required double Id { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("merchantId")]
    public int? MerchantId { get; set; }
}

public sealed class OpenApiCreateBankVAOutputDto
{
    [System.Text.Json.Serialization.JsonPropertyName("confirmId")]
    public string? ConfirmId { get; set; }
}

public sealed class OpenApiConfigAccountBusinessDto
{
    [System.Text.Json.Serialization.JsonPropertyName("bankName")]
    public BankNameEnum? BankName { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("accountNumber")]
    public string? AccountNumber { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("accountName")]
    public string? AccountName { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("mobile")]
    public string? Mobile { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("vaPrefix")]
    public string? VaPrefix { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("merchantId")]
    public int? MerchantId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("acbUserId")]
    public required string AcbUserId { get; set; }
    /// <summary>Bank BIN. Use <see cref="Tingee.Sdk.Types.BankBin"/> constants.</summary>
    [System.Text.Json.Serialization.JsonPropertyName("bankBin")]
    public string? BankBin { get; set; }
}

public sealed class OpenApiDeleteConfigBusinessDto
{
    [System.Text.Json.Serialization.JsonPropertyName("accountType")]
    public required BankAccountTypeEnum AccountType { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("configRemove")]
    public required ACBConfigBusinessDto ConfigRemove { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("merchantId")]
    public int? MerchantId { get; set; }
    /// <summary>Bank BIN. Use <see cref="Tingee.Sdk.Types.BankBin"/> constants.</summary>
    [System.Text.Json.Serialization.JsonPropertyName("bankBin")]
    public string? BankBin { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("bankName")]
    public BankNameEnum? BankName { get; set; }
}

public sealed class OpenApiMerchantIdDto
{
    [System.Text.Json.Serialization.JsonPropertyName("merchantId")]
    public required long MerchantId { get; set; }
}

[System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
public enum MerchantBaasTypeEnum
{
    [System.Runtime.Serialization.EnumMember(Value = "trial")] TRIAL,
    [System.Runtime.Serialization.EnumMember(Value = "trial-extended")] TRIAL_EXTENDED,
    [System.Runtime.Serialization.EnumMember(Value = "customer")] CUSTOMER,
    [System.Runtime.Serialization.EnumMember(Value = "cancelled")] CANCELLED,
    [System.Runtime.Serialization.EnumMember(Value = "unclassified")] UNCLASSIFIED
}

public sealed class OpenApiCreateMerchantDto
{
    [System.Text.Json.Serialization.JsonPropertyName("id")]
    public int? Id { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("code")]
    public string? Code { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("name")]
    public required string Name { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("email")]
    public string? Email { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("phoneNumber")]
    public required string PhoneNumber { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("website")]
    public string? Website { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("businessSectorIds")]
    public IList<double>? BusinessSectorIds { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("provinceId")]
    public string? ProvinceId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("districtId")]
    public string? DistrictId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("communeId")]
    public string? CommuneId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("address")]
    public string? Address { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("fullAddress")]
    public string? FullAddress { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("referralCode")]
    public string? ReferralCode { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("baasType")]
    public MerchantBaasTypeEnum? BaasType { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("password")]
    public required string Password { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("appType")]
    public required AppTypeEnum AppType { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("requirePasswordChange")]
    public bool? RequirePasswordChange { get; set; }
}

public sealed class EventUrlItemDto
{
    [System.Text.Json.Serialization.JsonPropertyName("url")]
    public required string Url { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("type")]
    public required EventUrlItemType Type { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("ids")]
    public IList<string>? Ids { get; set; }
}

public sealed class OCBConfigDto
{
    [System.Text.Json.Serialization.JsonPropertyName("clientId")]
    public required string ClientId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("clientSecret")]
    public string? ClientSecret { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("pathCertKey")]
    public FileUploadDto? PathCertKey { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("pathPrivateKey")]
    public FileUploadDto? PathPrivateKey { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("userName")]
    public required string UserName { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("password")]
    public string? Password { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("vaPrefix")]
    public string? VaPrefix { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("vaPrefixForDynamicQR")]
    public string? VaPrefixForDynamicQR { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("accountNumbers")]
    public IList<string>? AccountNumbers { get; set; }
}

public sealed class MBBConfigDto
{
    [System.Text.Json.Serialization.JsonPropertyName("accountNumber")]
    public required string AccountNumber { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("accountName")]
    public required string AccountName { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("identity")]
    public required string Identity { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("mobile")]
    public required string Mobile { get; set; }
}

public sealed class ShinhanConfigDto
{
    [System.Text.Json.Serialization.JsonPropertyName("vaPrefix")]
    public required string VaPrefix { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("clientId")]
    public required string ClientId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("clientSecret")]
    public string? ClientSecret { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("pathPublicKey")]
    public FileUploadDto? PathPublicKey { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("pathPrivateKey")]
    public FileUploadDto? PathPrivateKey { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("accountNumber")]
    public required string AccountNumber { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("accountName")]
    public required string AccountName { get; set; }
}

public sealed class ACBConfigDto
{
    [System.Text.Json.Serialization.JsonPropertyName("businessAccounts")]
    public IList<ACBConfigBusinessDto>? BusinessAccounts { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("businessHouseholdAccounts")]
    public IList<ACBConfigBusinessDto>? BusinessHouseholdAccounts { get; set; }
}

public sealed class VPBConfigBusinessDto
{
    [System.Text.Json.Serialization.JsonPropertyName("accountNumber")]
    public required string AccountNumber { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("accountName")]
    public required string AccountName { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("merchantId")]
    public required string MerchantId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("terminalId")]
    public required string TerminalId { get; set; }
}

public sealed class VPBConfigDto
{
    [System.Text.Json.Serialization.JsonPropertyName("businessAccounts")]
    public IList<VPBConfigBusinessDto>? BusinessAccounts { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("businessHouseholdAccounts")]
    public IList<VPBConfigBusinessDto>? BusinessHouseholdAccounts { get; set; }
}

public sealed class VCBConfigDto
{
    [System.Text.Json.Serialization.JsonPropertyName("businessAccounts")]
    public IList<VCBConfigBusinessDto>? BusinessAccounts { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("businessHouseholdAccounts")]
    public IList<VCBConfigBusinessDto>? BusinessHouseholdAccounts { get; set; }
}

public sealed class BankConfigDto
{
    [System.Text.Json.Serialization.JsonPropertyName("ocbConfigDtos")]
    public IList<OCBConfigDto>? OcbConfigDtos { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("mbbConfigDtos")]
    public IList<MBBConfigDto>? MbbConfigDtos { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("bidvConfigDtos")]
    public IList<BIDVConfigDto>? BidvConfigDtos { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("shinhanConfigDtos")]
    public IList<ShinhanConfigDto>? ShinhanConfigDtos { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("vibConfigDtos")]
    public IList<VIBConfigDto>? VibConfigDtos { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("ctgConfigDtos")]
    public IList<CTGConfigDto>? CtgConfigDtos { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("acbConfigDto")]
    public ACBConfigDto? AcbConfigDto { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("vpbConfigDto")]
    public VPBConfigDto? VpbConfigDto { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("vcbConfigDto")]
    public VCBConfigDto? VcbConfigDto { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("baokimConfigDto")]
    public BaoKimConfigDto? BaokimConfigDto { get; set; }
}

public sealed class BNPLConfigDto
{
    [System.Text.Json.Serialization.JsonPropertyName("baokimConfigDto")]
    public BaoKimConfigDto? BaokimConfigDto { get; set; }
}

public sealed class OnePayConfigDto
{
    [System.Text.Json.Serialization.JsonPropertyName("merchantId")]
    public required string MerchantId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("signingKey")]
    public required string SigningKey { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("verifyKey")]
    public required string VerifyKey { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("accessCode")]
    public required string AccessCode { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("hashCode")]
    public required string HashCode { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("callbackUrl")]
    public required string CallbackUrl { get; set; }
}

public sealed class DirectDebitConfigDto
{
    [System.Text.Json.Serialization.JsonPropertyName("onePayConfigDto")]
    public OnePayConfigDto? OnePayConfigDto { get; set; }
}

public sealed class MerchantPackageInfo
{
    [System.Text.Json.Serialization.JsonPropertyName("packageName")]
    public string? PackageName { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("expirationDate")]
    public string? ExpirationDate { get; set; }
}

public sealed class MerchantDto
{
    [System.Text.Json.Serialization.JsonPropertyName("id")]
    public required int Id { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("creationTime")]
    public string? CreationTime { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("code")]
    public string? Code { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("name")]
    public required string Name { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("email")]
    public string? Email { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("phoneNumber")]
    public required string PhoneNumber { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("website")]
    public string? Website { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("businessSectorIds")]
    public IList<double>? BusinessSectorIds { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("provinceId")]
    public string? ProvinceId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("districtId")]
    public string? DistrictId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("communeId")]
    public string? CommuneId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("address")]
    public string? Address { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("fullAddress")]
    public string? FullAddress { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("clientId")]
    public string? ClientId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("secretToken")]
    public string? SecretToken { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("eventUrl")]
    public string? EventUrl { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("eventUrls")]
    public IList<EventUrlItemDto>? EventUrls { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("isLockEvent")]
    public bool? IsLockEvent { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("bankConfigDto")]
    public BankConfigDto? BankConfigDto { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("bnplConfigDto")]
    public BNPLConfigDto? BnplConfigDto { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("directDebitConfigDto")]
    public DirectDebitConfigDto? DirectDebitConfigDto { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("sendNotifyPlatformDto")]
    public SendNotifyPlatformDto? SendNotifyPlatformDto { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("isOrganizationUnit")]
    public bool? IsOrganizationUnit { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("referralCode")]
    public string? ReferralCode { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("userReferralAncestorIds")]
    public string? UserReferralAncestorIds { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("userReferralLevel")]
    public double? UserReferralLevel { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("deviceDistributorAncestorMap")]
    public string? DeviceDistributorAncestorMap { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("isMasterMerchant")]
    public bool? IsMasterMerchant { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("baasType")]
    public MerchantBaasTypeEnum? BaasType { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("merchantPackages")]
    public IList<MerchantPackageInfo>? MerchantPackages { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("masterMerchantNames")]
    public string? MasterMerchantNames { get; set; }
}

public sealed class OpenApiGetPagingMerchantsDto
{
    [System.Text.Json.Serialization.JsonPropertyName("filter")]
    public string? Filter { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("sorting")]
    public string? Sorting { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("skipCount")]
    public required int SkipCount { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("maxResultCount")]
    public required int MaxResultCount { get; set; }
}

[System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
public enum EInvoiceProviderEnum
{
    [System.Runtime.Serialization.EnumMember(Value = "x-cyber")] X_CYBER,
    [System.Runtime.Serialization.EnumMember(Value = "hilo")] HILO,
    [System.Runtime.Serialization.EnumMember(Value = "s-invoice")] S_INVOICE,
    [System.Runtime.Serialization.EnumMember(Value = "misa")] MISA,
    [System.Runtime.Serialization.EnumMember(Value = "bkav")] BKAV
}

public sealed class GetPagingEInvoiceAccountOutputDto
{
    [System.Text.Json.Serialization.JsonPropertyName("id")]
    public required int Id { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("creationTime")]
    public string? CreationTime { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("merchantId")]
    public required double MerchantId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("masterMerchantId")]
    public required double MasterMerchantId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("provider")]
    public required EInvoiceProviderEnum Provider { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("taxCode")]
    public required string TaxCode { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("username")]
    public required string Username { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("password")]
    public required string Password { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("isDefault")]
    public bool? IsDefault { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("isActive")]
    public bool? IsActive { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("services")]
    public IList<string>? Services { get; set; }
}

public sealed class GetPagingEInvoiceAccountInputDto
{
    [System.Text.Json.Serialization.JsonPropertyName("filter")]
    public string? Filter { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("sorting")]
    public string? Sorting { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("skipCount")]
    public required int SkipCount { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("maxResultCount")]
    public required int MaxResultCount { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("provider")]
    public EInvoiceProviderEnum? Provider { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("isDefault")]
    public bool? IsDefault { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("isActive")]
    public bool? IsActive { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("merchantId")]
    public int? MerchantId { get; set; }
}

public sealed class CreateOrUpdateEInvoiceAccountDto
{
    [System.Text.Json.Serialization.JsonPropertyName("masterMerchantId")]
    public required double MasterMerchantId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("provider")]
    public required EInvoiceProviderEnum Provider { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("taxCode")]
    public required string TaxCode { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("username")]
    public required string Username { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("password")]
    public required string Password { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("isDefault")]
    public bool? IsDefault { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("isActive")]
    public bool? IsActive { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("id")]
    public int? Id { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("merchantId")]
    public int? MerchantId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("services")]
    public IList<string>? Services { get; set; }
}

public sealed class DeleteEInvoiceAccountDto
{
    [System.Text.Json.Serialization.JsonPropertyName("id")]
    public required int Id { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("merchantId")]
    public int? MerchantId { get; set; }
}

public sealed class EInvoiceProviderDto
{
    [System.Text.Json.Serialization.JsonPropertyName("code")]
    public EInvoiceProviderEnum? Code { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("name")]
    public string? Name { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("description")]
    public string? Description { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("urlLogo")]
    public string? UrlLogo { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("lookupUrlPattern")]
    public string? LookupUrlPattern { get; set; }
}

public sealed class DownloadInvoiceOutputDto
{
    [System.Text.Json.Serialization.JsonPropertyName("invoiceCode")]
    public required string InvoiceCode { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("pdfBase64")]
    public string? PdfBase64 { get; set; }
}

public sealed class InvoiceItemDto
{
    [System.Text.Json.Serialization.JsonPropertyName("itemCode")]
    public string? ItemCode { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("itemName")]
    public required string ItemName { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("unitName")]
    public string? UnitName { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("quantity")]
    public required string Quantity { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("unitPrice")]
    public required string UnitPrice { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("discount")]
    public string? Discount { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("discountAmount")]
    public string? DiscountAmount { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("totalBeforeTax")]
    public string? TotalBeforeTax { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("taxRateCode")]
    public required string TaxRateCode { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("taxAmount")]
    public string? TaxAmount { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("totalAfterTax")]
    public string? TotalAfterTax { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("itemType")]
    public int? ItemType { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("adjustmentType")]
    public int? AdjustmentType { get; set; }
}

public sealed class TaxRateSummaryDto
{
    [System.Text.Json.Serialization.JsonPropertyName("taxRateCode")]
    public required string TaxRateCode { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("totalTaxableAmount")]
    public string? TotalTaxableAmount { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("taxAmount")]
    public string? TaxAmount { get; set; }
}

public sealed class CreateInvoiceDto
{
    [System.Text.Json.Serialization.JsonPropertyName("merchantId")]
    public int? MerchantId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("accountId")]
    public int? AccountId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("invoiceType")]
    public string? InvoiceType { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("invoicePattern")]
    public required string InvoicePattern { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("invoiceSeries")]
    public required string InvoiceSeries { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("invoiceCode")]
    public required string InvoiceCode { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("invoiceDate")]
    public required string InvoiceDate { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("buyerTaxCode")]
    public string? BuyerTaxCode { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("buyerIdentity")]
    public string? BuyerIdentity { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("buyerIdType")]
    public string? BuyerIdType { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("buyerName")]
    public string? BuyerName { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("buyerLegalName")]
    public string? BuyerLegalName { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("buyerAddress")]
    public string? BuyerAddress { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("buyerPhone")]
    public string? BuyerPhone { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("buyerEmail")]
    public string? BuyerEmail { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("buyerBankAccount")]
    public string? BuyerBankAccount { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("buyerBankName")]
    public string? BuyerBankName { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("paymentMethod")]
    public int? PaymentMethod { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("paymentMethodName")]
    public string? PaymentMethodName { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("currency")]
    public string? Currency { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("exchangeRate")]
    public string? ExchangeRate { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("amountInWords")]
    public string? AmountInWords { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("note")]
    public string? Note { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("items")]
    public required IList<InvoiceItemDto> Items { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("totalDiscount")]
    public string? TotalDiscount { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("totalBeforeTax")]
    public string? TotalBeforeTax { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("totalTax")]
    public string? TotalTax { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("totalAfterTax")]
    public string? TotalAfterTax { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("taxRateSummaries")]
    public IList<TaxRateSummaryDto>? TaxRateSummaries { get; set; }
}

public sealed class TrackingResultDto
{
    [System.Text.Json.Serialization.JsonPropertyName("invoiceCode")]
    public required string InvoiceCode { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("trackingCode")]
    public string? TrackingCode { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("invoiceNumber")]
    public string? InvoiceNumber { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("reservationCode")]
    public string? ReservationCode { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("codeOfTax")]
    public string? CodeOfTax { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("url")]
    public string? Url { get; set; }
}

public sealed class GetInvoiceInfoQueryDto
{
    [System.Text.Json.Serialization.JsonPropertyName("merchantId")]
    public int? MerchantId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("accountId")]
    public int? AccountId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("invoiceCode")]
    public required string InvoiceCode { get; set; }
}

public sealed class DownloadInvoiceQueryDto
{
    [System.Text.Json.Serialization.JsonPropertyName("merchantId")]
    public int? MerchantId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("accountId")]
    public int? AccountId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("invoiceCode")]
    public required string InvoiceCode { get; set; }
}

public sealed class InvoiceTemplateOutputDto
{
    [System.Text.Json.Serialization.JsonPropertyName("invoicePattern")]
    public required string InvoicePattern { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("invoiceSeries")]
    public required string InvoiceSeries { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("quota")]
    public int? Quota { get; set; }
}

public sealed class InvoiceTemplateInputDto
{
    [System.Text.Json.Serialization.JsonPropertyName("merchantId")]
    public int? MerchantId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("accountId")]
    public int? AccountId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("provider")]
    public EInvoiceProviderEnum? Provider { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("taxCode")]
    public string? TaxCode { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("username")]
    public string? Username { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("password")]
    public string? Password { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("invoiceNoToCheck")]
    public int? InvoiceNoToCheck { get; set; }
}

public sealed class SendInvoiceEmailDto
{
    [System.Text.Json.Serialization.JsonPropertyName("merchantId")]
    public int? MerchantId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("accountId")]
    public int? AccountId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("invoiceCode")]
    public required string InvoiceCode { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("buyerName")]
    public string? BuyerName { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("recipientEmail")]
    public required string RecipientEmail { get; set; }
}

public sealed class ConnectTCTRequestDto
{
    [System.Text.Json.Serialization.JsonPropertyName("merchantId")]
    public int? MerchantId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("accountId")]
    public int? AccountId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("tctUsername")]
    public string? TctUsername { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("tctPassword")]
    public string? TctPassword { get; set; }
}

public sealed class InputInvoiceBaseDto
{
    [System.Text.Json.Serialization.JsonPropertyName("merchantId")]
    public int? MerchantId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("accountId")]
    public int? AccountId { get; set; }
}

public sealed class SyncIncomeInvoiceRequestDto
{
    [System.Text.Json.Serialization.JsonPropertyName("merchantId")]
    public int? MerchantId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("accountId")]
    public int? AccountId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("fromDate")]
    public string? FromDate { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("toDate")]
    public string? ToDate { get; set; }
}

public sealed class GetIncomeInvoicesListRequestDto
{
    [System.Text.Json.Serialization.JsonPropertyName("merchantId")]
    public int? MerchantId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("accountId")]
    public int? AccountId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("fromDate")]
    public string? FromDate { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("toDate")]
    public string? ToDate { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("benBan")]
    public string? BenBan { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("benMua")]
    public string? BenMua { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("current")]
    public double? Current { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("ngayDuyetBd")]
    public string? NgayDuyetBd { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("ngayDuyetKt")]
    public string? NgayDuyetKt { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("ngayLapBd")]
    public string? NgayLapBd { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("ngayLapKt")]
    public string? NgayLapKt { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("ngayNhanBd")]
    public string? NgayNhanBd { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("ngayNhanKt")]
    public string? NgayNhanKt { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("nhanDan")]
    public string? NhanDan { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("page")]
    public double? Page { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("pageSize")]
    public double? PageSize { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("size")]
    public double? Size { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("soHoaDon")]
    public string? SoHoaDon { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("tinhChatHoaDon")]
    public double? TinhChatHoaDon { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("trangThaiPheDuyet")]
    public double? TrangThaiPheDuyet { get; set; }
}

public sealed class GetIncomeInvoiceDetailRequestDto
{
    [System.Text.Json.Serialization.JsonPropertyName("merchantId")]
    public int? MerchantId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("accountId")]
    public int? AccountId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("maHoaDon")]
    public required string MaHoaDon { get; set; }
}

public sealed class GetIncomeInvoicePreviewBase64RequestDto
{
    [System.Text.Json.Serialization.JsonPropertyName("merchantId")]
    public int? MerchantId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("accountId")]
    public int? AccountId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("maHoaDon")]
    public required string MaHoaDon { get; set; }
}

public sealed class OpenApiCreatePaymentLinkInputDto
{
    [System.Text.Json.Serialization.JsonPropertyName("merchantId")]
    public required int MerchantId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("orderId")]
    public required string OrderId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("requestId")]
    public required string RequestId { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("amount")]
    public required double Amount { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("currency")]
    public string? Currency { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("expireInMinute")]
    public double? ExpireInMinute { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("description")]
    public string? Description { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("orderInfo")]
    public string? OrderInfo { get; set; }
    /// <summary>Bank BIN. Use <see cref="Tingee.Sdk.Types.BankBin"/> constants.</summary>
    [System.Text.Json.Serialization.JsonPropertyName("bankBin")]
    public string? BankBin { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("vaAccountNumber")]
    public string? VaAccountNumber { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("returnUrl")]
    public string? ReturnUrl { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("customerEmail")]
    public string? CustomerEmail { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("paymentGroup")]
    public string? PaymentGroup { get; set; }
}