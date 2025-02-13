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
    public partial class ufrm_QuanLy : UserControl
    {
        public ufrm_QuanLy()
        {
            InitializeComponent();
        }

       

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ufrm_QuanLyKhachHang kh = new ufrm_QuanLyKhachHang();
            this.Controls.Clear();
            this.Controls.Add(kh);
            kh.Dock = DockStyle.Fill;
        }

        private void quảnLýĐăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       
    }
}
