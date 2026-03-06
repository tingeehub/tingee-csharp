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
    SecretKey   = Environment.GetEnvironmentVariable("TINGEE_SECRET_KEY")!,
    ClientId    = Environment.GetEnvironmentVariable("TINGEE_CLIENT_ID")!,
    Environment = TingeeEnvironment.Production, // Uat | Production, mặc định Production
});

var result = await client.Merchant.GetPagingAsync(new OpenApiGetPagingMerchantsDto
{
    SkipCount      = 0,
    MaxResultCount = 10,
});

if (result.IsSuccess)
    foreach (var m in result.Data!.Items!) Console.WriteLine(m.Name);
else
    Console.Error.WriteLine($"Lỗi {result.Code}: {result.Message}");
```

---

## Cấu hình

| Thuộc tính | Kiểu | Mặc định | Mô tả |
|---|---|---|---|
| `SecretKey` | `string` | — | **Bắt buộc.** Secret key từ Tingee Dashboard |
| `ClientId` | `string` | — | **Bắt buộc.** Client ID từ Tingee Dashboard |
| `Environment` | `TingeeEnvironment` | `Production` | `Uat` \| `Production` |
| `BaseUrl` | `string?` | — | Ghi đè URL (bỏ qua `Environment`) |
| `TimeoutMilliseconds` | `int` | `90000` | Timeout (ms) |

### Dependency Injection (ASP.NET Core)

```csharp
// Program.cs
builder.Services.AddSingleton(new TingeeClientOptions
{
    SecretKey   = builder.Configuration["Tingee:SecretKey"]!,
    ClientId    = builder.Configuration["Tingee:ClientId"]!,
    Environment = TingeeEnvironment.Production,
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

Các phương thức được nhóm theo tính năng (`client.<Group>.<Method>Async()`):

```csharp
// Merchant — lấy danh sách
var result = await client.Merchant.GetPagingAsync(new OpenApiGetPagingMerchantsDto
{
    SkipCount = 0, MaxResultCount = 10,
});
if (result.IsSuccess)
    foreach (var m in result.Data!.Items!) Console.WriteLine(m.Name);

// Shop — lấy danh sách
var shops = await client.Shop.GetPagingAsync(new OpenApiGetShopPagedInputDto
{
    SkipCount = 0, MaxResultCount = 10,
});

// Direct Debit
var sub = await client.DirectDebit.GetSubscriptionStatusAsync(
    requestId: "uuid-here",
    subscriptionId: "uuid-here",
    tokenRef: "token-ref");
```

> **Lưu ý:** SDK trả về `TingeeApiResponse<T>` với `Code` và `Message`. Dùng `result.IsSuccess` hoặc `result.Code == "00"` để xác định thành công — SDK **không tự throw** khi `Code != "00"`.

---

## Xác thực Webhook

Khi Tingee gọi vào endpoint webhook của bạn, dùng `client.VerifyWebhookSignature()`:

```csharp
// ASP.NET Core Controller — truyền object
[HttpPost("/webhook/tingee")]
public async Task<IActionResult> HandleWebhook()
{
    var signature = Request.Headers["x-signature"].ToString();
    var timestamp = Request.Headers["x-request-timestamp"].ToString();
    var body      = await Request.ReadFromJsonAsync<Dictionary<string, object>>();

    var result = client.VerifyWebhookSignature(signature, timestamp, body);

    if (!result.IsValid)
        return Unauthorized(new { error = result.Message });

    // Xử lý giao dịch...
    return Ok(new { received = true });
}
```

```csharp
// Truyền raw JSON string — tự động parse
[HttpPost("/webhook/tingee")]
public async Task<IActionResult> HandleWebhook()
{
    var signature = Request.Headers["x-signature"].ToString();
    var timestamp = Request.Headers["x-request-timestamp"].ToString();

    Request.EnableBuffering();
    using var reader = new StreamReader(Request.Body, leaveOpen: true);
    var rawBody = await reader.ReadToEndAsync();

    var result = client.VerifyWebhookSignature(signature, timestamp, rawBody);

    if (!result.IsValid)
        return Unauthorized(new { error = result.Message });

    // Xử lý giao dịch...
    return Ok(new { received = true });
}
```

---

## Xem thêm

- [CHANGELOG](./CHANGELOG.md)
- [Tài liệu Tingee Open API](https://open-api.tingee.vn)
- [Tài liệu Tingee Developer](https://developers.tingee.vn)
- [Trang chủ Tingee](https://tingee.vn)
