namespace DoAn_QuanLyKhachSan.UI.UserFormPhu
{
    partial class ufrm_CRUDThietBi
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
            System.Windows.Forms.Label maThietBiLabel;
            System.Windows.Forms.Label tenThietBiLabel;
            System.Windows.Forms.Label soLuongThietBiLabel;
            System.Windows.Forms.Label tinhTrangLabel;
            this.txtTimKiemThietbi = new System.Windows.Forms.TextBox();
            this.btnClearThietbi = new System.Windows.Forms.Button();
            this.btnXoaThietbi = new System.Windows.Forms.Button();
            this.btnSuaThietbi = new System.Windows.Forms.Button();
            this.btnThemThietbi = new System.Windows.Forms.Button();
            this.btnTroLaiThietbi = new System.Windows.Forms.Button();
            this.data_Thietbi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.heThongKhachSanDataSet = new DoAn_QuanLyKhachSan.HeThongKhachSanDataSet();
            this.tHIET_BIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tHIET_BITableAdapter = new DoAn_QuanLyKhachSan.HeThongKhachSanDataSetTableAdapters.THIET_BITableAdapter();
            this.tableAdapterManager = new DoAn_QuanLyKhachSan.HeThongKhachSanDataSetTableAdapters.TableAdapterManager();
            this.maThietBiTextBox = new System.Windows.Forms.TextBox();
            this.tenThietBiTextBox = new System.Windows.Forms.TextBox();
            this.soLuongThietBiTextBox = new System.Windows.Forms.TextBox();
            this.tinhTrangTextBox = new System.Windows.Forms.ComboBox();
            maThietBiLabel = new System.Windows.Forms.Label();
            tenThietBiLabel = new System.Windows.Forms.Label();
            soLuongThietBiLabel = new System.Windows.Forms.Label();
            tinhTrangLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_Thietbi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heThongKhachSanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHIET_BIBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // maThietBiLabel
            // 
            maThietBiLabel.AutoSize = true;
            maThietBiLabel.Location = new System.Drawing.Point(67, 237);
            maThietBiLabel.Name = "maThietBiLabel";
            maThietBiLabel.Size = new System.Drawing.Size(85, 16);
            maThietBiLabel.TabIndex = 85;
            maThietBiLabel.Text = "MÃ THIẾT BỊ";
            // 
            // tenThietBiLabel
            // 
            tenThietBiLabel.AutoSize = true;
            tenThietBiLabel.Location = new System.Drawing.Point(67, 265);
            tenThietBiLabel.Name = "tenThietBiLabel";
            tenThietBiLabel.Size = new System.Drawing.Size(93, 16);
            tenThietBiLabel.TabIndex = 87;
            tenThietBiLabel.Text = "TÊN THIẾT BỊ";
            // 
            // soLuongThietBiLabel
            // 
            soLuongThietBiLabel.AutoSize = true;
            soLuongThietBiLabel.Location = new System.Drawing.Point(67, 293);
            soLuongThietBiLabel.Name = "soLuongThietBiLabel";
            soLuongThietBiLabel.Size = new System.Drawing.Size(134, 16);
            soLuongThietBiLabel.TabIndex = 89;
            soLuongThietBiLabel.Text = "SỐ LƯỢNG THIẾT BỊ";
            // 
            // tinhTrangLabel
            // 
            tinhTrangLabel.AutoSize = true;
            tinhTrangLabel.Location = new System.Drawing.Point(67, 321);
            tinhTrangLabel.Name = "tinhTrangLabel";
            tinhTrangLabel.Size = new System.Drawing.Size(90, 16);
            tinhTrangLabel.TabIndex = 91;
            tinhTrangLabel.Text = "TÌNH TRẠNG";
            // 
            // txtTimKiemThietbi
            // 
            this.txtTimKiemThietbi.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTimKiemThietbi.Location = new System.Drawing.Point(553, 184);
            this.txtTimKiemThietbi.Name = "txtTimKiemThietbi";
            this.txtTimKiemThietbi.Size = new System.Drawing.Size(603, 22);
            this.txtTimKiemThietbi.TabIndex = 84;
            this.txtTimKiemThietbi.TextChanged += new System.EventHandler(this.txtTimKiemThietbi_TextChanged);
            // 
            // btnClearThietbi
            // 
            this.btnClearThietbi.Location = new System.Drawing.Point(723, 649);
            this.btnClearThietbi.Name = "btnClearThietbi";
            this.btnClearThietbi.Size = new System.Drawing.Size(147, 53);
            this.btnClearThietbi.TabIndex = 83;
            this.btnClearThietbi.Text = "Xóa Dữ Liệu";
            this.btnClearThietbi.UseVisualStyleBackColor = true;
            this.btnClearThietbi.Click += new System.EventHandler(this.btnClearThietbi_Click);
            // 
            // btnXoaThietbi
            // 
            this.btnXoaThietbi.Location = new System.Drawing.Point(572, 649);
            this.btnXoaThietbi.Name = "btnXoaThietbi";
            this.btnXoaThietbi.Size = new System.Drawing.Size(87, 53);
            this.btnXoaThietbi.TabIndex = 82;
            this.btnXoaThietbi.Text = "Xóa";
            this.btnXoaThietbi.UseVisualStyleBackColor = true;
            this.btnXoaThietbi.Click += new System.EventHandler(this.btnXoaThietbi_Click);
            // 
            // btnSuaThietbi
            // 
            this.btnSuaThietbi.Location = new System.Drawing.Point(411, 649);
            this.btnSuaThietbi.Name = "btnSuaThietbi";
            this.btnSuaThietbi.Size = new System.Drawing.Size(87, 53);
            this.btnSuaThietbi.TabIndex = 81;
            this.btnSuaThietbi.Text = "Sửa";
            this.btnSuaThietbi.UseVisualStyleBackColor = true;
            this.btnSuaThietbi.Click += new System.EventHandler(this.btnSuaThietbi_Click);
            // 
            // btnThemThietbi
            // 
            this.btnThemThietbi.Location = new System.Drawing.Point(262, 649);
            this.btnThemThietbi.Name = "btnThemThietbi";
            this.btnThemThietbi.Size = new System.Drawing.Size(87, 53);
            this.btnThemThietbi.TabIndex = 80;
            this.btnThemThietbi.Text = "Thêm";
            this.btnThemThietbi.UseVisualStyleBackColor = true;
            this.btnThemThietbi.Click += new System.EventHandler(this.btnThemThietbi_Click);
            // 
            // btnTroLaiThietbi
            // 
            this.btnTroLaiThietbi.Location = new System.Drawing.Point(61, 114);
            this.btnTroLaiThietbi.Name = "btnTroLaiThietbi";
            this.btnTroLaiThietbi.Size = new System.Drawing.Size(75, 23);
            this.btnTroLaiThietbi.TabIndex = 79;
            this.btnTroLaiThietbi.Text = "Trở lại";
            this.btnTroLaiThietbi.UseVisualStyleBackColor = true;
            this.btnTroLaiThietbi.Click += new System.EventHandler(this.btnTroLaiThietbi_Click);
            // 
            // data_Thietbi
            // 
            this.data_Thietbi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Thietbi.Location = new System.Drawing.Point(553, 212);
            this.data_Thietbi.Name = "data_Thietbi";
            this.data_Thietbi.RowHeadersWidth = 51;
            this.data_Thietbi.RowTemplate.Height = 24;
            this.data_Thietbi.Size = new System.Drawing.Size(599, 393);
            this.data_Thietbi.TabIndex = 78;
            this.data_Thietbi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_Thietbi_CellClick);
            this.data_Thietbi.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.data_Thietbi_CellFormatting);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(448, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 29);
            this.label1.TabIndex = 77;
            this.label1.Text = "QUẢN LÝ THÔNG TIN THIẾT BỊ";
            // 
            // heThongKhachSanDataSet
            // 
            this.heThongKhachSanDataSet.DataSetName = "HeThongKhachSanDataSet";
            this.heThongKhachSanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tHIET_BIBindingSource
            // 
            this.tHIET_BIBindingSource.DataMember = "THIET_BI";
            this.tHIET_BIBindingSource.DataSource = this.heThongKhachSanDataSet;
            // 
            // tHIET_BITableAdapter
            // 
            this.tHIET_BITableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CALAMVIECTableAdapter = null;
            this.tableAdapterManager.CHAMCONGLAMVIECTableAdapter = null;
            this.tableAdapterManager.DICH_VUTableAdapter = null;
            this.tableAdapterManager.HOA_DONTableAdapter = null;
            this.tableAdapterManager.KHACH_HANGTableAdapter = null;
            this.tableAdapterManager.LOAI_PHONGTableAdapter = null;
            this.tableAdapterManager.NHAN_VIENTableAdapter = null;
            this.tableAdapterManager.PHANCONGCALAMTableAdapter = null;
            this.tableAdapterManager.PHANQUYENTableAdapter = null;
            this.tableAdapterManager.PHIEU_DAT_PHONGTableAdapter = null;
            this.tableAdapterManager.PHONGTableAdapter = null;
            this.tableAdapterManager.TAIKHOANTableAdapter = null;
            this.tableAdapterManager.TangLauTableAdapter = null;
            this.tableAdapterManager.THIET_BITableAdapter = this.tHIET_BITableAdapter;
            this.tableAdapterManager.UpdateOrder = DoAn_QuanLyKhachSan.HeThongKhachSanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // maThietBiTextBox
            // 
            this.maThietBiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tHIET_BIBindingSource, "MaThietBi", true));
            this.maThietBiTextBox.Enabled = false;
            this.maThietBiTextBox.Location = new System.Drawing.Point(207, 234);
            this.maThietBiTextBox.Name = "maThietBiTextBox";
            this.maThietBiTextBox.Size = new System.Drawing.Size(257, 22);
            this.maThietBiTextBox.TabIndex = 86;
            // 
            // tenThietBiTextBox
            // 
            this.tenThietBiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tHIET_BIBindingSource, "TenThietBi", true));
            this.tenThietBiTextBox.Location = new System.Drawing.Point(207, 262);
            this.tenThietBiTextBox.Name = "tenThietBiTextBox";
            this.tenThietBiTextBox.Size = new System.Drawing.Size(257, 22);
            this.tenThietBiTextBox.TabIndex = 88;
            // 
            // soLuongThietBiTextBox
            // 
            this.soLuongThietBiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tHIET_BIBindingSource, "SoLuongThietBi", true));
            this.soLuongThietBiTextBox.Location = new System.Drawing.Point(207, 290);
            this.soLuongThietBiTextBox.Name = "soLuongThietBiTextBox";
            this.soLuongThietBiTextBox.Size = new System.Drawing.Size(257, 22);
            this.soLuongThietBiTextBox.TabIndex = 90;
            // 
            // tinhTrangTextBox
            // 
            this.tinhTrangTextBox.FormattingEnabled = true;
            this.tinhTrangTextBox.Items.AddRange(new object[] {
            "Mới 100%",
            "Hoạt động tốt",
            "Bảo trì"});
            this.tinhTrangTextBox.Location = new System.Drawing.Point(207, 321);
            this.tinhTrangTextBox.Name = "tinhTrangTextBox";
            this.tinhTrangTextBox.Size = new System.Drawing.Size(257, 24);
            this.tinhTrangTextBox.TabIndex = 92;
            // 
            // ufrm_CRUDThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tinhTrangTextBox);
            this.Controls.Add(maThietBiLabel);
            this.Controls.Add(this.maThietBiTextBox);
            this.Controls.Add(tenThietBiLabel);
            this.Controls.Add(this.tenThietBiTextBox);
            this.Controls.Add(soLuongThietBiLabel);
            this.Controls.Add(this.soLuongThietBiTextBox);
            this.Controls.Add(tinhTrangLabel);
            this.Controls.Add(this.txtTimKiemThietbi);
            this.Controls.Add(this.btnClearThietbi);
            this.Controls.Add(this.btnXoaThietbi);
            this.Controls.Add(this.btnSuaThietbi);
            this.Controls.Add(this.btnThemThietbi);
            this.Controls.Add(this.btnTroLaiThietbi);
            this.Controls.Add(this.data_Thietbi);
            this.Controls.Add(this.label1);
            this.Name = "ufrm_CRUDThietBi";
            this.Size = new System.Drawing.Size(1191, 830);
            ((System.ComponentModel.ISupportInitialize)(this.data_Thietbi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heThongKhachSanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHIET_BIBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTimKiemThietbi;
        private System.Windows.Forms.Button btnClearThietbi;
        private System.Windows.Forms.Button btnXoaThietbi;
        private System.Windows.Forms.Button btnSuaThietbi;
        private System.Windows.Forms.Button btnThemThietbi;
        private System.Windows.Forms.Button btnTroLaiThietbi;
        private System.Windows.Forms.DataGridView data_Thietbi;
        private System.Windows.Forms.Label label1;
        private HeThongKhachSanDataSet heThongKhachSanDataSet;
        private System.Windows.Forms.BindingSource tHIET_BIBindingSource;
        private HeThongKhachSanDataSetTableAdapters.THIET_BITableAdapter tHIET_BITableAdapter;
        private HeThongKhachSanDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox maThietBiTextBox;
        private System.Windows.Forms.TextBox tenThietBiTextBox;
        private System.Windows.Forms.TextBox soLuongThietBiTextBox;
        private System.Windows.Forms.ComboBox tinhTrangTextBox;
    }
}
