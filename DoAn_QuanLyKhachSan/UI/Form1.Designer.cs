namespace DoAn_QuanLyKhachSan
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThongTinKhachHang = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.btnQuanLy = new System.Windows.Forms.Button();
            this.btnManHinhHeThong = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ufrm_ThongTinKhachHang1 = new DoAn_QuanLyKhachSan.UI.UseForm.ufrm_ThongTinKhachHang();
            this.ufrm_BaoCao1 = new DoAn_QuanLyKhachSan.UI.UseForm.ufrm_BaoCao();
            this.ufrm_PhanQuyen1 = new DoAn_QuanLyKhachSan.UI.UseForm.ufrm_PhanQuyen();
            this.ufrm_ManHinhHeThong1 = new DoAn_QuanLyKhachSan.UI.UseForm.ufrm_ManHinhHeThong();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1424, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(187)))), ((int)(((byte)(178)))));
            this.panel1.Controls.Add(this.btnThongTinKhachHang);
            this.panel1.Controls.Add(this.btnBaoCao);
            this.panel1.Controls.Add(this.btnQuanLy);
            this.panel1.Controls.Add(this.btnManHinhHeThong);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 860);
            this.panel1.TabIndex = 2;
            // 
            // btnThongTinKhachHang
            // 
            this.btnThongTinKhachHang.FlatAppearance.BorderSize = 0;
            this.btnThongTinKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongTinKhachHang.Location = new System.Drawing.Point(3, 245);
            this.btnThongTinKhachHang.Name = "btnThongTinKhachHang";
            this.btnThongTinKhachHang.Size = new System.Drawing.Size(227, 48);
            this.btnThongTinKhachHang.TabIndex = 7;
            this.btnThongTinKhachHang.Text = "Thông Tin Khách Hàng";
            this.btnThongTinKhachHang.UseVisualStyleBackColor = true;
            this.btnThongTinKhachHang.Click += new System.EventHandler(this.btnThongTinKhachHang_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.FlatAppearance.BorderSize = 0;
            this.btnBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoCao.Location = new System.Drawing.Point(3, 286);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(227, 48);
            this.btnBaoCao.TabIndex = 6;
            this.btnBaoCao.Text = "Báo Cáo";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // btnQuanLy
            // 
            this.btnQuanLy.FlatAppearance.BorderSize = 0;
            this.btnQuanLy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLy.Location = new System.Drawing.Point(3, 191);
            this.btnQuanLy.Name = "btnQuanLy";
            this.btnQuanLy.Size = new System.Drawing.Size(227, 48);
            this.btnQuanLy.TabIndex = 5;
            this.btnQuanLy.Text = "Quản Lý";
            this.btnQuanLy.UseVisualStyleBackColor = true;
            this.btnQuanLy.Click += new System.EventHandler(this.btnQuanLy_Click);
            // 
            // btnManHinhHeThong
            // 
            this.btnManHinhHeThong.FlatAppearance.BorderSize = 0;
            this.btnManHinhHeThong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManHinhHeThong.Location = new System.Drawing.Point(3, 137);
            this.btnManHinhHeThong.Name = "btnManHinhHeThong";
            this.btnManHinhHeThong.Size = new System.Drawing.Size(227, 48);
            this.btnManHinhHeThong.TabIndex = 4;
            this.btnManHinhHeThong.Text = "Màn Hình Hệ Thống";
            this.btnManHinhHeThong.UseVisualStyleBackColor = true;
            this.btnManHinhHeThong.Click += new System.EventHandler(this.btnManHinhHeThong_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(233)))), ((int)(((byte)(213)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 100);
            this.panel2.TabIndex = 3;
            // 
            // ufrm_ThongTinKhachHang1
            // 
            this.ufrm_ThongTinKhachHang1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ufrm_ThongTinKhachHang1.Location = new System.Drawing.Point(233, 30);
            this.ufrm_ThongTinKhachHang1.Name = "ufrm_ThongTinKhachHang1";
            this.ufrm_ThongTinKhachHang1.Size = new System.Drawing.Size(1191, 860);
            this.ufrm_ThongTinKhachHang1.TabIndex = 4;
            // 
            // ufrm_BaoCao1
            // 
            this.ufrm_BaoCao1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ufrm_BaoCao1.Location = new System.Drawing.Point(233, 30);
            this.ufrm_BaoCao1.Name = "ufrm_BaoCao1";
            this.ufrm_BaoCao1.Size = new System.Drawing.Size(1191, 860);
            this.ufrm_BaoCao1.TabIndex = 3;
            // 
            // ufrm_PhanQuyen1
            // 
            this.ufrm_PhanQuyen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ufrm_PhanQuyen1.Location = new System.Drawing.Point(233, 30);
            this.ufrm_PhanQuyen1.Name = "ufrm_PhanQuyen1";
            this.ufrm_PhanQuyen1.Size = new System.Drawing.Size(1191, 860);
            this.ufrm_PhanQuyen1.TabIndex = 5;
            // 
            // ufrm_ManHinhHeThong1
            // 
            this.ufrm_ManHinhHeThong1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ufrm_ManHinhHeThong1.Location = new System.Drawing.Point(233, 30);
            this.ufrm_ManHinhHeThong1.Name = "ufrm_ManHinhHeThong1";
            this.ufrm_ManHinhHeThong1.Size = new System.Drawing.Size(1191, 860);
            this.ufrm_ManHinhHeThong1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1424, 890);
            this.Controls.Add(this.ufrm_ManHinhHeThong1);
            this.Controls.Add(this.ufrm_PhanQuyen1);
            this.Controls.Add(this.ufrm_ThongTinKhachHang1);
            this.Controls.Add(this.ufrm_BaoCao1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnManHinhHeThong;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Button btnQuanLy;
        private System.Windows.Forms.Button btnThongTinKhachHang;
        private UI.UseForm.ufrm_BaoCao ufrm_BaoCao1;
        private UI.UseForm.ufrm_ThongTinKhachHang ufrm_ThongTinKhachHang1;
        private UI.UseForm.ufrm_PhanQuyen ufrm_PhanQuyen1;
        private UI.UseForm.ufrm_ManHinhHeThong ufrm_ManHinhHeThong1;
    }
}

