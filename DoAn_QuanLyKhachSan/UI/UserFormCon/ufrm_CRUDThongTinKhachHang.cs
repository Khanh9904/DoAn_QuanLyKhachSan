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
    public partial class ufrm_CRUDThongTinKhachHang : UserControl
    {
        public ufrm_CRUDThongTinKhachHang()
        {
            InitializeComponent();
        }

        private void kHACH_HANGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kHACH_HANGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.heThongKhachSanDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            ufrm_CRUDPhanQuyen quanly = new ufrm_CRUDPhanQuyen();
            this.Controls.Add(quanly);
            quanly.Dock = DockStyle.Fill;
        }
    }
}
