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
    public partial class ufrm_TTDichVu : UserControl
    {
        Database db = new Database();

        private BLL_DichVu BLL_DichVu;
        public ufrm_TTDichVu()
        {
            InitializeComponent();
            BLL_DichVu = new BLL_DichVu(new Database().GetDataSet());

            LoadDichVu();
        }
        public void LoadDichVu()
        {
            try
            {
                data_TTDichVu.DataSource = BLL_DichVu.GetDataDichVu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin liên kết nối : " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTimKiemTTDichVu_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiemTTDichVu.Text.Trim();
            DataTable dt = BLL_DichVu.SearchDichVu(keyword);
            data_TTDichVu.DataSource = dt;
        }
    }
}
