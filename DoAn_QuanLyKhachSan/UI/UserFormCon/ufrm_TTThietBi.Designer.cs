namespace DoAn_QuanLyKhachSan.UI.UserFormCon
{
    partial class ufrm_TTThietBi
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
            this.data_TTThietBi = new System.Windows.Forms.DataGridView();
            this.txtTimKiemTTThietBi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.data_TTThietBi)).BeginInit();
            this.SuspendLayout();
            // 
            // data_TTThietBi
            // 
            this.data_TTThietBi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_TTThietBi.Location = new System.Drawing.Point(197, 227);
            this.data_TTThietBi.Name = "data_TTThietBi";
            this.data_TTThietBi.RowHeadersWidth = 51;
            this.data_TTThietBi.RowTemplate.Height = 24;
            this.data_TTThietBi.Size = new System.Drawing.Size(893, 352);
            this.data_TTThietBi.TabIndex = 69;
            // 
            // txtTimKiemTTThietBi
            // 
            this.txtTimKiemTTThietBi.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTimKiemTTThietBi.Location = new System.Drawing.Point(197, 191);
            this.txtTimKiemTTThietBi.Name = "txtTimKiemTTThietBi";
            this.txtTimKiemTTThietBi.Size = new System.Drawing.Size(893, 22);
            this.txtTimKiemTTThietBi.TabIndex = 68;
            this.txtTimKiemTTThietBi.TextChanged += new System.EventHandler(this.txtTimKiemTTThietBi_TextChanged);
            // 
            // ufrm_TTThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.data_TTThietBi);
            this.Controls.Add(this.txtTimKiemTTThietBi);
            this.Name = "ufrm_TTThietBi";
            this.Size = new System.Drawing.Size(1424, 890);
            ((System.ComponentModel.ISupportInitialize)(this.data_TTThietBi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_TTThietBi;
        private System.Windows.Forms.TextBox txtTimKiemTTThietBi;
    }
}
