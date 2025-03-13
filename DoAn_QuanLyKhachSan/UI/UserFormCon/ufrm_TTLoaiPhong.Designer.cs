namespace DoAn_QuanLyKhachSan.UI.UserFormCon
{
    partial class ufrm_TTLoaiPhong
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
            this.data_TTLoaiPhong = new System.Windows.Forms.DataGridView();
            this.txtTimKiemTTLoaiPhong = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.data_TTLoaiPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // data_TTLoaiPhong
            // 
            this.data_TTLoaiPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_TTLoaiPhong.Location = new System.Drawing.Point(224, 200);
            this.data_TTLoaiPhong.Name = "data_TTLoaiPhong";
            this.data_TTLoaiPhong.RowHeadersWidth = 51;
            this.data_TTLoaiPhong.RowTemplate.Height = 24;
            this.data_TTLoaiPhong.Size = new System.Drawing.Size(893, 352);
            this.data_TTLoaiPhong.TabIndex = 67;
            this.data_TTLoaiPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_TTLoaiPhong_CellContentClick);
            // 
            // txtTimKiemTTLoaiPhong
            // 
            this.txtTimKiemTTLoaiPhong.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTimKiemTTLoaiPhong.Location = new System.Drawing.Point(224, 164);
            this.txtTimKiemTTLoaiPhong.Name = "txtTimKiemTTLoaiPhong";
            this.txtTimKiemTTLoaiPhong.Size = new System.Drawing.Size(893, 22);
            this.txtTimKiemTTLoaiPhong.TabIndex = 66;
            this.txtTimKiemTTLoaiPhong.TextChanged += new System.EventHandler(this.txtTimKiemTTLoaiPhong_TextChanged);
            // 
            // ufrm_TTLoaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.data_TTLoaiPhong);
            this.Controls.Add(this.txtTimKiemTTLoaiPhong);
            this.Name = "ufrm_TTLoaiPhong";
            this.Size = new System.Drawing.Size(1424, 890);
            ((System.ComponentModel.ISupportInitialize)(this.data_TTLoaiPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_TTLoaiPhong;
        private System.Windows.Forms.TextBox txtTimKiemTTLoaiPhong;
    }
}
