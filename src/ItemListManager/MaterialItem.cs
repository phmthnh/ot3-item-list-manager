namespace ItemListManager
{
    // Giữ giá bằng dữ liệu số thay vì đọc ngược từ chuỗi đã định dạng.
    internal sealed record MaterialItem(string Code, string Name, string Unit, decimal Price);
}
