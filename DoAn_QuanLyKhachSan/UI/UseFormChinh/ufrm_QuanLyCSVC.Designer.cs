namespace DoAn_QuanLyKhachSan.UI.UseForm
{
    partial class ufrm_QuanLyCSVC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ufrm_QuanLyCSVC));
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ThongTinPhong = new System.Windows.Forms.ToolStripButton();
            this.ThongTinLoaiPhong = new System.Windows.Forms.ToolStripButton();
            this.ThongTinTang = new System.Windows.Forms.ToolStripButton();
            this.ThongTinThietBi = new System.Windows.Forms.ToolStripButton();
            this.ThongTinDichVu = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(567, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý csvc";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ThongTinPhong,
            this.ThongTinLoaiPhong,
            this.ThongTinTang,
            this.ThongTinThietBi,
            this.ThongTinDichVu});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1250, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ThongTinPhong
            // 
            this.ThongTinPhong.Image = ((System.Drawing.Image)(resources.GetObject("ThongTinPhong.Image")));
            this.ThongTinPhong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ThongTinPhong.Name = "ThongTinPhong";
            this.ThongTinPhong.Size = new System.Drawing.Size(145, 24);
            this.ThongTinPhong.Text = "Thông Tin Phòng";
            // 
            // ThongTinLoaiPhong
            // 
            this.ThongTinLoaiPhong.Image = ((System.Drawing.Image)(resources.GetObject("ThongTinLoaiPhong.Image")));
            this.ThongTinLoaiPhong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ThongTinLoaiPhong.Name = "ThongTinLoaiPhong";
            this.ThongTinLoaiPhong.Size = new System.Drawing.Size(177, 24);
            this.ThongTinLoaiPhong.Text = "Thông Tin Loại Phòng";
            this.ThongTinLoaiPhong.Click += new System.EventHandler(this.ThongTinLoaiPhong_Click);
            // 
            // ThongTinTang
            // 
            this.ThongTinTang.Image = ((System.Drawing.Image)(resources.GetObject("ThongTinTang.Image")));
            this.ThongTinTang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ThongTinTang.Name = "ThongTinTang";
            this.ThongTinTang.Size = new System.Drawing.Size(136, 24);
            this.ThongTinTang.Text = "Thông Tin Tầng";
            this.ThongTinTang.Click += new System.EventHandler(this.ThongTinTang_Click);
            // 
            // ThongTinThietBi
            // 
            this.ThongTinThietBi.Image = ((System.Drawing.Image)(resources.GetObject("ThongTinThietBi.Image")));
            this.ThongTinThietBi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ThongTinThietBi.Name = "ThongTinThietBi";
            this.ThongTinThietBi.Size = new System.Drawing.Size(153, 24);
            this.ThongTinThietBi.Text = "Thông Tin Thiết Bị";
            // 
            // ThongTinDichVu
            // 
            this.ThongTinDichVu.Image = ((System.Drawing.Image)(resources.GetObject("ThongTinDichVu.Image")));
            this.ThongTinDichVu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ThongTinDichVu.Name = "ThongTinDichVu";
            this.ThongTinDichVu.Size = new System.Drawing.Size(154, 24);
            this.ThongTinDichVu.Text = "Thông Tin Dịch Vụ";
            this.ThongTinDichVu.Click += new System.EventHandler(this.ThongTinDichVu_Click);
            // 
            // ufrm_QuanLyCSVC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Name = "ufrm_QuanLyCSVC";
            this.Size = new System.Drawing.Size(1250, 830);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ThongTinPhong;
        private System.Windows.Forms.ToolStripButton ThongTinLoaiPhong;
        private System.Windows.Forms.ToolStripButton ThongTinTang;
        private System.Windows.Forms.ToolStripButton ThongTinThietBi;
        private System.Windows.Forms.ToolStripButton ThongTinDichVu;
    }
}
