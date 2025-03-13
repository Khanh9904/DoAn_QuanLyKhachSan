namespace DoAn_QuanLyKhachSan.UI.UserFormCon
{
    partial class ufrm_TTDichVu
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
            this.data_TTDichVu = new System.Windows.Forms.DataGridView();
            this.txtTimKiemTTDichVu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.data_TTDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // data_TTDichVu
            // 
            this.data_TTDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_TTDichVu.Location = new System.Drawing.Point(210, 183);
            this.data_TTDichVu.Name = "data_TTDichVu";
            this.data_TTDichVu.RowHeadersWidth = 51;
            this.data_TTDichVu.RowTemplate.Height = 24;
            this.data_TTDichVu.Size = new System.Drawing.Size(893, 352);
            this.data_TTDichVu.TabIndex = 71;
            // 
            // txtTimKiemTTDichVu
            // 
            this.txtTimKiemTTDichVu.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTimKiemTTDichVu.Location = new System.Drawing.Point(210, 147);
            this.txtTimKiemTTDichVu.Name = "txtTimKiemTTDichVu";
            this.txtTimKiemTTDichVu.Size = new System.Drawing.Size(893, 22);
            this.txtTimKiemTTDichVu.TabIndex = 70;
            this.txtTimKiemTTDichVu.TextChanged += new System.EventHandler(this.txtTimKiemTTDichVu_TextChanged);
            // 
            // ufrm_TTDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.data_TTDichVu);
            this.Controls.Add(this.txtTimKiemTTDichVu);
            this.Name = "ufrm_TTDichVu";
            this.Size = new System.Drawing.Size(1424, 890);
            ((System.ComponentModel.ISupportInitialize)(this.data_TTDichVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_TTDichVu;
        private System.Windows.Forms.TextBox txtTimKiemTTDichVu;
    }
}
