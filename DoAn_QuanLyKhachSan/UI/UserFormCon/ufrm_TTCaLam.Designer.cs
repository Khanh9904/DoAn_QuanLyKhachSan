namespace DoAn_QuanLyKhachSan.UI.UserFormCon
{
    partial class ufrm_TTCaLam
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
            this.data_TTCaLam = new System.Windows.Forms.DataGridView();
            this.txtTimKiemTTCaLam = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.data_TTCaLam)).BeginInit();
            this.SuspendLayout();
            // 
            // data_TTCaLam
            // 
            this.data_TTCaLam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_TTCaLam.Location = new System.Drawing.Point(227, 167);
            this.data_TTCaLam.Name = "data_TTCaLam";
            this.data_TTCaLam.RowHeadersWidth = 51;
            this.data_TTCaLam.RowTemplate.Height = 24;
            this.data_TTCaLam.Size = new System.Drawing.Size(893, 352);
            this.data_TTCaLam.TabIndex = 69;
            // 
            // txtTimKiemTTCaLam
            // 
            this.txtTimKiemTTCaLam.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTimKiemTTCaLam.Location = new System.Drawing.Point(227, 131);
            this.txtTimKiemTTCaLam.Name = "txtTimKiemTTCaLam";
            this.txtTimKiemTTCaLam.Size = new System.Drawing.Size(893, 22);
            this.txtTimKiemTTCaLam.TabIndex = 68;
            this.txtTimKiemTTCaLam.TextChanged += new System.EventHandler(this.txtTimKiemTTCaLam_TextChanged);
            // 
            // ufrm_TTCaLam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.data_TTCaLam);
            this.Controls.Add(this.txtTimKiemTTCaLam);
            this.Name = "ufrm_TTCaLam";
            this.Size = new System.Drawing.Size(1424, 890);
            ((System.ComponentModel.ISupportInitialize)(this.data_TTCaLam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_TTCaLam;
        private System.Windows.Forms.TextBox txtTimKiemTTCaLam;
    }
}
