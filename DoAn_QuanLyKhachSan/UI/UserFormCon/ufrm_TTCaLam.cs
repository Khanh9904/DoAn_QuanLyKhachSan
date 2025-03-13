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
    public partial class ufrm_TTCaLam : UserControl
    {
        Database db = new Database();

        private BLL_CaLam BLL_CaLam;

        public ufrm_TTCaLam()
        {
            InitializeComponent();
            BLL_CaLam = new BLL_CaLam(new Database().GetDataSet());

            LoadCaLam();
        }

        public void LoadCaLam()
        {
            try
            {
                data_TTCaLam.DataSource = BLL_CaLam.GetDataCaLam();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin liên kết nối : " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTimKiemTTCaLam_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiemTTCaLam.Text.Trim();

            DataTable dt = BLL_CaLam.SearchCaLam(keyword);

            data_TTCaLam.DataSource = dt;
        }
    }
}
