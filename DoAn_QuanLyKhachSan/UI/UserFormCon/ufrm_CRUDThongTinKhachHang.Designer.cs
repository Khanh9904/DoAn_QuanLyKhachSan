namespace DoAn_QuanLyKhachSan.UI.UseForm
{
    partial class ufrm_CRUDThongTinKhachHang
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label maKhachHangLabel;
            System.Windows.Forms.Label hoTenLabel;
            System.Windows.Forms.Label ngaySinhLabel;
            System.Windows.Forms.Label gioiTinhLabel;
            System.Windows.Forms.Label sDTLabel;
            System.Windows.Forms.Label diaChiLabel;
            System.Windows.Forms.Label cCCDLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.heThongKhachSanDataSet = new DoAn_QuanLyKhachSan.HeThongKhachSanDataSet();
            this.kHACH_HANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kHACH_HANGTableAdapter = new DoAn_QuanLyKhachSan.HeThongKhachSanDataSetTableAdapters.KHACH_HANGTableAdapter();
            this.tableAdapterManager = new DoAn_QuanLyKhachSan.HeThongKhachSanDataSetTableAdapters.TableAdapterManager();
            this.maKhachHangTextBox = new System.Windows.Forms.TextBox();
            this.hoTenTextBox = new System.Windows.Forms.TextBox();
            this.ngaySinhDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sDTTextBox = new System.Windows.Forms.TextBox();
            this.diaChiTextBox = new System.Windows.Forms.TextBox();
            this.cCCDTextBox = new System.Windows.Forms.TextBox();
            this.data_ThongTinKhachHang = new System.Windows.Forms.DataGridView();
            this.btnClearThongTinKhachHang = new System.Windows.Forms.Button();
            this.btnXoaThongTinKhachHang = new System.Windows.Forms.Button();
            this.btnSuaThongTinKhachHang = new System.Windows.Forms.Button();
            this.btnThemThongTinKhachHang = new System.Windows.Forms.Button();
            this.txtTimKiemThongTinKhachHang = new System.Windows.Forms.TextBox();
            this.gioiTinhTextBox = new System.Windows.Forms.ComboBox();
            maKhachHangLabel = new System.Windows.Forms.Label();
            hoTenLabel = new System.Windows.Forms.Label();
            ngaySinhLabel = new System.Windows.Forms.Label();
            gioiTinhLabel = new System.Windows.Forms.Label();
            sDTLabel = new System.Windows.Forms.Label();
            diaChiLabel = new System.Windows.Forms.Label();
            cCCDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.heThongKhachSanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACH_HANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_ThongTinKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // maKhachHangLabel
            // 
            maKhachHangLabel.AutoSize = true;
            maKhachHangLabel.Location = new System.Drawing.Point(98, 144);
            maKhachHangLabel.Name = "maKhachHangLabel";
            maKhachHangLabel.Size = new System.Drawing.Size(118, 16);
            maKhachHangLabel.TabIndex = 2;
            maKhachHangLabel.Text = "MÃ KHÁCH HÀNG";
            // 
            // hoTenLabel
            // 
            hoTenLabel.AutoSize = true;
            hoTenLabel.Location = new System.Drawing.Point(98, 172);
            hoTenLabel.Name = "hoTenLabel";
            hoTenLabel.Size = new System.Drawing.Size(58, 16);
            hoTenLabel.TabIndex = 4;
            hoTenLabel.Text = "HỌ TÊN";
            // 
            // ngaySinhLabel
            // 
            ngaySinhLabel.AutoSize = true;
            ngaySinhLabel.Location = new System.Drawing.Point(98, 201);
            ngaySinhLabel.Name = "ngaySinhLabel";
            ngaySinhLabel.Size = new System.Drawing.Size(80, 16);
            ngaySinhLabel.TabIndex = 6;
            ngaySinhLabel.Text = "NGÀY SINH";
            // 
            // gioiTinhLabel
            // 
            gioiTinhLabel.AutoSize = true;
            gioiTinhLabel.Location = new System.Drawing.Point(98, 233);
            gioiTinhLabel.Name = "gioiTinhLabel";
            gioiTinhLabel.Size = new System.Drawing.Size(68, 16);
            gioiTinhLabel.TabIndex = 8;
            gioiTinhLabel.Text = "GIỚI TÍNH";
            // 
            // sDTLabel
            // 
            sDTLabel.AutoSize = true;
            sDTLabel.Location = new System.Drawing.Point(98, 261);
            sDTLabel.Name = "sDTLabel";
            sDTLabel.Size = new System.Drawing.Size(104, 16);
            sDTLabel.TabIndex = 10;
            sDTLabel.Text = "SỐ ĐIỆN THOẠI";
            // 
            // diaChiLabel
            // 
            diaChiLabel.AutoSize = true;
            diaChiLabel.Location = new System.Drawing.Point(98, 289);
            diaChiLabel.Name = "diaChiLabel";
            diaChiLabel.Size = new System.Drawing.Size(53, 16);
            diaChiLabel.TabIndex = 12;
            diaChiLabel.Text = "ĐỊA CHỈ";
            // 
            // cCCDLabel
            // 
            cCCDLabel.AutoSize = true;
            cCCDLabel.Location = new System.Drawing.Point(98, 317);
            cCCDLabel.Name = "cCCDLabel";
            cCCDLabel.Size = new System.Drawing.Size(44, 16);
            cCCDLabel.TabIndex = 14;
            cCCDLabel.Text = "CCCD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(421, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ THÔNG TIN KHÁCH HÀNG";
            // 
            // heThongKhachSanDataSet
            // 
            this.heThongKhachSanDataSet.DataSetName = "HeThongKhachSanDataSet";
            this.heThongKhachSanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kHACH_HANGBindingSource
            // 
            this.kHACH_HANGBindingSource.DataMember = "KHACH_HANG";
            this.kHACH_HANGBindingSource.DataSource = this.heThongKhachSanDataSet;
            // 
            // kHACH_HANGTableAdapter
            // 
            this.kHACH_HANGTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CALAMVIECTableAdapter = null;
            this.tableAdapterManager.CHAMCONGLAMVIECTableAdapter = null;
            this.tableAdapterManager.DICH_VUTableAdapter = null;
            this.tableAdapterManager.HOA_DONTableAdapter = null;
            this.tableAdapterManager.KHACH_HANGTableAdapter = this.kHACH_HANGTableAdapter;
            this.tableAdapterManager.LOAI_PHONGTableAdapter = null;
            this.tableAdapterManager.NHAN_VIENTableAdapter = null;
            this.tableAdapterManager.PHANCONGCALAMTableAdapter = null;
            this.tableAdapterManager.PHANQUYENTableAdapter = null;
            this.tableAdapterManager.PHIEU_DAT_PHONGTableAdapter = null;
            this.tableAdapterManager.PHONGTableAdapter = null;
            this.tableAdapterManager.TAIKHOANTableAdapter = null;
            this.tableAdapterManager.TangLauTableAdapter = null;
            this.tableAdapterManager.THIET_BITableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DoAn_QuanLyKhachSan.HeThongKhachSanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // maKhachHangTextBox
            // 
            this.maKhachHangTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHACH_HANGBindingSource, "MaKhachHang", true));
            this.maKhachHangTextBox.Enabled = false;
            this.maKhachHangTextBox.Location = new System.Drawing.Point(229, 141);
            this.maKhachHangTextBox.Name = "maKhachHangTextBox";
            this.maKhachHangTextBox.Size = new System.Drawing.Size(200, 22);
            this.maKhachHangTextBox.TabIndex = 3;
            // 
            // hoTenTextBox
            // 
            this.hoTenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHACH_HANGBindingSource, "HoTen", true));
            this.hoTenTextBox.Location = new System.Drawing.Point(229, 169);
            this.hoTenTextBox.Name = "hoTenTextBox";
            this.hoTenTextBox.Size = new System.Drawing.Size(200, 22);
            this.hoTenTextBox.TabIndex = 5;
            // 
            // ngaySinhDateTimePicker
            // 
            this.ngaySinhDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.kHACH_HANGBindingSource, "NgaySinh", true));
            this.ngaySinhDateTimePicker.Location = new System.Drawing.Point(229, 197);
            this.ngaySinhDateTimePicker.Name = "ngaySinhDateTimePicker";
            this.ngaySinhDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.ngaySinhDateTimePicker.TabIndex = 7;
            // 
            // sDTTextBox
            // 
            this.sDTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHACH_HANGBindingSource, "SDT", true));
            this.sDTTextBox.Location = new System.Drawing.Point(229, 258);
            this.sDTTextBox.Name = "sDTTextBox";
            this.sDTTextBox.Size = new System.Drawing.Size(200, 22);
            this.sDTTextBox.TabIndex = 11;
            // 
            // diaChiTextBox
            // 
            this.diaChiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHACH_HANGBindingSource, "DiaChi", true));
            this.diaChiTextBox.Location = new System.Drawing.Point(229, 286);
            this.diaChiTextBox.Name = "diaChiTextBox";
            this.diaChiTextBox.Size = new System.Drawing.Size(200, 22);
            this.diaChiTextBox.TabIndex = 13;
            // 
            // cCCDTextBox
            // 
            this.cCCDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHACH_HANGBindingSource, "CCCD", true));
            this.cCCDTextBox.Location = new System.Drawing.Point(229, 314);
            this.cCCDTextBox.Name = "cCCDTextBox";
            this.cCCDTextBox.Size = new System.Drawing.Size(200, 22);
            this.cCCDTextBox.TabIndex = 15;
            // 
            // data_ThongTinKhachHang
            // 
            this.data_ThongTinKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_ThongTinKhachHang.Location = new System.Drawing.Point(513, 169);
            this.data_ThongTinKhachHang.Name = "data_ThongTinKhachHang";
            this.data_ThongTinKhachHang.RowHeadersWidth = 51;
            this.data_ThongTinKhachHang.RowTemplate.Height = 24;
            this.data_ThongTinKhachHang.Size = new System.Drawing.Size(593, 249);
            this.data_ThongTinKhachHang.TabIndex = 17;
            this.data_ThongTinKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_ThongTinKhachHang_CellClick);
            // 
            // btnClearThongTinKhachHang
            // 
            this.btnClearThongTinKhachHang.Location = new System.Drawing.Point(738, 474);
            this.btnClearThongTinKhachHang.Name = "btnClearThongTinKhachHang";
            this.btnClearThongTinKhachHang.Size = new System.Drawing.Size(176, 55);
            this.btnClearThongTinKhachHang.TabIndex = 87;
            this.btnClearThongTinKhachHang.Text = "Xóa Dữ Liệu";
            this.btnClearThongTinKhachHang.UseVisualStyleBackColor = true;
            this.btnClearThongTinKhachHang.Click += new System.EventHandler(this.btnClearThongTinKhachHang_Click);
            // 
            // btnXoaThongTinKhachHang
            // 
            this.btnXoaThongTinKhachHang.Location = new System.Drawing.Point(587, 474);
            this.btnXoaThongTinKhachHang.Name = "btnXoaThongTinKhachHang";
            this.btnXoaThongTinKhachHang.Size = new System.Drawing.Size(116, 55);
            this.btnXoaThongTinKhachHang.TabIndex = 86;
            this.btnXoaThongTinKhachHang.Text = "Xóa";
            this.btnXoaThongTinKhachHang.UseVisualStyleBackColor = true;
            this.btnXoaThongTinKhachHang.Click += new System.EventHandler(this.btnXoaThongTinKhachHang_Click);
            // 
            // btnSuaThongTinKhachHang
            // 
            this.btnSuaThongTinKhachHang.Location = new System.Drawing.Point(426, 474);
            this.btnSuaThongTinKhachHang.Name = "btnSuaThongTinKhachHang";
            this.btnSuaThongTinKhachHang.Size = new System.Drawing.Size(116, 55);
            this.btnSuaThongTinKhachHang.TabIndex = 85;
            this.btnSuaThongTinKhachHang.Text = "Sửa";
            this.btnSuaThongTinKhachHang.UseVisualStyleBackColor = true;
            this.btnSuaThongTinKhachHang.Click += new System.EventHandler(this.btnSuaThongTinKhachHang_Click);
            // 
            // btnThemThongTinKhachHang
            // 
            this.btnThemThongTinKhachHang.Location = new System.Drawing.Point(277, 474);
            this.btnThemThongTinKhachHang.Name = "btnThemThongTinKhachHang";
            this.btnThemThongTinKhachHang.Size = new System.Drawing.Size(116, 55);
            this.btnThemThongTinKhachHang.TabIndex = 84;
            this.btnThemThongTinKhachHang.Text = "Thêm";
            this.btnThemThongTinKhachHang.UseVisualStyleBackColor = true;
            this.btnThemThongTinKhachHang.Click += new System.EventHandler(this.btnThemThongTinKhachHang_Click);
            // 
            // txtTimKiemThongTinKhachHang
            // 
            this.txtTimKiemThongTinKhachHang.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTimKiemThongTinKhachHang.Location = new System.Drawing.Point(513, 144);
            this.txtTimKiemThongTinKhachHang.Name = "txtTimKiemThongTinKhachHang";
            this.txtTimKiemThongTinKhachHang.Size = new System.Drawing.Size(593, 22);
            this.txtTimKiemThongTinKhachHang.TabIndex = 88;
            this.txtTimKiemThongTinKhachHang.TextChanged += new System.EventHandler(this.txtTimKiemThongTinKhachHang_TextChanged);
            // 
            // gioiTinhTextBox
            // 
            this.gioiTinhTextBox.FormattingEnabled = true;
            this.gioiTinhTextBox.Items.AddRange(new object[] {
            "Nữ",
            "Nam"});
            this.gioiTinhTextBox.Location = new System.Drawing.Point(229, 224);
            this.gioiTinhTextBox.Name = "gioiTinhTextBox";
            this.gioiTinhTextBox.Size = new System.Drawing.Size(200, 24);
            this.gioiTinhTextBox.TabIndex = 89;
            // 
            // ufrm_CRUDThongTinKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gioiTinhTextBox);
            this.Controls.Add(this.txtTimKiemThongTinKhachHang);
            this.Controls.Add(this.btnClearThongTinKhachHang);
            this.Controls.Add(this.btnXoaThongTinKhachHang);
            this.Controls.Add(this.btnSuaThongTinKhachHang);
            this.Controls.Add(this.btnThemThongTinKhachHang);
            this.Controls.Add(this.data_ThongTinKhachHang);
            this.Controls.Add(maKhachHangLabel);
            this.Controls.Add(this.maKhachHangTextBox);
            this.Controls.Add(hoTenLabel);
            this.Controls.Add(this.hoTenTextBox);
            this.Controls.Add(ngaySinhLabel);
            this.Controls.Add(this.ngaySinhDateTimePicker);
            this.Controls.Add(gioiTinhLabel);
            this.Controls.Add(sDTLabel);
            this.Controls.Add(this.sDTTextBox);
            this.Controls.Add(diaChiLabel);
            this.Controls.Add(this.diaChiTextBox);
            this.Controls.Add(cCCDLabel);
            this.Controls.Add(this.cCCDTextBox);
            this.Controls.Add(this.label1);
            this.Name = "ufrm_CRUDThongTinKhachHang";
            this.Size = new System.Drawing.Size(1191, 830);
            ((System.ComponentModel.ISupportInitialize)(this.heThongKhachSanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACH_HANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_ThongTinKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private HeThongKhachSanDataSet heThongKhachSanDataSet;
        private System.Windows.Forms.BindingSource kHACH_HANGBindingSource;
        private HeThongKhachSanDataSetTableAdapters.KHACH_HANGTableAdapter kHACH_HANGTableAdapter;
        private HeThongKhachSanDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox maKhachHangTextBox;
        private System.Windows.Forms.TextBox hoTenTextBox;
        private System.Windows.Forms.DateTimePicker ngaySinhDateTimePicker;
        private System.Windows.Forms.TextBox sDTTextBox;
        private System.Windows.Forms.TextBox diaChiTextBox;
        private System.Windows.Forms.TextBox cCCDTextBox;
        private System.Windows.Forms.DataGridView data_ThongTinKhachHang;
        private System.Windows.Forms.Button btnClearThongTinKhachHang;
        private System.Windows.Forms.Button btnXoaThongTinKhachHang;
        private System.Windows.Forms.Button btnSuaThongTinKhachHang;
        private System.Windows.Forms.Button btnThemThongTinKhachHang;
        private System.Windows.Forms.TextBox txtTimKiemThongTinKhachHang;
        private System.Windows.Forms.ComboBox gioiTinhTextBox;
    }
}
