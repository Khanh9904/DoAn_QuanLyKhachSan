using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QuanLyKhachSan.UI.UserFormPhu
{
    public partial class ufrm_CRUDLoaiPhong : UserControl
    {
        public ufrm_CRUDLoaiPhong()
        {
            InitializeComponent();
        }

        private void kHACH_HANGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kHACH_HANGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.heThongKhachSanDataSet);

        }
    }
}
