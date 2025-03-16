namespace DoAn_QuanLyKhachSan.UI.UserFormCon
{
    partial class ufrm_TTPhanQuyen
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
            System.Windows.Forms.Label iD_PHANQUYENLabel;
            System.Windows.Forms.Label tENQUYENLabel;
            System.Windows.Forms.Label moTaLabel;
            System.Windows.Forms.Label mUCLUONGLAMVIECLabel;
            this.data_TTPhanQuyen = new System.Windows.Forms.DataGridView();
            this.txtTimKiemTTPhanQuyen = new System.Windows.Forms.TextBox();
            this.btnIDPhanQuyen = new System.Windows.Forms.TextBox();
            this.btnTenQuyen = new System.Windows.Forms.TextBox();
            this.btnMucLuong = new System.Windows.Forms.TextBox();
            this.btnMoTa = new System.Windows.Forms.TextBox();
            iD_PHANQUYENLabel = new System.Windows.Forms.Label();
            tENQUYENLabel = new System.Windows.Forms.Label();
            moTaLabel = new System.Windows.Forms.Label();
            mUCLUONGLAMVIECLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_TTPhanQuyen)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_PHANQUYENLabel
            // 
            iD_PHANQUYENLabel.AutoSize = true;
            iD_PHANQUYENLabel.Location = new System.Drawing.Point(33, 187);
            iD_PHANQUYENLabel.Name = "iD_PHANQUYENLabel";
            iD_PHANQUYENLabel.Size = new System.Drawing.Size(119, 16);
            iD_PHANQUYENLabel.TabIndex = 68;
            iD_PHANQUYENLabel.Text = "MÃ PHÂN QUYỀN";
            // 
            // tENQUYENLabel
            // 
            tENQUYENLabel.AutoSize = true;
            tENQUYENLabel.Location = new System.Drawing.Point(33, 215);
            tENQUYENLabel.Name = "tENQUYENLabel";
            tENQUYENLabel.Size = new System.Drawing.Size(127, 16);
            tENQUYENLabel.TabIndex = 70;
            tENQUYENLabel.Text = "TÊN PHÂN QUYỀN";
            // 
            // moTaLabel
            // 
            moTaLabel.AutoSize = true;
            moTaLabel.Location = new System.Drawing.Point(33, 270);
            moTaLabel.Name = "moTaLabel";
            moTaLabel.Size = new System.Drawing.Size(87, 16);
            moTaLabel.TabIndex = 72;
            moTaLabel.Text = "MỨC LƯƠNG";
            // 
            // mUCLUONGLAMVIECLabel
            // 
            mUCLUONGLAMVIECLabel.AutoSize = true;
            mUCLUONGLAMVIECLabel.Location = new System.Drawing.Point(33, 243);
            mUCLUONGLAMVIECLabel.Name = "mUCLUONGLAMVIECLabel";
            mUCLUONGLAMVIECLabel.Size = new System.Drawing.Size(49, 16);
            mUCLUONGLAMVIECLabel.TabIndex = 74;
            mUCLUONGLAMVIECLabel.Text = "MÔ TẢ";
            // 
            // data_TTPhanQuyen
            // 
            this.data_TTPhanQuyen.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.data_TTPhanQuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_TTPhanQuyen.Location = new System.Drawing.Point(398, 172);
            this.data_TTPhanQuyen.Name = "data_TTPhanQuyen";
            this.data_TTPhanQuyen.RowHeadersWidth = 51;
            this.data_TTPhanQuyen.RowTemplate.Height = 24;
            this.data_TTPhanQuyen.Size = new System.Drawing.Size(893, 352);
            this.data_TTPhanQuyen.TabIndex = 67;
            this.data_TTPhanQuyen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_TTPhanQuyen_CellClick);
            this.data_TTPhanQuyen.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.data_TTPhanQuyen_CellFormatting);
            // 
            // txtTimKiemTTPhanQuyen
            // 
            this.txtTimKiemTTPhanQuyen.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtTimKiemTTPhanQuyen.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTimKiemTTPhanQuyen.Location = new System.Drawing.Point(398, 136);
            this.txtTimKiemTTPhanQuyen.Name = "txtTimKiemTTPhanQuyen";
            this.txtTimKiemTTPhanQuyen.Size = new System.Drawing.Size(893, 22);
            this.txtTimKiemTTPhanQuyen.TabIndex = 66;
            this.txtTimKiemTTPhanQuyen.TextChanged += new System.EventHandler(this.txtTimKiemTTPhanQuyen_TextChanged);
            // 
            // btnIDPhanQuyen
            // 
            this.btnIDPhanQuyen.Enabled = false;
            this.btnIDPhanQuyen.Location = new System.Drawing.Point(183, 184);
            this.btnIDPhanQuyen.Name = "btnIDPhanQuyen";
            this.btnIDPhanQuyen.Size = new System.Drawing.Size(180, 22);
            this.btnIDPhanQuyen.TabIndex = 69;
            // 
            // btnTenQuyen
            // 
            this.btnTenQuyen.Location = new System.Drawing.Point(183, 212);
            this.btnTenQuyen.Name = "btnTenQuyen";
            this.btnTenQuyen.Size = new System.Drawing.Size(180, 22);
            this.btnTenQuyen.TabIndex = 71;
            // 
            // btnMucLuong
            // 
            this.btnMucLuong.Location = new System.Drawing.Point(183, 270);
            this.btnMucLuong.Name = "btnMucLuong";
            this.btnMucLuong.Size = new System.Drawing.Size(180, 22);
            this.btnMucLuong.TabIndex = 73;
            this.btnMucLuong.TextChanged += new System.EventHandler(this.btnMucLuong_TextChanged);
            // 
            // btnMoTa
            // 
            this.btnMoTa.Location = new System.Drawing.Point(183, 240);
            this.btnMoTa.Name = "btnMoTa";
            this.btnMoTa.Size = new System.Drawing.Size(180, 22);
            this.btnMoTa.TabIndex = 75;
            // 
            // ufrm_TTPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(iD_PHANQUYENLabel);
            this.Controls.Add(this.btnIDPhanQuyen);
            this.Controls.Add(tENQUYENLabel);
            this.Controls.Add(this.btnTenQuyen);
            this.Controls.Add(moTaLabel);
            this.Controls.Add(this.btnMucLuong);
            this.Controls.Add(mUCLUONGLAMVIECLabel);
            this.Controls.Add(this.btnMoTa);
            this.Controls.Add(this.data_TTPhanQuyen);
            this.Controls.Add(this.txtTimKiemTTPhanQuyen);
            this.Name = "ufrm_TTPhanQuyen";
            this.Size = new System.Drawing.Size(1424, 890);
            ((System.ComponentModel.ISupportInitialize)(this.data_TTPhanQuyen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_TTPhanQuyen;
        private System.Windows.Forms.TextBox txtTimKiemTTPhanQuyen;
        private System.Windows.Forms.TextBox btnIDPhanQuyen;
        private System.Windows.Forms.TextBox btnTenQuyen;
        private System.Windows.Forms.TextBox btnMucLuong;
        private System.Windows.Forms.TextBox btnMoTa;
    }
}
