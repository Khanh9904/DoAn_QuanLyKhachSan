namespace DoAn_QuanLyKhachSan.UI.UserFormCon
{
    partial class ufrm_TTTaiKhoan
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
            System.Windows.Forms.Label iD_TAIKHOANLabel;
            System.Windows.Forms.Label eMAILLabel;
            System.Windows.Forms.Label mATKHAULabel;
            System.Windows.Forms.Label iD_PHANQUYENLabel;
            this.data_TTTaiKhoan = new System.Windows.Forms.DataGridView();
            this.txtTimKiemTTaiKhoan = new System.Windows.Forms.TextBox();
            this.cbIDPhanQuyen = new System.Windows.Forms.ComboBox();
            this.iD_TAIKHOANTextBox = new System.Windows.Forms.TextBox();
            this.eMAILTextBox = new System.Windows.Forms.TextBox();
            this.mATKHAUTextBox = new System.Windows.Forms.TextBox();
            iD_TAIKHOANLabel = new System.Windows.Forms.Label();
            eMAILLabel = new System.Windows.Forms.Label();
            mATKHAULabel = new System.Windows.Forms.Label();
            iD_PHANQUYENLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_TTTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_TAIKHOANLabel
            // 
            iD_TAIKHOANLabel.AutoSize = true;
            iD_TAIKHOANLabel.Location = new System.Drawing.Point(47, 214);
            iD_TAIKHOANLabel.Name = "iD_TAIKHOANLabel";
            iD_TAIKHOANLabel.Size = new System.Drawing.Size(101, 16);
            iD_TAIKHOANLabel.TabIndex = 70;
            iD_TAIKHOANLabel.Text = "MÃ TÀI KHOẢN";
            // 
            // eMAILLabel
            // 
            eMAILLabel.AutoSize = true;
            eMAILLabel.Location = new System.Drawing.Point(47, 242);
            eMAILLabel.Name = "eMAILLabel";
            eMAILLabel.Size = new System.Drawing.Size(46, 16);
            eMAILLabel.TabIndex = 72;
            eMAILLabel.Text = "EMAIL";
            // 
            // mATKHAULabel
            // 
            mATKHAULabel.AutoSize = true;
            mATKHAULabel.Location = new System.Drawing.Point(47, 270);
            mATKHAULabel.Name = "mATKHAULabel";
            mATKHAULabel.Size = new System.Drawing.Size(76, 16);
            mATKHAULabel.TabIndex = 74;
            mATKHAULabel.Text = "MẬT KHẨU";
            // 
            // iD_PHANQUYENLabel
            // 
            iD_PHANQUYENLabel.AutoSize = true;
            iD_PHANQUYENLabel.Location = new System.Drawing.Point(47, 298);
            iD_PHANQUYENLabel.Name = "iD_PHANQUYENLabel";
            iD_PHANQUYENLabel.Size = new System.Drawing.Size(119, 16);
            iD_PHANQUYENLabel.TabIndex = 76;
            iD_PHANQUYENLabel.Text = "MÃ PHÂN QUYỀN";
            // 
            // data_TTTaiKhoan
            // 
            this.data_TTTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_TTTaiKhoan.Location = new System.Drawing.Point(531, 125);
            this.data_TTTaiKhoan.Name = "data_TTTaiKhoan";
            this.data_TTTaiKhoan.RowHeadersWidth = 51;
            this.data_TTTaiKhoan.RowTemplate.Height = 24;
            this.data_TTTaiKhoan.Size = new System.Drawing.Size(893, 352);
            this.data_TTTaiKhoan.TabIndex = 69;
            this.data_TTTaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_TTTaiKhoan_CellClick);
            // 
            // txtTimKiemTTaiKhoan
            // 
            this.txtTimKiemTTaiKhoan.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTimKiemTTaiKhoan.Location = new System.Drawing.Point(531, 89);
            this.txtTimKiemTTaiKhoan.Name = "txtTimKiemTTaiKhoan";
            this.txtTimKiemTTaiKhoan.Size = new System.Drawing.Size(893, 22);
            this.txtTimKiemTTaiKhoan.TabIndex = 68;
            this.txtTimKiemTTaiKhoan.TextChanged += new System.EventHandler(this.txtTimKiemTTaiKhoan_TextChanged);
            // 
            // cbIDPhanQuyen
            // 
            this.cbIDPhanQuyen.FormattingEnabled = true;
            this.cbIDPhanQuyen.Location = new System.Drawing.Point(195, 292);
            this.cbIDPhanQuyen.Name = "cbIDPhanQuyen";
            this.cbIDPhanQuyen.Size = new System.Drawing.Size(302, 24);
            this.cbIDPhanQuyen.TabIndex = 77;
            // 
            // iD_TAIKHOANTextBox
            // 
            this.iD_TAIKHOANTextBox.Enabled = false;
            this.iD_TAIKHOANTextBox.Location = new System.Drawing.Point(195, 208);
            this.iD_TAIKHOANTextBox.Name = "iD_TAIKHOANTextBox";
            this.iD_TAIKHOANTextBox.Size = new System.Drawing.Size(302, 22);
            this.iD_TAIKHOANTextBox.TabIndex = 71;
            // 
            // eMAILTextBox
            // 
            this.eMAILTextBox.Location = new System.Drawing.Point(195, 236);
            this.eMAILTextBox.Name = "eMAILTextBox";
            this.eMAILTextBox.Size = new System.Drawing.Size(302, 22);
            this.eMAILTextBox.TabIndex = 73;
            // 
            // mATKHAUTextBox
            // 
            this.mATKHAUTextBox.Location = new System.Drawing.Point(195, 264);
            this.mATKHAUTextBox.Name = "mATKHAUTextBox";
            this.mATKHAUTextBox.Size = new System.Drawing.Size(302, 22);
            this.mATKHAUTextBox.TabIndex = 75;
            // 
            // ufrm_TTTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbIDPhanQuyen);
            this.Controls.Add(iD_TAIKHOANLabel);
            this.Controls.Add(this.iD_TAIKHOANTextBox);
            this.Controls.Add(eMAILLabel);
            this.Controls.Add(this.eMAILTextBox);
            this.Controls.Add(mATKHAULabel);
            this.Controls.Add(this.mATKHAUTextBox);
            this.Controls.Add(iD_PHANQUYENLabel);
            this.Controls.Add(this.data_TTTaiKhoan);
            this.Controls.Add(this.txtTimKiemTTaiKhoan);
            this.Name = "ufrm_TTTaiKhoan";
            this.Size = new System.Drawing.Size(1424, 890);
            ((System.ComponentModel.ISupportInitialize)(this.data_TTTaiKhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_TTTaiKhoan;
        private System.Windows.Forms.TextBox txtTimKiemTTaiKhoan;
        private System.Windows.Forms.ComboBox cbIDPhanQuyen;
        private System.Windows.Forms.TextBox iD_TAIKHOANTextBox;
        private System.Windows.Forms.TextBox eMAILTextBox;
        private System.Windows.Forms.TextBox mATKHAUTextBox;
    }
}
