# Changelog — Tingee.Sdk (C#)

## [0.3.0] — 2026-08-06

### Added
- Bank V1 API additions:
  - `CreateDebitAsync`: `POST /v1/bank/create-debit` (tạo VA ghi nợ)
  - `CreateBatchVaOnOffAsync`: `POST /v1/bank/create-batch-va-on-off` (tạo/bật/tắt VA hàng loạt)
  - `WebhookNotificationAsync`: `POST /v1/bank/webhook-notification` (cập nhật cấu hình nhận webhook notification)
  - `CreateBankLinkSessionAsync`: `POST /v1/bank/create-bank-link-session` (tạo phiên liên kết tài khoản ngân hàng)
  - `OnVaAsync` / `OffVaAsync`: `POST /v1/bank/on-va`, `POST /v1/bank/off-va` (bật/tắt Virtual Account)
  - `ConfirmRegisterNotifyAsync`: `POST /v1/bank/confirm-register-notify` (xác nhận đăng ký nhận thông báo biến động)
- Payment Gateway API support (`/v1/payment-gateway/*`):
  - `CreatePaymentLinkAsync`: `POST /v1/payment-gateway/create-payment-link` (tạo link thanh toán)
- Webhook & transaction status enum values: `delete-va-success`, `delete-va-failed`, `bank-link-success`, `bank-link-failed`

### Fixed & Improved
- Fixed ambiguous reference compiler error between `Tingee.Sdk.Types.Dtos.Boolean` and C# `bool` by mapping Swagger `Boolean` schema to C# `bool` keyword
- Regenerated C# DTO classes and client API method groups (155 DTO types, 72 API method groups)

## [0.2.4] — 2026-06-18

### Fixed
- Fixed `System.Text.Json` deserialization errors for value types (`int`, `long`, `double`, `bool`) when API returns `null`.
- Fixed `System.Text.Json` deserialization errors by allowing number reading from string (`JsonNumberHandling.AllowReadingFromString`).

## [0.2.3] [DEPRECATED] — 2026-04-09

> **⚠️ Deprecated** — Phiên bản này không còn được hỗ trợ. Vui lòng nâng cấp lên `>=0.2.4`.

### Changed
- Updated model classes
- Update serialization json 

## [0.2.2] [DEPRECATED] — 2026-04-08

> **⚠️ Deprecated** — Phiên bản này không còn được hỗ trợ. Vui lòng nâng cấp lên `>=0.2.4`.

### Changed
- Updated OpenAPI spec with latest API definitions
- Regenerated SDK client methods and DTOs

## [0.2.1] [DEPRECATED] — 2026-03-31

> **⚠️ Deprecated** — Phiên bản này không còn được hỗ trợ. Vui lòng nâng cấp lên `>=0.2.4`.

### Changed
- Updated OpenAPI spec with latest API definitions
- Regenerated SDK client methods and DTOs

## [0.2.0] [DEPRECATED] — 2026-03-30

> **⚠️ Deprecated** — Phiên bản này không còn được hỗ trợ. Vui lòng nâng cấp lên `>=0.2.4`.

### Added
- E-Invoice API support: account management, invoice creation, template listing, invoice download, and email sending

### Changed
- Updated OpenAPI spec with latest API definitions
- Regenerated SDK client and DTO classes

## [0.1.0] [DEPRECATED] — 2026-03-06

> **⚠️ Deprecated** — Phiên bản này không còn được hỗ trợ. Vui lòng nâng cấp lên `>=0.2.4`.

### Added
- Initial SDK release
- API client implementation
- Request signing
- Basic error handling
