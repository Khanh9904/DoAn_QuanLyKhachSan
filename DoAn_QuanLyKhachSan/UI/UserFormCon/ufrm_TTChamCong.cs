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
    public partial class ufrm_TTChamCong : UserControl
    {
        Database db = new Database();
        private BLL_ChamCong BLL_ChamCong;

        public ufrm_TTChamCong()
        {
            InitializeComponent();
            BLL_ChamCong = new BLL_ChamCong(new Database().GetDataSet());
            LoadChamcong();

        }

        public void LoadChamcong()
        {
            try
            {
                data_TTChamCong.DataSource = BLL_ChamCong.GetDataChamcong();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin kết nối:" + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTimKiemTTChamCong_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiemTTChamCong.Text.Trim();
            DataTable dt = BLL_ChamCong.timkiemchamcong(keyword);
            data_TTChamCong.DataSource = dt;
        }
    }
}
