namespace DoAn_QuanLyKhachSan.UI.UserFormPhu
{
    partial class ufrm_CRUDTang
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
            System.Windows.Forms.Label maTangLabel;
            System.Windows.Forms.Label tenTangLabel;
            this.data_Tang = new System.Windows.Forms.DataGridView();
            this.txtTimKiemTang = new System.Windows.Forms.TextBox();
            this.btnClearTang = new System.Windows.Forms.Button();
            this.btnXoaTang = new System.Windows.Forms.Button();
            this.btnSuaTang = new System.Windows.Forms.Button();
            this.btnThemTang = new System.Windows.Forms.Button();
            this.btnTroLaiTang = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.heThongKhachSanDataSet1 = new DoAn_QuanLyKhachSan.HeThongKhachSanDataSet();
            this.tangLauBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tangLauTableAdapter = new DoAn_QuanLyKhachSan.HeThongKhachSanDataSetTableAdapters.TangLauTableAdapter();
            this.tableAdapterManager = new DoAn_QuanLyKhachSan.HeThongKhachSanDataSetTableAdapters.TableAdapterManager();
            this.maTangTextBox = new System.Windows.Forms.TextBox();
            this.tenTangTextBox = new System.Windows.Forms.TextBox();
            maTangLabel = new System.Windows.Forms.Label();
            tenTangLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_Tang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heThongKhachSanDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tangLauBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // maTangLabel
            // 
            maTangLabel.AutoSize = true;
            maTangLabel.Location = new System.Drawing.Point(71, 282);
            maTangLabel.Name = "maTangLabel";
            maTangLabel.Size = new System.Drawing.Size(68, 16);
            maTangLabel.TabIndex = 83;
            maTangLabel.Text = "MÃ TẦNG";
            // 
            // tenTangLabel
            // 
            tenTangLabel.AutoSize = true;
            tenTangLabel.Location = new System.Drawing.Point(71, 310);
            tenTangLabel.Name = "tenTangLabel";
            tenTangLabel.Size = new System.Drawing.Size(76, 16);
            tenTangLabel.TabIndex = 85;
            tenTangLabel.Text = "TÊN TẦNG";
            // 
            // data_Tang
            // 
            this.data_Tang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Tang.Location = new System.Drawing.Point(431, 251);
            this.data_Tang.Name = "data_Tang";
            this.data_Tang.RowHeadersWidth = 51;
            this.data_Tang.RowTemplate.Height = 24;
            this.data_Tang.Size = new System.Drawing.Size(703, 364);
            this.data_Tang.TabIndex = 65;
            this.data_Tang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_Tang_CellClick_1);
            // 
            // txtTimKiemTang
            // 
            this.txtTimKiemTang.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTimKiemTang.Location = new System.Drawing.Point(431, 213);
            this.txtTimKiemTang.Name = "txtTimKiemTang";
            this.txtTimKiemTang.Size = new System.Drawing.Size(703, 22);
            this.txtTimKiemTang.TabIndex = 64;
            this.txtTimKiemTang.TextChanged += new System.EventHandler(this.txtTimKiemTang_TextChanged);
            // 
            // btnClearTang
            // 
            this.btnClearTang.Location = new System.Drawing.Point(740, 648);
            this.btnClearTang.Name = "btnClearTang";
            this.btnClearTang.Size = new System.Drawing.Size(170, 50);
            this.btnClearTang.TabIndex = 63;
            this.btnClearTang.Text = "Xóa Dữ Liệu";
            this.btnClearTang.UseVisualStyleBackColor = true;
            this.btnClearTang.Click += new System.EventHandler(this.btnClearTang_Click);
            // 
            // btnXoaTang
            // 
            this.btnXoaTang.Location = new System.Drawing.Point(589, 648);
            this.btnXoaTang.Name = "btnXoaTang";
            this.btnXoaTang.Size = new System.Drawing.Size(110, 50);
            this.btnXoaTang.TabIndex = 62;
            this.btnXoaTang.Text = "Xóa";
            this.btnXoaTang.UseVisualStyleBackColor = true;
            this.btnXoaTang.Click += new System.EventHandler(this.btnXoaTang_Click);
            // 
            // btnSuaTang
            // 
            this.btnSuaTang.Location = new System.Drawing.Point(428, 648);
            this.btnSuaTang.Name = "btnSuaTang";
            this.btnSuaTang.Size = new System.Drawing.Size(110, 50);
            this.btnSuaTang.TabIndex = 61;
            this.btnSuaTang.Text = "Sửa";
            this.btnSuaTang.UseVisualStyleBackColor = true;
            this.btnSuaTang.Click += new System.EventHandler(this.btnSuaTang_Click);
            // 
            // btnThemTang
            // 
            this.btnThemTang.Location = new System.Drawing.Point(279, 648);
            this.btnThemTang.Name = "btnThemTang";
            this.btnThemTang.Size = new System.Drawing.Size(110, 50);
            this.btnThemTang.TabIndex = 60;
            this.btnThemTang.Text = "Thêm";
            this.btnThemTang.UseVisualStyleBackColor = true;
            this.btnThemTang.Click += new System.EventHandler(this.btnThemTang_Click);
            // 
            // btnTroLaiTang
            // 
            this.btnTroLaiTang.Location = new System.Drawing.Point(60, 174);
            this.btnTroLaiTang.Name = "btnTroLaiTang";
            this.btnTroLaiTang.Size = new System.Drawing.Size(75, 23);
            this.btnTroLaiTang.TabIndex = 59;
            this.btnTroLaiTang.Text = "Trở lại";
            this.btnTroLaiTang.UseVisualStyleBackColor = true;
            this.btnTroLaiTang.Click += new System.EventHandler(this.btnTroLaiTang_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(522, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 82;
            this.label1.Text = "QUẢN LÝ TẦNG";
            // 
            // heThongKhachSanDataSet1
            // 
            this.heThongKhachSanDataSet1.DataSetName = "HeThongKhachSanDataSet1";
            this.heThongKhachSanDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tangLauBindingSource
            // 
            this.tangLauBindingSource.DataMember = "TangLau";
            this.tangLauBindingSource.DataSource = this.heThongKhachSanDataSet1;
            // 
            // tangLauTableAdapter
            // 
            this.tangLauTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.TangLauTableAdapter = this.tangLauTableAdapter;
            this.tableAdapterManager.THIET_BITableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DoAn_QuanLyKhachSan.HeThongKhachSanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // maTangTextBox
            // 
            this.maTangTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tangLauBindingSource, "MaTang", true));
            this.maTangTextBox.Enabled = false;
            this.maTangTextBox.Location = new System.Drawing.Point(166, 276);
            this.maTangTextBox.Name = "maTangTextBox";
            this.maTangTextBox.Size = new System.Drawing.Size(202, 22);
            this.maTangTextBox.TabIndex = 84;
            // 
            // tenTangTextBox
            // 
            this.tenTangTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tangLauBindingSource, "TenTang", true));
            this.tenTangTextBox.Location = new System.Drawing.Point(166, 304);
            this.tenTangTextBox.Name = "tenTangTextBox";
            this.tenTangTextBox.Size = new System.Drawing.Size(202, 22);
            this.tenTangTextBox.TabIndex = 86;
            // 
            // ufrm_CRUDTang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(maTangLabel);
            this.Controls.Add(this.maTangTextBox);
            this.Controls.Add(tenTangLabel);
            this.Controls.Add(this.tenTangTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.data_Tang);
            this.Controls.Add(this.txtTimKiemTang);
            this.Controls.Add(this.btnClearTang);
            this.Controls.Add(this.btnXoaTang);
            this.Controls.Add(this.btnSuaTang);
            this.Controls.Add(this.btnThemTang);
            this.Controls.Add(this.btnTroLaiTang);
            this.Name = "ufrm_CRUDTang";
            this.Size = new System.Drawing.Size(1191, 830);
            ((System.ComponentModel.ISupportInitialize)(this.data_Tang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heThongKhachSanDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tangLauBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView data_Tang;
        private System.Windows.Forms.TextBox txtTimKiemTang;
        private System.Windows.Forms.Button btnClearTang;
        private System.Windows.Forms.Button btnXoaTang;
        private System.Windows.Forms.Button btnSuaTang;
        private System.Windows.Forms.Button btnThemTang;
        private System.Windows.Forms.Button btnTroLaiTang;
        private System.Windows.Forms.Label label1;
        private HeThongKhachSanDataSet heThongKhachSanDataSet1;
        private System.Windows.Forms.BindingSource tangLauBindingSource;
        private HeThongKhachSanDataSetTableAdapters.TangLauTableAdapter tangLauTableAdapter;
        private HeThongKhachSanDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox maTangTextBox;
        private System.Windows.Forms.TextBox tenTangTextBox;
    }
}
