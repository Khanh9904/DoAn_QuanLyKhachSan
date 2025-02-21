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
    public partial class ufrm_QuanLyCSVC : UserControl
    {
        public ufrm_QuanLyCSVC()
        {
            InitializeComponent();
        }

        private void ThongTinTang_Click(object sender, EventArgs e)
        {
            ufrm_CRUDTang kh = new ufrm_CRUDTang();
            this.Controls.Clear();
            this.Controls.Add(kh);
            kh.Dock = DockStyle.Fill;
        }

        private void ThongTinLoaiPhong_Click(object sender, EventArgs e)
        {
            ufrm_CRUDLoaiPhong kh = new ufrm_CRUDLoaiPhong();
            this.Controls.Clear();
            this.Controls.Add(kh);
            kh.Dock = DockStyle.Fill;
        }

        private void ThongTinDichVu_Click(object sender, EventArgs e)
        {
            ufrm_CRUDDichVu kh = new ufrm_CRUDDichVu();
            this.Controls.Clear();
            this.Controls.Add(kh);
            kh.Dock = DockStyle.Fill;
        }
    }
}
