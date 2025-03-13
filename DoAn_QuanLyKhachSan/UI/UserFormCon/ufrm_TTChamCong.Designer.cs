namespace DoAn_QuanLyKhachSan.UI.UserFormCon
{
    partial class ufrm_TTChamCong
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
            this.data_TTChamCong = new System.Windows.Forms.DataGridView();
            this.txtTimKiemTTChamCong = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.data_TTChamCong)).BeginInit();
            this.SuspendLayout();
            // 
            // data_TTChamCong
            // 
            this.data_TTChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_TTChamCong.Location = new System.Drawing.Point(184, 218);
            this.data_TTChamCong.Name = "data_TTChamCong";
            this.data_TTChamCong.RowHeadersWidth = 51;
            this.data_TTChamCong.RowTemplate.Height = 24;
            this.data_TTChamCong.Size = new System.Drawing.Size(893, 352);
            this.data_TTChamCong.TabIndex = 65;
            // 
            // txtTimKiemTTChamCong
            // 
            this.txtTimKiemTTChamCong.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTimKiemTTChamCong.Location = new System.Drawing.Point(184, 182);
            this.txtTimKiemTTChamCong.Name = "txtTimKiemTTChamCong";
            this.txtTimKiemTTChamCong.Size = new System.Drawing.Size(893, 22);
            this.txtTimKiemTTChamCong.TabIndex = 64;
            this.txtTimKiemTTChamCong.TextChanged += new System.EventHandler(this.txtTimKiemTTChamCong_TextChanged);
            // 
            // ufrm_TTChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.data_TTChamCong);
            this.Controls.Add(this.txtTimKiemTTChamCong);
            this.Name = "ufrm_TTChamCong";
            this.Size = new System.Drawing.Size(1424, 890);
            ((System.ComponentModel.ISupportInitialize)(this.data_TTChamCong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_TTChamCong;
        private System.Windows.Forms.TextBox txtTimKiemTTChamCong;
    }
}
