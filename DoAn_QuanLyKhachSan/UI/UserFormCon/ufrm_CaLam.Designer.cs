namespace DoAn_QuanLyKhachSan.UI.UserFormCon
{
    partial class ufrm_CaLam
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
            System.Windows.Forms.Label iD_CALAMLabel;
            System.Windows.Forms.Label tENCALabel;
            System.Windows.Forms.Label gIOBATDAULabel;
            System.Windows.Forms.Label gIOKETTHUCLabel;
            this.tableAdapterManager = new DoAn_QuanLyKhachSan.HeThongKhachSanDataSetTableAdapters.TableAdapterManager();
            this.dICH_VUTableAdapter = new DoAn_QuanLyKhachSan.HeThongKhachSanDataSetTableAdapters.DICH_VUTableAdapter();
            this.dICH_VUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.heThongKhachSanDataSet = new DoAn_QuanLyKhachSan.HeThongKhachSanDataSet();
            this.txtTimKiemCaLam = new System.Windows.Forms.TextBox();
            this.btnClearCaLam = new System.Windows.Forms.Button();
            this.btnXoaCaLam = new System.Windows.Forms.Button();
            this.btnSuaCaLam = new System.Windows.Forms.Button();
            this.btnThemCaLam = new System.Windows.Forms.Button();
            this.data_CaLam = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cALAMVIECBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cALAMVIECTableAdapter = new DoAn_QuanLyKhachSan.HeThongKhachSanDataSetTableAdapters.CALAMVIECTableAdapter();
            this.iD_CALAMTextBox = new System.Windows.Forms.TextBox();
            this.tENCATextBox = new System.Windows.Forms.TextBox();
            this.gIOBATDAUTextBox = new System.Windows.Forms.TextBox();
            this.gIOKETTHUCTextBox = new System.Windows.Forms.TextBox();
            iD_CALAMLabel = new System.Windows.Forms.Label();
            tENCALabel = new System.Windows.Forms.Label();
            gIOBATDAULabel = new System.Windows.Forms.Label();
            gIOKETTHUCLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dICH_VUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heThongKhachSanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_CaLam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cALAMVIECBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_CALAMLabel
            // 
            iD_CALAMLabel.AutoSize = true;
            iD_CALAMLabel.Location = new System.Drawing.Point(136, 247);
            iD_CALAMLabel.Name = "iD_CALAMLabel";
            iD_CALAMLabel.Size = new System.Drawing.Size(78, 16);
            iD_CALAMLabel.TabIndex = 67;
            iD_CALAMLabel.Text = "MÃ CA LÀM";
            // 
            // tENCALabel
            // 
            tENCALabel.AutoSize = true;
            tENCALabel.Location = new System.Drawing.Point(136, 275);
            tENCALabel.Name = "tENCALabel";
            tENCALabel.Size = new System.Drawing.Size(86, 16);
            tENCALabel.TabIndex = 69;
            tENCALabel.Text = "TÊN CA LÀM";
            // 
            // gIOBATDAULabel
            // 
            gIOBATDAULabel.AutoSize = true;
            gIOBATDAULabel.Location = new System.Drawing.Point(136, 303);
            gIOBATDAULabel.Name = "gIOBATDAULabel";
            gIOBATDAULabel.Size = new System.Drawing.Size(91, 16);
            gIOBATDAULabel.TabIndex = 71;
            gIOBATDAULabel.Text = "GIỜ BẮT ĐẦU";
            // 
            // gIOKETTHUCLabel
            // 
            gIOKETTHUCLabel.AutoSize = true;
            gIOKETTHUCLabel.Location = new System.Drawing.Point(136, 331);
            gIOKETTHUCLabel.Name = "gIOKETTHUCLabel";
            gIOKETTHUCLabel.Size = new System.Drawing.Size(100, 16);
            gIOKETTHUCLabel.TabIndex = 73;
            gIOKETTHUCLabel.Text = "GIỜ KẾT THÚC";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CALAMVIECTableAdapter = null;
            this.tableAdapterManager.CHAMCONGLAMVIECTableAdapter = null;
            this.tableAdapterManager.DICH_VUTableAdapter = this.dICH_VUTableAdapter;
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
            this.tableAdapterManager.THIET_BITableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DoAn_QuanLyKhachSan.HeThongKhachSanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dICH_VUTableAdapter
            // 
            this.dICH_VUTableAdapter.ClearBeforeFill = true;
            // 
            // dICH_VUBindingSource
            // 
            this.dICH_VUBindingSource.DataMember = "DICH_VU";
            this.dICH_VUBindingSource.DataSource = this.heThongKhachSanDataSet;
            // 
            // heThongKhachSanDataSet
            // 
            this.heThongKhachSanDataSet.DataSetName = "HeThongKhachSanDataSet";
            this.heThongKhachSanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtTimKiemCaLam
            // 
            this.txtTimKiemCaLam.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTimKiemCaLam.Location = new System.Drawing.Point(571, 195);
            this.txtTimKiemCaLam.Name = "txtTimKiemCaLam";
            this.txtTimKiemCaLam.Size = new System.Drawing.Size(603, 22);
            this.txtTimKiemCaLam.TabIndex = 67;
            this.txtTimKiemCaLam.TextChanged += new System.EventHandler(this.txtTimKiemCaLam_TextChanged);
            // 
            // btnClearCaLam
            // 
            this.btnClearCaLam.Location = new System.Drawing.Point(757, 659);
            this.btnClearCaLam.Name = "btnClearCaLam";
            this.btnClearCaLam.Size = new System.Drawing.Size(182, 51);
            this.btnClearCaLam.TabIndex = 57;
            this.btnClearCaLam.Text = "Xóa Dữ Liệu";
            this.btnClearCaLam.UseVisualStyleBackColor = true;
            this.btnClearCaLam.Click += new System.EventHandler(this.btnClearCaLam_Click);
            // 
            // btnXoaCaLam
            // 
            this.btnXoaCaLam.Location = new System.Drawing.Point(606, 659);
            this.btnXoaCaLam.Name = "btnXoaCaLam";
            this.btnXoaCaLam.Size = new System.Drawing.Size(122, 51);
            this.btnXoaCaLam.TabIndex = 56;
            this.btnXoaCaLam.Text = "Xóa";
            this.btnXoaCaLam.UseVisualStyleBackColor = true;
            this.btnXoaCaLam.Click += new System.EventHandler(this.btnXoaCaLam_Click);
            // 
            // btnSuaCaLam
            // 
            this.btnSuaCaLam.Location = new System.Drawing.Point(445, 659);
            this.btnSuaCaLam.Name = "btnSuaCaLam";
            this.btnSuaCaLam.Size = new System.Drawing.Size(122, 51);
            this.btnSuaCaLam.TabIndex = 55;
            this.btnSuaCaLam.Text = "Sửa";
            this.btnSuaCaLam.UseVisualStyleBackColor = true;
            this.btnSuaCaLam.Click += new System.EventHandler(this.btnSuaCaLam_Click);
            // 
            // btnThemCaLam
            // 
            this.btnThemCaLam.Location = new System.Drawing.Point(296, 659);
            this.btnThemCaLam.Name = "btnThemCaLam";
            this.btnThemCaLam.Size = new System.Drawing.Size(122, 51);
            this.btnThemCaLam.TabIndex = 54;
            this.btnThemCaLam.Text = "Thêm";
            this.btnThemCaLam.UseVisualStyleBackColor = true;
            this.btnThemCaLam.Click += new System.EventHandler(this.btnThemCaLam_Click);
            // 
            // data_CaLam
            // 
            this.data_CaLam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_CaLam.Location = new System.Drawing.Point(571, 223);
            this.data_CaLam.Name = "data_CaLam";
            this.data_CaLam.RowHeadersWidth = 51;
            this.data_CaLam.RowTemplate.Height = 24;
            this.data_CaLam.Size = new System.Drawing.Size(599, 393);
            this.data_CaLam.TabIndex = 53;
            this.data_CaLam.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CaLam_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(466, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 29);
            this.label1.TabIndex = 52;
            this.label1.Text = "QUẢN LÝ THÔNG TIN CA LÀM";
            // 
            // cALAMVIECBindingSource
            // 
            this.cALAMVIECBindingSource.DataMember = "CALAMVIEC";
            this.cALAMVIECBindingSource.DataSource = this.heThongKhachSanDataSet;
            // 
            // cALAMVIECTableAdapter
            // 
            this.cALAMVIECTableAdapter.ClearBeforeFill = true;
            // 
            // iD_CALAMTextBox
            // 
            this.iD_CALAMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cALAMVIECBindingSource, "ID_CALAM", true));
            this.iD_CALAMTextBox.Enabled = false;
            this.iD_CALAMTextBox.Location = new System.Drawing.Point(239, 244);
            this.iD_CALAMTextBox.Name = "iD_CALAMTextBox";
            this.iD_CALAMTextBox.Size = new System.Drawing.Size(235, 22);
            this.iD_CALAMTextBox.TabIndex = 68;
            // 
            // tENCATextBox
            // 
            this.tENCATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cALAMVIECBindingSource, "TENCA", true));
            this.tENCATextBox.Location = new System.Drawing.Point(239, 272);
            this.tENCATextBox.Name = "tENCATextBox";
            this.tENCATextBox.Size = new System.Drawing.Size(235, 22);
            this.tENCATextBox.TabIndex = 70;
            // 
            // gIOBATDAUTextBox
            // 
            this.gIOBATDAUTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cALAMVIECBindingSource, "GIOBATDAU", true));
            this.gIOBATDAUTextBox.Location = new System.Drawing.Point(239, 300);
            this.gIOBATDAUTextBox.Name = "gIOBATDAUTextBox";
            this.gIOBATDAUTextBox.Size = new System.Drawing.Size(235, 22);
            this.gIOBATDAUTextBox.TabIndex = 72;
            // 
            // gIOKETTHUCTextBox
            // 
            this.gIOKETTHUCTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cALAMVIECBindingSource, "GIOKETTHUC", true));
            this.gIOKETTHUCTextBox.Location = new System.Drawing.Point(239, 328);
            this.gIOKETTHUCTextBox.Name = "gIOKETTHUCTextBox";
            this.gIOKETTHUCTextBox.Size = new System.Drawing.Size(235, 22);
            this.gIOKETTHUCTextBox.TabIndex = 74;
            // 
            // ufrm_CaLam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(iD_CALAMLabel);
            this.Controls.Add(this.iD_CALAMTextBox);
            this.Controls.Add(tENCALabel);
            this.Controls.Add(this.tENCATextBox);
            this.Controls.Add(gIOBATDAULabel);
            this.Controls.Add(this.gIOBATDAUTextBox);
            this.Controls.Add(gIOKETTHUCLabel);
            this.Controls.Add(this.gIOKETTHUCTextBox);
            this.Controls.Add(this.txtTimKiemCaLam);
            this.Controls.Add(this.btnClearCaLam);
            this.Controls.Add(this.btnXoaCaLam);
            this.Controls.Add(this.btnSuaCaLam);
            this.Controls.Add(this.btnThemCaLam);
            this.Controls.Add(this.data_CaLam);
            this.Controls.Add(this.label1);
            this.Name = "ufrm_CaLam";
            this.Size = new System.Drawing.Size(1250, 830);
            ((System.ComponentModel.ISupportInitialize)(this.dICH_VUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heThongKhachSanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_CaLam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cALAMVIECBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HeThongKhachSanDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private HeThongKhachSanDataSetTableAdapters.DICH_VUTableAdapter dICH_VUTableAdapter;
        private System.Windows.Forms.BindingSource dICH_VUBindingSource;
        private HeThongKhachSanDataSet heThongKhachSanDataSet;
        private System.Windows.Forms.TextBox txtTimKiemCaLam;
        private System.Windows.Forms.Button btnClearCaLam;
        private System.Windows.Forms.Button btnXoaCaLam;
        private System.Windows.Forms.Button btnSuaCaLam;
        private System.Windows.Forms.Button btnThemCaLam;
        private System.Windows.Forms.DataGridView data_CaLam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource cALAMVIECBindingSource;
        private HeThongKhachSanDataSetTableAdapters.CALAMVIECTableAdapter cALAMVIECTableAdapter;
        private System.Windows.Forms.TextBox iD_CALAMTextBox;
        private System.Windows.Forms.TextBox tENCATextBox;
        private System.Windows.Forms.TextBox gIOBATDAUTextBox;
        private System.Windows.Forms.TextBox gIOKETTHUCTextBox;
    }
}
