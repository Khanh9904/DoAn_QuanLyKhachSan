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
    public partial class ufrm_TTPhanQuyen : UserControl
    {
        Database db = new Database();

        private BLL_QuanLyPhanQuyen BLL_QuanLyPhanQuyen;

        public ufrm_TTPhanQuyen()
        {
            InitializeComponent();
            BLL_QuanLyPhanQuyen = new BLL_QuanLyPhanQuyen(new Database().GetDataSet());

            LoadPhanQuyen();
        }

        public void LoadPhanQuyen()
        {
            try
            {
                data_TTPhanQuyen.DataSource = BLL_QuanLyPhanQuyen.GetDataPhanQuyen();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin liên kết nối : " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTimKiemTTPhanQuyen_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiemTTPhanQuyen.Text.Trim();

            DataTable dt = BLL_QuanLyPhanQuyen.TimKiemPhanQuyen(keyword);

            data_TTPhanQuyen.DataSource = dt;
        }
    }
}
