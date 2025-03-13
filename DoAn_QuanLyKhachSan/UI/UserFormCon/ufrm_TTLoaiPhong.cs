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
    public partial class ufrm_TTLoaiPhong : UserControl
    {
        Database db = new Database();

        private BLL_LoaiPhong BLL_LoaiPhong;
        public ufrm_TTLoaiPhong()
        {
            InitializeComponent();
            BLL_LoaiPhong = new BLL_LoaiPhong(new Database().GetDataSet());

            LoadLoaiPhong();
        }

        public void LoadLoaiPhong()
        {
            try
            {
                data_TTLoaiPhong.DataSource = BLL_LoaiPhong.GetDataLoaiPhong();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin liên kết nối : " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void data_TTLoaiPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTimKiemTTLoaiPhong_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiemTTLoaiPhong.Text.Trim();

            DataTable dt = BLL_LoaiPhong.SearchLoaiPhong(keyword);

            data_TTLoaiPhong.DataSource = dt;
        }
    }
}
