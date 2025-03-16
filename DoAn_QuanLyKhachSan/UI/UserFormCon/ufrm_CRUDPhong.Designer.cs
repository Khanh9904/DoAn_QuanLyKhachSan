namespace DoAn_QuanLyKhachSan.UI.UseForm
{
    partial class ufrm_CRUDPhong
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
            System.Windows.Forms.Label maLoaiPhongLabel;
            System.Windows.Forms.Label tinhTrangLabel;
            System.Windows.Forms.Label tenPhongLabel;
            System.Windows.Forms.Label maPhongLabel;
            this.tinhTrangTextBox = new System.Windows.Forms.ComboBox();
            this.txtTimKiemPhong = new System.Windows.Forms.TextBox();
            this.cbTang = new System.Windows.Forms.ComboBox();
            this.cbMaLoaiPhong = new System.Windows.Forms.ComboBox();
            this.btnThemPhong = new System.Windows.Forms.Button();
            this.btnSuaPhong = new System.Windows.Forms.Button();
            this.btnXoaPhong = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tenPhongTextBox = new System.Windows.Forms.TextBox();
            this.maPhongTextBox = new System.Windows.Forms.TextBox();
            this.tableAdapterManager = new DoAn_QuanLyKhachSan.HeThongKhachSanDataSetTableAdapters.TableAdapterManager();
            this.pHONGTableAdapter = new DoAn_QuanLyKhachSan.HeThongKhachSanDataSetTableAdapters.PHONGTableAdapter();
            this.pHONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.heThongKhachSanDataSet = new DoAn_QuanLyKhachSan.HeThongKhachSanDataSet();
            this.data_Phong = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            maThietBiLabel = new System.Windows.Forms.Label();
            maLoaiPhongLabel = new System.Windows.Forms.Label();
            tinhTrangLabel = new System.Windows.Forms.Label();
            tenPhongLabel = new System.Windows.Forms.Label();
            maPhongLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heThongKhachSanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_Phong)).BeginInit();
            this.SuspendLayout();
            // 
            // maThietBiLabel
            // 
            maThietBiLabel.AutoSize = true;
            maThietBiLabel.Location = new System.Drawing.Point(42, 302);
            maThietBiLabel.Name = "maThietBiLabel";
            maThietBiLabel.Size = new System.Drawing.Size(68, 16);
            maThietBiLabel.TabIndex = 11;
            maThietBiLabel.Text = "MÃ TẦNG";
            maThietBiLabel.Click += new System.EventHandler(this.maThietBiLabel_Click);
            // 
            // maLoaiPhongLabel
            // 
            maLoaiPhongLabel.AutoSize = true;
            maLoaiPhongLabel.Location = new System.Drawing.Point(42, 274);
            maLoaiPhongLabel.Name = "maLoaiPhongLabel";
            maLoaiPhongLabel.Size = new System.Drawing.Size(111, 16);
            maLoaiPhongLabel.TabIndex = 9;
            maLoaiPhongLabel.Text = "MÃ LOẠI PHÒNG";
            // 
            // tinhTrangLabel
            // 
            tinhTrangLabel.AutoSize = true;
            tinhTrangLabel.Location = new System.Drawing.Point(42, 246);
            tinhTrangLabel.Name = "tinhTrangLabel";
            tinhTrangLabel.Size = new System.Drawing.Size(90, 16);
            tinhTrangLabel.TabIndex = 7;
            tinhTrangLabel.Text = "TINH TRANG";
            // 
            // tenPhongLabel
            // 
            tenPhongLabel.AutoSize = true;
            tenPhongLabel.Location = new System.Drawing.Point(42, 218);
            tenPhongLabel.Name = "tenPhongLabel";
            tenPhongLabel.Size = new System.Drawing.Size(87, 16);
            tenPhongLabel.TabIndex = 5;
            tenPhongLabel.Text = "TÊN PHÒNG";
            // 
            // maPhongLabel
            // 
            maPhongLabel.AutoSize = true;
            maPhongLabel.Location = new System.Drawing.Point(42, 190);
            maPhongLabel.Name = "maPhongLabel";
            maPhongLabel.Size = new System.Drawing.Size(79, 16);
            maPhongLabel.TabIndex = 3;
            maPhongLabel.Text = "MÃ PHÒNG";
            // 
            // tinhTrangTextBox
            // 
            this.tinhTrangTextBox.FormattingEnabled = true;
            this.tinhTrangTextBox.Items.AddRange(new object[] {
            "Đang sử dụng",
            "Trống"});
            this.tinhTrangTextBox.Location = new System.Drawing.Point(183, 243);
            this.tinhTrangTextBox.Name = "tinhTrangTextBox";
            this.tinhTrangTextBox.Size = new System.Drawing.Size(237, 24);
            this.tinhTrangTextBox.TabIndex = 25;
            // 
            // txtTimKiemPhong
            // 
            this.txtTimKiemPhong.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTimKiemPhong.Location = new System.Drawing.Point(478, 147);
            this.txtTimKiemPhong.Name = "txtTimKiemPhong";
            this.txtTimKiemPhong.Size = new System.Drawing.Size(775, 22);
            this.txtTimKiemPhong.TabIndex = 24;
            this.txtTimKiemPhong.TextChanged += new System.EventHandler(this.txtTimKiemPhong_TextChanged);
            // 
            // cbTang
            // 
            this.cbTang.FormattingEnabled = true;
            this.cbTang.Location = new System.Drawing.Point(183, 301);
            this.cbTang.Name = "cbTang";
            this.cbTang.Size = new System.Drawing.Size(237, 24);
            this.cbTang.TabIndex = 22;
            // 
            // cbMaLoaiPhong
            // 
            this.cbMaLoaiPhong.FormattingEnabled = true;
            this.cbMaLoaiPhong.Location = new System.Drawing.Point(183, 271);
            this.cbMaLoaiPhong.Name = "cbMaLoaiPhong";
            this.cbMaLoaiPhong.Size = new System.Drawing.Size(237, 24);
            this.cbMaLoaiPhong.TabIndex = 21;
            // 
            // btnThemPhong
            // 
            this.btnThemPhong.Location = new System.Drawing.Point(297, 617);
            this.btnThemPhong.Name = "btnThemPhong";
            this.btnThemPhong.Size = new System.Drawing.Size(123, 49);
            this.btnThemPhong.TabIndex = 17;
            this.btnThemPhong.Text = "Thêm";
            this.btnThemPhong.UseVisualStyleBackColor = true;
            this.btnThemPhong.Click += new System.EventHandler(this.btnThemPhong_Click);
            // 
            // btnSuaPhong
            // 
            this.btnSuaPhong.Location = new System.Drawing.Point(446, 617);
            this.btnSuaPhong.Name = "btnSuaPhong";
            this.btnSuaPhong.Size = new System.Drawing.Size(123, 49);
            this.btnSuaPhong.TabIndex = 18;
            this.btnSuaPhong.Text = "Sửa";
            this.btnSuaPhong.UseVisualStyleBackColor = true;
            this.btnSuaPhong.Click += new System.EventHandler(this.btnSuaPhong_Click);
            // 
            // btnXoaPhong
            // 
            this.btnXoaPhong.Location = new System.Drawing.Point(607, 617);
            this.btnXoaPhong.Name = "btnXoaPhong";
            this.btnXoaPhong.Size = new System.Drawing.Size(123, 49);
            this.btnXoaPhong.TabIndex = 19;
            this.btnXoaPhong.Text = "Xóa";
            this.btnXoaPhong.UseVisualStyleBackColor = true;
            this.btnXoaPhong.Click += new System.EventHandler(this.btnXoaPhong_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(758, 617);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(183, 49);
            this.button5.TabIndex = 20;
            this.button5.Text = "Xóa Dữ Liệu";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // tenPhongTextBox
            // 
            this.tenPhongTextBox.Location = new System.Drawing.Point(183, 212);
            this.tenPhongTextBox.Name = "tenPhongTextBox";
            this.tenPhongTextBox.Size = new System.Drawing.Size(237, 22);
            this.tenPhongTextBox.TabIndex = 6;
            // 
            // maPhongTextBox
            // 
            this.maPhongTextBox.Enabled = false;
            this.maPhongTextBox.Location = new System.Drawing.Point(183, 184);
            this.maPhongTextBox.Name = "maPhongTextBox";
            this.maPhongTextBox.Size = new System.Drawing.Size(237, 22);
            this.maPhongTextBox.TabIndex = 4;
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
            this.tableAdapterManager.PHONGTableAdapter = this.pHONGTableAdapter;
            this.tableAdapterManager.TAIKHOANTableAdapter = null;
            this.tableAdapterManager.TangLauTableAdapter = null;
            this.tableAdapterManager.THIET_BITableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DoAn_QuanLyKhachSan.HeThongKhachSanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pHONGTableAdapter
            // 
            this.pHONGTableAdapter.ClearBeforeFill = true;
            // 
            // pHONGBindingSource
            // 
            this.pHONGBindingSource.DataMember = "PHONG";
            // 
            // heThongKhachSanDataSet
            // 
            this.heThongKhachSanDataSet.DataSetName = "HeThongKhachSanDataSet";
            this.heThongKhachSanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // data_Phong
            // 
            this.data_Phong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Phong.Location = new System.Drawing.Point(478, 175);
            this.data_Phong.Name = "data_Phong";
            this.data_Phong.RowHeadersWidth = 51;
            this.data_Phong.RowTemplate.Height = 24;
            this.data_Phong.Size = new System.Drawing.Size(769, 393);
            this.data_Phong.TabIndex = 2;
            this.data_Phong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_Phong_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(458, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ THÔNG TIN PHÒNG";
            // 
            // ufrm_CRUDPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tinhTrangTextBox);
            this.Controls.Add(this.txtTimKiemPhong);
            this.Controls.Add(this.cbTang);
            this.Controls.Add(this.cbMaLoaiPhong);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnXoaPhong);
            this.Controls.Add(this.btnSuaPhong);
            this.Controls.Add(this.btnThemPhong);
            this.Controls.Add(maPhongLabel);
            this.Controls.Add(this.maPhongTextBox);
            this.Controls.Add(tenPhongLabel);
            this.Controls.Add(this.tenPhongTextBox);
            this.Controls.Add(tinhTrangLabel);
            this.Controls.Add(maLoaiPhongLabel);
            this.Controls.Add(maThietBiLabel);
            this.Controls.Add(this.data_Phong);
            this.Controls.Add(this.label1);
            this.Name = "ufrm_CRUDPhong";
            this.Size = new System.Drawing.Size(1250, 830);
            this.Load += new System.EventHandler(this.ufrm_CRUDPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heThongKhachSanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_Phong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox tinhTrangTextBox;
        private System.Windows.Forms.TextBox txtTimKiemPhong;
        private System.Windows.Forms.ComboBox cbTang;
        private System.Windows.Forms.ComboBox cbMaLoaiPhong;
        private System.Windows.Forms.Button btnThemPhong;
        private System.Windows.Forms.Button btnSuaPhong;
        private System.Windows.Forms.Button btnXoaPhong;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox tenPhongTextBox;
        private System.Windows.Forms.TextBox maPhongTextBox;
        private HeThongKhachSanDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private HeThongKhachSanDataSetTableAdapters.PHONGTableAdapter pHONGTableAdapter;
        private System.Windows.Forms.BindingSource pHONGBindingSource;
        private HeThongKhachSanDataSet heThongKhachSanDataSet;
        private System.Windows.Forms.DataGridView data_Phong;
        private System.Windows.Forms.Label label1;
    }
}
