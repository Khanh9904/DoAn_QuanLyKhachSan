﻿namespace DoAn_QuanLyKhachSan.UI.UserFormPhu
{
    partial class ufrm_CRUDDichVu
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
            System.Windows.Forms.Label maDichVuLabel;
            System.Windows.Forms.Label tenDichVuLabel;
            System.Windows.Forms.Label giaDichVuLabel;
            System.Windows.Forms.Label trangThaiDichVuLabel;
            System.Windows.Forms.Label soLuongDichVuLabel;
            this.btnClearDichVu = new System.Windows.Forms.Button();
            this.btnXoaDichVu = new System.Windows.Forms.Button();
            this.btnSuaDichVu = new System.Windows.Forms.Button();
            this.btnThemDichVu = new System.Windows.Forms.Button();
            this.data_DichVu = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.heThongKhachSanDataSet = new DoAn_QuanLyKhachSan.HeThongKhachSanDataSet();
            this.dICH_VUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dICH_VUTableAdapter = new DoAn_QuanLyKhachSan.HeThongKhachSanDataSetTableAdapters.DICH_VUTableAdapter();
            this.tableAdapterManager = new DoAn_QuanLyKhachSan.HeThongKhachSanDataSetTableAdapters.TableAdapterManager();
            this.maDichVuTextBox = new System.Windows.Forms.TextBox();
            this.tenDichVuTextBox = new System.Windows.Forms.TextBox();
            this.giaDichVuTextBox = new System.Windows.Forms.TextBox();
            this.soLuongDichVuTextBox = new System.Windows.Forms.TextBox();
            this.txtTimKiemDichVu = new System.Windows.Forms.TextBox();
            this.trangThaiDichVuTextBox = new System.Windows.Forms.ComboBox();
            maDichVuLabel = new System.Windows.Forms.Label();
            tenDichVuLabel = new System.Windows.Forms.Label();
            giaDichVuLabel = new System.Windows.Forms.Label();
            trangThaiDichVuLabel = new System.Windows.Forms.Label();
            soLuongDichVuLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_DichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heThongKhachSanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dICH_VUBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // maDichVuLabel
            // 
            maDichVuLabel.AutoSize = true;
            maDichVuLabel.Location = new System.Drawing.Point(68, 236);
            maDichVuLabel.Name = "maDichVuLabel";
            maDichVuLabel.Size = new System.Drawing.Size(84, 16);
            maDichVuLabel.TabIndex = 40;
            maDichVuLabel.Text = "MÃ DỊCH VỤ";
            // 
            // tenDichVuLabel
            // 
            tenDichVuLabel.AutoSize = true;
            tenDichVuLabel.Location = new System.Drawing.Point(68, 264);
            tenDichVuLabel.Name = "tenDichVuLabel";
            tenDichVuLabel.Size = new System.Drawing.Size(92, 16);
            tenDichVuLabel.TabIndex = 42;
            tenDichVuLabel.Text = "TÊN DỊCH VỤ";
            // 
            // giaDichVuLabel
            // 
            giaDichVuLabel.AutoSize = true;
            giaDichVuLabel.Location = new System.Drawing.Point(68, 292);
            giaDichVuLabel.Name = "giaDichVuLabel";
            giaDichVuLabel.Size = new System.Drawing.Size(86, 16);
            giaDichVuLabel.TabIndex = 44;
            giaDichVuLabel.Text = "GIÁ DỊCH VỤ";
            // 
            // trangThaiDichVuLabel
            // 
            trangThaiDichVuLabel.AutoSize = true;
            trangThaiDichVuLabel.Location = new System.Drawing.Point(68, 320);
            trangThaiDichVuLabel.Name = "trangThaiDichVuLabel";
            trangThaiDichVuLabel.Size = new System.Drawing.Size(89, 16);
            trangThaiDichVuLabel.TabIndex = 46;
            trangThaiDichVuLabel.Text = "TRẠNG THÁI";
            // 
            // soLuongDichVuLabel
            // 
            soLuongDichVuLabel.AutoSize = true;
            soLuongDichVuLabel.Location = new System.Drawing.Point(68, 348);
            soLuongDichVuLabel.Name = "soLuongDichVuLabel";
            soLuongDichVuLabel.Size = new System.Drawing.Size(76, 16);
            soLuongDichVuLabel.TabIndex = 48;
            soLuongDichVuLabel.Text = "SỐ LƯỢNG";
            // 
            // btnClearDichVu
            // 
            this.btnClearDichVu.Location = new System.Drawing.Point(749, 644);
            this.btnClearDichVu.Name = "btnClearDichVu";
            this.btnClearDichVu.Size = new System.Drawing.Size(182, 51);
            this.btnClearDichVu.TabIndex = 39;
            this.btnClearDichVu.Text = "Xóa Dữ Liệu";
            this.btnClearDichVu.UseVisualStyleBackColor = true;
            this.btnClearDichVu.Click += new System.EventHandler(this.btnClearDichVu_Click);
            // 
            // btnXoaDichVu
            // 
            this.btnXoaDichVu.Location = new System.Drawing.Point(598, 644);
            this.btnXoaDichVu.Name = "btnXoaDichVu";
            this.btnXoaDichVu.Size = new System.Drawing.Size(122, 51);
            this.btnXoaDichVu.TabIndex = 38;
            this.btnXoaDichVu.Text = "Xóa";
            this.btnXoaDichVu.UseVisualStyleBackColor = true;
            this.btnXoaDichVu.Click += new System.EventHandler(this.btnXoaDichVu_Click);
            // 
            // btnSuaDichVu
            // 
            this.btnSuaDichVu.Location = new System.Drawing.Point(437, 644);
            this.btnSuaDichVu.Name = "btnSuaDichVu";
            this.btnSuaDichVu.Size = new System.Drawing.Size(122, 51);
            this.btnSuaDichVu.TabIndex = 37;
            this.btnSuaDichVu.Text = "Sửa";
            this.btnSuaDichVu.UseVisualStyleBackColor = true;
            this.btnSuaDichVu.Click += new System.EventHandler(this.btnSuaDichVu_Click);
            // 
            // btnThemDichVu
            // 
            this.btnThemDichVu.Location = new System.Drawing.Point(288, 644);
            this.btnThemDichVu.Name = "btnThemDichVu";
            this.btnThemDichVu.Size = new System.Drawing.Size(122, 51);
            this.btnThemDichVu.TabIndex = 36;
            this.btnThemDichVu.Text = "Thêm";
            this.btnThemDichVu.UseVisualStyleBackColor = true;
            this.btnThemDichVu.Click += new System.EventHandler(this.btnThemDichVu_Click);
            // 
            // data_DichVu
            // 
            this.data_DichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_DichVu.Location = new System.Drawing.Point(563, 208);
            this.data_DichVu.Name = "data_DichVu";
            this.data_DichVu.RowHeadersWidth = 51;
            this.data_DichVu.RowTemplate.Height = 24;
            this.data_DichVu.Size = new System.Drawing.Size(599, 393);
            this.data_DichVu.TabIndex = 22;
            this.data_DichVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_DichVu_CellClick);
            this.data_DichVu.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.data_DichVu_CellFormatting);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(458, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "QUẢN LÝ THÔNG TIN DỊCH VỤ";
            // 
            // heThongKhachSanDataSet
            // 
            this.heThongKhachSanDataSet.DataSetName = "HeThongKhachSanDataSet";
            this.heThongKhachSanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dICH_VUBindingSource
            // 
            this.dICH_VUBindingSource.DataMember = "DICH_VU";
            this.dICH_VUBindingSource.DataSource = this.heThongKhachSanDataSet;
            // 
            // dICH_VUTableAdapter
            // 
            this.dICH_VUTableAdapter.ClearBeforeFill = true;
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
            // maDichVuTextBox
            // 
            this.maDichVuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dICH_VUBindingSource, "MaDichVu", true));
            this.maDichVuTextBox.Enabled = false;
            this.maDichVuTextBox.Location = new System.Drawing.Point(199, 233);
            this.maDichVuTextBox.Name = "maDichVuTextBox";
            this.maDichVuTextBox.Size = new System.Drawing.Size(283, 22);
            this.maDichVuTextBox.TabIndex = 41;
            // 
            // tenDichVuTextBox
            // 
            this.tenDichVuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dICH_VUBindingSource, "TenDichVu", true));
            this.tenDichVuTextBox.Location = new System.Drawing.Point(199, 261);
            this.tenDichVuTextBox.Name = "tenDichVuTextBox";
            this.tenDichVuTextBox.Size = new System.Drawing.Size(283, 22);
            this.tenDichVuTextBox.TabIndex = 43;
            // 
            // giaDichVuTextBox
            // 
            this.giaDichVuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dICH_VUBindingSource, "GiaDichVu", true));
            this.giaDichVuTextBox.Location = new System.Drawing.Point(199, 289);
            this.giaDichVuTextBox.Name = "giaDichVuTextBox";
            this.giaDichVuTextBox.Size = new System.Drawing.Size(283, 22);
            this.giaDichVuTextBox.TabIndex = 45;
            this.giaDichVuTextBox.TextChanged += new System.EventHandler(this.giaDichVuTextBox_TextChanged);
            // 
            // soLuongDichVuTextBox
            // 
            this.soLuongDichVuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dICH_VUBindingSource, "SoLuongDichVu", true));
            this.soLuongDichVuTextBox.Location = new System.Drawing.Point(199, 345);
            this.soLuongDichVuTextBox.Name = "soLuongDichVuTextBox";
            this.soLuongDichVuTextBox.Size = new System.Drawing.Size(283, 22);
            this.soLuongDichVuTextBox.TabIndex = 49;
            // 
            // txtTimKiemDichVu
            // 
            this.txtTimKiemDichVu.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTimKiemDichVu.Location = new System.Drawing.Point(563, 180);
            this.txtTimKiemDichVu.Name = "txtTimKiemDichVu";
            this.txtTimKiemDichVu.Size = new System.Drawing.Size(603, 22);
            this.txtTimKiemDichVu.TabIndex = 50;
            this.txtTimKiemDichVu.TextChanged += new System.EventHandler(this.txtTimKiemDichVu_TextChanged);
            // 
            // trangThaiDichVuTextBox
            // 
            this.trangThaiDichVuTextBox.FormattingEnabled = true;
            this.trangThaiDichVuTextBox.Items.AddRange(new object[] {
            "Tốt",
            "Bảo trì",
            "Hỏng"});
            this.trangThaiDichVuTextBox.Location = new System.Drawing.Point(200, 315);
            this.trangThaiDichVuTextBox.Name = "trangThaiDichVuTextBox";
            this.trangThaiDichVuTextBox.Size = new System.Drawing.Size(282, 24);
            this.trangThaiDichVuTextBox.TabIndex = 51;
            // 
            // ufrm_CRUDDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.trangThaiDichVuTextBox);
            this.Controls.Add(this.txtTimKiemDichVu);
            this.Controls.Add(maDichVuLabel);
            this.Controls.Add(this.maDichVuTextBox);
            this.Controls.Add(tenDichVuLabel);
            this.Controls.Add(this.tenDichVuTextBox);
            this.Controls.Add(giaDichVuLabel);
            this.Controls.Add(this.giaDichVuTextBox);
            this.Controls.Add(trangThaiDichVuLabel);
            this.Controls.Add(soLuongDichVuLabel);
            this.Controls.Add(this.soLuongDichVuTextBox);
            this.Controls.Add(this.btnClearDichVu);
            this.Controls.Add(this.btnXoaDichVu);
            this.Controls.Add(this.btnSuaDichVu);
            this.Controls.Add(this.btnThemDichVu);
            this.Controls.Add(this.data_DichVu);
            this.Controls.Add(this.label1);
            this.Name = "ufrm_CRUDDichVu";
            this.Size = new System.Drawing.Size(1250, 830);
            this.Load += new System.EventHandler(this.ufrm_CRUDDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_DichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heThongKhachSanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dICH_VUBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClearDichVu;
        private System.Windows.Forms.Button btnXoaDichVu;
        private System.Windows.Forms.Button btnSuaDichVu;
        private System.Windows.Forms.Button btnThemDichVu;
        private System.Windows.Forms.DataGridView data_DichVu;
        private System.Windows.Forms.Label label1;
        private HeThongKhachSanDataSet heThongKhachSanDataSet;
        private System.Windows.Forms.BindingSource dICH_VUBindingSource;
        private HeThongKhachSanDataSetTableAdapters.DICH_VUTableAdapter dICH_VUTableAdapter;
        private HeThongKhachSanDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox maDichVuTextBox;
        private System.Windows.Forms.TextBox tenDichVuTextBox;
        private System.Windows.Forms.TextBox giaDichVuTextBox;
        private System.Windows.Forms.TextBox soLuongDichVuTextBox;
        private System.Windows.Forms.TextBox txtTimKiemDichVu;
        private System.Windows.Forms.ComboBox trangThaiDichVuTextBox;
    }
}
