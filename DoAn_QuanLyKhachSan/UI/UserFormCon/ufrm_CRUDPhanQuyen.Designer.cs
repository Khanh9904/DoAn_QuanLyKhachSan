namespace DoAn_QuanLyKhachSan.UI.UseForm
{
    partial class ufrm_CRUDPhanQuyen
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
            System.Windows.Forms.Label iD_PHANQUYENLabel;
            System.Windows.Forms.Label tENQUYENLabel;
            System.Windows.Forms.Label moTaLabel;
            System.Windows.Forms.Label mUCLUONGLAMVIECLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.heThongKhachSanDataSet = new DoAn_QuanLyKhachSan.HeThongKhachSanDataSet();
            this.pHANQUYENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHANQUYENTableAdapter = new DoAn_QuanLyKhachSan.HeThongKhachSanDataSetTableAdapters.PHANQUYENTableAdapter();
            this.tableAdapterManager = new DoAn_QuanLyKhachSan.HeThongKhachSanDataSetTableAdapters.TableAdapterManager();
            this.btnIDPhanQuyen = new System.Windows.Forms.TextBox();
            this.btnTenQuyen = new System.Windows.Forms.TextBox();
            this.btnMucLuong = new System.Windows.Forms.TextBox();
            this.btnMoTa = new System.Windows.Forms.TextBox();
            this.btnThemQuyen = new System.Windows.Forms.Button();
            this.btnSuaQuyen = new System.Windows.Forms.Button();
            this.btnXoaQuyen = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.data_PhanQuyen = new System.Windows.Forms.DataGridView();
            this.txtTimKiemQuyen = new System.Windows.Forms.TextBox();
            iD_PHANQUYENLabel = new System.Windows.Forms.Label();
            tENQUYENLabel = new System.Windows.Forms.Label();
            moTaLabel = new System.Windows.Forms.Label();
            mUCLUONGLAMVIECLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.heThongKhachSanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHANQUYENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_PhanQuyen)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_PHANQUYENLabel
            // 
            iD_PHANQUYENLabel.AutoSize = true;
            iD_PHANQUYENLabel.Location = new System.Drawing.Point(37, 130);
            iD_PHANQUYENLabel.Name = "iD_PHANQUYENLabel";
            iD_PHANQUYENLabel.Size = new System.Drawing.Size(119, 16);
            iD_PHANQUYENLabel.TabIndex = 3;
            iD_PHANQUYENLabel.Text = "MÃ PHÂN QUYỀN";
            // 
            // tENQUYENLabel
            // 
            tENQUYENLabel.AutoSize = true;
            tENQUYENLabel.Location = new System.Drawing.Point(37, 158);
            tENQUYENLabel.Name = "tENQUYENLabel";
            tENQUYENLabel.Size = new System.Drawing.Size(127, 16);
            tENQUYENLabel.TabIndex = 5;
            tENQUYENLabel.Text = "TÊN PHÂN QUYỀN";
            // 
            // moTaLabel
            // 
            moTaLabel.AutoSize = true;
            moTaLabel.Location = new System.Drawing.Point(37, 213);
            moTaLabel.Name = "moTaLabel";
            moTaLabel.Size = new System.Drawing.Size(87, 16);
            moTaLabel.TabIndex = 7;
            moTaLabel.Text = "MỨC LƯƠNG";
            moTaLabel.Click += new System.EventHandler(this.moTaLabel_Click);
            // 
            // mUCLUONGLAMVIECLabel
            // 
            mUCLUONGLAMVIECLabel.AutoSize = true;
            mUCLUONGLAMVIECLabel.Location = new System.Drawing.Point(37, 186);
            mUCLUONGLAMVIECLabel.Name = "mUCLUONGLAMVIECLabel";
            mUCLUONGLAMVIECLabel.Size = new System.Drawing.Size(49, 16);
            mUCLUONGLAMVIECLabel.TabIndex = 9;
            mUCLUONGLAMVIECLabel.Text = "MÔ TẢ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(484, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ PHÂN QUYỀN";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Trở lại";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // heThongKhachSanDataSet
            // 
            this.heThongKhachSanDataSet.DataSetName = "HeThongKhachSanDataSet";
            this.heThongKhachSanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pHANQUYENBindingSource
            // 
            this.pHANQUYENBindingSource.DataMember = "PHANQUYEN";
            this.pHANQUYENBindingSource.DataSource = this.heThongKhachSanDataSet;
            // 
            // pHANQUYENTableAdapter
            // 
            this.pHANQUYENTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.PHANQUYENTableAdapter = this.pHANQUYENTableAdapter;
            this.tableAdapterManager.PHIEU_DAT_PHONGTableAdapter = null;
            this.tableAdapterManager.PHONGTableAdapter = null;
            this.tableAdapterManager.TAIKHOANTableAdapter = null;
            this.tableAdapterManager.TangLauTableAdapter = null;
            this.tableAdapterManager.THIET_BITableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DoAn_QuanLyKhachSan.HeThongKhachSanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnIDPhanQuyen
            // 
            this.btnIDPhanQuyen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pHANQUYENBindingSource, "ID_PHANQUYEN", true));
            this.btnIDPhanQuyen.Enabled = false;
            this.btnIDPhanQuyen.Location = new System.Drawing.Point(187, 127);
            this.btnIDPhanQuyen.Name = "btnIDPhanQuyen";
            this.btnIDPhanQuyen.Size = new System.Drawing.Size(180, 22);
            this.btnIDPhanQuyen.TabIndex = 4;
            // 
            // btnTenQuyen
            // 
            this.btnTenQuyen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pHANQUYENBindingSource, "TENQUYEN", true));
            this.btnTenQuyen.Location = new System.Drawing.Point(187, 155);
            this.btnTenQuyen.Name = "btnTenQuyen";
            this.btnTenQuyen.Size = new System.Drawing.Size(180, 22);
            this.btnTenQuyen.TabIndex = 6;
            // 
            // btnMucLuong
            // 
            this.btnMucLuong.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pHANQUYENBindingSource, "MoTa", true));
            this.btnMucLuong.Location = new System.Drawing.Point(187, 213);
            this.btnMucLuong.Name = "btnMucLuong";
            this.btnMucLuong.Size = new System.Drawing.Size(180, 22);
            this.btnMucLuong.TabIndex = 8;
            // 
            // btnMoTa
            // 
            this.btnMoTa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pHANQUYENBindingSource, "MUCLUONGLAMVIEC", true));
            this.btnMoTa.Location = new System.Drawing.Point(187, 183);
            this.btnMoTa.Name = "btnMoTa";
            this.btnMoTa.Size = new System.Drawing.Size(180, 22);
            this.btnMoTa.TabIndex = 10;
            // 
            // btnThemQuyen
            // 
            this.btnThemQuyen.Location = new System.Drawing.Point(265, 537);
            this.btnThemQuyen.Name = "btnThemQuyen";
            this.btnThemQuyen.Size = new System.Drawing.Size(134, 58);
            this.btnThemQuyen.TabIndex = 11;
            this.btnThemQuyen.Text = "Thêm";
            this.btnThemQuyen.UseVisualStyleBackColor = true;
            this.btnThemQuyen.Click += new System.EventHandler(this.btnThemQuyen_Click);
            // 
            // btnSuaQuyen
            // 
            this.btnSuaQuyen.Location = new System.Drawing.Point(414, 537);
            this.btnSuaQuyen.Name = "btnSuaQuyen";
            this.btnSuaQuyen.Size = new System.Drawing.Size(134, 58);
            this.btnSuaQuyen.TabIndex = 12;
            this.btnSuaQuyen.Text = "Sửa";
            this.btnSuaQuyen.UseVisualStyleBackColor = true;
            this.btnSuaQuyen.Click += new System.EventHandler(this.btnSuaQuyen_Click);
            // 
            // btnXoaQuyen
            // 
            this.btnXoaQuyen.Location = new System.Drawing.Point(575, 537);
            this.btnXoaQuyen.Name = "btnXoaQuyen";
            this.btnXoaQuyen.Size = new System.Drawing.Size(134, 58);
            this.btnXoaQuyen.TabIndex = 13;
            this.btnXoaQuyen.Text = "Xóa";
            this.btnXoaQuyen.UseVisualStyleBackColor = true;
            this.btnXoaQuyen.Click += new System.EventHandler(this.btnXoaQuyen_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(726, 537);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(194, 58);
            this.button5.TabIndex = 14;
            this.button5.Text = "Xóa Dữ Liệu";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // data_PhanQuyen
            // 
            this.data_PhanQuyen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_PhanQuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_PhanQuyen.Location = new System.Drawing.Point(411, 127);
            this.data_PhanQuyen.Name = "data_PhanQuyen";
            this.data_PhanQuyen.RowHeadersWidth = 51;
            this.data_PhanQuyen.RowTemplate.Height = 24;
            this.data_PhanQuyen.Size = new System.Drawing.Size(703, 371);
            this.data_PhanQuyen.TabIndex = 15;
            this.data_PhanQuyen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_PhanQuyen_CellClick);
            this.data_PhanQuyen.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.data_PhanQuyen_CellFormatting);
            // 
            // txtTimKiemQuyen
            // 
            this.txtTimKiemQuyen.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTimKiemQuyen.Location = new System.Drawing.Point(411, 99);
            this.txtTimKiemQuyen.Name = "txtTimKiemQuyen";
            this.txtTimKiemQuyen.Size = new System.Drawing.Size(703, 22);
            this.txtTimKiemQuyen.TabIndex = 16;
            this.txtTimKiemQuyen.TextChanged += new System.EventHandler(this.txtTimKiemQuyen_TextChanged);
            // 
            // ufrm_CRUDPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtTimKiemQuyen);
            this.Controls.Add(this.data_PhanQuyen);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnXoaQuyen);
            this.Controls.Add(this.btnSuaQuyen);
            this.Controls.Add(this.btnThemQuyen);
            this.Controls.Add(iD_PHANQUYENLabel);
            this.Controls.Add(this.btnIDPhanQuyen);
            this.Controls.Add(tENQUYENLabel);
            this.Controls.Add(this.btnTenQuyen);
            this.Controls.Add(moTaLabel);
            this.Controls.Add(this.btnMucLuong);
            this.Controls.Add(mUCLUONGLAMVIECLabel);
            this.Controls.Add(this.btnMoTa);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "ufrm_CRUDPhanQuyen";
            this.Size = new System.Drawing.Size(1250, 830);
            ((System.ComponentModel.ISupportInitialize)(this.heThongKhachSanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHANQUYENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_PhanQuyen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private HeThongKhachSanDataSet heThongKhachSanDataSet;
        private System.Windows.Forms.BindingSource pHANQUYENBindingSource;
        private HeThongKhachSanDataSetTableAdapters.PHANQUYENTableAdapter pHANQUYENTableAdapter;
        private HeThongKhachSanDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox btnIDPhanQuyen;
        private System.Windows.Forms.TextBox btnTenQuyen;
        private System.Windows.Forms.TextBox btnMucLuong;
        private System.Windows.Forms.TextBox btnMoTa;
        private System.Windows.Forms.Button btnThemQuyen;
        private System.Windows.Forms.Button btnSuaQuyen;
        private System.Windows.Forms.Button btnXoaQuyen;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView data_PhanQuyen;
        private System.Windows.Forms.TextBox txtTimKiemQuyen;
    }
}
