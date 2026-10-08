using System.Globalization;

namespace ItemListManager
{
    public partial class MainForm : Form
    {
        private readonly List<MaterialItem> _items = new();

        public MainForm() { InitializeComponent(); }

        private bool IsDuplicateCode(string code, MaterialItem? except = null)
        {
            return _items.Any(item => !ReferenceEquals(item, except)
                && item.Code.Equals(code, StringComparison.OrdinalIgnoreCase));
        }

        private void ShowDuplicateCode(string code)
        {
            MessageBox.Show(this, $"Mã vật tư '{code}' đã tồn tại trong danh sách.", "Trùng mã",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtCode.Focus();
        }

        private static string[] DisplayValues(MaterialItem item)
        {
            return new[] { item.Code, item.Name, item.Unit, item.Price.ToString("N0") };
        }

        private void btnAdd_Click(object? sender, EventArgs e)
        {
            if (!ValidateInputs(out var code, out var name, out var unit, out var price)) return;
            if (IsDuplicateCode(code)) { ShowDuplicateCode(code); return; }
            var item = new MaterialItem(code, name, unit, price);
            _items.Add(item);
            lvItems.Items.Add(new ListViewItem(DisplayValues(item)) { Tag = item });
            ClearForm();
        }

        private void btnUpdate_Click(object? sender, EventArgs e)
        {
            if (lvItems.SelectedItems.Count == 0)
            {
                MessageBox.Show(this, "Vui lòng chọn một dòng cần cập nhật.", "Chưa chọn dòng",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!ValidateInputs(out var code, out var name, out var unit, out var price)) return;
            var row = lvItems.SelectedItems[0];
            var oldItem = (MaterialItem)row.Tag!;
            if (IsDuplicateCode(code, oldItem)) { ShowDuplicateCode(code); return; }
            var item = new MaterialItem(code, name, unit, price);
            _items[_items.IndexOf(oldItem)] = item;
            row.Tag = item;
            var values = DisplayValues(item);
            for (int i = 0; i < values.Length; i++) row.SubItems[i].Text = values[i];
            ClearForm();
        }

        private void btnDelete_Click(object? sender, EventArgs e)
        {
            if (lvItems.SelectedItems.Count == 0)
            {
                MessageBox.Show(this, "Vui lòng chọn một dòng cần xóa.", "Chưa chọn dòng",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var row = lvItems.SelectedItems[0];
            if (MessageBox.Show(this, $"Bạn có chắc muốn xóa vật tư '{row.SubItems[1].Text}'?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            _items.Remove((MaterialItem)row.Tag!);
            lvItems.Items.Remove(row);
            ClearForm();
        }

        private void btnClearAll_Click(object? sender, EventArgs e)
        {
            if (_items.Count == 0) return;
            if (MessageBox.Show(this, "Bạn có chắc muốn xóa TOÀN BỘ danh sách?", "Xác nhận xóa tất cả",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
            _items.Clear();
            lvItems.Items.Clear();
            ClearForm();
        }

        private void lvItems_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (lvItems.SelectedItems.Count == 0) return;
            var item = (MaterialItem)lvItems.SelectedItems[0].Tag!;
            txtCode.Text = item.Code;
            txtName.Text = item.Name;
            cboUnit.SelectedItem = item.Unit;
            txtPrice.Text = item.Price.ToString(CultureInfo.CurrentCulture);
        }

        private bool ValidateInputs(out string code, out string name, out string unit, out decimal price)
        {
            code = txtCode.Text.Trim(); name = txtName.Text.Trim(); unit = cboUnit.Text; price = 0;
            if (string.IsNullOrWhiteSpace(code))
            {
                MessageBox.Show(this, "Vui lòng nhập Mã vật tư.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCode.Focus(); return false;
            }
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show(this, "Vui lòng nhập Tên vật tư.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus(); return false;
            }
            if (cboUnit.SelectedIndex < 0)
            {
                MessageBox.Show(this, "Vui lòng chọn Đơn vị tính.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboUnit.Focus(); return false;
            }
            if (!decimal.TryParse(txtPrice.Text.Trim(), out price) || price <= 0)
            {
                MessageBox.Show(this, "Vui lòng nhập Đơn giá hợp lệ (số dương).", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.Focus(); return false;
            }
            return true;
        }

        private void ClearForm()
        {
            foreach (ListViewItem row in lvItems.SelectedItems) row.Selected = false;
            txtCode.Clear(); txtName.Clear(); cboUnit.SelectedIndex = 0; txtPrice.Clear(); txtCode.Focus();
        }
    }
}
