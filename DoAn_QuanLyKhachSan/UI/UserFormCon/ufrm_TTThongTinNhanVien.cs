using BLL;
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
    public partial class ufrm_TTThongTinNhanVien : UserControl
    {

        Database db = new Database();

        private BLL_ThongTinNhanVien BLL_ThongTinNhanVien;

        public ufrm_TTThongTinNhanVien()
        {
            InitializeComponent();
            BLL_ThongTinNhanVien = new BLL_ThongTinNhanVien(new Database().GetDataSet());
            LoadNhanVien();

        }

        //Hàm load dữ liệu nhân viên
        public void LoadNhanVien()
        {
            try
            {
                data_TTNhanVien.DataSource = BLL_ThongTinNhanVien.GetDataNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin liên kết nối : " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void data_TTNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTimKiemTTNhanVien_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiemTTNhanVien.Text.Trim();

            DataTable dt = BLL_ThongTinNhanVien.SearchNhanVien(keyword);

            data_TTNhanVien.DataSource = dt;
        }
    }
}
