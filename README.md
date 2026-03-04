# Tingee.Sdk

> SDK chính thức tích hợp **Tingee Open API** cho C# / .NET 8+

[![NuGet](https://img.shields.io/nuget/v/Tingee.Sdk)](https://www.nuget.org/packages/Tingee.Sdk)
[![.NET](https://img.shields.io/badge/.NET-8.0-purple)](https://dotnet.microsoft.com)
[![License: ISC](https://img.shields.io/badge/License-ISC-yellow)](LICENSE)

---

## Cài đặt

```bash
dotnet add package Tingee.Sdk
```

hoặc qua NuGet Package Manager:

```
Install-Package Tingee.Sdk
```

---

## Bắt đầu nhanh

```csharp
using Tingee.Sdk.Client;

var client = new TingeeClient(new TingeeClientOptions
{
    SecretKey            = Environment.GetEnvironmentVariable("TINGEE_SECRET_KEY")!,
    ClientId             = Environment.GetEnvironmentVariable("TINGEE_CLIENT_ID")!,
    Environment          = TingeeEnvironment.Uat,       // Uat | Production, mặc định Uat
    TimeoutMilliseconds  = 90_000,                      // mặc định 90s
    BaseUrl              = "https://uat-open-api.tingee.vn", // tùy chọn, ghi đè Environment
});

var result = await client.V1.MerchantGetPagingAsync(new OpenApiGetMerchantPagedInputDto
{
    MaxResultCount = 10,
    SkipCount      = 0,
});

if (result?.IsSuccess == true)
    Console.WriteLine(result.Data);
else
    Console.WriteLine($"Lỗi {result?.Code}: {result?.Message}");
```

---

## Cấu hình

| Thuộc tính | Kiểu | Mặc định | Mô tả |
|---|---|---|---|
| `SecretKey` | `string` | — | **Bắt buộc.** Secret key từ Tingee Dashboard |
| `ClientId` | `string` | — | **Bắt buộc.** Client ID từ Tingee Dashboard |
| `Environment` | `TingeeEnvironment` | `Uat` | `Uat` \| `Production` |
| `BaseUrl` | `string?` | — | Ghi đè URL (bỏ qua `Environment`) |
| `TimeoutMilliseconds` | `int` | `90000` | Timeout (ms) |

### Dependency Injection (ASP.NET Core)

```csharp
// Program.cs
builder.Services.AddSingleton(new TingeeClientOptions
{
    SecretKey   = builder.Configuration["Tingee:SecretKey"]!,
    ClientId    = builder.Configuration["Tingee:ClientId"]!,
    Environment = TingeeEnvironment.Uat,
});
builder.Services.AddSingleton<TingeeClient>();
```

```json
// appsettings.json
{
  "Tingee": {
    "SecretKey": "your-secret-key",
    "ClientId":  "your-client-id"
  }
}
```

---

## Gọi API

Tất cả phương thức nằm trong `client.V1.*`:

```csharp
// Lấy danh sách shop (có phân trang)
var result = await client.V1.ShopGetPagingAsync(new OpenApiGetShopPagedInputDto
{
    MaxResultCount = 10,
    SkipCount      = 0,
});
if (result?.IsSuccess == true)
    foreach (var shop in result.Data!.Items!) Console.WriteLine(shop.Name);

// Direct Debit
var sub = await client.V1.DirectDebitGetSubscriptionStatusAsync(new DirectDebitGetSubscriptionStatusInputDto
{
    RequestId      = "uuid-here",
    SubscriptionId = "uuid-here",
    TokenRef       = "token-ref",
});
```

> **Lưu ý:** SDK trả về `TingeeApiResponse<T>` với `Code` và `Message`. Dùng `result?.IsSuccess == true` hoặc `result?.Code == "00"` để xác định thành công — SDK **không tự throw** khi `Code != "00"`.

---

## Xác thực Webhook

```csharp
// ASP.NET Core Controller
[HttpPost("/webhook/tingee")]
public async Task<IActionResult> HandleWebhook()
{
    var signature = Request.Headers["x-signature"].ToString();
    var timestamp = Request.Headers["x-request-timestamp"].ToString();
    var body      = await Request.ReadFromJsonAsync<Dictionary<string, object>>();

    var result = client.VerifyWebhookSignature(signature, timestamp, body);

    if (result.IsError == true)
        return Unauthorized(new { error = result.Message });

    // Xử lý giao dịch...
    return Ok(new { received = true });
}
```

---

## Bank Constants

```csharp
using Tingee.Sdk.Types;

BankNameEnum.Vietcombank.GetBin()       // "970436"
BankNameEnum.Vietcombank.GetShortName() // "Vietcombank"
BankNameEnum.Vietcombank.GetFullName()  // "Ngân hàng TMCP Ngoại Thương Việt Nam"
```

---

## Xem thêm

- [CHANGELOG](./CHANGELOG.md)
- [Tài liệu Tingee Open API](https://open-api.tingee.vn)
- [Tài liệu Tingee Developer](https://developers.tingee.vn)
- [Trang chủ Tingee](https://tingee.vn)
