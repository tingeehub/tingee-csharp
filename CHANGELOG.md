# Changelog — Tingee.Sdk (C#)

All notable changes to this package will be documented in this file.
Format: [Keep a Changelog](https://keepachangelog.com/en/1.0.0/)

---

## [0.1.0] — 2026-03-04

### Initial release

#### Added
- `TingeeClient` — main client class with DI-friendly `TingeeClientOptions`:
  ```csharp
  var client = new TingeeClient(new TingeeClientOptions
  {
      SecretKey   = "...",
      ClientId    = "...",
      Environment = TingeeEnvironment.Uat,
  });
  ```
- `client.V1.*` — **49 auto-generated V1 API methods** from OpenAPI spec
  - VietQR, Dynamic QR generation
  - Merchant, Shop, Device management
  - Direct Debit / Subscription APIs
  - Bank / VA (Virtual Account) APIs
  - Account info, Notification, Config endpoints
- `TingeeV1CustomMethods` (extends `V1Methods`) — hand-written method class in `TingeeClient.Custom.cs`, never overwritten by generator; accessible via `client.V1.*` alongside generated methods
- `client.VerifyWebhookSignature(signature, timestamp, body)` — instance method, uses secretKey already set on the client (no need to pass key again)
- `TingeeSigner` — static webhook verification utility
- `TingeeHttpClient` — `System.Net.Http.HttpClient`-based client with:
  - Automatic HMAC-SHA512 signature on every request
  - Timestamp forced to **SE Asia Standard Time (UTC+7)** to prevent "Request expired" errors
  - Query string support for GET endpoints
  - Configurable timeout (default 90s)
- `BankNameEnum`, `BankAccountTypeEnum`, extension methods `GetBin()`, `GetShortName()` — Vietnamese bank constants
- Full model types for all 138 DTOs (`Tingee.Sdk.Types.Dtos.*`)
- `TingeeApiResponse<T>` with `IsSuccess` / `IsError` convenience properties
- Environment: `TingeeEnvironment.Production` | `TingeeEnvironment.Uat` | custom `BaseUrl`
- NuGet package: `Tingee.Sdk` — target `net8.0`

#### Design decisions
- HTTP client returns raw `TingeeApiResponse<T>` — callers check `result?.Code == "00"` themselves; no auto-throw on business errors
- Network/timeout errors throw `TingeeHttpException`
