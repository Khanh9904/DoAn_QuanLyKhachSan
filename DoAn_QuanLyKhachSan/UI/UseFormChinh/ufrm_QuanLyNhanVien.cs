﻿using DoAn_QuanLyKhachSan.UI.UserFormCon;
using DoAn_QuanLyKhachSan.UI.UserFormPhu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QuanLyKhachSan.UI.UseForm
{
    public partial class ufrm_QuanLyNhanVien : UserControl
    {
        public ufrm_QuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void TSThongTinNhanVien_Click(object sender, EventArgs e)
        {
            ufrm_CRUDThongTinNhanVien kh = new ufrm_CRUDThongTinNhanVien();
            this.Controls.Clear();
            this.Controls.Add(kh);
            kh.Dock = DockStyle.Fill;
        }

        private void TSTinhLuong_Click(object sender, EventArgs e)
        {
            ufrm_Chamconglamviec kh = new ufrm_Chamconglamviec();
            this.Controls.Clear();
            this.Controls.Add(kh);
            kh.Dock = DockStyle.Fill;
        }
    }
}
