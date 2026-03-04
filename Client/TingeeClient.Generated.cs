// Auto-generated from openapi/sdk.json
// DO NOT EDIT MANUALLY

#nullable enable

using Tingee.Sdk.Http;
using Tingee.Sdk.Types;
using Tingee.Sdk.Types.Dtos;

namespace Tingee.Sdk.Client;

public sealed partial class TingeeClient
{
    // 'public TingeeClient.V1Methods V1 { get; }' is declared in hand-written TingeeClient.cs

    /// <summary>Base class for all V1 API methods. Extend via TingeeV1CustomMethods.</summary>
    public class V1Methods
    {
        private protected readonly TingeeHttpClient _httpClient;
        protected internal V1Methods(TingeeHttpClient httpClient) => _httpClient = httpClient;

        /// <summary>
        /// POST /v1/generate-viet-qr
        /// </summary>
        public async Task<TingeeApiResponse<GenerateVietQROuputDto?>> GenerateVietQrAsync(
            OpenApiGenerateVietQRInputDto body,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<GenerateVietQROuputDto?>>(
                method: Tingee.Sdk.Http.HttpMethod.Post,
                path: "/v1/generate-viet-qr",
                body: body,
                query: null,
                cancellationToken: cancellationToken);
            return response.Data!;
        }

        /// <summary>
        /// POST /v1/generate-dynamic-qr
        /// </summary>
        public async Task<TingeeApiResponse<GenerateDynamicQROuputDto?>> GenerateDynamicQrAsync(
            GenerateDynamicQRInputDto body,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<GenerateDynamicQROuputDto?>>(
                method: Tingee.Sdk.Http.HttpMethod.Post,
                path: "/v1/generate-dynamic-qr",
                body: body,
                query: null,
                cancellationToken: cancellationToken);
            return response.Data!;
        }

        /// <summary>
        /// POST /v1/delete-dynamic-qr
        /// </summary>
        public async Task<TingeeApiResponse<EmptyDto?>> DeleteDynamicQrAsync(
            OpenApiDeleteDynamicQRInputDto body,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<EmptyDto?>>(
                method: Tingee.Sdk.Http.HttpMethod.Post,
                path: "/v1/delete-dynamic-qr",
                body: body,
                query: null,
                cancellationToken: cancellationToken);
            return response.Data!;
        }

        /// <summary>
        /// POST /v1/get-status-dynamic-qr
        /// </summary>
        public async Task<TingeeApiResponse<OpenApiGetStatusDynamicQROutputDto?>> GetStatusDynamicQrAsync(
            OpenApiGetStatusDynamicQRInputDto body,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<OpenApiGetStatusDynamicQROutputDto?>>(
                method: Tingee.Sdk.Http.HttpMethod.Post,
                path: "/v1/get-status-dynamic-qr",
                body: body,
                query: null,
                cancellationToken: cancellationToken);
            return response.Data!;
        }

        /// <summary>
        /// GET /v1/get-banks
        /// </summary>
        public async Task<IList<Bank>> GetBanksAsync(
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<IList<Bank>>(
                method: Tingee.Sdk.Http.HttpMethod.Get,
                path: "/v1/get-banks",
                body: null,
                query: null,
                cancellationToken: cancellationToken);
            return response.Data!;
        }

        /// <summary>
        /// POST /v1/get-va-paging
        /// </summary>
        public async Task<TingeeApiResponse<PagedResultDto<OpenApiGetVAPagedOuputDto>?>> GetVaPagingAsync(
            OpenApiGetVAPagedInputDto body,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<PagedResultDto<OpenApiGetVAPagedOuputDto>?>>(
                method: Tingee.Sdk.Http.HttpMethod.Post,
                path: "/v1/get-va-paging",
                body: body,
                query: null,
                cancellationToken: cancellationToken);
            return response.Data!;
        }

        /// <summary>
        /// POST /v1/get-account-number-info-by-qr-code
        /// </summary>
        public async Task<TingeeApiResponse<PagedResultDto<OpenApiGenerateVietQROuputDto>?>> GetAccountNumberInfoByQrCodeAsync(
            string qrCode,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<PagedResultDto<OpenApiGenerateVietQROuputDto>?>>(
                method: Tingee.Sdk.Http.HttpMethod.Post,
                path: "/v1/get-account-number-info-by-qr-code",
                body: null,
                query: new Dictionary<string, string?>
            {
                ["qrCode"] = qrCode.ToString()
            },
                cancellationToken: cancellationToken);
            return response.Data!;
        }

        /// <summary>
        /// POST /v1/create-va
        /// </summary>
        public async Task<TingeeApiResponse<BankCreateVAOuputDto?>> CreateVaAsync(
            OpenApiCreateVAInpuDto body,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<BankCreateVAOuputDto?>>(
                method: Tingee.Sdk.Http.HttpMethod.Post,
                path: "/v1/create-va",
                body: body,
                query: null,
                cancellationToken: cancellationToken);
            return response.Data!;
        }

        /// <summary>
        /// POST /v1/create-va-advanced
        /// </summary>
        public async Task<TingeeApiResponse<BankCreateVAOuputDto?>> CreateVaAdvancedAsync(
            OpenApiCreateVAInpuDto body,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<BankCreateVAOuputDto?>>(
                method: Tingee.Sdk.Http.HttpMethod.Post,
                path: "/v1/create-va-advanced",
                body: body,
                query: null,
                cancellationToken: cancellationToken);
            return response.Data!;
        }

        /// <summary>
        /// POST /v1/confirm-va
        /// </summary>
        public async Task<TingeeApiResponse<OpenApiConfirmVAOuputDto?>> ConfirmVaAsync(
            OpenApiBankConfirmVAInputDto body,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<OpenApiConfirmVAOuputDto?>>(
                method: Tingee.Sdk.Http.HttpMethod.Post,
                path: "/v1/confirm-va",
                body: body,
                query: null,
                cancellationToken: cancellationToken);
            return response.Data!;
        }

        /// <summary>
        /// POST /v1/delete-va
        /// </summary>
        public async Task<TingeeApiResponse<BankDeleteVAOutputDto?>> DeleteVaAsync(
            string bankBin,
            string bankName,
            string vaAccountNumber,
            double? merchantId,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<BankDeleteVAOutputDto?>>(
                method: Tingee.Sdk.Http.HttpMethod.Post,
                path: "/v1/delete-va",
                body: null,
                query: new Dictionary<string, string?>
            {
                ["bankBin"] = bankBin.ToString(),
                ["bankName"] = bankName?.ToString(),
                ["vaAccountNumber"] = vaAccountNumber.ToString(),
                ["merchantId"] = merchantId?.ToString()
            },
                cancellationToken: cancellationToken);
            return response.Data!;
        }

        /// <summary>
        /// POST /v1/confirm-delete-va
        /// </summary>
        public async Task<TingeeApiResponse<EmptyDto?>> ConfirmDeleteVaAsync(
            OpenApiBankConfirmVAInputDto body,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<EmptyDto?>>(
                method: Tingee.Sdk.Http.HttpMethod.Post,
                path: "/v1/confirm-delete-va",
                body: body,
                query: null,
                cancellationToken: cancellationToken);
            return response.Data!;
        }

        /// <summary>
        /// POST /v1/register-notify
        /// </summary>
        public async Task<TingeeApiResponse<BankDeleteVAOutputDto?>> RegisterNotifyAsync(
            OpenApiRegisterNotifyDto body,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<BankDeleteVAOutputDto?>>(
                method: Tingee.Sdk.Http.HttpMethod.Post,
                path: "/v1/register-notify",
                body: body,
                query: null,
                cancellationToken: cancellationToken);
            return response.Data!;
        }

        /// <summary>
        /// POST /v1/confirm-register-notify
        /// </summary>
        public async Task<TingeeApiResponse<BankDeleteVAOutputDto?>> ConfirmRegisterNotifyAsync(
            OpenApiBankConfirmVAInputDto body,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<BankDeleteVAOutputDto?>>(
                method: Tingee.Sdk.Http.HttpMethod.Post,
                path: "/v1/confirm-register-notify",
                body: body,
                query: null,
                cancellationToken: cancellationToken);
            return response.Data!;
        }

        /// <summary>
        /// POST /v1/refund
        /// </summary>
        public async Task<TingeeApiResponse<EmptyDto?>> RefundAsync(
            OpenApiRefundDto body,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<EmptyDto?>>(
                method: Tingee.Sdk.Http.HttpMethod.Post,
                path: "/v1/refund",
                body: body,
                query: null,
                cancellationToken: cancellationToken);
            return response.Data!;
        }

        /// <summary>
        /// POST /v1/device/read-security-code
        /// </summary>
        public async Task<TingeeApiResponse<EmptyDto?>> DeviceReadSecurityCodeAsync(
            OpenApiReadSecurityCodeDto body,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<EmptyDto?>>(
                method: Tingee.Sdk.Http.HttpMethod.Post,
                path: "/v1/device/read-security-code",
                body: body,
                query: null,
                cancellationToken: cancellationToken);
            return response.Data!;
        }

        /// <summary>
        /// POST /v1/device/read-partner-security-code
        /// </summary>
        public async Task<TingeeApiResponse<EmptyDto?>> DeviceReadPartnerSecurityCodeAsync(
            OpenApiReadPartnerSecurityCodeDto body,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<EmptyDto?>>(
                method: Tingee.Sdk.Http.HttpMethod.Post,
                path: "/v1/device/read-partner-security-code",
                body: body,
                query: null,
                cancellationToken: cancellationToken);
            return response.Data!;
        }

        /// <summary>
        /// POST /v1/device/add-device-to-shop
        /// </summary>
        public async Task<TingeeApiResponse<IList<SendNotifyTingeeBoxDto>?>> DeviceAddDeviceToShopAsync(
            OpenApiAddDeviceToShop body,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<IList<SendNotifyTingeeBoxDto>?>>(
                method: Tingee.Sdk.Http.HttpMethod.Post,
                path: "/v1/device/add-device-to-shop",
                body: body,
                query: null,
                cancellationToken: cancellationToken);
            return response.Data!;
        }

        /// <summary>
        /// POST /v1/device/update-shop-device-link-status
        /// </summary>
        public async Task<TingeeApiResponse<EmptyDto?>> DeviceUpdateShopDeviceLinkStatusAsync(
            OpenApiUpdateShopDeviceLinkDto body,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<EmptyDto?>>(
                method: Tingee.Sdk.Http.HttpMethod.Post,
                path: "/v1/device/update-shop-device-link-status",
                body: body,
                query: null,
                cancellationToken: cancellationToken);
            return response.Data!;
        }

        /// <summary>
        /// POST /v1/device/read-amount
        /// </summary>
        public async Task<TingeeApiResponse<EmptyDto?>> DeviceReadAmountAsync(
            BIDVOpenApiReadAmountDto body,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<EmptyDto?>>(
                method: Tingee.Sdk.Http.HttpMethod.Post,
                path: "/v1/device/read-amount",
                body: body,
                query: null,
                cancellationToken: cancellationToken);
            return response.Data!;
        }

        /// <summary>
        /// POST /v1/device/read-amount-link-to-merchant
        /// </summary>
        public async Task<TingeeApiResponse<EmptyDto?>> DeviceReadAmountLinkToMerchantAsync(
            OpenApiReadAmountDto body,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<EmptyDto?>>(
                method: Tingee.Sdk.Http.HttpMethod.Post,
                path: "/v1/device/read-amount-link-to-merchant",
                body: body,
                query: null,
                cancellationToken: cancellationToken);
            return response.Data!;
        }

        /// <summary>
        /// POST /v1/device/show-qr-code
        /// </summary>
        public async Task<TingeeApiResponse<EmptyDto?>> DeviceShowQrCodeAsync(
            OpenApiShowQRCodeDto body,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<EmptyDto?>>(
                method: Tingee.Sdk.Http.HttpMethod.Post,
                path: "/v1/device/show-qr-code",
                body: body,
                query: null,
                cancellationToken: cancellationToken);
            return response.Data!;
        }

        /// <summary>
        /// POST /v1/device/show-dynamic-qr-code
        /// </summary>
        public async Task<TingeeApiResponse<EmptyDto?>> DeviceShowDynamicQrCodeAsync(
            OpenApiShowQRCodeDto body,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<EmptyDto?>>(
                method: Tingee.Sdk.Http.HttpMethod.Post,
                path: "/v1/device/show-dynamic-qr-code",
                body: body,
                query: null,
                cancellationToken: cancellationToken);
            return response.Data!;
        }

        /// <summary>
        /// POST /v1/device/show-static-qr-code
        /// </summary>
        public async Task<TingeeApiResponse<EmptyDto?>> DeviceShowStaticQrCodeAsync(
            OpenApiShowQRCodeDto body,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<EmptyDto?>>(
                method: Tingee.Sdk.Http.HttpMethod.Post,
                path: "/v1/device/show-static-qr-code",
                body: body,
                query: null,
                cancellationToken: cancellationToken);
            return response.Data!;
        }

        /// <summary>
        /// POST /v1/device/get-devices-link-to-shop-or-va
        /// </summary>
        public async Task<TingeeApiResponse<IList<SendNotifyTingeeBoxDto>?>> DeviceGetDevicesLinkToShopOrVaAsync(
            OpenApiGetDevicesLinkToShopOrVA body,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<IList<SendNotifyTingeeBoxDto>?>>(
                method: Tingee.Sdk.Http.HttpMethod.Post,
                path: "/v1/device/get-devices-link-to-shop-or-va",
                body: body,
                query: null,
                cancellationToken: cancellationToken);
            return response.Data!;
        }

        /// <summary>
        /// POST /v1/device/get-paging
        /// </summary>
        public async Task<TingeeApiResponse<PagedResultDto<DeviceDto>?>> DeviceGetPagingAsync(
            OpenApiGetPagingDeviceInputDto body,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<PagedResultDto<DeviceDto>?>>(
                method: Tingee.Sdk.Http.HttpMethod.Post,
                path: "/v1/device/get-paging",
                body: body,
                query: null,
                cancellationToken: cancellationToken);
            return response.Data!;
        }

        /// <summary>
        /// DELETE /v1/device/reset
        /// </summary>
        public async Task<TingeeApiResponse<string?>> DeviceResetAsync(
            string uuid,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<string?>>(
                method: Tingee.Sdk.Http.HttpMethod.Delete,
                path: "/v1/device/reset",
                body: null,
                query: new Dictionary<string, string?>
            {
                ["uuid"] = uuid.ToString()
            },
                cancellationToken: cancellationToken);
            return response.Data!;
        }

        /// <summary>
        /// POST /v1/user/verify-referral-code
        /// </summary>
        public async Task<TingeeApiResponse<OpenApiVerifyReferralCodeResponseDto?>> UserVerifyReferralCodeAsync(
            string referralCode,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<OpenApiVerifyReferralCodeResponseDto?>>(
                method: Tingee.Sdk.Http.HttpMethod.Post,
                path: "/v1/user/verify-referral-code",
                body: null,
                query: new Dictionary<string, string?>
            {
                ["referralCode"] = referralCode.ToString()
            },
                cancellationToken: cancellationToken);
            return response.Data!;
        }

        /// <summary>
        /// POST /v1/shop/create-or-update
        /// </summary>
        public async Task<TingeeApiResponse<OpenApiCreateOrUpdateShopOutputDto?>> ShopCreateOrUpdateAsync(
            OpenApiCreateOrUpdateShopDto body,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<OpenApiCreateOrUpdateShopOutputDto?>>(
                method: Tingee.Sdk.Http.HttpMethod.Post,
                path: "/v1/shop/create-or-update",
                body: body,
                query: null,
                cancellationToken: cancellationToken);
            return response.Data!;
        }

        /// <summary>
        /// POST /v1/shop/get-paging
        /// </summary>
        public async Task<TingeeApiResponse<PagedResultDto<OpenApiGetShopPagedOuputDto>?>> ShopGetPagingAsync(
            OpenApiGetShopPagedInputDto body,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<PagedResultDto<OpenApiGetShopPagedOuputDto>?>>(
                method: Tingee.Sdk.Http.HttpMethod.Post,
                path: "/v1/shop/get-paging",
                body: body,
                query: null,
                cancellationToken: cancellationToken);
            return response.Data!;
        }

        /// <summary>
        /// POST /v1/deep-link/generate
        /// </summary>
        public async Task<TingeeApiResponse<string?>> DeepLinkGenerateAsync(
            OpenApiDeepLinkDto body,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<string?>>(
                method: Tingee.Sdk.Http.HttpMethod.Post,
                path: "/v1/deep-link/generate",
                body: body,
                query: null,
                cancellationToken: cancellationToken);
            return response.Data!;
        }

        /// <summary>
        /// POST /v1/account-number/get-all-ddl
        /// </summary>
        public async Task<TingeeApiResponse<IList<V2AccountNumberDDLDto>?>> AccountNumberGetAllDdlAsync(
            OpenApiAccountNumberDDLPagedInputDto body,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<IList<V2AccountNumberDDLDto>?>>(
                method: Tingee.Sdk.Http.HttpMethod.Post,
                path: "/v1/account-number/get-all-ddl",
                body: body,
                query: null,
                cancellationToken: cancellationToken);
            return response.Data!;
        }

        /// <summary>
        /// POST /v1/transaction/get-paging
        /// </summary>
        public async Task<TingeeApiResponse<PagedResultDto<OpenApiTransactionPagedOuputDto>?>> TransactionGetPagingAsync(
            OpenApiTransactionPagedInputDto body,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<PagedResultDto<OpenApiTransactionPagedOuputDto>?>>(
                method: Tingee.Sdk.Http.HttpMethod.Post,
                path: "/v1/transaction/get-paging",
                body: body,
                query: null,
                cancellationToken: cancellationToken);
            return response.Data!;
        }

        /// <summary>
        /// POST /v1/merchant/get-paging-config
        /// </summary>
        public async Task<TingeeApiResponse<PagedResultDto<MerchantBankConfigPagedOutputDto>?>> MerchantGetPagingConfigAsync(
            OpenApiMerchantBankConfigPagedInputDto body,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<PagedResultDto<MerchantBankConfigPagedOutputDto>?>>(
                method: Tingee.Sdk.Http.HttpMethod.Post,
                path: "/v1/merchant/get-paging-config",
                body: body,
                query: null,
                cancellationToken: cancellationToken);
            return response.Data!;
        }

        /// <summary>
        /// POST /v1/merchant/create-or-update-config
        /// </summary>
        public async Task<TingeeApiResponse<double?>> MerchantCreateOrUpdateConfigAsync(
            OpenApiBankCreateOrUpdateConfigDto body,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<double?>>(
                method: Tingee.Sdk.Http.HttpMethod.Post,
                path: "/v1/merchant/create-or-update-config",
                body: body,
                query: null,
                cancellationToken: cancellationToken);
            return response.Data!;
        }

        /// <summary>
        /// POST /v1/merchant/delete-config
        /// </summary>
        public async Task<TingeeApiResponse<double?>> MerchantDeleteConfigAsync(
            OpenApiDeleteConfigDto body,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<double?>>(
                method: Tingee.Sdk.Http.HttpMethod.Post,
                path: "/v1/merchant/delete-config",
                body: body,
                query: null,
                cancellationToken: cancellationToken);
            return response.Data!;
        }

        /// <summary>
        /// POST /v1/merchant/config-account-business
        /// </summary>
        public async Task<TingeeApiResponse<OpenApiCreateBankVAOutputDto?>> MerchantConfigAccountBusinessAsync(
            OpenApiConfigAccountBusinessDto body,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<OpenApiCreateBankVAOutputDto?>>(
                method: Tingee.Sdk.Http.HttpMethod.Post,
                path: "/v1/merchant/config-account-business",
                body: body,
                query: null,
                cancellationToken: cancellationToken);
            return response.Data!;
        }

        /// <summary>
        /// POST /v1/merchant/delete-config-account-business
        /// </summary>
        public async Task<TingeeApiResponse<object?>> MerchantDeleteConfigAccountBusinessAsync(
            OpenApiDeleteConfigBusinessDto body,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<object?>>(
                method: Tingee.Sdk.Http.HttpMethod.Post,
                path: "/v1/merchant/delete-config-account-business",
                body: body,
                query: null,
                cancellationToken: cancellationToken);
            return response.Data!;
        }

        /// <summary>
        /// POST /v1/merchant/create
        /// </summary>
        public async Task<TingeeApiResponse<double?>> MerchantCreateAsync(
            OpenApiCreateMerchantDto body,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<double?>>(
                method: Tingee.Sdk.Http.HttpMethod.Post,
                path: "/v1/merchant/create",
                body: body,
                query: null,
                cancellationToken: cancellationToken);
            return response.Data!;
        }

        /// <summary>
        /// POST /v1/merchant/get-paging
        /// </summary>
        public async Task<TingeeApiResponse<PagedResultDto<MerchantDto>?>> MerchantGetPagingAsync(
            OpenApiGetPagingMerchantsDto body,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<PagedResultDto<MerchantDto>?>>(
                method: Tingee.Sdk.Http.HttpMethod.Post,
                path: "/v1/merchant/get-paging",
                body: body,
                query: null,
                cancellationToken: cancellationToken);
            return response.Data!;
        }

        /// <summary>
        /// DELETE /v1/merchant/delete
        /// </summary>
        public async Task<TingeeApiResponse<EmptyDto?>> MerchantDeleteAsync(
            double merchantId,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<EmptyDto?>>(
                method: Tingee.Sdk.Http.HttpMethod.Delete,
                path: "/v1/merchant/delete",
                body: null,
                query: new Dictionary<string, string?>
            {
                ["merchantId"] = merchantId.ToString()
            },
                cancellationToken: cancellationToken);
            return response.Data!;
        }

        /// <summary>
        /// POST /v1/direct-debit/register
        /// </summary>
        public async Task<TingeeApiResponse<string?>> DirectDebitRegisterAsync(
            OpenApiRegisterDto body,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<string?>>(
                method: Tingee.Sdk.Http.HttpMethod.Post,
                path: "/v1/direct-debit/register",
                body: body,
                query: null,
                cancellationToken: cancellationToken);
            return response.Data!;
        }

        /// <summary>
        /// POST /v1/direct-debit/payment-bill
        /// </summary>
        public async Task<TingeeApiResponse<PaymentBillResponseDto?>> DirectDebitPaymentBillAsync(
            OpenApiPaymentBillDto body,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<PaymentBillResponseDto?>>(
                method: Tingee.Sdk.Http.HttpMethod.Post,
                path: "/v1/direct-debit/payment-bill",
                body: body,
                query: null,
                cancellationToken: cancellationToken);
            return response.Data!;
        }

        /// <summary>
        /// DELETE /v1/direct-debit/delete-subscription
        /// </summary>
        public async Task<TingeeApiResponse<DeleteSubscriptionOutputDto?>> DirectDebitDeleteSubscriptionAsync(
            OpenApiDeleteSubscriptionDto body,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<DeleteSubscriptionOutputDto?>>(
                method: Tingee.Sdk.Http.HttpMethod.Delete,
                path: "/v1/direct-debit/delete-subscription",
                body: body,
                query: null,
                cancellationToken: cancellationToken);
            return response.Data!;
        }

        /// <summary>
        /// POST /v1/direct-debit/refund
        /// </summary>
        public async Task<TingeeApiResponse<RefundOutputDto?>> DirectDebitRefundAsync(
            OpenApiRefundInputDto body,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<RefundOutputDto?>>(
                method: Tingee.Sdk.Http.HttpMethod.Post,
                path: "/v1/direct-debit/refund",
                body: body,
                query: null,
                cancellationToken: cancellationToken);
            return response.Data!;
        }

        /// <summary>
        /// PUT /v1/direct-debit/edit-confirm-payment-method
        /// </summary>
        public async Task<TingeeApiResponse<string?>> DirectDebitEditConfirmPaymentMethodAsync(
            OpenApiEditConfirmBeforePaymentMethodDto body,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<string?>>(
                method: Tingee.Sdk.Http.HttpMethod.Put,
                path: "/v1/direct-debit/edit-confirm-payment-method",
                body: body,
                query: null,
                cancellationToken: cancellationToken);
            return response.Data!;
        }

        /// <summary>
        /// GET /v1/direct-debit/get-subscription-status
        /// </summary>
        public async Task<TingeeApiResponse<OpenApiSubscriptionStatusResponseDto?>> DirectDebitGetSubscriptionStatusAsync(
            string requestId,
            string subscriptionId,
            string tokenRef,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<OpenApiSubscriptionStatusResponseDto?>>(
                method: Tingee.Sdk.Http.HttpMethod.Get,
                path: "/v1/direct-debit/get-subscription-status",
                body: null,
                query: new Dictionary<string, string?>
            {
                ["requestId"] = requestId.ToString(),
                ["subscriptionId"] = subscriptionId.ToString(),
                ["tokenRef"] = tokenRef.ToString()
            },
                cancellationToken: cancellationToken);
            return response.Data!;
        }

        /// <summary>
        /// GET /v1/direct-debit/get-transaction-status
        /// </summary>
        public async Task<TingeeApiResponse<OpenApiPaymentTransactionStatusResponseDto?>> DirectDebitGetTransactionStatusAsync(
            string transactionId,
            string tokenRef,
            string subscriptionId,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<OpenApiPaymentTransactionStatusResponseDto?>>(
                method: Tingee.Sdk.Http.HttpMethod.Get,
                path: "/v1/direct-debit/get-transaction-status",
                body: null,
                query: new Dictionary<string, string?>
            {
                ["transactionId"] = transactionId.ToString(),
                ["tokenRef"] = tokenRef.ToString(),
                ["subscriptionId"] = subscriptionId.ToString()
            },
                cancellationToken: cancellationToken);
            return response.Data!;
        }

        /// <summary>
        /// GET /v1/direct-debit/get-paging-transactions
        /// </summary>
        public async Task<TingeeApiResponse<PagedResultDto<OpenApiPaymentTransactionsPagedOutputDto>?>> DirectDebitGetPagingTransactionsAsync(
            string subscriptionId,
            string tokenRef,
            string startTime,
            string endTime,
            double? skipCount,
            double? maxResultCount,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<PagedResultDto<OpenApiPaymentTransactionsPagedOutputDto>?>>(
                method: Tingee.Sdk.Http.HttpMethod.Get,
                path: "/v1/direct-debit/get-paging-transactions",
                body: null,
                query: new Dictionary<string, string?>
            {
                ["subscriptionId"] = subscriptionId.ToString(),
                ["tokenRef"] = tokenRef.ToString(),
                ["startTime"] = startTime?.ToString(),
                ["endTime"] = endTime?.ToString(),
                ["skipCount"] = skipCount?.ToString(),
                ["maxResultCount"] = maxResultCount?.ToString()
            },
                cancellationToken: cancellationToken);
            return response.Data!;
        }
    }

}
