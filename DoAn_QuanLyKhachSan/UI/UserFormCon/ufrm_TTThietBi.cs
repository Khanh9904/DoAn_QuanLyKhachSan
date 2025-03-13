using BLL;
using DAL.DAL;
using DAL.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QuanLyKhachSan.UI.UserFormCon
{
    public partial class ufrm_TTThietBi : UserControl
    {
        Database db = new Database();

        private BLL_ThietBi BLL_ThietBi;
        public ufrm_TTThietBi()
        {
            InitializeComponent();
            BLL_ThietBi = new BLL_ThietBi(new Database().GetDataSet());

            LoadThietBi();
        }
        public void LoadThietBi()
        {
            try
            {
                data_TTThietBi.DataSource = BLL_ThietBi.GetDataThietBi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin liên kết nối : " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTimKiemTTThietBi_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiemTTThietBi.Text.Trim();
            DataTable dt = BLL_ThietBi.SearchThietBi(keyword);
            data_TTThietBi.DataSource = dt;
        }
    }
}
