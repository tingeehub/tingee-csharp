// Auto-generated from openapi/sdk.json
// DO NOT EDIT MANUALLY

#nullable disable

namespace Tingee.Sdk.Types.Dtos;

public sealed class OpenApiOuputDto
{
    public string Code { get; set; } = default!;
    public string Message { get; set; } = default!;
    public object Data { get; set; }
}

public sealed class GenerateVietQROuputDto
{
    public string QrCode { get; set; } = default!;
    public string QrCodeImage { get; set; } = default!;
    public string QrAccount { get; set; } = default!;
    public string ReferenceLabelCode { get; set; } = default!;
}

public sealed class OpenApiGenerateVietQRInputDto
{
    public string BankBin { get; set; } = default!;
    public string BankName { get; set; }
    public string AccountNumber { get; set; } = default!;
    public double Amount { get; set; }
    public string Content { get; set; } = default!;
}

public sealed class GenerateDynamicQROuputDto
{
    public string QrCode { get; set; } = default!;
    public string QrAccount { get; set; } = default!;
    public string BillId { get; set; } = default!;
}

public sealed class GenerateDynamicQRInputDto
{
    public double MerchantId { get; set; }
    public string VaAccountNumber { get; set; } = default!;
    public string QrCodeType { get; set; } = default!;
    public string BankBin { get; set; } = default!;
    public string BankName { get; set; }
    public double Amount { get; set; }
    public string Purpose { get; set; } = default!;
    public string ExtraInfo { get; set; }
}

public sealed class EmptyDto
{

}

public sealed class OpenApiDeleteDynamicQRInputDto
{
    public double? MerchantId { get; set; }
    public string QrAccount { get; set; } = default!;
    public string BillId { get; set; } = default!;
}

public sealed class OpenApiBillInfoDto
{
    public string BillId { get; set; } = default!;
    public string QrCodeType { get; set; } = default!;
    public string BankBin { get; set; } = default!;
    public string AccountNumber { get; set; } = default!;
    public string VaAccountNumber { get; set; } = default!;
    public string QrAccount { get; set; } = default!;
    public double Amount { get; set; }
    public string Purpose { get; set; } = default!;
    public double TotalAmountPaid { get; set; }
    public double TotalPaymentsCount { get; set; }
    public double ExpireInMinute { get; set; }
    public string ExtraInfo { get; set; }
    public string Status { get; set; } = default!;
}

public sealed class OpenApiTransactionPagedOuputDto
{
    public string TransactionId { get; set; } = default!;
    public double MerchantId { get; set; }
    public double ShopId { get; set; }
    public string BankBin { get; set; }
    public string CashFlowSource { get; set; }
    public string Code { get; set; } = default!;
    public double Amount { get; set; }
    public string Type { get; set; }
    public string Content { get; set; }
    public string Currency { get; set; }
    public string AccountNumber { get; set; } = default!;
    public string VaAccountNumber { get; set; }
    public string TransactionDate { get; set; }
    public string BillId { get; set; } = default!;
}

public sealed class OpenApiGetStatusDynamicQROutputDto
{
    public OpenApiBillInfoDto BillInfo { get; set; }
    public IList<OpenApiTransactionPagedOuputDto> TransactionInfos { get; set; }
}

public sealed class OpenApiGetStatusDynamicQRInputDto
{
    public double? MerchantId { get; set; }
    public string QrAccount { get; set; } = default!;
    public string BillId { get; set; } = default!;
}

public sealed class Bank
{
    public string Code { get; set; }
    public string Name { get; set; }
    public string ShortName { get; set; }
    public string Bin { get; set; }
    public string UrlLogo { get; set; }
    public object TermsAndConditions { get; set; }
}

public sealed class PagedResultDto<T>
{
    [System.Text.Json.Serialization.JsonPropertyName("totalCount")]
    public double? TotalCount { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("items")]
    public IList<T> Items { get; set; } = new List<T>();
}

public sealed class OpenApiGetVAPagedOuputDto
{
    public string BankName { get; set; } = default!;
    public string BankBin { get; set; } = default!;
    public string AccountType { get; set; } = default!;
    public string AccountName { get; set; }
    public string AccountNumber { get; set; } = default!;
    public string VaAccountNumber { get; set; }
    public double ShopId { get; set; }
    public string Status { get; set; } = default!;
    public string CreationTime { get; set; } = default!;
}

public sealed class OpenApiGetVAPagedInputDto
{
    public string Filter { get; set; }
    public string Sorting { get; set; }
    public double SkipCount { get; set; }
    public double MaxResultCount { get; set; }
    public string StartTime { get; set; }
    public string EndTime { get; set; }
    public double MerchantId { get; set; }
    public double? ShopId { get; set; }
    public string AccountType { get; set; } = default!;
    public double? AgentId { get; set; }
    public string DataAccess { get; set; } = default!;
    public string BankBin { get; set; } = default!;
    public string BankName { get; set; } = default!;
}

public sealed class OpenApiGenerateVietQROuputDto
{
    public string BankBin { get; set; } = default!;
    public string AccountNumber { get; set; } = default!;
    public string Amount { get; set; } = default!;
    public string Purpose { get; set; } = default!;
    public string VaPrefix { get; set; } = default!;
    public string VaSuffix { get; set; } = default!;
}

public sealed class BankCreateVAOuputDto
{
    public string BankName { get; set; } = default!;
    public double MerchantAccountNumberId { get; set; }
    public double ShopId { get; set; }
    public string Status { get; set; } = default!;
    public string ConfirmId { get; set; }
    public string VaAccountNumber { get; set; }
    public string DeepLink { get; set; }
    public string OtpMethod { get; set; } = default!;
}

public sealed class OpenApiCreateVAInpuDto
{
    public string Name { get; set; }
    public string CashFlowSource { get; set; }
    public string AccountType { get; set; } = default!;
    public string AccountNumber { get; set; } = default!;
    public string AccountName { get; set; } = default!;
    public string Identity { get; set; } = default!;
    public string Mobile { get; set; } = default!;
    public double? MasterMerchantId { get; set; }
    public double? ShopId { get; set; }
    public string VaPrefix { get; set; }
    public string VaSuffix { get; set; }
    public string MerchantName { get; set; }
    public string MerchantAddress { get; set; }
    public double? ServiceId { get; set; }
    public bool? IsCreateNonOtp { get; set; }
    public string Code { get; set; }
    public string TaxCode { get; set; }
    public string SoftposUserName { get; set; }
    public string SoftposDeveloperId { get; set; }
    public string SoftposTid { get; set; }
    public string SoftposMid { get; set; }
    public string AuthorizationCode { get; set; }
    public string SessionLogin { get; set; }
    public bool IsNotifyAccountNumber { get; set; }
    public string AppType { get; set; } = default!;
    public string LinkType { get; set; } = default!;
    public string VaAccountNumber { get; set; }
    public string AcbUserId { get; set; }
    public string BankBin { get; set; } = default!;
    public string BankName { get; set; }
    public double? MerchantId { get; set; }
    public string RedirectUrl { get; set; } = default!;
    public string WebhookUrl { get; set; } = default!;
}

public sealed class OpenApiConfirmVAOuputDto
{
    public string AccountType { get; set; } = default!;
    public string BankName { get; set; } = default!;
    public string AccountNumber { get; set; } = default!;
    public string VaAccountNumber { get; set; } = default!;
}

public sealed class OpenApiBankConfirmVAInputDto
{
    public double MerchantId { get; set; }
    public string ConfirmId { get; set; } = default!;
    public string OtpNumber { get; set; } = default!;
    public string BankName { get; set; } = default!;
    public string BankBin { get; set; } = default!;
}

public sealed class BankDeleteVAOutputDto
{
    public string ConfirmId { get; set; }
}

public sealed class OpenApiRegisterNotifyDto
{
    public double? MerchantId { get; set; }
    public string VaAccountNumber { get; set; } = default!;
    public string BankBin { get; set; } = default!;
    public string BankName { get; set; }
}

public sealed class OpenApiRefundDto
{
    public double? MerchantId { get; set; }
    public string TransactionCode { get; set; } = default!;
    public string BankBin { get; set; } = default!;
    public string BankName { get; set; }
}

public sealed class OpenApiReadSecurityCodeDto
{
    public double? MerchantId { get; set; }
    public string Uuid { get; set; } = default!;
}

public sealed class OpenApiReadPartnerSecurityCodeDto
{
    public double? MerchantId { get; set; }
    public string Uuid { get; set; } = default!;
    public string SecurityCode { get; set; } = default!;
}

public sealed class SendNotifyTingeeBoxDto
{
    public string Type { get; set; } = default!;
    public string Uuid { get; set; } = default!;
}

public sealed class OpenApiAddDeviceToShop
{
    public string Uuid { get; set; } = default!;
    public string SecurityCode { get; set; } = default!;
    public string AppType { get; set; } = default!;
    public double? MasterMerchantId { get; set; }
    public double? MerchantId { get; set; }
    public IList<string> VaAccountNumbers { get; set; }
    public IList<double>? ShopIds { get; set; }
}

public sealed class OpenApiShopLinkToDeviceDto
{
    public string ShopName { get; set; } = default!;
    public double ShopId { get; set; }
    public bool IsLinkToDevice { get; set; }
    public string FullAddress { get; set; } = default!;
    public string VaAccountNumber { get; set; } = default!;
}

public sealed class OpenApiUpdateShopDeviceLinkDto
{
    public string Uuid { get; set; } = default!;
    public string Type { get; set; } = default!;
    public string AppType { get; set; } = default!;
    public IList<OpenApiShopLinkToDeviceDto> ShopsLinkToDeviceDtos { get; set; }
    public double? MerchantId { get; set; }
}

public sealed class BIDVOpenApiReadAmountDto
{
    public string Uuid { get; set; } = default!;
    public string TransactionId { get; set; } = default!;
    public double Amount { get; set; }
    public string BankBin { get; set; } = default!;
    public string FirstDisplayText { get; set; } = default!;
    public string SecondDisplayText { get; set; } = default!;
    public string ThirdDisplayText { get; set; } = default!;
    public bool PlaySound { get; set; }
}

public sealed class OpenApiReadAmountDto
{
    public double? MerchantId { get; set; }
    public string Uuid { get; set; } = default!;
    public string TransactionId { get; set; } = default!;
    public double Amount { get; set; }
    public string BankBin { get; set; } = default!;
    public string FirstDisplayText { get; set; } = default!;
    public string SecondDisplayText { get; set; } = default!;
    public string ThirdDisplayText { get; set; } = default!;
    public bool PlaySound { get; set; }
}

public sealed class OpenApiShowQRCodeDto
{
    public double? MerchantId { get; set; }
    public string Uuid { get; set; } = default!;
    public string VaAccountNumber { get; set; } = default!;
    public double Amount { get; set; }
    public string QrCode { get; set; } = default!;
    public string BankBin { get; set; } = default!;
    public string BankName { get; set; }
    public string DeviceType { get; set; }
    public string FirstText { get; set; } = default!;
    public string SecondText { get; set; } = default!;
    public string ThirdText { get; set; } = default!;
    public double ShowTime { get; set; }
    public bool IsStaticQr { get; set; }
    public bool PlaySound { get; set; }
}

public sealed class OpenApiGetDevicesLinkToShopOrVA
{
    public double? MerchantId { get; set; }
    public string VaAccountNumber { get; set; } = default!;
    public double? ShopId { get; set; }
}

public sealed class DeviceInfoDto
{

}

public sealed class ShopInfoDto
{
    public string Name { get; set; } = default!;
    public double Id { get; set; }
}

public sealed class DeviceDto
{
    public double? Id { get; set; }
    public string CreationTime { get; set; } = default!;
    public double? CreatorUserId { get; set; }
    public string LastModificationTime { get; set; } = default!;
    public double? LastModifierUserId { get; set; }
    public double? DeleterUserId { get; set; }
    public string Type { get; set; } = default!;
    public string Uuid { get; set; } = default!;
    public string Name { get; set; } = default!;
    public string System { get; set; }
    public string SystemVersion { get; set; }
    public double? MerchantId { get; set; }
    public double? AssignedAgentId { get; set; }
    public string MerchantPhoneNumber { get; set; }
    public string EmployeeName { get; set; }
    public string FirebaseToken { get; set; }
    public string Status { get; set; } = default!;
    public DeviceInfoDto? DeviceInfoDto { get; set; }
    public string UseDate { get; set; }
    public string SecurityCode { get; set; }
    public IList<string> SelectedBankNames { get; set; }
    public string UserReferralAncestorIds { get; set; }
    public double? UserReferralLevel { get; set; }
    public string DeviceDistributorAncestorIds { get; set; }
    public double? DeviceDistributorLevel { get; set; }
    public double MasterMerchantId { get; set; }
    public string MerchantName { get; set; }
    public IList<ShopInfoDto>? ShopDtos { get; set; }
    public string AgentName { get; set; }
    public double? AgentId { get; set; }
}

public sealed class OpenApiGetPagingDeviceInputDto
{
    public string Filter { get; set; }
    public string Sorting { get; set; }
    public double SkipCount { get; set; }
    public double MaxResultCount { get; set; }
    public double MerchantId { get; set; }
    public string Type { get; set; }
}

public sealed class OpenApiVerifyReferralCodeResponseDto
{
    public bool IsValid { get; set; }
    public bool? CanConnectAllBanks { get; set; }
    public IList<string>? BankBins { get; set; }
}

public sealed class OpenApiCreateOrUpdateShopOutputDto
{
    public double ShopId { get; set; }
}

public sealed class SendNotifyTelegramDto
{
    public double ChatId { get; set; }
}

public sealed class SendNotifyLarkDto
{
    public string UrlWebhook { get; set; } = default!;
}

public sealed class SendNotifyZaloDto
{
    public string Type { get; set; } = default!;
    public string Name { get; set; } = default!;
}

public sealed class SendNotifyPlatformDto
{
    public IList<SendNotifyTelegramDto> TelegramDtos { get; set; }
    public IList<SendNotifyLarkDto> LarkDtos { get; set; }
    public IList<SendNotifyZaloDto> ZaloDtos { get; set; }
    public IList<SendNotifyTingeeBoxDto> TingeeBoxDtos { get; set; }
}

public sealed class OpenApiCreateOrUpdateShopDto
{
    public double? Id { get; set; }
    public string Name { get; set; } = default!;
    public string Email { get; set; }
    public string PhoneNumber { get; set; } = default!;
    public string ProvinceId { get; set; }
    public string DistrictId { get; set; }
    public string CommuneId { get; set; }
    public string Address { get; set; }
    public string FullAddress { get; set; }
    public SendNotifyPlatformDto? SendNotifyPlatformDto { get; set; }
    public bool IsActive { get; set; }
    public string Status { get; set; }
    public string UserReferralAncestorIds { get; set; }
    public double? UserReferralLevel { get; set; }
    public string DeviceDistributorAncestorMap { get; set; }
    public double? MerchantId { get; set; }
}

public sealed class OpenApiGetShopPagedOuputDto
{
    public double Id { get; set; }
    public bool IsActive { get; set; }
    public double Name { get; set; }
    public string Address { get; set; }
}

public sealed class OpenApiGetShopPagedInputDto
{
    public string Filter { get; set; }
    public string Sorting { get; set; }
    public double SkipCount { get; set; }
    public double MaxResultCount { get; set; }
    public double? MerchantId { get; set; }
}

public sealed class GoogleModuleConfigDto
{
    public bool? Enable { get; set; }
    public double? Position { get; set; }
    public string PlaceId { get; set; }
    public string Title { get; set; }
}

public sealed class HotlineModuleConfigDto
{
    public bool? Enable { get; set; }
    public double? Position { get; set; }
    public string PhoneNumber { get; set; }
    public string Title { get; set; }
}

public sealed class EmailModuleConfigDto
{
    public bool? Enable { get; set; }
    public double? Position { get; set; }
    public string Email { get; set; }
    public string Title { get; set; }
}

public sealed class ZaloModuleConfigDto
{
    public bool? Enable { get; set; }
    public double? Position { get; set; }
    public string ZaloId { get; set; }
    public string Title { get; set; }
}

public sealed class MessengerModuleConfigDto
{
    public bool? Enable { get; set; }
    public double? Position { get; set; }
    public string PageId { get; set; }
    public string Title { get; set; }
}

public sealed class PaymentModuleConfigDto
{
    public bool? Enable { get; set; }
    public double? Position { get; set; }
    public IList<string>? AccountNumberIds { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
}

public sealed class InvoiceModuleConfigDto
{
    public bool? Enable { get; set; }
    public double? Position { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Webhook { get; set; }
}

public sealed class ShopNfcModuleItemDto
{
    public GoogleModuleConfigDto? GoogleConfig { get; set; }
    public HotlineModuleConfigDto? HotlineConfig { get; set; }
    public EmailModuleConfigDto? EmailConfig { get; set; }
    public ZaloModuleConfigDto? ZaloConfig { get; set; }
    public MessengerModuleConfigDto? MessengerConfig { get; set; }
    public PaymentModuleConfigDto? PaymentConfig { get; set; }
    public InvoiceModuleConfigDto? InvoiceConfig { get; set; }
}

public sealed class OpenApiShopNFCConfigDto
{
    public double? MerchantId { get; set; }
    public double ShopId { get; set; }
    public string DisplayName { get; set; } = default!;
    public string Color { get; set; } = default!;
    public string Address { get; set; } = default!;
    public string Title { get; set; } = default!;
    public string Description { get; set; } = default!;
    public string Logo { get; set; } = default!;
    public string Avatar { get; set; } = default!;
    public bool IsActive { get; set; }
    public ShopNfcModuleItemDto Modules { get; set; }
}

public sealed class OpenApiLinkOrUnlinkNfcShopDto
{
    public string NfcId { get; set; } = default!;
    public double ShopId { get; set; }
    public bool IsLink { get; set; }
    public double? MerchantId { get; set; }
}

public sealed class OpenApiDeepLinkDto
{
    public double? MerchantId { get; set; }
    public string Type { get; set; } = default!;
    public string QrCode { get; set; } = default!;
    public string RedirectUrl { get; set; } = default!;
    public string CallbackUrl { get; set; } = default!;
    public string BankBin { get; set; } = default!;
    public string DestinationBankBin { get; set; } = default!;
    public string AccountName { get; set; } = default!;
    public string AccountNumber { get; set; } = default!;
    public double Amount { get; set; }
    public string Content { get; set; } = default!;
    public string BillNumber { get; set; } = default!;
}

public sealed class OCBInfoDto
{
    public string VaPrefix { get; set; }
    public string IdentificationNumber { get; set; }
    public string AccountName { get; set; }
    public string AccountNumber { get; set; }
    public string RegisterDate { get; set; }
    public string VaAccountNumber { get; set; }
    public string MerchantName { get; set; }
    public string MerchantAddress { get; set; }
    public string MobilePhone { get; set; }
    public string Email { get; set; }
}

public sealed class TPBInfoDto
{
    public string AccountName { get; set; }
}

public sealed class BIDVInfoDto
{
    public string VaPrefix { get; set; }
    public string MerchantName { get; set; }
    public string MerchantAddress { get; set; }
    public string AccountNo { get; set; }
    public string AccountName { get; set; }
    public string Identity { get; set; }
    public string Mobile { get; set; }
    public string Email { get; set; }
}

public sealed class MBBInfoDto
{
    public string MerchantName { get; set; }
    public string MerchantAddress { get; set; }
    public string AccountNumber { get; set; }
    public string AccountName { get; set; }
    public string Identity { get; set; }
    public string Mobile { get; set; }
    public string Email { get; set; }
}

public sealed class ACBInfoDto
{
    public string VaPrefix { get; set; }
    public string MerchantName { get; set; }
    public string MerchantAddress { get; set; }
    public string AccountNumber { get; set; }
    public string AccountName { get; set; }
    public string Mobile { get; set; }
    public string Email { get; set; }
    public string AcbUserId { get; set; }
}

public sealed class VPBInfoDto
{
    public string AccountNumber { get; set; }
    public string AccountName { get; set; }
    public string Identity { get; set; }
    public string RegisterId { get; set; }
    public string BankRegisterId { get; set; }
    public bool? IsWaitingForApproveDelete { get; set; }
    public string SoftposUserName { get; set; }
    public string SoftposDeveloperId { get; set; }
    public string SoftposTid { get; set; }
    public string SoftposMid { get; set; }
}

public sealed class ShinhanInfoDto
{
    public string VaPrefix { get; set; }
    public string AccountNumber { get; set; }
    public string MerchantName { get; set; }
}

public sealed class PGBInfoDto
{
    public string AccountName { get; set; }
    public string AccountNumber { get; set; }
    public string Identity { get; set; }
    public string Mobile { get; set; }
}

public sealed class VIBInfoDto
{
    public string VaPrefix { get; set; }
    public string MerchantName { get; set; }
    public string AccountNumber { get; set; }
    public string AccountName { get; set; }
    public string Identity { get; set; }
    public string Mobile { get; set; }
    public string Email { get; set; }
    public string ContractId { get; set; }
    public string CustId { get; set; }
}

public sealed class CTGInfoDto
{
    public string VaPrefix { get; set; }
    public string MerchantName { get; set; }
    public string AccountNumber { get; set; }
    public string AccountName { get; set; }
    public string Identity { get; set; }
    public string Mobile { get; set; }
}

public sealed class STBInfoDto
{
    public string MerchantName { get; set; }
    public string AccountNumber { get; set; }
    public string AccountName { get; set; }
    public string Identity { get; set; }
    public string Mobile { get; set; }
    public string MerchantId { get; set; }
    public string StoreId { get; set; }
}

public sealed class AgribankInfoDto
{
    public string AccountNumber { get; set; }
    public string AccountName { get; set; }
    public string Identity { get; set; }
    public string Mobile { get; set; }
    public string TaxCode { get; set; }
    public string AgribankVaId { get; set; }
}

public sealed class VCBBaasDto
{
    public string RequestId { get; set; }
    public string RedirectUrl { get; set; }
    public string WebhookUrl { get; set; }
}

public sealed class VCBInfoDto
{
    public string AccountName { get; set; }
    public string AccountNumber { get; set; }
    public string Mobile { get; set; }
    public VCBBaasDto? BaasDto { get; set; }
}

public sealed class COBInfoDto
{
    public string AccountName { get; set; }
    public string AccountNumber { get; set; }
    public string Identity { get; set; }
    public string Mobile { get; set; }
    public string MerchantName { get; set; }
}

public sealed class BankInfoDto
{
    public OCBInfoDto? OcbInfoDto { get; set; }
    public TPBInfoDto? TpbInfoDto { get; set; }
    public BIDVInfoDto? BidvInfoDto { get; set; }
    public MBBInfoDto? MbbInfoDto { get; set; }
    public ACBInfoDto? AcbInfoDto { get; set; }
    public VPBInfoDto? VpbInfoDto { get; set; }
    public ShinhanInfoDto? ShinhanInfoDto { get; set; }
    public PGBInfoDto? PgbInfoDto { get; set; }
    public VIBInfoDto? VibInfoDto { get; set; }
    public CTGInfoDto? CtgInfoDto { get; set; }
    public STBInfoDto? StbInfoDto { get; set; }
    public AgribankInfoDto? AgribankInfoDto { get; set; }
    public VCBInfoDto? VcbInfoDto { get; set; }
    public COBInfoDto? CobInfoDto { get; set; }
}

public sealed class V2AccountNumberDDLDto
{
    public double Id { get; set; }
    public string Name { get; set; } = default!;
    public double MerchantId { get; set; }
    public string BankBin { get; set; } = default!;
    public string BankName { get; set; } = default!;
    public string AccountNumber { get; set; } = default!;
    public string VaAccountNumber { get; set; }
    public string RealVANumber { get; set; }
    public BankInfoDto? BankInfoDto { get; set; }
    public double ShopId { get; set; }
    public string ShopName { get; set; } = default!;
}

public sealed class OpenApiAccountNumberDDLPagedInputDto
{
    public string Filter { get; set; }
    public string Sorting { get; set; }
    public double SkipCount { get; set; }
    public double MaxResultCount { get; set; }
    public double? MerchantId { get; set; }
    public IList<double>? MerchantAccountNumberIds { get; set; }
    public IList<double>? ShopIds { get; set; }
    public IList<string>? RealVANumbers { get; set; }
    public bool? IsGetMerchantCashAccountsNumber { get; set; }
    public IList<string> BankBins { get; set; }
    public IList<string>? BankNames { get; set; }
}

public sealed class OpenApiTransactionPagedInputDto
{
    public string Filter { get; set; }
    public string Sorting { get; set; }
    public double SkipCount { get; set; }
    public double MaxResultCount { get; set; }
    public double MerchantId { get; set; }
    public IList<double> ShopIds { get; set; }
    public IList<string> VaAccountNumbers { get; set; }
    public string BankBin { get; set; }
    public string BillId { get; set; } = default!;
    public string StartTime { get; set; }
    public string EndTime { get; set; }
}

public sealed class MerchantBankConfigPagedOutputDto
{
    public double Id { get; set; }
    public string CreationTime { get; set; } = default!;
    public double? CreatorUserId { get; set; }
    public string LastModificationTime { get; set; } = default!;
    public double? LastModifierUserId { get; set; }
    public double? DeleterUserId { get; set; }
    public double MerchantId { get; set; }
    public string AccountType { get; set; } = default!;
    public object ConfigDto { get; set; }
    public string BankBin { get; set; } = default!;
    public string BankName { get; set; }
}

public sealed class OpenApiMerchantBankConfigPagedInputDto
{
    public string Filter { get; set; }
    public string Sorting { get; set; }
    public double SkipCount { get; set; }
    public double MaxResultCount { get; set; }
    public string AccountType { get; set; } = default!;
    public double MerchantId { get; set; }
    public string BankBin { get; set; } = default!;
    public string BankName { get; set; }
}

public sealed class BIDVConfigDto
{
    public string VaPrefix { get; set; } = default!;
    public string BankPartnerId { get; set; } = default!;
    public string AccountNumber { get; set; } = default!;
    public string AccountName { get; set; } = default!;
}

public sealed class CTGConfigDto
{
    public string AccountNumber { get; set; } = default!;
    public string AccountName { get; set; } = default!;
    public string VaPrefix { get; set; } = default!;
}

public sealed class ACBConfigBusinessDto
{
    public string AccountNumber { get; set; } = default!;
    public string AccountName { get; set; } = default!;
    public string VaPrefix { get; set; } = default!;
    public string Mobile { get; set; } = default!;
    public string AcbUserId { get; set; } = default!;
}

public sealed class OpenApiBankCreateOrUpdateConfigDto
{
    public BIDVConfigDto? BidvConfigDto { get; set; }
    public CTGConfigDto? CtgConfigDto { get; set; }
    public ACBConfigBusinessDto? AcbConfigDto { get; set; }
    public string AccountType { get; set; } = default!;
    public double Id { get; set; }
    public string OtpNumber { get; set; }
    public string ConfirmId { get; set; }
    public string BankBin { get; set; } = default!;
    public string BankName { get; set; }
    public double? MerchantId { get; set; }
}

public sealed class OpenApiDeleteConfigDto
{
    public string OtpNumber { get; set; }
    public string ConfirmId { get; set; }
    public double Id { get; set; }
    public double? MerchantId { get; set; }
}

public sealed class OpenApiCreateBankVAOutputDto
{
    public string ConfirmId { get; set; }
}

public sealed class OpenApiConfigAccountBusinessDto
{
    public string BankName { get; set; }
    public string AccountNumber { get; set; } = default!;
    public string AccountName { get; set; } = default!;
    public string Mobile { get; set; } = default!;
    public string VaPrefix { get; set; }
    public double MerchantId { get; set; }
    public string AcbUserId { get; set; } = default!;
    public string BankBin { get; set; } = default!;
}

public sealed class OpenApiDeleteConfigBusinessDto
{
    public string AccountType { get; set; } = default!;
    public ACBConfigBusinessDto ConfigRemove { get; set; }
    public double? MerchantId { get; set; }
    public string BankBin { get; set; } = default!;
    public string BankName { get; set; }
}

public sealed class EventUrlItemDto
{
    public string Url { get; set; } = default!;
    public string Type { get; set; } = default!;
    public IList<string>? Ids { get; set; }
}

public sealed class OpenApiCreateMerchantDto
{
    public double? Id { get; set; }
    public string Code { get; set; }
    public string Name { get; set; } = default!;
    public string Email { get; set; }
    public string PhoneNumber { get; set; } = default!;
    public string Website { get; set; }
    public IList<double>? BusinessSectorIds { get; set; }
    public string ProvinceId { get; set; }
    public string DistrictId { get; set; }
    public string CommuneId { get; set; }
    public string Address { get; set; }
    public string FullAddress { get; set; }
    public string EventUrl { get; set; }
    public IList<EventUrlItemDto>? EventUrls { get; set; }
    public bool? IsLockEvent { get; set; }
    public bool? IsOrganizationUnit { get; set; }
    public string ReferralCode { get; set; }
    public string UserReferralAncestorIds { get; set; }
    public double? UserReferralLevel { get; set; }
    public string DeviceDistributorAncestorMap { get; set; }
    public bool? IsMasterMerchant { get; set; }
    public string Password { get; set; } = default!;
    public string AppType { get; set; } = default!;
    public bool? IsMultipleRole { get; set; }
    public double? UserReferrerId { get; set; }
}

public sealed class FileUploadDto
{
    public string FileLogId { get; set; } = default!;
    public string Path { get; set; } = default!;
}

public sealed class OCBConfigDto
{
    public string ClientId { get; set; } = default!;
    public string ClientSecret { get; set; }
    public FileUploadDto? PathCertKey { get; set; }
    public FileUploadDto? PathPrivateKey { get; set; }
    public string UserName { get; set; } = default!;
    public string Password { get; set; }
    public string VaPrefix { get; set; }
    public string VaPrefixForDynamicQR { get; set; }
    public IList<string>? AccountNumbers { get; set; }
}

public sealed class MBBConfigDto
{
    public string AccountNumber { get; set; } = default!;
    public string AccountName { get; set; } = default!;
    public string Identity { get; set; } = default!;
    public string Mobile { get; set; } = default!;
}

public sealed class ShinhanConfigDto
{
    public string VaPrefix { get; set; } = default!;
    public string ClientId { get; set; } = default!;
    public string ClientSecret { get; set; }
    public FileUploadDto? PathPublicKey { get; set; }
    public FileUploadDto? PathPrivateKey { get; set; }
    public string AccountNumber { get; set; } = default!;
    public string AccountName { get; set; } = default!;
}

public sealed class VIBConfigDto
{
    public string VaPrefix { get; set; } = default!;
    public FileUploadDto? PathPublicKey { get; set; }
    public FileUploadDto? PathPrivateKey { get; set; }
    public string BasicAuthToken { get; set; } = default!;
    public string Cif { get; set; } = default!;
    public string ClientId { get; set; } = default!;
    public string ClientSecret { get; set; } = default!;
    public string AccountNumber { get; set; } = default!;
    public double VaCharactersNumber { get; set; }
}

public sealed class ACBConfigDto
{
    public IList<ACBConfigBusinessDto>? BusinessAccounts { get; set; }
    public IList<ACBConfigBusinessDto>? BusinessHouseholdAccounts { get; set; }
}

public sealed class VPBConfigBusinessDto
{
    public string AccountNumber { get; set; } = default!;
    public string AccountName { get; set; } = default!;
    public string MerchantId { get; set; } = default!;
    public string TerminalId { get; set; } = default!;
}

public sealed class VPBConfigDto
{
    public IList<VPBConfigBusinessDto>? BusinessAccounts { get; set; }
    public IList<VPBConfigBusinessDto>? BusinessHouseholdAccounts { get; set; }
}

public sealed class VCBConfigBusinessDto
{
    public string AccountNumber { get; set; } = default!;
    public string AccountName { get; set; } = default!;
    public string MerchantId { get; set; } = default!;
    public string TerminalId { get; set; } = default!;
}

public sealed class VCBConfigDto
{
    public IList<VCBConfigBusinessDto>? BusinessAccounts { get; set; }
    public IList<VCBConfigBusinessDto>? BusinessHouseholdAccounts { get; set; }
}

public sealed class BankConfigDto
{
    public IList<OCBConfigDto>? OcbConfigDtos { get; set; }
    public IList<MBBConfigDto>? MbbConfigDtos { get; set; }
    public IList<BIDVConfigDto>? BidvConfigDtos { get; set; }
    public IList<ShinhanConfigDto>? ShinhanConfigDtos { get; set; }
    public IList<VIBConfigDto>? VibConfigDtos { get; set; }
    public IList<CTGConfigDto>? CtgConfigDtos { get; set; }
    public ACBConfigDto? AcbConfigDto { get; set; }
    public VPBConfigDto? VpbConfigDto { get; set; }
    public VCBConfigDto? VcbConfigDto { get; set; }
}

public sealed class BaoKimConfigDto
{
    public string Mid { get; set; } = default!;
}

public sealed class BNPLConfigDto
{
    public BaoKimConfigDto? BaokimConfigDto { get; set; }
}

public sealed class OnePayConfigDto
{
    public string MerchantId { get; set; } = default!;
    public string SigningKey { get; set; } = default!;
    public string VerifyKey { get; set; } = default!;
    public string AccessCode { get; set; } = default!;
    public string HashCode { get; set; } = default!;
    public string CallbackUrl { get; set; } = default!;
}

public sealed class DirectDebitConfigDto
{
    public OnePayConfigDto OnePayConfigDto { get; set; }
}

public sealed class MerchantPackageInfo
{
    public string PackageName { get; set; }
    public string ExpirationDate { get; set; }
}

public sealed class MerchantDto
{
    public double Id { get; set; }
    public string CreationTime { get; set; } = default!;
    public double? CreatorUserId { get; set; }
    public string LastModificationTime { get; set; } = default!;
    public double? LastModifierUserId { get; set; }
    public double? DeleterUserId { get; set; }
    public string Code { get; set; }
    public string Name { get; set; } = default!;
    public string Email { get; set; }
    public string PhoneNumber { get; set; } = default!;
    public string Website { get; set; }
    public IList<double>? BusinessSectorIds { get; set; }
    public string ProvinceId { get; set; }
    public string DistrictId { get; set; }
    public string CommuneId { get; set; }
    public string Address { get; set; }
    public string FullAddress { get; set; }
    public string ClientId { get; set; }
    public string SecretToken { get; set; }
    public string EventUrl { get; set; }
    public IList<EventUrlItemDto>? EventUrls { get; set; }
    public bool? IsLockEvent { get; set; }
    public BankConfigDto? BankConfigDto { get; set; }
    public BNPLConfigDto? BnplConfigDto { get; set; }
    public DirectDebitConfigDto? DirectDebitConfigDto { get; set; }
    public SendNotifyPlatformDto? SendNotifyPlatformDto { get; set; }
    public bool? IsOrganizationUnit { get; set; }
    public string ReferralCode { get; set; }
    public string UserReferralAncestorIds { get; set; }
    public double? UserReferralLevel { get; set; }
    public string DeviceDistributorAncestorMap { get; set; }
    public bool? IsMasterMerchant { get; set; }
    public IList<MerchantPackageInfo>? MerchantPackages { get; set; }
}

public sealed class OpenApiGetPagingMerchantsDto
{
    public string Filter { get; set; }
    public string Sorting { get; set; }
    public double SkipCount { get; set; }
    public double MaxResultCount { get; set; }
}

public sealed class OpenApiRegisterDto
{
    public string RequestId { get; set; } = default!;
    public string BankBin { get; set; } = default!;
    public string AccountName { get; set; } = default!;
    public string Phone { get; set; } = default!;
    public string ReturnUrl { get; set; } = default!;
}

public sealed class PaymentBillResponseDto
{
    public string Code { get; set; } = default!;
    public string Status { get; set; } = default!;
    public string TransactionCode { get; set; } = default!;
    public bool IsSentConfirmEmail { get; set; }
    public bool IsSentConfirmZalo { get; set; }
    public string ReturnUrl { get; set; } = default!;
}

public sealed class OpenApiPaymentBillDto
{
    public string RequestId { get; set; } = default!;
    public string ClientId { get; set; } = default!;
    public string SubscriptionId { get; set; } = default!;
    public string Amount { get; set; } = default!;
    public string Description { get; set; } = default!;
    public string ExpirationTime { get; set; } = default!;
    public string Signature { get; set; } = default!;
    public string Token { get; set; } = default!;
    public object AdditionalData { get; set; }
    public string TokenRef { get; set; } = default!;
    public string PartnerCode { get; set; } = default!;
    public string AccountNumber { get; set; } = default!;
    public string ServiceProviderName { get; set; } = default!;
    public string ReturnUrl { get; set; } = default!;
}

public sealed class DeleteSubscriptionOutputDto
{
    public string ConfirmUrl { get; set; } = default!;
    public string Code { get; set; } = default!;
}

public sealed class OpenApiDeleteSubscriptionDto
{
    public string RequestId { get; set; } = default!;
    public string ReturnUrl { get; set; } = default!;
    public string SubscriptionId { get; set; } = default!;
    public string TokenRef { get; set; } = default!;
}

public sealed class RefundOutputDto
{
    public double RefundAmount { get; set; }
    public string TransactionId { get; set; } = default!;
    public string Status { get; set; } = default!;
}

public sealed class OpenApiRefundInputDto
{
    public string SubscriptionId { get; set; } = default!;
    public string TokenRef { get; set; } = default!;
    public string TransactionId { get; set; } = default!;
    public double Amount { get; set; }
}

public sealed class OpenApiEditConfirmBeforePaymentMethodDto
{
    public string RequestId { get; set; } = default!;
    public string ReturnUrl { get; set; } = default!;
    public string SubscriptionId { get; set; } = default!;
}

public sealed class OpenApiSubscriptionStatusResponseDto
{
    public string LastModificationTime { get; set; } = default!;
    public double? LastModifierUserId { get; set; }
    public string Email { get; set; }
    public string BankName { get; set; } = default!;
    public string AccountName { get; set; }
    public string AccountNumber { get; set; } = default!;
    public string Phone { get; set; } = default!;
    public bool ConfirmPaymentByEmail { get; set; }
    public string ConfirmEmail { get; set; }
    public bool ConfirmPaymentByZalo { get; set; }
    public string ConfirmPhoneNumber { get; set; } = default!;
    public string TokenRef { get; set; } = default!;
    public string Status { get; set; } = default!;
    public string SubscriptionId { get; set; } = default!;
    public string BankBin { get; set; } = default!;
}

public sealed class CustomerInfoDto
{
    public string OnepayAccountId { get; set; } = default!;
    public string Name { get; set; } = default!;
    public string Phone { get; set; } = default!;
    public string Email { get; set; } = default!;
}

public sealed class OpenApiPaymentTransactionStatusResponseDto
{
    public string TransactionId { get; set; } = default!;
    public string SubscriptionId { get; set; } = default!;
    public string TokenRef { get; set; } = default!;
    public string BankBin { get; set; } = default!;
    public CustomerInfoDto Customer { get; set; }
    public string AccountNumber { get; set; } = default!;
    public string AccountName { get; set; } = default!;
    public string Code { get; set; } = default!;
    public double Amount { get; set; }
    public string Currency { get; set; } = default!;
    public string Content { get; set; } = default!;
    public string TransactionDate { get; set; } = default!;
    public string Status { get; set; } = default!;
}

public sealed class OpenApiPaymentTransactionsPagedOutputDto
{
    public string TransactionId { get; set; } = default!;
    public string Code { get; set; } = default!;
    public string BankName { get; set; } = default!;
    public string BankBin { get; set; } = default!;
    public string Amount { get; set; } = default!;
    public string Content { get; set; } = default!;
    public string AccountNumber { get; set; } = default!;
    public string TransactionDate { get; set; } = default!;
    public string SubscriptionId { get; set; } = default!;
    public string TokenRef { get; set; } = default!;
    public string Status { get; set; } = default!;
    public object AdditionalData { get; set; }
}