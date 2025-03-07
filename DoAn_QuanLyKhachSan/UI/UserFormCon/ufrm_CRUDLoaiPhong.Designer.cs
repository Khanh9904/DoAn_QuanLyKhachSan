namespace DoAn_QuanLyKhachSan.UI.UserFormPhu
{
    partial class ufrm_CRUDLoaiPhong
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
            System.Windows.Forms.Label maLoaiPhongLabel;
            System.Windows.Forms.Label tenLoaiPhongLabel;
            System.Windows.Forms.Label giaLabel;
            System.Windows.Forms.Label soNguoiToiDaLabel;
            this.txtTimKiemLoaiPhong = new System.Windows.Forms.TextBox();
            this.btnClearLoaiPhong = new System.Windows.Forms.Button();
            this.btnXoaLoaiPhong = new System.Windows.Forms.Button();
            this.btnSuaLoaiPhong = new System.Windows.Forms.Button();
            this.btnThemLoaiPhong = new System.Windows.Forms.Button();
            this.btnTroLaiLoaiPhong = new System.Windows.Forms.Button();
            this.data_LoaiPhong = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.heThongKhachSanDataSet = new DoAn_QuanLyKhachSan.HeThongKhachSanDataSet();
            this.kHACH_HANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kHACH_HANGTableAdapter = new DoAn_QuanLyKhachSan.HeThongKhachSanDataSetTableAdapters.KHACH_HANGTableAdapter();
            this.tableAdapterManager = new DoAn_QuanLyKhachSan.HeThongKhachSanDataSetTableAdapters.TableAdapterManager();
            this.lOAI_PHONGTableAdapter = new DoAn_QuanLyKhachSan.HeThongKhachSanDataSetTableAdapters.LOAI_PHONGTableAdapter();
            this.lOAI_PHONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maLoaiPhongTextBox = new System.Windows.Forms.TextBox();
            this.tenLoaiPhongTextBox = new System.Windows.Forms.TextBox();
            this.giaTextBox = new System.Windows.Forms.TextBox();
            this.soNguoiToiDaTextBox = new System.Windows.Forms.TextBox();
            maLoaiPhongLabel = new System.Windows.Forms.Label();
            tenLoaiPhongLabel = new System.Windows.Forms.Label();
            giaLabel = new System.Windows.Forms.Label();
            soNguoiToiDaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_LoaiPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heThongKhachSanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACH_HANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAI_PHONGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // maLoaiPhongLabel
            // 
            maLoaiPhongLabel.AutoSize = true;
            maLoaiPhongLabel.Location = new System.Drawing.Point(74, 209);
            maLoaiPhongLabel.Name = "maLoaiPhongLabel";
            maLoaiPhongLabel.Size = new System.Drawing.Size(111, 16);
            maLoaiPhongLabel.TabIndex = 69;
            maLoaiPhongLabel.Text = "MÃ LOẠI PHÒNG";
            // 
            // tenLoaiPhongLabel
            // 
            tenLoaiPhongLabel.AutoSize = true;
            tenLoaiPhongLabel.Location = new System.Drawing.Point(74, 237);
            tenLoaiPhongLabel.Name = "tenLoaiPhongLabel";
            tenLoaiPhongLabel.Size = new System.Drawing.Size(119, 16);
            tenLoaiPhongLabel.TabIndex = 71;
            tenLoaiPhongLabel.Text = "TÊN LOẠI PHÒNG";
            // 
            // giaLabel
            // 
            giaLabel.AutoSize = true;
            giaLabel.Location = new System.Drawing.Point(74, 265);
            giaLabel.Name = "giaLabel";
            giaLabel.Size = new System.Drawing.Size(29, 16);
            giaLabel.TabIndex = 73;
            giaLabel.Text = "GIÁ";
            // 
            // soNguoiToiDaLabel
            // 
            soNguoiToiDaLabel.AutoSize = true;
            soNguoiToiDaLabel.Location = new System.Drawing.Point(74, 293);
            soNguoiToiDaLabel.Name = "soNguoiToiDaLabel";
            soNguoiToiDaLabel.Size = new System.Drawing.Size(118, 16);
            soNguoiToiDaLabel.TabIndex = 75;
            soNguoiToiDaLabel.Text = "SỐ NGƯỜI TỐI ĐA";
            // 
            // txtTimKiemLoaiPhong
            // 
            this.txtTimKiemLoaiPhong.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTimKiemLoaiPhong.Location = new System.Drawing.Point(578, 171);
            this.txtTimKiemLoaiPhong.Name = "txtTimKiemLoaiPhong";
            this.txtTimKiemLoaiPhong.Size = new System.Drawing.Size(603, 22);
            this.txtTimKiemLoaiPhong.TabIndex = 68;
            this.txtTimKiemLoaiPhong.TextChanged += new System.EventHandler(this.txtTimKiemLoaiPhong_TextChanged);
            // 
            // btnClearLoaiPhong
            // 
            this.btnClearLoaiPhong.Location = new System.Drawing.Point(751, 636);
            this.btnClearLoaiPhong.Name = "btnClearLoaiPhong";
            this.btnClearLoaiPhong.Size = new System.Drawing.Size(182, 50);
            this.btnClearLoaiPhong.TabIndex = 57;
            this.btnClearLoaiPhong.Text = "Xóa Dữ Liệu";
            this.btnClearLoaiPhong.UseVisualStyleBackColor = true;
            this.btnClearLoaiPhong.Click += new System.EventHandler(this.btnClearLoaiPhong_Click);
            // 
            // btnXoaLoaiPhong
            // 
            this.btnXoaLoaiPhong.Location = new System.Drawing.Point(600, 636);
            this.btnXoaLoaiPhong.Name = "btnXoaLoaiPhong";
            this.btnXoaLoaiPhong.Size = new System.Drawing.Size(122, 50);
            this.btnXoaLoaiPhong.TabIndex = 56;
            this.btnXoaLoaiPhong.Text = "Xóa";
            this.btnXoaLoaiPhong.UseVisualStyleBackColor = true;
            this.btnXoaLoaiPhong.Click += new System.EventHandler(this.btnXoaLoaiPhong_Click);
            // 
            // btnSuaLoaiPhong
            // 
            this.btnSuaLoaiPhong.Location = new System.Drawing.Point(439, 636);
            this.btnSuaLoaiPhong.Name = "btnSuaLoaiPhong";
            this.btnSuaLoaiPhong.Size = new System.Drawing.Size(122, 50);
            this.btnSuaLoaiPhong.TabIndex = 55;
            this.btnSuaLoaiPhong.Text = "Sửa";
            this.btnSuaLoaiPhong.UseVisualStyleBackColor = true;
            this.btnSuaLoaiPhong.Click += new System.EventHandler(this.btnSuaLoaiPhong_Click);
            // 
            // btnThemLoaiPhong
            // 
            this.btnThemLoaiPhong.Location = new System.Drawing.Point(290, 636);
            this.btnThemLoaiPhong.Name = "btnThemLoaiPhong";
            this.btnThemLoaiPhong.Size = new System.Drawing.Size(122, 50);
            this.btnThemLoaiPhong.TabIndex = 54;
            this.btnThemLoaiPhong.Text = "Thêm";
            this.btnThemLoaiPhong.UseVisualStyleBackColor = true;
            this.btnThemLoaiPhong.Click += new System.EventHandler(this.btnThemLoaiPhong_Click);
            // 
            // btnTroLaiLoaiPhong
            // 
            this.btnTroLaiLoaiPhong.Location = new System.Drawing.Point(86, 101);
            this.btnTroLaiLoaiPhong.Name = "btnTroLaiLoaiPhong";
            this.btnTroLaiLoaiPhong.Size = new System.Drawing.Size(75, 23);
            this.btnTroLaiLoaiPhong.TabIndex = 53;
            this.btnTroLaiLoaiPhong.Text = "Trở lại";
            this.btnTroLaiLoaiPhong.UseVisualStyleBackColor = true;
            // 
            // data_LoaiPhong
            // 
            this.data_LoaiPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_LoaiPhong.Location = new System.Drawing.Point(578, 199);
            this.data_LoaiPhong.Name = "data_LoaiPhong";
            this.data_LoaiPhong.RowHeadersWidth = 51;
            this.data_LoaiPhong.RowTemplate.Height = 24;
            this.data_LoaiPhong.Size = new System.Drawing.Size(599, 393);
            this.data_LoaiPhong.TabIndex = 52;
            this.data_LoaiPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_LoaiPhong_CellClick);
            this.data_LoaiPhong.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.data_LoaiPhong_CellFormatting);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(473, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 29);
            this.label1.TabIndex = 51;
            this.label1.Text = "QUẢN LÝ THÔNG TIN LOẠI PHÒNG";
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
            this.tableAdapterManager.LOAI_PHONGTableAdapter = this.lOAI_PHONGTableAdapter;
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
            // lOAI_PHONGTableAdapter
            // 
            this.lOAI_PHONGTableAdapter.ClearBeforeFill = true;
            // 
            // lOAI_PHONGBindingSource
            // 
            this.lOAI_PHONGBindingSource.DataMember = "LOAI_PHONG";
            this.lOAI_PHONGBindingSource.DataSource = this.heThongKhachSanDataSet;
            // 
            // maLoaiPhongTextBox
            // 
            this.maLoaiPhongTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOAI_PHONGBindingSource, "MaLoaiPhong", true));
            this.maLoaiPhongTextBox.Enabled = false;
            this.maLoaiPhongTextBox.Location = new System.Drawing.Point(199, 206);
            this.maLoaiPhongTextBox.Name = "maLoaiPhongTextBox";
            this.maLoaiPhongTextBox.Size = new System.Drawing.Size(272, 22);
            this.maLoaiPhongTextBox.TabIndex = 70;
            // 
            // tenLoaiPhongTextBox
            // 
            this.tenLoaiPhongTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOAI_PHONGBindingSource, "TenLoaiPhong", true));
            this.tenLoaiPhongTextBox.Location = new System.Drawing.Point(199, 234);
            this.tenLoaiPhongTextBox.Name = "tenLoaiPhongTextBox";
            this.tenLoaiPhongTextBox.Size = new System.Drawing.Size(272, 22);
            this.tenLoaiPhongTextBox.TabIndex = 72;
            // 
            // giaTextBox
            // 
            this.giaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOAI_PHONGBindingSource, "Gia", true));
            this.giaTextBox.Location = new System.Drawing.Point(199, 262);
            this.giaTextBox.Name = "giaTextBox";
            this.giaTextBox.Size = new System.Drawing.Size(272, 22);
            this.giaTextBox.TabIndex = 74;
            // 
            // soNguoiToiDaTextBox
            // 
            this.soNguoiToiDaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOAI_PHONGBindingSource, "SoNguoiToiDa", true));
            this.soNguoiToiDaTextBox.Location = new System.Drawing.Point(199, 290);
            this.soNguoiToiDaTextBox.Name = "soNguoiToiDaTextBox";
            this.soNguoiToiDaTextBox.Size = new System.Drawing.Size(272, 22);
            this.soNguoiToiDaTextBox.TabIndex = 76;
            // 
            // ufrm_CRUDLoaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(maLoaiPhongLabel);
            this.Controls.Add(this.maLoaiPhongTextBox);
            this.Controls.Add(tenLoaiPhongLabel);
            this.Controls.Add(this.tenLoaiPhongTextBox);
            this.Controls.Add(giaLabel);
            this.Controls.Add(this.giaTextBox);
            this.Controls.Add(soNguoiToiDaLabel);
            this.Controls.Add(this.soNguoiToiDaTextBox);
            this.Controls.Add(this.txtTimKiemLoaiPhong);
            this.Controls.Add(this.btnClearLoaiPhong);
            this.Controls.Add(this.btnXoaLoaiPhong);
            this.Controls.Add(this.btnSuaLoaiPhong);
            this.Controls.Add(this.btnThemLoaiPhong);
            this.Controls.Add(this.btnTroLaiLoaiPhong);
            this.Controls.Add(this.data_LoaiPhong);
            this.Controls.Add(this.label1);
            this.Name = "ufrm_CRUDLoaiPhong";
            this.Size = new System.Drawing.Size(1250, 830);
            ((System.ComponentModel.ISupportInitialize)(this.data_LoaiPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heThongKhachSanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACH_HANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAI_PHONGBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTimKiemLoaiPhong;
        private System.Windows.Forms.Button btnClearLoaiPhong;
        private System.Windows.Forms.Button btnXoaLoaiPhong;
        private System.Windows.Forms.Button btnSuaLoaiPhong;
        private System.Windows.Forms.Button btnThemLoaiPhong;
        private System.Windows.Forms.Button btnTroLaiLoaiPhong;
        private System.Windows.Forms.DataGridView data_LoaiPhong;
        private System.Windows.Forms.Label label1;
        private HeThongKhachSanDataSet heThongKhachSanDataSet;
        private System.Windows.Forms.BindingSource kHACH_HANGBindingSource;
        private HeThongKhachSanDataSetTableAdapters.KHACH_HANGTableAdapter kHACH_HANGTableAdapter;
        private HeThongKhachSanDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private HeThongKhachSanDataSetTableAdapters.LOAI_PHONGTableAdapter lOAI_PHONGTableAdapter;
        private System.Windows.Forms.BindingSource lOAI_PHONGBindingSource;
        private System.Windows.Forms.TextBox maLoaiPhongTextBox;
        private System.Windows.Forms.TextBox tenLoaiPhongTextBox;
        private System.Windows.Forms.TextBox giaTextBox;
        private System.Windows.Forms.TextBox soNguoiToiDaTextBox;
    }
}
