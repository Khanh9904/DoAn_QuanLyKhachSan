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
            this.data_TTTaiKhoan = new System.Windows.Forms.DataGridView();
            this.txtTimKiemTTaiKhoan = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.data_TTTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // data_TTTaiKhoan
            // 
            this.data_TTTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_TTTaiKhoan.Location = new System.Drawing.Point(200, 192);
            this.data_TTTaiKhoan.Name = "data_TTTaiKhoan";
            this.data_TTTaiKhoan.RowHeadersWidth = 51;
            this.data_TTTaiKhoan.RowTemplate.Height = 24;
            this.data_TTTaiKhoan.Size = new System.Drawing.Size(893, 352);
            this.data_TTTaiKhoan.TabIndex = 69;
            // 
            // txtTimKiemTTaiKhoan
            // 
            this.txtTimKiemTTaiKhoan.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTimKiemTTaiKhoan.Location = new System.Drawing.Point(200, 156);
            this.txtTimKiemTTaiKhoan.Name = "txtTimKiemTTaiKhoan";
            this.txtTimKiemTTaiKhoan.Size = new System.Drawing.Size(893, 22);
            this.txtTimKiemTTaiKhoan.TabIndex = 68;
            this.txtTimKiemTTaiKhoan.TextChanged += new System.EventHandler(this.txtTimKiemTTaiKhoan_TextChanged);
            // 
            // ufrm_TTTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
    }
}
