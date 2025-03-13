namespace DoAn_QuanLyKhachSan.UI.UserFormCon
{
    partial class ufrm_TTThongTinKhachHang
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
            this.data_TTTTKH = new System.Windows.Forms.DataGridView();
            this.txtTimKiemTTTTKH = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.data_TTTTKH)).BeginInit();
            this.SuspendLayout();
            // 
            // data_TTTTKH
            // 
            this.data_TTTTKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_TTTTKH.Location = new System.Drawing.Point(175, 198);
            this.data_TTTTKH.Name = "data_TTTTKH";
            this.data_TTTTKH.RowHeadersWidth = 51;
            this.data_TTTTKH.RowTemplate.Height = 24;
            this.data_TTTTKH.Size = new System.Drawing.Size(893, 352);
            this.data_TTTTKH.TabIndex = 67;
            // 
            // txtTimKiemTTTTKH
            // 
            this.txtTimKiemTTTTKH.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTimKiemTTTTKH.Location = new System.Drawing.Point(175, 162);
            this.txtTimKiemTTTTKH.Name = "txtTimKiemTTTTKH";
            this.txtTimKiemTTTTKH.Size = new System.Drawing.Size(893, 22);
            this.txtTimKiemTTTTKH.TabIndex = 66;
            this.txtTimKiemTTTTKH.TextChanged += new System.EventHandler(this.txtTimKiemTTTTKH_TextChanged);
            // 
            // ufrm_TTThongTinKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.data_TTTTKH);
            this.Controls.Add(this.txtTimKiemTTTTKH);
            this.Name = "ufrm_TTThongTinKhachHang";
            this.Size = new System.Drawing.Size(1424, 890);
            ((System.ComponentModel.ISupportInitialize)(this.data_TTTTKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_TTTTKH;
        private System.Windows.Forms.TextBox txtTimKiemTTTTKH;
    }
}
