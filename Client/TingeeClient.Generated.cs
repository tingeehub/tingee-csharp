// Auto-generated from openapi/sdk.json
// DO NOT EDIT MANUALLY

#nullable enable

using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using Tingee.Sdk.Http;
using Tingee.Sdk.Types;
using Tingee.Sdk.Types.Dtos;

namespace Tingee.Sdk.Client;

public sealed partial class TingeeClient
{
    // Group: Bank
    private BankGroup? _bank;
    public BankGroup Bank => _bank ??= new BankGroup(_httpClient);

    public sealed class BankGroup
    {
        private readonly TingeeHttpClient _httpClient;
        internal BankGroup(TingeeHttpClient httpClient) => _httpClient = httpClient;

        /// <summary>
        /// POST /v1/bank/generate-viet-qr
        /// </summary>
        public async Task<TingeeApiResponse<GenerateVietQROuputDto?>> GenerateVietQrAsync(
            OpenApiGenerateVietQRInputDto body,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<GenerateVietQROuputDto?>>(
                method: Tingee.Sdk.Http.HttpMethod.Post,
                path: "/v1/bank/generate-viet-qr",
                body: body,
                query: null,
                cancellationToken: cancellationToken);
            return response.Data!;
        }
        /// <summary>
        /// POST /v1/bank/generate-dynamic-qr
        /// </summary>
        public async Task<TingeeApiResponse<GenerateDynamicQROuputDto?>> GenerateDynamicQrAsync(
            GenerateDynamicQRInputDto body,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<GenerateDynamicQROuputDto?>>(
                method: Tingee.Sdk.Http.HttpMethod.Post,
                path: "/v1/bank/generate-dynamic-qr",
                body: body,
                query: null,
                cancellationToken: cancellationToken);
            return response.Data!;
        }
        /// <summary>
        /// POST /v1/bank/delete-dynamic-qr
        /// </summary>
        public async Task<TingeeApiResponse<EmptyDto?>> DeleteDynamicQrAsync(
            OpenApiDeleteDynamicQRInputDto body,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<EmptyDto?>>(
                method: Tingee.Sdk.Http.HttpMethod.Post,
                path: "/v1/bank/delete-dynamic-qr",
                body: body,
                query: null,
                cancellationToken: cancellationToken);
            return response.Data!;
        }
        /// <summary>
        /// POST /v1/bank/get-status-dynamic-qr
        /// </summary>
        public async Task<TingeeApiResponse<OpenApiGetStatusDynamicQROutputDto?>> GetStatusDynamicQrAsync(
            OpenApiGetStatusDynamicQRInputDto body,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<OpenApiGetStatusDynamicQROutputDto?>>(
                method: Tingee.Sdk.Http.HttpMethod.Post,
                path: "/v1/bank/get-status-dynamic-qr",
                body: body,
                query: null,
                cancellationToken: cancellationToken);
            return response.Data!;
        }
        /// <summary>
        /// GET /v1/bank/get-banks
        /// </summary>
        public async Task<TingeeApiResponse<IList<Bank>?>> GetBanksAsync(
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<IList<Bank>?>>(
                method: Tingee.Sdk.Http.HttpMethod.Get,
                path: "/v1/bank/get-banks",
                body: null,
                query: null,
                cancellationToken: cancellationToken);
            return response.Data!;
        }
        /// <summary>
        /// POST /v1/bank/get-va-paging
        /// </summary>
        public async Task<TingeeApiResponse<PagedResultDto<OpenApiGetVAPagedOuputDto>?>> GetVaPagingAsync(
            OpenApiGetVAPagedInputDto body,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<PagedResultDto<OpenApiGetVAPagedOuputDto>?>>(
                method: Tingee.Sdk.Http.HttpMethod.Post,
                path: "/v1/bank/get-va-paging",
                body: body,
                query: null,
                cancellationToken: cancellationToken);
            return response.Data!;
        }
        /// <summary>
        /// POST /v1/bank/get-account-number-info-by-qr-code
        /// </summary>
        public async Task<TingeeApiResponse<PagedResultDto<OpenApiGenerateVietQROuputDto>?>> GetAccountNumberInfoByQrCodeAsync(
            string qrcode,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<PagedResultDto<OpenApiGenerateVietQROuputDto>?>>(
                method: Tingee.Sdk.Http.HttpMethod.Post,
                path: "/v1/bank/get-account-number-info-by-qr-code",
                body: null,
                query: new Dictionary<string, string?>
                    {
                        ["qrCode"] = qrcode.ToString()
                    },
                cancellationToken: cancellationToken);
            return response.Data!;
        }
        /// <summary>
        /// POST /v1/bank/create-va
        /// </summary>
        public async Task<TingeeApiResponse<BankCreateVAOuputDto?>> CreateVaAsync(
            OpenApiCreateVAInpuDto body,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<BankCreateVAOuputDto?>>(
                method: Tingee.Sdk.Http.HttpMethod.Post,
                path: "/v1/bank/create-va",
                body: body,
                query: null,
                cancellationToken: cancellationToken);
            return response.Data!;
        }
        /// <summary>
        /// POST /v1/bank/create-va-advanced
        /// </summary>
        public async Task<TingeeApiResponse<BankCreateVAOuputDto?>> CreateVaAdvancedAsync(
            OpenApiCreateVAInpuDto body,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<BankCreateVAOuputDto?>>(
                method: Tingee.Sdk.Http.HttpMethod.Post,
                path: "/v1/bank/create-va-advanced",
                body: body,
                query: null,
                cancellationToken: cancellationToken);
            return response.Data!;
        }
        /// <summary>
        /// POST /v1/bank/confirm-va
        /// </summary>
        public async Task<TingeeApiResponse<OpenApiConfirmVAOuputDto?>> ConfirmVaAsync(
            OpenApiBankConfirmVAInputDto body,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<OpenApiConfirmVAOuputDto?>>(
                method: Tingee.Sdk.Http.HttpMethod.Post,
                path: "/v1/bank/confirm-va",
                body: body,
                query: null,
                cancellationToken: cancellationToken);
            return response.Data!;
        }
        /// <summary>
        /// POST /v1/bank/delete-va
        /// </summary>
        public async Task<TingeeApiResponse<BankDeleteVAOutputDto?>> DeleteVaAsync(
            string bankbin,
            BankNameEnum? bankname,
            string vaaccountnumber,
            int? merchantid,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<BankDeleteVAOutputDto?>>(
                method: Tingee.Sdk.Http.HttpMethod.Post,
                path: "/v1/bank/delete-va",
                body: null,
                query: new Dictionary<string, string?>
                    {
                        ["bankBin"] = bankbin?.ToString(),
                        ["bankName"] = bankname?.ToString(),
                        ["vaAccountNumber"] = vaaccountnumber.ToString(),
                        ["merchantId"] = merchantid?.ToString()
                    },
                cancellationToken: cancellationToken);
            return response.Data!;
        }
        /// <summary>
        /// POST /v1/bank/confirm-delete-va
        /// </summary>
        public async Task<TingeeApiResponse<EmptyDto?>> ConfirmDeleteVaAsync(
            OpenApiBankConfirmVAInputDto body,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<EmptyDto?>>(
                method: Tingee.Sdk.Http.HttpMethod.Post,
                path: "/v1/bank/confirm-delete-va",
                body: body,
                query: null,
                cancellationToken: cancellationToken);
            return response.Data!;
        }
        /// <summary>
        /// POST /v1/bank/register-notify
        /// </summary>
        public async Task<TingeeApiResponse<BankDeleteVAOutputDto?>> RegisterNotifyAsync(
            OpenApiRegisterNotifyDto body,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<BankDeleteVAOutputDto?>>(
                method: Tingee.Sdk.Http.HttpMethod.Post,
                path: "/v1/bank/register-notify",
                body: body,
                query: null,
                cancellationToken: cancellationToken);
            return response.Data!;
        }
        /// <summary>
        /// POST /v1/bank/confirm-register-notify
        /// </summary>
        public async Task<TingeeApiResponse<BankDeleteVAOutputDto?>> ConfirmRegisterNotifyAsync(
            OpenApiBankConfirmVAInputDto body,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<BankDeleteVAOutputDto?>>(
                method: Tingee.Sdk.Http.HttpMethod.Post,
                path: "/v1/bank/confirm-register-notify",
                body: body,
                query: null,
                cancellationToken: cancellationToken);
            return response.Data!;
        }
    }

    // Group: Device
    private DeviceGroup? _device;
    public DeviceGroup Device => _device ??= new DeviceGroup(_httpClient);

    public sealed class DeviceGroup
    {
        private readonly TingeeHttpClient _httpClient;
        internal DeviceGroup(TingeeHttpClient httpClient) => _httpClient = httpClient;

        /// <summary>
        /// POST /v1/device/read-security-code
        /// </summary>
        public async Task<TingeeApiResponse<EmptyDto?>> ReadSecurityCodeAsync(
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
        /// POST /v1/device/add-device-to-shop
        /// </summary>
        public async Task<TingeeApiResponse<IList<SendNotifyTingeeBoxDto>?>> AddDeviceToShopAsync(
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
        public async Task<TingeeApiResponse<EmptyDto?>> UpdateShopDeviceLinkStatusAsync(
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
        /// POST /v1/device/read-amount-link-to-merchant
        /// </summary>
        public async Task<TingeeApiResponse<EmptyDto?>> ReadAmountLinkToMerchantAsync(
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
        public async Task<TingeeApiResponse<EmptyDto?>> ShowQrCodeAsync(
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
        public async Task<TingeeApiResponse<EmptyDto?>> ShowDynamicQrCodeAsync(
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
        public async Task<TingeeApiResponse<EmptyDto?>> ShowStaticQrCodeAsync(
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
        public async Task<TingeeApiResponse<IList<SendNotifyTingeeBoxDto>?>> GetDevicesLinkToShopOrVaAsync(
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
        public async Task<TingeeApiResponse<PagedResultDto<DeviceDto>?>> GetPagingAsync(
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
        public async Task<TingeeApiResponse<string?>> ResetAsync(
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
        /// POST /v1/device/generate-and-show-dynamic-qr-code
        /// </summary>
        public async Task<TingeeApiResponse<object?>> GenerateAndShowDynamicQrCodeAsync(
            OpenApiGenerateAndShowDynamicQrCodeDto body,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<object?>>(
                method: Tingee.Sdk.Http.HttpMethod.Post,
                path: "/v1/device/generate-and-show-dynamic-qr-code",
                body: body,
                query: null,
                cancellationToken: cancellationToken);
            return response.Data!;
        }
    }

    // Group: Shop
    private ShopGroup? _shop;
    public ShopGroup Shop => _shop ??= new ShopGroup(_httpClient);

    public sealed class ShopGroup
    {
        private readonly TingeeHttpClient _httpClient;
        internal ShopGroup(TingeeHttpClient httpClient) => _httpClient = httpClient;

        /// <summary>
        /// POST /v1/shop/create-or-update
        /// </summary>
        public async Task<TingeeApiResponse<OpenApiCreateOrUpdateShopOutputDto?>> CreateOrUpdateAsync(
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
        public async Task<TingeeApiResponse<PagedResultDto<OpenApiGetShopPagedOuputDto>?>> GetPagingAsync(
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
    }

    // Group: DeepLink
    private DeepLinkGroup? _deepLink;
    public DeepLinkGroup DeepLink => _deepLink ??= new DeepLinkGroup(_httpClient);

    public sealed class DeepLinkGroup
    {
        private readonly TingeeHttpClient _httpClient;
        internal DeepLinkGroup(TingeeHttpClient httpClient) => _httpClient = httpClient;

        /// <summary>
        /// POST /v1/deep-link/generate
        /// </summary>
        public async Task<TingeeApiResponse<string?>> GenerateAsync(
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
    }

    // Group: Transaction
    private TransactionGroup? _transaction;
    public TransactionGroup Transaction => _transaction ??= new TransactionGroup(_httpClient);

    public sealed class TransactionGroup
    {
        private readonly TingeeHttpClient _httpClient;
        internal TransactionGroup(TingeeHttpClient httpClient) => _httpClient = httpClient;

        /// <summary>
        /// POST /v1/transaction/get-paging
        /// </summary>
        public async Task<TingeeApiResponse<PagedResultDto<OpenApiTransactionPagedOuputDto>?>> GetPagingAsync(
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
    }

    // Group: DirectDebit
    private DirectDebitGroup? _directDebit;
    public DirectDebitGroup DirectDebit => _directDebit ??= new DirectDebitGroup(_httpClient);

    public sealed class DirectDebitGroup
    {
        private readonly TingeeHttpClient _httpClient;
        internal DirectDebitGroup(TingeeHttpClient httpClient) => _httpClient = httpClient;

        /// <summary>
        /// POST /v1/direct-debit/register
        /// </summary>
        public async Task<TingeeApiResponse<string?>> RegisterAsync(
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
        public async Task<TingeeApiResponse<PaymentBillResponseDto?>> PaymentBillAsync(
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
        public async Task<TingeeApiResponse<DeleteSubscriptionOutputDto?>> DeleteSubscriptionAsync(
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
        public async Task<TingeeApiResponse<RefundOutputDto?>> RefundAsync(
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
        public async Task<TingeeApiResponse<string?>> EditConfirmPaymentMethodAsync(
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
        public async Task<TingeeApiResponse<OpenApiSubscriptionStatusResponseDto?>> GetSubscriptionStatusAsync(
            string requestid,
            string subscriptionid,
            string tokenref,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<OpenApiSubscriptionStatusResponseDto?>>(
                method: Tingee.Sdk.Http.HttpMethod.Get,
                path: "/v1/direct-debit/get-subscription-status",
                body: null,
                query: new Dictionary<string, string?>
                    {
                        ["requestId"] = requestid?.ToString(),
                        ["subscriptionId"] = subscriptionid.ToString(),
                        ["tokenRef"] = tokenref.ToString()
                    },
                cancellationToken: cancellationToken);
            return response.Data!;
        }
        /// <summary>
        /// GET /v1/direct-debit/get-transaction-status
        /// </summary>
        public async Task<TingeeApiResponse<OpenApiPaymentTransactionStatusResponseDto?>> GetTransactionStatusAsync(
            string transactionid,
            string tokenref,
            string subscriptionid,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<OpenApiPaymentTransactionStatusResponseDto?>>(
                method: Tingee.Sdk.Http.HttpMethod.Get,
                path: "/v1/direct-debit/get-transaction-status",
                body: null,
                query: new Dictionary<string, string?>
                    {
                        ["transactionId"] = transactionid.ToString(),
                        ["tokenRef"] = tokenref.ToString(),
                        ["subscriptionId"] = subscriptionid.ToString()
                    },
                cancellationToken: cancellationToken);
            return response.Data!;
        }
        /// <summary>
        /// GET /v1/direct-debit/get-paging-transactions
        /// </summary>
        public async Task<TingeeApiResponse<PagedResultDto<OpenApiPaymentTransactionsPagedOutputDto>?>> GetPagingTransactionsAsync(
            string subscriptionid,
            string tokenref,
            string starttime,
            string endtime,
            int? skipcount,
            int? maxresultcount,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<PagedResultDto<OpenApiPaymentTransactionsPagedOutputDto>?>>(
                method: Tingee.Sdk.Http.HttpMethod.Get,
                path: "/v1/direct-debit/get-paging-transactions",
                body: null,
                query: new Dictionary<string, string?>
                    {
                        ["subscriptionId"] = subscriptionid.ToString(),
                        ["tokenRef"] = tokenref.ToString(),
                        ["startTime"] = starttime?.ToString(),
                        ["endTime"] = endtime?.ToString(),
                        ["skipCount"] = skipcount?.ToString(),
                        ["maxResultCount"] = maxresultcount?.ToString()
                    },
                cancellationToken: cancellationToken);
            return response.Data!;
        }
    }

    // Group: Merchant
    private MerchantGroup? _merchant;
    public MerchantGroup Merchant => _merchant ??= new MerchantGroup(_httpClient);

    public sealed class MerchantGroup
    {
        private readonly TingeeHttpClient _httpClient;
        internal MerchantGroup(TingeeHttpClient httpClient) => _httpClient = httpClient;

        /// <summary>
        /// POST /v1/merchant/get-paging-config
        /// </summary>
        public async Task<TingeeApiResponse<PagedResultDto<MerchantBankConfigPagedOutputDto>?>> GetPagingConfigAsync(
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
        public async Task<TingeeApiResponse<double?>> CreateOrUpdateConfigAsync(
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
        public async Task<TingeeApiResponse<double?>> DeleteConfigAsync(
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
        public async Task<TingeeApiResponse<OpenApiCreateBankVAOutputDto?>> ConfigAccountBusinessAsync(
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
        public async Task<TingeeApiResponse<object?>> DeleteConfigAccountBusinessAsync(
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
        public async Task<TingeeApiResponse<double?>> CreateAsync(
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
        public async Task<TingeeApiResponse<PagedResultDto<MerchantDto>?>> GetPagingAsync(
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
        public async Task<TingeeApiResponse<EmptyDto?>> DeleteAsync(
            double merchantid,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<EmptyDto?>>(
                method: Tingee.Sdk.Http.HttpMethod.Delete,
                path: "/v1/merchant/delete",
                body: null,
                query: new Dictionary<string, string?>
                    {
                        ["merchantId"] = merchantid.ToString()
                    },
                cancellationToken: cancellationToken);
            return response.Data!;
        }
    }

    // Group: EInvoice
    private EInvoiceGroup? _eInvoice;
    public EInvoiceGroup EInvoice => _eInvoice ??= new EInvoiceGroup(_httpClient);

    public sealed class EInvoiceGroup
    {
        private readonly TingeeHttpClient _httpClient;
        internal EInvoiceGroup(TingeeHttpClient httpClient) => _httpClient = httpClient;

        /// <summary>
        /// POST /v1/e-invoice/get-paging-account
        /// </summary>
        public async Task<TingeeApiResponse<PagedResultDto<GetPagingEInvoiceAccountOutputDto>?>> GetPagingAccountAsync(
            GetPagingEInvoiceAccountInputDto body,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<PagedResultDto<GetPagingEInvoiceAccountOutputDto>?>>(
                method: Tingee.Sdk.Http.HttpMethod.Post,
                path: "/v1/e-invoice/get-paging-account",
                body: body,
                query: null,
                cancellationToken: cancellationToken);
            return response.Data!;
        }
        /// <summary>
        /// POST /v1/e-invoice/create-or-update-account
        /// </summary>
        public async Task<TingeeApiResponse<EInvoiceAccountOutputDto?>> CreateOrUpdateAccountAsync(
            CreateOrUpdateEInvoiceAccountDto body,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<EInvoiceAccountOutputDto?>>(
                method: Tingee.Sdk.Http.HttpMethod.Post,
                path: "/v1/e-invoice/create-or-update-account",
                body: body,
                query: null,
                cancellationToken: cancellationToken);
            return response.Data!;
        }
        /// <summary>
        /// POST /v1/e-invoice/delete-account
        /// </summary>
        public async Task<TingeeApiResponse<EmptyDto?>> DeleteAccountAsync(
            DeleteEInvoiceAccountDto body,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<EmptyDto?>>(
                method: Tingee.Sdk.Http.HttpMethod.Post,
                path: "/v1/e-invoice/delete-account",
                body: body,
                query: null,
                cancellationToken: cancellationToken);
            return response.Data!;
        }
        /// <summary>
        /// POST /v1/e-invoice/get-provider
        /// </summary>
        public async Task<TingeeApiResponse<IList<EInvoiceProviderDto>?>> GetProviderAsync(
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<IList<EInvoiceProviderDto>?>>(
                method: Tingee.Sdk.Http.HttpMethod.Post,
                path: "/v1/e-invoice/get-provider",
                body: null,
                query: null,
                cancellationToken: cancellationToken);
            return response.Data!;
        }
        /// <summary>
        /// POST /v1/e-invoice/create
        /// </summary>
        public async Task<TingeeApiResponse<DownloadInvoiceOutputDto?>> CreateAsync(
            CreateInvoiceDto body,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<DownloadInvoiceOutputDto?>>(
                method: Tingee.Sdk.Http.HttpMethod.Post,
                path: "/v1/e-invoice/create",
                body: body,
                query: null,
                cancellationToken: cancellationToken);
            return response.Data!;
        }
        /// <summary>
        /// POST /v1/e-invoice/create-and-issue
        /// </summary>
        public async Task<TingeeApiResponse<TrackingResultDto?>> CreateAndIssueAsync(
            CreateInvoiceDto body,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<TrackingResultDto?>>(
                method: Tingee.Sdk.Http.HttpMethod.Post,
                path: "/v1/e-invoice/create-and-issue",
                body: body,
                query: null,
                cancellationToken: cancellationToken);
            return response.Data!;
        }
        /// <summary>
        /// POST /v1/e-invoice/download
        /// </summary>
        public async Task<TingeeApiResponse<DownloadInvoiceOutputDto?>> DownloadAsync(
            DownloadInvoiceQueryDto body,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<DownloadInvoiceOutputDto?>>(
                method: Tingee.Sdk.Http.HttpMethod.Post,
                path: "/v1/e-invoice/download",
                body: body,
                query: null,
                cancellationToken: cancellationToken);
            return response.Data!;
        }
        /// <summary>
        /// POST /v1/e-invoice/invoice-templates
        /// </summary>
        public async Task<TingeeApiResponse<InvoiceTemplateOutputDto?>> InvoiceTemplatesAsync(
            InvoiceTemplateQueryDto body,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<InvoiceTemplateOutputDto?>>(
                method: Tingee.Sdk.Http.HttpMethod.Post,
                path: "/v1/e-invoice/invoice-templates",
                body: body,
                query: null,
                cancellationToken: cancellationToken);
            return response.Data!;
        }
        /// <summary>
        /// POST /v1/e-invoice/send-email
        /// </summary>
        public async Task<TingeeApiResponse<EmptyDto?>> SendEmailAsync(
            SendInvoiceEmailDto body,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.RequestAsync<TingeeApiResponse<EmptyDto?>>(
                method: Tingee.Sdk.Http.HttpMethod.Post,
                path: "/v1/e-invoice/send-email",
                body: body,
                query: null,
                cancellationToken: cancellationToken);
            return response.Data!;
        }
    }

}
