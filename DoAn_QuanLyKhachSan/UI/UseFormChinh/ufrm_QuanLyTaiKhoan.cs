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
    public partial class ufrm_QuanLyTaiKhoan : UserControl
    {
        public ufrm_QuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ufrm_CRUDPhanQuyen kh = new ufrm_CRUDPhanQuyen();
            this.Controls.Clear();
            this.Controls.Add(kh);
            kh.Dock = DockStyle.Fill;
        }
    }
}
