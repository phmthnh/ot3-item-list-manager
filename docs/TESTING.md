# Kiểm thử — Bài 3 — Quản lý danh mục Vật tư / Linh kiện

Ngày chạy: 08/10/2026. Môi trường: Windows, .NET SDK 10.0.401.

Đã chạy 17/17 kiểm tra đạt với vi-VN. Chạy thêm 17/17 đạt với en-US.

Các kiểm tra chạy trên form thật: hiển thị control, gọi handler, nhập/sửa dữ liệu và xử lý MessageBox. Hộp thoại xác nhận được chương trình kiểm tra trả lời Yes/No tự động. Bộ kiểm tra được chạy ngoài repo để không trộn công cụ audit vào bài nộp.

| Kiểm tra đã chạy | Kết quả |
|---|---|
| `duplicate_on_add` | PASS |
| `duplicate_not_added` | PASS |
| `add_two` | PASS |
| `selection_price` | PASS |
| `price_roundtrip` | PASS |
| `duplicate_on_update` | PASS |
| `update_preserves_codes` | PASS |
| `update_allowed` | PASS |
| `delete_no` | PASS |
| `cancel_delete` | PASS |
| `delete_yes` | PASS |
| `confirmed_delete` | PASS |
| `clear_all_no` | PASS |
| `cancel_clear` | PASS |
| `clear_all_yes` | PASS |
| `confirmed_clear` | PASS |
| `model_synced_after_delete` | PASS |

Kết quả chi tiết: [test-results.json](./test-results.json).

## Kiểm tra thêm trước khi nộp

- [ ] Mở solution bằng Visual Studio 2026, chọn MainForm.cs → Shift+F7 và kiểm tra kéo thả trong Toolbox.
- [ ] Chạy F5, đi qua các bước ở README bằng bàn phím/chuột.
- [ ] Kiểm tra giao diện ở DPI/cỡ màn hình đang dùng.
- [ ] Đối chiếu ảnh screenshot với kết quả chạy thực tế.
