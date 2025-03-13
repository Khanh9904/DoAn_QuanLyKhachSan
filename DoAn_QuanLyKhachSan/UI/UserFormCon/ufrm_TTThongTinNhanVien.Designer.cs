namespace DoAn_QuanLyKhachSan.UI.UserFormCon
{
    partial class ufrm_TTThongTinNhanVien
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
            this.data_TTNhanVien = new System.Windows.Forms.DataGridView();
            this.txtTimKiemTTNhanVien = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.data_TTNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // data_TTNhanVien
            // 
            this.data_TTNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_TTNhanVien.Location = new System.Drawing.Point(228, 170);
            this.data_TTNhanVien.Name = "data_TTNhanVien";
            this.data_TTNhanVien.RowHeadersWidth = 51;
            this.data_TTNhanVien.RowTemplate.Height = 24;
            this.data_TTNhanVien.Size = new System.Drawing.Size(893, 352);
            this.data_TTNhanVien.TabIndex = 61;
            this.data_TTNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_TTNhanVien_CellContentClick);
            // 
            // txtTimKiemTTNhanVien
            // 
            this.txtTimKiemTTNhanVien.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTimKiemTTNhanVien.Location = new System.Drawing.Point(228, 134);
            this.txtTimKiemTTNhanVien.Name = "txtTimKiemTTNhanVien";
            this.txtTimKiemTTNhanVien.Size = new System.Drawing.Size(893, 22);
            this.txtTimKiemTTNhanVien.TabIndex = 60;
            this.txtTimKiemTTNhanVien.TextChanged += new System.EventHandler(this.txtTimKiemTTNhanVien_TextChanged);
            // 
            // ufrm_TTThongTinNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.data_TTNhanVien);
            this.Controls.Add(this.txtTimKiemTTNhanVien);
            this.Name = "ufrm_TTThongTinNhanVien";
            this.Size = new System.Drawing.Size(1411, 830);
            ((System.ComponentModel.ISupportInitialize)(this.data_TTNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_TTNhanVien;
        private System.Windows.Forms.TextBox txtTimKiemTTNhanVien;
    }
}
