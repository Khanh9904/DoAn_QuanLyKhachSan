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

        private void data_TTTTKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow rowst = data_TTTTKH.Rows[e.RowIndex];

                maKhachHangTextBox.Text = rowst.Cells["MaKhachHang"]?.Value != DBNull.Value ? rowst.Cells["MaKhachHang"].Value.ToString() : "";

                hoTenTextBox.Text = rowst.Cells["HoTen"]?.Value != DBNull.Value ? rowst.Cells["HoTen"].Value.ToString() : "";


                if (rowst.Cells["NgaySinh"]?.Value != DBNull.Value && rowst.Cells["NgaySinh"]?.Value != null)
                {
                    ngaySinhDateTimePicker.Text = rowst.Cells["NgaySinh"].Value.ToString();
                }
                else
                {
                    ngaySinhDateTimePicker.Value = DateTime.Now;
                }

                gioiTinhTextBox.Text = rowst.Cells["GioiTinh"]?.Value != DBNull.Value ? rowst.Cells["GioiTinh"].Value.ToString() : "";

                sDTTextBox.Text = rowst.Cells["SDT"]?.Value != DBNull.Value ? rowst.Cells["SDT"].Value.ToString() : "";

                diaChiTextBox.Text = rowst.Cells["DiaChi"]?.Value != DBNull.Value ? rowst.Cells["DiaChi"].Value.ToString() : "";

                cCCDTextBox.Text = rowst.Cells["CCCD"]?.Value != DBNull.Value ? rowst.Cells["CCCD"].Value.ToString() : "";


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
