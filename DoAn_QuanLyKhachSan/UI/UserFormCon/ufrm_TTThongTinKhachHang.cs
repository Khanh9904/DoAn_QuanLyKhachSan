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
    public partial class ufrm_TTThongTinKhachHang : UserControl
    {
        Database Database = new Database();

        public BLL_ThongTinKhachHang BLL_ThongTinKhachHang;

        public ufrm_TTThongTinKhachHang()
        {
            InitializeComponent();
            BLL_ThongTinKhachHang = new BLL_ThongTinKhachHang(Database.GetDataSet());

            LoadKhachHang();
        }

        public void LoadKhachHang()
        {
            try
            {
                data_TTTTKH.DataSource = BLL_ThongTinKhachHang.GetDataKhachHang();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin liên kết nối : " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTimKiemTTTTKH_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiemTTTTKH.Text.Trim();

            DataTable dt = BLL_ThongTinKhachHang.SearchKhachHang(keyword);

            data_TTTTKH.DataSource = dt;
        }
    }
}
