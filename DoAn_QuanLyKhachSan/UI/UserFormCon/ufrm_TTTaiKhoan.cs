using BLL;
using DAL.DAL.DoAn_QuanLyKhachSan.DAL;
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
    public partial class ufrm_TTTaiKhoan : UserControl
    {
        Database db = new Database();

        private BLL_TaiKhoan BLL_TaiKhoan;

        public ufrm_TTTaiKhoan()
        {
            InitializeComponent();

            BLL_TaiKhoan = new BLL_TaiKhoan(new Database().GetDataSet());

            LoadTaiKhoan();
        }
        public void LoadTaiKhoan()
        {
            try
            {
                data_TTTaiKhoan.DataSource = BLL_TaiKhoan.GetDataTaiKhoan();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin liên kết nối : " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTimKiemTTaiKhoan_TextChanged(object sender, EventArgs e)
        {
            try
            {
                data_TTTaiKhoan.DataSource = BLL_TaiKhoan.SearchTaiKhoan(txtTimKiemTTaiKhoan.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin liên kết nối : " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
