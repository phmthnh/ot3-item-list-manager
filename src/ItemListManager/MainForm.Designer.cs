namespace ItemListManager
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.grpInput    = new System.Windows.Forms.GroupBox();
            this.lblCode     = new System.Windows.Forms.Label();
            this.txtCode     = new System.Windows.Forms.TextBox();
            this.lblName     = new System.Windows.Forms.Label();
            this.txtName     = new System.Windows.Forms.TextBox();
            this.lblUnit     = new System.Windows.Forms.Label();
            this.cboUnit     = new System.Windows.Forms.ComboBox();
            this.lblPrice    = new System.Windows.Forms.Label();
            this.txtPrice    = new System.Windows.Forms.TextBox();
            this.btnAdd      = new System.Windows.Forms.Button();
            this.btnUpdate   = new System.Windows.Forms.Button();
            this.btnDelete   = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.grpList     = new System.Windows.Forms.GroupBox();
            this.lvItems     = new System.Windows.Forms.ListView();
            this.colCode     = new System.Windows.Forms.ColumnHeader();
            this.colName     = new System.Windows.Forms.ColumnHeader();
            this.colUnit     = new System.Windows.Forms.ColumnHeader();
            this.colPrice    = new System.Windows.Forms.ColumnHeader();
            this.grpInput.SuspendLayout();
            this.grpList.SuspendLayout();
            this.SuspendLayout();

            // grpInput
            this.grpInput.Controls.Add(this.lblCode);
            this.grpInput.Controls.Add(this.txtCode);
            this.grpInput.Controls.Add(this.lblName);
            this.grpInput.Controls.Add(this.txtName);
            this.grpInput.Controls.Add(this.lblUnit);
            this.grpInput.Controls.Add(this.cboUnit);
            this.grpInput.Controls.Add(this.lblPrice);
            this.grpInput.Controls.Add(this.txtPrice);
            this.grpInput.Controls.Add(this.btnAdd);
            this.grpInput.Controls.Add(this.btnUpdate);
            this.grpInput.Controls.Add(this.btnDelete);
            this.grpInput.Controls.Add(this.btnClearAll);
            this.grpInput.Location = new System.Drawing.Point(12, 12);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(280, 430);
            this.grpInput.TabIndex = 0;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Nhập liệu";

            // lblCode
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(12, 30);
            this.lblCode.Name = "lblCode";
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "Mã vật tư:";

            // txtCode
            this.txtCode.Location = new System.Drawing.Point(120, 27);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(145, 23);
            this.txtCode.TabIndex = 1;

            // lblName
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 68);
            this.lblName.Name = "lblName";
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Tên vật tư:";

            // txtName
            this.txtName.Location = new System.Drawing.Point(120, 65);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(145, 23);
            this.txtName.TabIndex = 3;

            // lblUnit
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(12, 106);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.TabIndex = 4;
            this.lblUnit.Text = "Đơn vị tính:";

            // cboUnit
            this.cboUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnit.Items.AddRange(new object[] { "Cái", "Bộ", "Kg", "Mét" });
            this.cboUnit.Location = new System.Drawing.Point(120, 103);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Size = new System.Drawing.Size(145, 23);
            this.cboUnit.TabIndex = 5;
            this.cboUnit.SelectedIndex = 0;

            // lblPrice
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(12, 144);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Đơn giá nhập:";

            // txtPrice
            this.txtPrice.Location = new System.Drawing.Point(120, 141);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(145, 23);
            this.txtPrice.TabIndex = 7;

            // btnAdd
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(0, 150, 100);
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(12, 195);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(118, 35);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // btnUpdate
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(147, 195);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(118, 35);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            // btnDelete
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(200, 50, 50);
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(12, 245);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(118, 35);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Xóa dòng";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // btnClearAll
            this.btnClearAll.BackColor = System.Drawing.Color.FromArgb(120, 60, 60);
            this.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAll.ForeColor = System.Drawing.Color.White;
            this.btnClearAll.Location = new System.Drawing.Point(147, 245);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(118, 35);
            this.btnClearAll.TabIndex = 11;
            this.btnClearAll.Text = "Xóa toàn bộ";
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);

            // grpList
            this.grpList.Controls.Add(this.lvItems);
            this.grpList.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.grpList.Location = new System.Drawing.Point(305, 12);
            this.grpList.Name = "grpList";
            this.grpList.Size = new System.Drawing.Size(560, 430);
            this.grpList.TabIndex = 1;
            this.grpList.TabStop = false;
            this.grpList.Text = "Danh sách vật tư";

            // lvItems
            this.lvItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { this.colCode, this.colName, this.colUnit, this.colPrice });
            this.lvItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvItems.FullRowSelect = true;
            this.lvItems.GridLines = true;
            this.lvItems.HideSelection = false;
            this.lvItems.Name = "lvItems";
            this.lvItems.TabIndex = 0;
            this.lvItems.UseCompatibleStateImageBehavior = false;
            this.lvItems.View = System.Windows.Forms.View.Details;
            this.lvItems.SelectedIndexChanged += new System.EventHandler(this.lvItems_SelectedIndexChanged);

            // columns
            this.colCode.Text = "Mã VT";
            this.colCode.Width = 100;
            this.colName.Text = "Tên VT";
            this.colName.Width = 200;
            this.colUnit.Text = "Đơn vị";
            this.colUnit.Width = 90;
            this.colPrice.Text = "Đơn giá";
            this.colPrice.Width = 120;
            this.colPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 460);
            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.grpList);
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BT3 - Quản lý danh mục Vật tư / Linh kiện";

            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpList.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.ComboBox cboUnit;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.GroupBox grpList;
        private System.Windows.Forms.ListView lvItems;
        private System.Windows.Forms.ColumnHeader colCode;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colUnit;
        private System.Windows.Forms.ColumnHeader colPrice;
    }
}
