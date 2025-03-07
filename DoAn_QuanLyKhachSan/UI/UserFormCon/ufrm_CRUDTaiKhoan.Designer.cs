namespace DoAn_QuanLyKhachSan.UI.UserFormCon
{
    partial class ufrm_CRUDTaiKhoan
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
            System.Windows.Forms.Label iD_TAIKHOANLabel;
            System.Windows.Forms.Label eMAILLabel;
            System.Windows.Forms.Label mATKHAULabel;
            System.Windows.Forms.Label iD_PHANQUYENLabel;
            this.btnClearTaiKhoan = new System.Windows.Forms.Button();
            this.btnXoaTaiKhoan = new System.Windows.Forms.Button();
            this.btnSuaTaiKhoan = new System.Windows.Forms.Button();
            this.btnThemTaiKhoan = new System.Windows.Forms.Button();
            this.btnTroLaiQLTTP = new System.Windows.Forms.Button();
            this.data_TaiKhoan = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.heThongKhachSanDataSet = new DoAn_QuanLyKhachSan.HeThongKhachSanDataSet();
            this.tAIKHOANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tAIKHOANTableAdapter = new DoAn_QuanLyKhachSan.HeThongKhachSanDataSetTableAdapters.TAIKHOANTableAdapter();
            this.tableAdapterManager = new DoAn_QuanLyKhachSan.HeThongKhachSanDataSetTableAdapters.TableAdapterManager();
            this.iD_TAIKHOANTextBox = new System.Windows.Forms.TextBox();
            this.eMAILTextBox = new System.Windows.Forms.TextBox();
            this.mATKHAUTextBox = new System.Windows.Forms.TextBox();
            this.cbIDPhanQuyen = new System.Windows.Forms.ComboBox();
            this.txtTimKiemTaiKhoan = new System.Windows.Forms.TextBox();
            iD_TAIKHOANLabel = new System.Windows.Forms.Label();
            eMAILLabel = new System.Windows.Forms.Label();
            mATKHAULabel = new System.Windows.Forms.Label();
            iD_PHANQUYENLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_TaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heThongKhachSanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAIKHOANBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_TAIKHOANLabel
            // 
            iD_TAIKHOANLabel.AutoSize = true;
            iD_TAIKHOANLabel.Location = new System.Drawing.Point(40, 255);
            iD_TAIKHOANLabel.Name = "iD_TAIKHOANLabel";
            iD_TAIKHOANLabel.Size = new System.Drawing.Size(101, 16);
            iD_TAIKHOANLabel.TabIndex = 40;
            iD_TAIKHOANLabel.Text = "MÃ TÀI KHOẢN";
            iD_TAIKHOANLabel.Click += new System.EventHandler(this.iD_TAIKHOANLabel_Click);
            // 
            // eMAILLabel
            // 
            eMAILLabel.AutoSize = true;
            eMAILLabel.Location = new System.Drawing.Point(40, 283);
            eMAILLabel.Name = "eMAILLabel";
            eMAILLabel.Size = new System.Drawing.Size(46, 16);
            eMAILLabel.TabIndex = 42;
            eMAILLabel.Text = "EMAIL";
            // 
            // mATKHAULabel
            // 
            mATKHAULabel.AutoSize = true;
            mATKHAULabel.Location = new System.Drawing.Point(40, 311);
            mATKHAULabel.Name = "mATKHAULabel";
            mATKHAULabel.Size = new System.Drawing.Size(76, 16);
            mATKHAULabel.TabIndex = 44;
            mATKHAULabel.Text = "MẬT KHẨU";
            // 
            // iD_PHANQUYENLabel
            // 
            iD_PHANQUYENLabel.AutoSize = true;
            iD_PHANQUYENLabel.Location = new System.Drawing.Point(40, 339);
            iD_PHANQUYENLabel.Name = "iD_PHANQUYENLabel";
            iD_PHANQUYENLabel.Size = new System.Drawing.Size(119, 16);
            iD_PHANQUYENLabel.TabIndex = 46;
            iD_PHANQUYENLabel.Text = "MÃ PHÂN QUYỀN";
            // 
            // btnClearTaiKhoan
            // 
            this.btnClearTaiKhoan.Location = new System.Drawing.Point(748, 659);
            this.btnClearTaiKhoan.Name = "btnClearTaiKhoan";
            this.btnClearTaiKhoan.Size = new System.Drawing.Size(194, 58);
            this.btnClearTaiKhoan.TabIndex = 39;
            this.btnClearTaiKhoan.Text = "Xóa Dữ Liệu";
            this.btnClearTaiKhoan.UseVisualStyleBackColor = true;
            this.btnClearTaiKhoan.Click += new System.EventHandler(this.btnClearTaiKhoan_Click);
            // 
            // btnXoaTaiKhoan
            // 
            this.btnXoaTaiKhoan.Location = new System.Drawing.Point(597, 659);
            this.btnXoaTaiKhoan.Name = "btnXoaTaiKhoan";
            this.btnXoaTaiKhoan.Size = new System.Drawing.Size(134, 58);
            this.btnXoaTaiKhoan.TabIndex = 38;
            this.btnXoaTaiKhoan.Text = "Xóa";
            this.btnXoaTaiKhoan.UseVisualStyleBackColor = true;
            this.btnXoaTaiKhoan.Click += new System.EventHandler(this.btnXoaTaiKhoan_Click);
            // 
            // btnSuaTaiKhoan
            // 
            this.btnSuaTaiKhoan.Location = new System.Drawing.Point(436, 659);
            this.btnSuaTaiKhoan.Name = "btnSuaTaiKhoan";
            this.btnSuaTaiKhoan.Size = new System.Drawing.Size(134, 58);
            this.btnSuaTaiKhoan.TabIndex = 37;
            this.btnSuaTaiKhoan.Text = "Sửa";
            this.btnSuaTaiKhoan.UseVisualStyleBackColor = true;
            this.btnSuaTaiKhoan.Click += new System.EventHandler(this.btnSuaTaiKhoan_Click);
            // 
            // btnThemTaiKhoan
            // 
            this.btnThemTaiKhoan.Location = new System.Drawing.Point(287, 659);
            this.btnThemTaiKhoan.Name = "btnThemTaiKhoan";
            this.btnThemTaiKhoan.Size = new System.Drawing.Size(134, 58);
            this.btnThemTaiKhoan.TabIndex = 36;
            this.btnThemTaiKhoan.Text = "Thêm";
            this.btnThemTaiKhoan.UseVisualStyleBackColor = true;
            this.btnThemTaiKhoan.Click += new System.EventHandler(this.btnThemTaiKhoan_Click);
            // 
            // btnTroLaiQLTTP
            // 
            this.btnTroLaiQLTTP.Location = new System.Drawing.Point(50, 124);
            this.btnTroLaiQLTTP.Name = "btnTroLaiQLTTP";
            this.btnTroLaiQLTTP.Size = new System.Drawing.Size(75, 23);
            this.btnTroLaiQLTTP.TabIndex = 35;
            this.btnTroLaiQLTTP.Text = "Trở lại";
            this.btnTroLaiQLTTP.UseVisualStyleBackColor = true;
            this.btnTroLaiQLTTP.Click += new System.EventHandler(this.btnTroLaiQLTTP_Click);
            // 
            // data_TaiKhoan
            // 
            this.data_TaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_TaiKhoan.Location = new System.Drawing.Point(542, 222);
            this.data_TaiKhoan.Name = "data_TaiKhoan";
            this.data_TaiKhoan.RowHeadersWidth = 51;
            this.data_TaiKhoan.RowTemplate.Height = 24;
            this.data_TaiKhoan.Size = new System.Drawing.Size(599, 393);
            this.data_TaiKhoan.TabIndex = 22;
            this.data_TaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_TaiKhoan_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(437, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "QUẢN LÝ THÔNG TIN TÀI KHOẢN";
            // 
            // heThongKhachSanDataSet
            // 
            this.heThongKhachSanDataSet.DataSetName = "HeThongKhachSanDataSet";
            this.heThongKhachSanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tAIKHOANBindingSource
            // 
            this.tAIKHOANBindingSource.DataMember = "TAIKHOAN";
            this.tAIKHOANBindingSource.DataSource = this.heThongKhachSanDataSet;
            // 
            // tAIKHOANTableAdapter
            // 
            this.tAIKHOANTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.TAIKHOANTableAdapter = this.tAIKHOANTableAdapter;
            this.tableAdapterManager.TangLauTableAdapter = null;
            this.tableAdapterManager.THIET_BITableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DoAn_QuanLyKhachSan.HeThongKhachSanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // iD_TAIKHOANTextBox
            // 
            this.iD_TAIKHOANTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAIKHOANBindingSource, "ID_TAIKHOAN", true));
            this.iD_TAIKHOANTextBox.Enabled = false;
            this.iD_TAIKHOANTextBox.Location = new System.Drawing.Point(165, 252);
            this.iD_TAIKHOANTextBox.Name = "iD_TAIKHOANTextBox";
            this.iD_TAIKHOANTextBox.Size = new System.Drawing.Size(302, 22);
            this.iD_TAIKHOANTextBox.TabIndex = 41;
            // 
            // eMAILTextBox
            // 
            this.eMAILTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAIKHOANBindingSource, "EMAIL", true));
            this.eMAILTextBox.Location = new System.Drawing.Point(165, 280);
            this.eMAILTextBox.Name = "eMAILTextBox";
            this.eMAILTextBox.Size = new System.Drawing.Size(302, 22);
            this.eMAILTextBox.TabIndex = 43;
            // 
            // mATKHAUTextBox
            // 
            this.mATKHAUTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAIKHOANBindingSource, "MATKHAU", true));
            this.mATKHAUTextBox.Location = new System.Drawing.Point(165, 308);
            this.mATKHAUTextBox.Name = "mATKHAUTextBox";
            this.mATKHAUTextBox.Size = new System.Drawing.Size(302, 22);
            this.mATKHAUTextBox.TabIndex = 45;
            // 
            // cbIDPhanQuyen
            // 
            this.cbIDPhanQuyen.FormattingEnabled = true;
            this.cbIDPhanQuyen.Location = new System.Drawing.Point(165, 336);
            this.cbIDPhanQuyen.Name = "cbIDPhanQuyen";
            this.cbIDPhanQuyen.Size = new System.Drawing.Size(302, 24);
            this.cbIDPhanQuyen.TabIndex = 47;
            // 
            // txtTimKiemTaiKhoan
            // 
            this.txtTimKiemTaiKhoan.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTimKiemTaiKhoan.Location = new System.Drawing.Point(542, 194);
            this.txtTimKiemTaiKhoan.Name = "txtTimKiemTaiKhoan";
            this.txtTimKiemTaiKhoan.Size = new System.Drawing.Size(599, 22);
            this.txtTimKiemTaiKhoan.TabIndex = 48;
            this.txtTimKiemTaiKhoan.TextChanged += new System.EventHandler(this.txtTimKiemnTaiKhoan_TextChanged);
            // 
            // ufrm_CRUDTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtTimKiemTaiKhoan);
            this.Controls.Add(this.cbIDPhanQuyen);
            this.Controls.Add(iD_TAIKHOANLabel);
            this.Controls.Add(this.iD_TAIKHOANTextBox);
            this.Controls.Add(eMAILLabel);
            this.Controls.Add(this.eMAILTextBox);
            this.Controls.Add(mATKHAULabel);
            this.Controls.Add(this.mATKHAUTextBox);
            this.Controls.Add(iD_PHANQUYENLabel);
            this.Controls.Add(this.btnClearTaiKhoan);
            this.Controls.Add(this.btnXoaTaiKhoan);
            this.Controls.Add(this.btnSuaTaiKhoan);
            this.Controls.Add(this.btnThemTaiKhoan);
            this.Controls.Add(this.btnTroLaiQLTTP);
            this.Controls.Add(this.data_TaiKhoan);
            this.Controls.Add(this.label1);
            this.Name = "ufrm_CRUDTaiKhoan";
            this.Size = new System.Drawing.Size(1191, 830);
            ((System.ComponentModel.ISupportInitialize)(this.data_TaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heThongKhachSanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAIKHOANBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClearTaiKhoan;
        private System.Windows.Forms.Button btnXoaTaiKhoan;
        private System.Windows.Forms.Button btnSuaTaiKhoan;
        private System.Windows.Forms.Button btnThemTaiKhoan;
        private System.Windows.Forms.Button btnTroLaiQLTTP;
        private System.Windows.Forms.DataGridView data_TaiKhoan;
        private System.Windows.Forms.Label label1;
        private HeThongKhachSanDataSet heThongKhachSanDataSet;
        private System.Windows.Forms.BindingSource tAIKHOANBindingSource;
        private HeThongKhachSanDataSetTableAdapters.TAIKHOANTableAdapter tAIKHOANTableAdapter;
        private HeThongKhachSanDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox iD_TAIKHOANTextBox;
        private System.Windows.Forms.TextBox eMAILTextBox;
        private System.Windows.Forms.TextBox mATKHAUTextBox;
        private System.Windows.Forms.ComboBox cbIDPhanQuyen;
        private System.Windows.Forms.TextBox txtTimKiemTaiKhoan;
    }
}
