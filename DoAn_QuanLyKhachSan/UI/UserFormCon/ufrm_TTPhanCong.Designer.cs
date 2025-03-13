namespace DoAn_QuanLyKhachSan.UI.UserFormCon
{
    partial class ufrm_TTPhanCong
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
            this.data_TTPhanCong = new System.Windows.Forms.DataGridView();
            this.txtTimKiemTTPhanCong = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.data_TTPhanCong)).BeginInit();
            this.SuspendLayout();
            // 
            // data_TTPhanCong
            // 
            this.data_TTPhanCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_TTPhanCong.Location = new System.Drawing.Point(212, 212);
            this.data_TTPhanCong.Name = "data_TTPhanCong";
            this.data_TTPhanCong.RowHeadersWidth = 51;
            this.data_TTPhanCong.RowTemplate.Height = 24;
            this.data_TTPhanCong.Size = new System.Drawing.Size(893, 352);
            this.data_TTPhanCong.TabIndex = 63;
            // 
            // txtTimKiemTTPhanCong
            // 
            this.txtTimKiemTTPhanCong.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTimKiemTTPhanCong.Location = new System.Drawing.Point(212, 176);
            this.txtTimKiemTTPhanCong.Name = "txtTimKiemTTPhanCong";
            this.txtTimKiemTTPhanCong.Size = new System.Drawing.Size(893, 22);
            this.txtTimKiemTTPhanCong.TabIndex = 62;
            this.txtTimKiemTTPhanCong.TextChanged += new System.EventHandler(this.txtTimKiemTTPhanCong_TextChanged);
            // 
            // ufrm_TTPhanCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.data_TTPhanCong);
            this.Controls.Add(this.txtTimKiemTTPhanCong);
            this.Name = "ufrm_TTPhanCong";
            this.Size = new System.Drawing.Size(1424, 890);
            this.Load += new System.EventHandler(this.ufrm_TTPhanCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_TTPhanCong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_TTPhanCong;
        private System.Windows.Forms.TextBox txtTimKiemTTPhanCong;
    }
}
