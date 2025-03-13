using System.Windows.Forms;

namespace DoAn_QuanLyKhachSan.UI.UserFormPhu
{
    partial class ufrm_PhanCongCaLam
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
            System.Windows.Forms.Label iD_PHANCONGLabel;
            System.Windows.Forms.Label iD_NHANVIENLabel;
            System.Windows.Forms.Label iD_CALAMLabel;
            System.Windows.Forms.Label nGAYLAMLabel;
            this.btnClearPhanCong = new System.Windows.Forms.Button();
            this.btnXoaPhanCong = new System.Windows.Forms.Button();
            this.btnSuaPhanCong = new System.Windows.Forms.Button();
            this.btnThemPhanCong = new System.Windows.Forms.Button();
            this.pHONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.heThongKhachSanDataSet = new DoAn_QuanLyKhachSan.HeThongKhachSanDataSet();
            this.tableAdapterManager = new DoAn_QuanLyKhachSan.HeThongKhachSanDataSetTableAdapters.TableAdapterManager();
            this.pHONGTableAdapter = new DoAn_QuanLyKhachSan.HeThongKhachSanDataSetTableAdapters.PHONGTableAdapter();
            this.txtTimKiemPhanCong = new System.Windows.Forms.TextBox();
            this.data_PhanCong = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pHANCONGCALAMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHANCONGCALAMTableAdapter = new DoAn_QuanLyKhachSan.HeThongKhachSanDataSetTableAdapters.PHANCONGCALAMTableAdapter();
            this.iD_PHANCONGTextBox = new System.Windows.Forms.TextBox();
            this.nGAYLAMDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cbNhanVien = new System.Windows.Forms.ComboBox();
            this.cbMaCa = new System.Windows.Forms.ComboBox();
            iD_PHANCONGLabel = new System.Windows.Forms.Label();
            iD_NHANVIENLabel = new System.Windows.Forms.Label();
            iD_CALAMLabel = new System.Windows.Forms.Label();
            nGAYLAMLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heThongKhachSanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_PhanCong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHANCONGCALAMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_PHANCONGLabel
            // 
            iD_PHANCONGLabel.AutoSize = true;
            iD_PHANCONGLabel.Location = new System.Drawing.Point(56, 304);
            iD_PHANCONGLabel.Name = "iD_PHANCONGLabel";
            iD_PHANCONGLabel.Size = new System.Drawing.Size(110, 16);
            iD_PHANCONGLabel.TabIndex = 42;
            iD_PHANCONGLabel.Text = "MÃ PHÂN CÔNG";
            // 
            // iD_NHANVIENLabel
            // 
            iD_NHANVIENLabel.AutoSize = true;
            iD_NHANVIENLabel.Location = new System.Drawing.Point(56, 332);
            iD_NHANVIENLabel.Name = "iD_NHANVIENLabel";
            iD_NHANVIENLabel.Size = new System.Drawing.Size(103, 16);
            iD_NHANVIENLabel.TabIndex = 44;
            iD_NHANVIENLabel.Text = "MÃ NHÂN VIÊN";
            // 
            // iD_CALAMLabel
            // 
            iD_CALAMLabel.AutoSize = true;
            iD_CALAMLabel.Location = new System.Drawing.Point(56, 360);
            iD_CALAMLabel.Name = "iD_CALAMLabel";
            iD_CALAMLabel.Size = new System.Drawing.Size(78, 16);
            iD_CALAMLabel.TabIndex = 46;
            iD_CALAMLabel.Text = "MÃ CA LÀM";
            // 
            // nGAYLAMLabel
            // 
            nGAYLAMLabel.AutoSize = true;
            nGAYLAMLabel.Location = new System.Drawing.Point(56, 389);
            nGAYLAMLabel.Name = "nGAYLAMLabel";
            nGAYLAMLabel.Size = new System.Drawing.Size(108, 16);
            nGAYLAMLabel.TabIndex = 48;
            nGAYLAMLabel.Text = "NGÀY LÀM VIỆC";
            // 
            // btnClearPhanCong
            // 
            this.btnClearPhanCong.Location = new System.Drawing.Point(766, 709);
            this.btnClearPhanCong.Name = "btnClearPhanCong";
            this.btnClearPhanCong.Size = new System.Drawing.Size(183, 49);
            this.btnClearPhanCong.TabIndex = 39;
            this.btnClearPhanCong.Text = "Xóa Dữ Liệu";
            this.btnClearPhanCong.UseVisualStyleBackColor = true;
            this.btnClearPhanCong.Click += new System.EventHandler(this.btnClearPhanCong_Click);
            // 
            // btnXoaPhanCong
            // 
            this.btnXoaPhanCong.Location = new System.Drawing.Point(615, 709);
            this.btnXoaPhanCong.Name = "btnXoaPhanCong";
            this.btnXoaPhanCong.Size = new System.Drawing.Size(123, 49);
            this.btnXoaPhanCong.TabIndex = 38;
            this.btnXoaPhanCong.Text = "Xóa";
            this.btnXoaPhanCong.UseVisualStyleBackColor = true;
            this.btnXoaPhanCong.Click += new System.EventHandler(this.btnXoaPhanCong_Click);
            // 
            // btnSuaPhanCong
            // 
            this.btnSuaPhanCong.Location = new System.Drawing.Point(454, 709);
            this.btnSuaPhanCong.Name = "btnSuaPhanCong";
            this.btnSuaPhanCong.Size = new System.Drawing.Size(123, 49);
            this.btnSuaPhanCong.TabIndex = 37;
            this.btnSuaPhanCong.Text = "Sửa";
            this.btnSuaPhanCong.UseVisualStyleBackColor = true;
            this.btnSuaPhanCong.Click += new System.EventHandler(this.btnSuaPhanCong_Click);
            // 
            // btnThemPhanCong
            // 
            this.btnThemPhanCong.Location = new System.Drawing.Point(305, 709);
            this.btnThemPhanCong.Name = "btnThemPhanCong";
            this.btnThemPhanCong.Size = new System.Drawing.Size(123, 49);
            this.btnThemPhanCong.TabIndex = 36;
            this.btnThemPhanCong.Text = "Thêm";
            this.btnThemPhanCong.UseVisualStyleBackColor = true;
            this.btnThemPhanCong.Click += new System.EventHandler(this.btnThemPhanCong_Click);
            // 
            // pHONGBindingSource
            // 
            this.pHONGBindingSource.DataMember = "PHONG";
            this.pHONGBindingSource.DataSource = this.heThongKhachSanDataSet;
            // 
            // heThongKhachSanDataSet
            // 
            this.heThongKhachSanDataSet.DataSetName = "HeThongKhachSanDataSet";
            this.heThongKhachSanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // txtTimKiemPhanCong
            // 
            this.txtTimKiemPhanCong.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTimKiemPhanCong.Location = new System.Drawing.Point(486, 239);
            this.txtTimKiemPhanCong.Name = "txtTimKiemPhanCong";
            this.txtTimKiemPhanCong.Size = new System.Drawing.Size(775, 22);
            this.txtTimKiemPhanCong.TabIndex = 42;
            // 
            // data_PhanCong
            // 
            this.data_PhanCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_PhanCong.Location = new System.Drawing.Point(486, 267);
            this.data_PhanCong.Name = "data_PhanCong";
            this.data_PhanCong.RowHeadersWidth = 51;
            this.data_PhanCong.RowTemplate.Height = 24;
            this.data_PhanCong.Size = new System.Drawing.Size(769, 393);
            this.data_PhanCong.TabIndex = 27;
            this.data_PhanCong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_PhanCong_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(466, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 29);
            this.label1.TabIndex = 26;
            this.label1.Text = "QUẢN LÝ PHÂN CÔNG CA LÀM";
            // 
            // pHANCONGCALAMBindingSource
            // 
            this.pHANCONGCALAMBindingSource.DataMember = "PHANCONGCALAM";
            this.pHANCONGCALAMBindingSource.DataSource = this.heThongKhachSanDataSet;
            // 
            // pHANCONGCALAMTableAdapter
            // 
            this.pHANCONGCALAMTableAdapter.ClearBeforeFill = true;
            // 
            // iD_PHANCONGTextBox
            // 
            this.iD_PHANCONGTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pHANCONGCALAMBindingSource, "ID_PHANCONG", true));
            this.iD_PHANCONGTextBox.Enabled = false;
            this.iD_PHANCONGTextBox.Location = new System.Drawing.Point(193, 301);
            this.iD_PHANCONGTextBox.Name = "iD_PHANCONGTextBox";
            this.iD_PHANCONGTextBox.Size = new System.Drawing.Size(235, 22);
            this.iD_PHANCONGTextBox.TabIndex = 43;
            // 
            // nGAYLAMDateTimePicker
            // 
            this.nGAYLAMDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pHANCONGCALAMBindingSource, "NGAYLAM", true));
            this.nGAYLAMDateTimePicker.Location = new System.Drawing.Point(193, 385);
            this.nGAYLAMDateTimePicker.Name = "nGAYLAMDateTimePicker";
            this.nGAYLAMDateTimePicker.Size = new System.Drawing.Size(235, 22);
            this.nGAYLAMDateTimePicker.TabIndex = 49;
            // 
            // cbNhanVien
            // 
            this.cbNhanVien.FormattingEnabled = true;
            this.cbNhanVien.Location = new System.Drawing.Point(193, 327);
            this.cbNhanVien.Name = "cbNhanVien";
            this.cbNhanVien.Size = new System.Drawing.Size(235, 24);
            this.cbNhanVien.TabIndex = 50;
            // 
            // cbMaCa
            // 
            this.cbMaCa.FormattingEnabled = true;
            this.cbMaCa.Location = new System.Drawing.Point(193, 357);
            this.cbMaCa.Name = "cbMaCa";
            this.cbMaCa.Size = new System.Drawing.Size(235, 24);
            this.cbMaCa.TabIndex = 51;
            // 
            // ufrm_PhanCongCaLam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbMaCa);
            this.Controls.Add(this.cbNhanVien);
            this.Controls.Add(iD_PHANCONGLabel);
            this.Controls.Add(this.iD_PHANCONGTextBox);
            this.Controls.Add(iD_NHANVIENLabel);
            this.Controls.Add(iD_CALAMLabel);
            this.Controls.Add(nGAYLAMLabel);
            this.Controls.Add(this.nGAYLAMDateTimePicker);
            this.Controls.Add(this.btnClearPhanCong);
            this.Controls.Add(this.btnXoaPhanCong);
            this.Controls.Add(this.btnSuaPhanCong);
            this.Controls.Add(this.btnThemPhanCong);
            this.Controls.Add(this.txtTimKiemPhanCong);
            this.Controls.Add(this.data_PhanCong);
            this.Controls.Add(this.label1);
            this.Name = "ufrm_PhanCongCaLam";
            this.Size = new System.Drawing.Size(1281, 830);
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heThongKhachSanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_PhanCong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHANCONGCALAMBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnClearPhanCong;
        private Button btnXoaPhanCong;
        private Button btnSuaPhanCong;
        private Button btnThemPhanCong;
        private BindingSource pHONGBindingSource;
        private HeThongKhachSanDataSet heThongKhachSanDataSet;
        private HeThongKhachSanDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private HeThongKhachSanDataSetTableAdapters.PHONGTableAdapter pHONGTableAdapter;
        private TextBox txtTimKiemPhanCong;
        private DataGridView data_PhanCong;
        private Label label1;
        private BindingSource pHANCONGCALAMBindingSource;
        private HeThongKhachSanDataSetTableAdapters.PHANCONGCALAMTableAdapter pHANCONGCALAMTableAdapter;
        private TextBox iD_PHANCONGTextBox;
        private DateTimePicker nGAYLAMDateTimePicker;
        private ComboBox cbNhanVien;
        private ComboBox cbMaCa;
    }
       
}
