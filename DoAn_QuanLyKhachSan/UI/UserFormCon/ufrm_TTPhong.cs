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
    public partial class ufrm_TTPhong : UserControl
    {
        Database db = new Database();

        private BLL_Phong BLL_Phong;

        public ufrm_TTPhong()
        {
            InitializeComponent();
            BLL_Phong = new BLL_Phong(new Database().GetDataSet());

            LoadPhong();
        }

        public void LoadPhong()
        {
            try
            {
                data_TTPhong.DataSource = BLL_Phong.GetDataPhong();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin liên kết nối : " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTimKiemTTPhong_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiemTTPhong.Text.Trim();

            DataTable dt = BLL_Phong.SearchPhong(keyword);

            data_TTPhong.DataSource = dt;
        }
    }
}
