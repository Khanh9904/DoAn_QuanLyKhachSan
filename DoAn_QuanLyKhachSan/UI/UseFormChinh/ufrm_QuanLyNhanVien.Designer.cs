namespace DoAn_QuanLyKhachSan.UI.UseForm
{
    partial class ufrm_QuanLyNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ufrm_QuanLyNhanVien));
            this.TSThongTinNhanVien = new System.Windows.Forms.ToolStripButton();
            this.TSPhanCongCaLam = new System.Windows.Forms.ToolStripButton();
            this.TSTinhLuong = new System.Windows.Forms.ToolStripButton();
            this.TSCaLam = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TSThongTinNhanVien
            // 
            this.TSThongTinNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("TSThongTinNhanVien.Image")));
            this.TSThongTinNhanVien.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSThongTinNhanVien.Name = "TSThongTinNhanVien";
            this.TSThongTinNhanVien.Size = new System.Drawing.Size(171, 28);
            this.TSThongTinNhanVien.Text = "Thông Tin Nhân Viên";
            this.TSThongTinNhanVien.Click += new System.EventHandler(this.TSThongTinNhanVien_Click);
            // 
            // TSPhanCongCaLam
            // 
            this.TSPhanCongCaLam.Image = ((System.Drawing.Image)(resources.GetObject("TSPhanCongCaLam.Image")));
            this.TSPhanCongCaLam.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSPhanCongCaLam.Name = "TSPhanCongCaLam";
            this.TSPhanCongCaLam.Size = new System.Drawing.Size(157, 28);
            this.TSPhanCongCaLam.Text = "Phân Công Ca Làm";
            // 
            // TSTinhLuong
            // 
            this.TSTinhLuong.Image = ((System.Drawing.Image)(resources.GetObject("TSTinhLuong.Image")));
            this.TSTinhLuong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSTinhLuong.Name = "TSTinhLuong";
            this.TSTinhLuong.Size = new System.Drawing.Size(163, 28);
            this.TSTinhLuong.Text = "Chấm Công Ca Làm";
            this.TSTinhLuong.Click += new System.EventHandler(this.TSTinhLuong_Click);
            // 
            // TSCaLam
            // 
            this.TSCaLam.Image = ((System.Drawing.Image)(resources.GetObject("TSCaLam.Image")));
            this.TSCaLam.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSCaLam.Name = "TSCaLam";
            this.TSCaLam.Size = new System.Drawing.Size(82, 28);
            this.TSCaLam.Text = "Ca Làm";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSThongTinNhanVien,
            this.TSPhanCongCaLam,
            this.TSTinhLuong,
            this.TSCaLam});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1424, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ufrm_QuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip1);
            this.Name = "ufrm_QuanLyNhanVien";
            this.Size = new System.Drawing.Size(1424, 890);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton TSThongTinNhanVien;
        private System.Windows.Forms.ToolStripButton TSPhanCongCaLam;
        private System.Windows.Forms.ToolStripButton TSTinhLuong;
        private System.Windows.Forms.ToolStripButton TSCaLam;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}
