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
    public partial class ufrm_TTPhanCong : UserControl
    {
        Database db = new Database();

        private BLL_PhanCongCaLam BLL_PhanCongCaLam;

        public ufrm_TTPhanCong()
        {
            InitializeComponent();
            BLL_PhanCongCaLam = new BLL_PhanCongCaLam(new Database().GetDataSet());

            LoadPhanCong();
        }

        public void LoadPhanCong()
        {
            try
            {
                data_TTPhanCong.DataSource = BLL_PhanCongCaLam.GetDataPhanCongCaLam();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin liên kết nối : " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ufrm_TTPhanCong_Load(object sender, EventArgs e)
        {

        }

        private void txtTimKiemTTPhanCong_TextChanged(object sender, EventArgs e)
        {
            //string keyword = txtTimKiemTTPhanCong.Text.Trim();
            //DataTable dt = BLL_PhanCongCaLam.SearchPhanCongCaLam(keyword);
            //data_TTPhanCong.DataSource = dt;
        }
    }
}
