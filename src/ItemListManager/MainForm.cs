namespace ItemListManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // --- Thêm mới ---
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs(out string code, out string name, out string unit, out decimal price))
                return;

            // Kiểm tra mã trùng
            foreach (ListViewItem item in lvItems.Items)
            {
                if (item.Text.Equals(code, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show($"Mã vật tư '{code}' đã tồn tại trong danh sách.", "Trùng mã",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCode.Focus();
                    return;
                }
            }

            var row = new ListViewItem(new[] { code, name, unit, price.ToString("N0") });
            lvItems.Items.Add(row);
            ClearForm();
        }

        // --- Cập nhật ---
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lvItems.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng cần cập nhật.", "Chưa chọn dòng",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!ValidateInputs(out string code, out string name, out string unit, out decimal price))
                return;

            var sel = lvItems.SelectedItems[0];
            sel.SubItems[0].Text = code;
            sel.SubItems[1].Text = name;
            sel.SubItems[2].Text = unit;
            sel.SubItems[3].Text = price.ToString("N0");
            ClearForm();
        }

        // --- Xóa dòng ---
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvItems.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng cần xóa.", "Chưa chọn dòng",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var sel = lvItems.SelectedItems[0];
            var confirm = MessageBox.Show($"Bạn có chắc muốn xóa vật tư '{sel.SubItems[1].Text}'?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                lvItems.Items.Remove(sel);
                ClearForm();
            }
        }

        // --- Xóa toàn bộ ---
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            if (lvItems.Items.Count == 0) return;
            var confirm = MessageBox.Show("Bạn có chắc muốn xóa TOÀN BỘ danh sách?",
                "Xác nhận xóa tất cả", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                lvItems.Items.Clear();
                ClearForm();
            }
        }

        // --- Click chọn dòng → nạp ngược form ---
        private void lvItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvItems.SelectedItems.Count == 0) return;
            var sel = lvItems.SelectedItems[0];
            txtCode.Text  = sel.SubItems[0].Text;
            txtName.Text  = sel.SubItems[1].Text;
            cboUnit.Text  = sel.SubItems[2].Text;
            txtPrice.Text = sel.SubItems[3].Text.Replace(",", "");
        }

        private bool ValidateInputs(out string code, out string name, out string unit, out decimal price)
        {
            code = txtCode.Text.Trim();
            name = txtName.Text.Trim();
            unit = cboUnit.Text.Trim();
            price = 0;

            if (string.IsNullOrEmpty(code))
            {
                MessageBox.Show("Vui lòng nhập Mã vật tư.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCode.Focus(); return false;
            }
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Vui lòng nhập Tên vật tư.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus(); return false;
            }
            if (!decimal.TryParse(txtPrice.Text.Trim(), out price) || price <= 0)
            {
                MessageBox.Show("Vui lòng nhập Đơn giá hợp lệ (số dương).", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.Focus(); return false;
            }
            return true;
        }

        private void ClearForm()
        {
            txtCode.Clear();
            txtName.Clear();
            cboUnit.SelectedIndex = 0;
            txtPrice.Clear();
            txtCode.Focus();
        }
    }
}
