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
    public partial class ufrm_CRUDTang : UserControl
    {
        public ufrm_CRUDTang()
        {
            InitializeComponent();
        }

        private void tangLauBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tangLauBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.heThongKhachSanDataSet1);

        }

        private void tangLauBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tangLauBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.heThongKhachSanDataSet1);

        }
    }
}
