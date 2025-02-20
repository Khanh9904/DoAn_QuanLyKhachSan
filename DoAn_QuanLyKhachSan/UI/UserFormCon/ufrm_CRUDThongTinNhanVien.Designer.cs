namespace DoAn_QuanLyKhachSan.UI.UserFormPhu
{
    partial class ufrm_CRUDThongTinNhanVien
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
            System.Windows.Forms.Label iD_NHANVIENLabel;
            System.Windows.Forms.Label hOTENLabel;
            System.Windows.Forms.Label nGAYSINHLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label sDTLabel;
            System.Windows.Forms.Label tONGNGAYCONGLabel;
            System.Windows.Forms.Label tONGLUONGLabel;
            System.Windows.Forms.Label iD_TAIKHOANLabel;
            this.txtTimKiemNhanVien = new System.Windows.Forms.TextBox();
            this.btnClearNhanVien = new System.Windows.Forms.Button();
            this.btnXoaNhanVien = new System.Windows.Forms.Button();
            this.btnSuaNhanVien = new System.Windows.Forms.Button();
            this.btnThemNhanVien = new System.Windows.Forms.Button();
            this.btnTroLaiNhanVien = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.heThongKhachSanDataSet = new DoAn_QuanLyKhachSan.HeThongKhachSanDataSet();
            this.nHAN_VIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nHAN_VIENTableAdapter = new DoAn_QuanLyKhachSan.HeThongKhachSanDataSetTableAdapters.NHAN_VIENTableAdapter();
            this.tableAdapterManager = new DoAn_QuanLyKhachSan.HeThongKhachSanDataSetTableAdapters.TableAdapterManager();
            this.heThongKhachSanDataSet1 = new DoAn_QuanLyKhachSan.HeThongKhachSanDataSet();
            this.iD_NHANVIENTextBox = new System.Windows.Forms.TextBox();
            this.hOTENTextBox = new System.Windows.Forms.TextBox();
            this.nGAYSINHDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dIACHITextBox = new System.Windows.Forms.TextBox();
            this.sDTTextBox = new System.Windows.Forms.TextBox();
            this.tONGNGAYCONGTextBox = new System.Windows.Forms.TextBox();
            this.tONGLUONGTextBox = new System.Windows.Forms.TextBox();
            this.cbIDTaiKhoan = new System.Windows.Forms.ComboBox();
            this.data_NhanVien = new System.Windows.Forms.DataGridView();
            iD_NHANVIENLabel = new System.Windows.Forms.Label();
            hOTENLabel = new System.Windows.Forms.Label();
            nGAYSINHLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            sDTLabel = new System.Windows.Forms.Label();
            tONGNGAYCONGLabel = new System.Windows.Forms.Label();
            tONGLUONGLabel = new System.Windows.Forms.Label();
            iD_TAIKHOANLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.heThongKhachSanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHAN_VIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heThongKhachSanDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_NhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_NHANVIENLabel
            // 
            iD_NHANVIENLabel.AutoSize = true;
            iD_NHANVIENLabel.Location = new System.Drawing.Point(87, 268);
            iD_NHANVIENLabel.Name = "iD_NHANVIENLabel";
            iD_NHANVIENLabel.Size = new System.Drawing.Size(96, 16);
            iD_NHANVIENLabel.TabIndex = 43;
            iD_NHANVIENLabel.Text = "ID NHANVIEN:";
            // 
            // hOTENLabel
            // 
            hOTENLabel.AutoSize = true;
            hOTENLabel.Location = new System.Drawing.Point(87, 296);
            hOTENLabel.Name = "hOTENLabel";
            hOTENLabel.Size = new System.Drawing.Size(58, 16);
            hOTENLabel.TabIndex = 45;
            hOTENLabel.Text = "HOTEN:";
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.Location = new System.Drawing.Point(87, 325);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(80, 16);
            nGAYSINHLabel.TabIndex = 47;
            nGAYSINHLabel.Text = "NGAYSINH:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(87, 352);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(54, 16);
            dIACHILabel.TabIndex = 49;
            dIACHILabel.Text = "DIACHI:";
            // 
            // sDTLabel
            // 
            sDTLabel.AutoSize = true;
            sDTLabel.Location = new System.Drawing.Point(87, 380);
            sDTLabel.Name = "sDTLabel";
            sDTLabel.Size = new System.Drawing.Size(38, 16);
            sDTLabel.TabIndex = 51;
            sDTLabel.Text = "SDT:";
            // 
            // tONGNGAYCONGLabel
            // 
            tONGNGAYCONGLabel.AutoSize = true;
            tONGNGAYCONGLabel.Location = new System.Drawing.Point(87, 408);
            tONGNGAYCONGLabel.Name = "tONGNGAYCONGLabel";
            tONGNGAYCONGLabel.Size = new System.Drawing.Size(126, 16);
            tONGNGAYCONGLabel.TabIndex = 53;
            tONGNGAYCONGLabel.Text = "TONGNGAYCONG:";
            // 
            // tONGLUONGLabel
            // 
            tONGLUONGLabel.AutoSize = true;
            tONGLUONGLabel.Location = new System.Drawing.Point(87, 436);
            tONGLUONGLabel.Name = "tONGLUONGLabel";
            tONGLUONGLabel.Size = new System.Drawing.Size(96, 16);
            tONGLUONGLabel.TabIndex = 55;
            tONGLUONGLabel.Text = "TONGLUONG:";
            // 
            // iD_TAIKHOANLabel
            // 
            iD_TAIKHOANLabel.AutoSize = true;
            iD_TAIKHOANLabel.Location = new System.Drawing.Point(87, 464);
            iD_TAIKHOANLabel.Name = "iD_TAIKHOANLabel";
            iD_TAIKHOANLabel.Size = new System.Drawing.Size(94, 16);
            iD_TAIKHOANLabel.TabIndex = 57;
            iD_TAIKHOANLabel.Text = "ID TAIKHOAN:";
            // 
            // txtTimKiemNhanVien
            // 
            this.txtTimKiemNhanVien.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTimKiemNhanVien.Location = new System.Drawing.Point(461, 213);
            this.txtTimKiemNhanVien.Name = "txtTimKiemNhanVien";
            this.txtTimKiemNhanVien.Size = new System.Drawing.Size(703, 22);
            this.txtTimKiemNhanVien.TabIndex = 32;
            this.txtTimKiemNhanVien.TextChanged += new System.EventHandler(this.txtTimKiemNhanVien_TextChanged);
            // 
            // btnClearNhanVien
            // 
            this.btnClearNhanVien.Location = new System.Drawing.Point(653, 634);
            this.btnClearNhanVien.Name = "btnClearNhanVien";
            this.btnClearNhanVien.Size = new System.Drawing.Size(135, 23);
            this.btnClearNhanVien.TabIndex = 30;
            this.btnClearNhanVien.Text = "Xóa Dữ Liệu";
            this.btnClearNhanVien.UseVisualStyleBackColor = true;
            this.btnClearNhanVien.Click += new System.EventHandler(this.btnClearNhanVien_Click);
            // 
            // btnXoaNhanVien
            // 
            this.btnXoaNhanVien.Location = new System.Drawing.Point(502, 634);
            this.btnXoaNhanVien.Name = "btnXoaNhanVien";
            this.btnXoaNhanVien.Size = new System.Drawing.Size(75, 23);
            this.btnXoaNhanVien.TabIndex = 29;
            this.btnXoaNhanVien.Text = "Xóa";
            this.btnXoaNhanVien.UseVisualStyleBackColor = true;
            this.btnXoaNhanVien.Click += new System.EventHandler(this.btnXoaNhanVien_Click);
            // 
            // btnSuaNhanVien
            // 
            this.btnSuaNhanVien.Location = new System.Drawing.Point(341, 634);
            this.btnSuaNhanVien.Name = "btnSuaNhanVien";
            this.btnSuaNhanVien.Size = new System.Drawing.Size(75, 23);
            this.btnSuaNhanVien.TabIndex = 28;
            this.btnSuaNhanVien.Text = "Sửa";
            this.btnSuaNhanVien.UseVisualStyleBackColor = true;
            this.btnSuaNhanVien.Click += new System.EventHandler(this.btnSuaNhanVien_Click);
            // 
            // btnThemNhanVien
            // 
            this.btnThemNhanVien.Location = new System.Drawing.Point(192, 634);
            this.btnThemNhanVien.Name = "btnThemNhanVien";
            this.btnThemNhanVien.Size = new System.Drawing.Size(75, 23);
            this.btnThemNhanVien.TabIndex = 27;
            this.btnThemNhanVien.Text = "Thêm";
            this.btnThemNhanVien.UseVisualStyleBackColor = true;
            this.btnThemNhanVien.Click += new System.EventHandler(this.btnThemNhanVien_Click);
            // 
            // btnTroLaiNhanVien
            // 
            this.btnTroLaiNhanVien.Location = new System.Drawing.Point(90, 174);
            this.btnTroLaiNhanVien.Name = "btnTroLaiNhanVien";
            this.btnTroLaiNhanVien.Size = new System.Drawing.Size(75, 23);
            this.btnTroLaiNhanVien.TabIndex = 18;
            this.btnTroLaiNhanVien.Text = "Trở lại";
            this.btnTroLaiNhanVien.UseVisualStyleBackColor = true;
            this.btnTroLaiNhanVien.Click += new System.EventHandler(this.btnTroLaiNhanVien_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(488, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // heThongKhachSanDataSet
            // 
            this.heThongKhachSanDataSet.DataSetName = "HeThongKhachSanDataSet";
            this.heThongKhachSanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nHAN_VIENBindingSource
            // 
            this.nHAN_VIENBindingSource.DataMember = "NHAN_VIEN";
            this.nHAN_VIENBindingSource.DataSource = this.heThongKhachSanDataSet;
            // 
            // nHAN_VIENTableAdapter
            // 
            this.nHAN_VIENTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.NHAN_VIENTableAdapter = this.nHAN_VIENTableAdapter;
            this.tableAdapterManager.PHANCONGCALAMTableAdapter = null;
            this.tableAdapterManager.PHANQUYENTableAdapter = null;
            this.tableAdapterManager.PHIEU_DAT_PHONGTableAdapter = null;
            this.tableAdapterManager.PHONGTableAdapter = null;
            this.tableAdapterManager.TAIKHOANTableAdapter = null;
            this.tableAdapterManager.TangLauTableAdapter = null;
            this.tableAdapterManager.THIET_BITableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DoAn_QuanLyKhachSan.HeThongKhachSanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // heThongKhachSanDataSet1
            // 
            this.heThongKhachSanDataSet1.DataSetName = "HeThongKhachSanDataSet";
            this.heThongKhachSanDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iD_NHANVIENTextBox
            // 
            this.iD_NHANVIENTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHAN_VIENBindingSource, "ID_NHANVIEN", true));
            this.iD_NHANVIENTextBox.Location = new System.Drawing.Point(219, 265);
            this.iD_NHANVIENTextBox.Name = "iD_NHANVIENTextBox";
            this.iD_NHANVIENTextBox.Size = new System.Drawing.Size(200, 22);
            this.iD_NHANVIENTextBox.TabIndex = 44;
            // 
            // hOTENTextBox
            // 
            this.hOTENTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHAN_VIENBindingSource, "HOTEN", true));
            this.hOTENTextBox.Location = new System.Drawing.Point(219, 293);
            this.hOTENTextBox.Name = "hOTENTextBox";
            this.hOTENTextBox.Size = new System.Drawing.Size(200, 22);
            this.hOTENTextBox.TabIndex = 46;
            // 
            // nGAYSINHDateTimePicker
            // 
            this.nGAYSINHDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.nHAN_VIENBindingSource, "NGAYSINH", true));
            this.nGAYSINHDateTimePicker.Location = new System.Drawing.Point(219, 321);
            this.nGAYSINHDateTimePicker.Name = "nGAYSINHDateTimePicker";
            this.nGAYSINHDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.nGAYSINHDateTimePicker.TabIndex = 48;
            // 
            // dIACHITextBox
            // 
            this.dIACHITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHAN_VIENBindingSource, "DIACHI", true));
            this.dIACHITextBox.Location = new System.Drawing.Point(219, 349);
            this.dIACHITextBox.Name = "dIACHITextBox";
            this.dIACHITextBox.Size = new System.Drawing.Size(200, 22);
            this.dIACHITextBox.TabIndex = 50;
            // 
            // sDTTextBox
            // 
            this.sDTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHAN_VIENBindingSource, "SDT", true));
            this.sDTTextBox.Location = new System.Drawing.Point(219, 377);
            this.sDTTextBox.Name = "sDTTextBox";
            this.sDTTextBox.Size = new System.Drawing.Size(200, 22);
            this.sDTTextBox.TabIndex = 52;
            // 
            // tONGNGAYCONGTextBox
            // 
            this.tONGNGAYCONGTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHAN_VIENBindingSource, "TONGNGAYCONG", true));
            this.tONGNGAYCONGTextBox.Location = new System.Drawing.Point(219, 405);
            this.tONGNGAYCONGTextBox.Name = "tONGNGAYCONGTextBox";
            this.tONGNGAYCONGTextBox.Size = new System.Drawing.Size(200, 22);
            this.tONGNGAYCONGTextBox.TabIndex = 54;
            // 
            // tONGLUONGTextBox
            // 
            this.tONGLUONGTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHAN_VIENBindingSource, "TONGLUONG", true));
            this.tONGLUONGTextBox.Location = new System.Drawing.Point(219, 433);
            this.tONGLUONGTextBox.Name = "tONGLUONGTextBox";
            this.tONGLUONGTextBox.Size = new System.Drawing.Size(200, 22);
            this.tONGLUONGTextBox.TabIndex = 56;
            // 
            // cbIDTaiKhoan
            // 
            this.cbIDTaiKhoan.FormattingEnabled = true;
            this.cbIDTaiKhoan.Location = new System.Drawing.Point(219, 461);
            this.cbIDTaiKhoan.Name = "cbIDTaiKhoan";
            this.cbIDTaiKhoan.Size = new System.Drawing.Size(197, 24);
            this.cbIDTaiKhoan.TabIndex = 58;
            this.cbIDTaiKhoan.SelectedIndexChanged += new System.EventHandler(this.cbIDTaiKhoan_SelectedIndexChanged);
            // 
            // data_NhanVien
            // 
            this.data_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_NhanVien.Location = new System.Drawing.Point(461, 249);
            this.data_NhanVien.Name = "data_NhanVien";
            this.data_NhanVien.RowHeadersWidth = 51;
            this.data_NhanVien.RowTemplate.Height = 24;
            this.data_NhanVien.Size = new System.Drawing.Size(845, 352);
            this.data_NhanVien.TabIndex = 59;
            this.data_NhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_NhanVien_CellClick);
            // 
            // ufrm_CRUDThongTinNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.data_NhanVien);
            this.Controls.Add(this.cbIDTaiKhoan);
            this.Controls.Add(iD_NHANVIENLabel);
            this.Controls.Add(this.iD_NHANVIENTextBox);
            this.Controls.Add(hOTENLabel);
            this.Controls.Add(this.hOTENTextBox);
            this.Controls.Add(nGAYSINHLabel);
            this.Controls.Add(this.nGAYSINHDateTimePicker);
            this.Controls.Add(dIACHILabel);
            this.Controls.Add(this.dIACHITextBox);
            this.Controls.Add(sDTLabel);
            this.Controls.Add(this.sDTTextBox);
            this.Controls.Add(tONGNGAYCONGLabel);
            this.Controls.Add(this.tONGNGAYCONGTextBox);
            this.Controls.Add(tONGLUONGLabel);
            this.Controls.Add(this.tONGLUONGTextBox);
            this.Controls.Add(iD_TAIKHOANLabel);
            this.Controls.Add(this.txtTimKiemNhanVien);
            this.Controls.Add(this.btnClearNhanVien);
            this.Controls.Add(this.btnXoaNhanVien);
            this.Controls.Add(this.btnSuaNhanVien);
            this.Controls.Add(this.btnThemNhanVien);
            this.Controls.Add(this.btnTroLaiNhanVien);
            this.Controls.Add(this.label1);
            this.Name = "ufrm_CRUDThongTinNhanVien";
            this.Size = new System.Drawing.Size(1250, 830);
            ((System.ComponentModel.ISupportInitialize)(this.heThongKhachSanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHAN_VIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heThongKhachSanDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_NhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTimKiemNhanVien;
        private System.Windows.Forms.Button btnClearNhanVien;
        private System.Windows.Forms.Button btnXoaNhanVien;
        private System.Windows.Forms.Button btnSuaNhanVien;
        private System.Windows.Forms.Button btnThemNhanVien;
        private System.Windows.Forms.Button btnTroLaiNhanVien;
        private System.Windows.Forms.Label label1;
        private HeThongKhachSanDataSet heThongKhachSanDataSet;
        private System.Windows.Forms.BindingSource nHAN_VIENBindingSource;
        private HeThongKhachSanDataSetTableAdapters.NHAN_VIENTableAdapter nHAN_VIENTableAdapter;
        private HeThongKhachSanDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private HeThongKhachSanDataSet heThongKhachSanDataSet1;
        private System.Windows.Forms.TextBox iD_NHANVIENTextBox;
        private System.Windows.Forms.TextBox hOTENTextBox;
        private System.Windows.Forms.DateTimePicker nGAYSINHDateTimePicker;
        private System.Windows.Forms.TextBox dIACHITextBox;
        private System.Windows.Forms.TextBox sDTTextBox;
        private System.Windows.Forms.TextBox tONGNGAYCONGTextBox;
        private System.Windows.Forms.TextBox tONGLUONGTextBox;
        private System.Windows.Forms.ComboBox cbIDTaiKhoan;
        private System.Windows.Forms.DataGridView data_NhanVien;
    }
}
