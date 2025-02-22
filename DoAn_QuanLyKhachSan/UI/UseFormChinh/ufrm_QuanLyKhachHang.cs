using DoAn_QuanLyKhachSan.UI.UseForm;
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

namespace DoAn_QuanLyKhachSan.UI.UseFormChinh
{
    public partial class ufrm_QuanLyKhachHang : UserControl
    {
        public ufrm_QuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ufrm_CRUDThongTinKhachHang kh = new ufrm_CRUDThongTinKhachHang();
            this.Controls.Clear();
            this.Controls.Add(kh);
            kh.Dock = DockStyle.Fill;
        }
    }
}
