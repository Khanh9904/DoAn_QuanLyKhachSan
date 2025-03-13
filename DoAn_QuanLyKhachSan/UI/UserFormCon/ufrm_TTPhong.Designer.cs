namespace DoAn_QuanLyKhachSan.UI.UserFormCon
{
    partial class ufrm_TTPhong
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
            this.data_TTPhong = new System.Windows.Forms.DataGridView();
            this.txtTimKiemTTPhong = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.data_TTPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // data_TTPhong
            // 
            this.data_TTPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_TTPhong.Location = new System.Drawing.Point(184, 195);
            this.data_TTPhong.Name = "data_TTPhong";
            this.data_TTPhong.RowHeadersWidth = 51;
            this.data_TTPhong.RowTemplate.Height = 24;
            this.data_TTPhong.Size = new System.Drawing.Size(893, 352);
            this.data_TTPhong.TabIndex = 65;
            // 
            // txtTimKiemTTPhong
            // 
            this.txtTimKiemTTPhong.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTimKiemTTPhong.Location = new System.Drawing.Point(184, 159);
            this.txtTimKiemTTPhong.Name = "txtTimKiemTTPhong";
            this.txtTimKiemTTPhong.Size = new System.Drawing.Size(893, 22);
            this.txtTimKiemTTPhong.TabIndex = 64;
            this.txtTimKiemTTPhong.TextChanged += new System.EventHandler(this.txtTimKiemTTPhong_TextChanged);
            // 
            // ufrm_TTPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.data_TTPhong);
            this.Controls.Add(this.txtTimKiemTTPhong);
            this.Name = "ufrm_TTPhong";
            this.Size = new System.Drawing.Size(1424, 890);
            ((System.ComponentModel.ISupportInitialize)(this.data_TTPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_TTPhong;
        private System.Windows.Forms.TextBox txtTimKiemTTPhong;
    }
}
