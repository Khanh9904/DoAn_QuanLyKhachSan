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

        private void data_TTLoaiPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow rowst = data_TTLoaiPhong.Rows[e.RowIndex];

                maLoaiPhongTextBox.Text = rowst.Cells["MaLoaiPhong"]?.Value != DBNull.Value ? rowst.Cells["MaLoaiPhong"].Value.ToString() : "";


                tenLoaiPhongTextBox.Text = rowst.Cells["TenLoaiPhong"]?.Value != DBNull.Value ? rowst.Cells["TenLoaiPhong"].Value.ToString() : "";

                giaTextBox.Text = rowst.Cells["Gia"]?.Value != DBNull.Value ? rowst.Cells["Gia"].Value.ToString() : "";

                soNguoiToiDaTextBox.Text = rowst.Cells["SoNguoiToiDa"]?.Value != DBNull.Value ? rowst.Cells["SoNguoiToiDa"].Value.ToString() : "";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void giaTextBox_TextChanged(object sender, EventArgs e)
        {
            string input = giaTextBox.Text.Replace(".", "").Replace(" VND", "").Trim();

            if (decimal.TryParse(input, out decimal mucLuong))
            {

                giaTextBox.Text = string.Format("{0:N0} VND", mucLuong);
                giaTextBox.SelectionStart = giaTextBox.Text.Length;
            }
        }
    }
}
