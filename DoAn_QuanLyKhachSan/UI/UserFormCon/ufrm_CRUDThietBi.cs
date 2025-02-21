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
    public partial class ufrm_CRUDThietBi : UserControl
    {
        public ufrm_CRUDThietBi()
        {
            InitializeComponent();
        }

        private void data_Thietbi_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void tHIET_BIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tHIET_BIBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.heThongKhachSanDataSet);

        }
    }
}
