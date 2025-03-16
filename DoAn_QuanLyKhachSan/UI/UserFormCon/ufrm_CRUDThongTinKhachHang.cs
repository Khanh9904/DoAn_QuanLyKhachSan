using BLL;
using DAL.Database;
using DAL.Model;
using DoAn_QuanLyKhachSan.UI.UseFormChinh;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QuanLyKhachSan.UI.UseForm
{
    public partial class ufrm_CRUDThongTinKhachHang : UserControl
    {

        Database Database = new Database();

        public BLL_ThongTinKhachHang BLL_ThongTinKhachHang;

        public ufrm_CRUDThongTinKhachHang()
        {
            InitializeComponent();

            BLL_ThongTinKhachHang = new BLL_ThongTinKhachHang(Database.GetDataSet());

            LoadKhachHang();

        }

        private void kHACH_HANGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kHACH_HANGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.heThongKhachSanDataSet);

        }

        
        //----------------------------------------------------------------------------------------------------------------------------------------------

        // Hàm load dữ liệu khách hàng
        public void LoadKhachHang()
        {
            try
            {
                data_ThongTinKhachHang.DataSource = BLL_ThongTinKhachHang.GetDataKhachHang();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin liên kết nối : " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //----------------------------------------------------------------------------------------------------------------------------------------------

        //dàm dọn thông tin
        public void btnDonThongTin()
        {
            maKhachHangTextBox.Text = "";
            hoTenTextBox.Text = "";
            ngaySinhDateTimePicker.Text = "";
            gioiTinhTextBox.Text = "";
            sDTTextBox.Text = "";
            diaChiTextBox.Text = "";
            cCCDTextBox.Text = "";
        }
        //----------------------------------------------------------------------------------------------------------------------------------------------

        // Thêm thông tin khách hàng
        private void btnThemThongTinKhachHang_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime ngaysinh = ngaySinhDateTimePicker.Value;

                ThongTinKhachHang thongtinkhachhang = new ThongTinKhachHang()
                {
                    HoTen = hoTenTextBox.Text,
                    NgaySinh = ngaysinh,
                    GioiTinh = gioiTinhTextBox.Text,
                    SDT = int.Parse(sDTTextBox.Text.Trim()),
                    DiaChi = diaChiTextBox.Text,
                    CCCD = cCCDTextBox.Text
                };

                BLL_ThongTinKhachHang.AddKhachHang(thongtinkhachhang);

                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadKhachHang();

                btnDonThongTin();

            }

            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin liên kết nối : " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //----------------------------------------------------------------------------------------------------------------------------------------------

        // Sửa thông tin khách hàng
        private void btnSuaThongTinKhachHang_Click(object sender, EventArgs e)
        {

            try
            {
                DateTime ngaysinh = ngaySinhDateTimePicker.Value;

                ThongTinKhachHang thongtinkhachhang = new ThongTinKhachHang()
                {
                    MaKhachHang = Convert.ToInt32(data_ThongTinKhachHang.CurrentRow.Cells["MaKhachHang"].Value),

                    HoTen = hoTenTextBox.Text.Trim(),

                    NgaySinh = ngaysinh,

                    GioiTinh = gioiTinhTextBox.Text.Trim(),

                    SDT = int.Parse(sDTTextBox.Text.Trim()),

                    DiaChi = diaChiTextBox.Text.Trim(),

                    CCCD = cCCDTextBox.Text.Trim()

                };
                BLL_ThongTinKhachHang.UpdateKhachHang(thongtinkhachhang);

                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadKhachHang();

                btnDonThongTin();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin liên kết nối : " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //----------------------------------------------------------------------------------------------------------------------------------------------

        // Xóa thông tin khách hàng
        private void btnXoaThongTinKhachHang_Click(object sender, EventArgs e)
        {

            try
            {
                if (data_ThongTinKhachHang.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn khách hàng cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }
                int MaKhachHang = Convert.ToInt32(data_ThongTinKhachHang.CurrentRow.Cells["MaKhachHang"].Value);

                BLL_ThongTinKhachHang.DeleteKhachHang(MaKhachHang);

                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadKhachHang();

                btnDonThongTin();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin liên kết nối : " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //----------------------------------------------------------------------------------------------------------------------------------------------

        // dọn  thông tin
        private void btnClearThongTinKhachHang_Click(object sender, EventArgs e)
        {
            btnDonThongTin();
        }

        private void data_ThongTinKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                DataGridViewRow rowst = data_ThongTinKhachHang.Rows[e.RowIndex];

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

        private void txtTimKiemThongTinKhachHang_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiemThongTinKhachHang.Text.Trim();

            DataTable dt = BLL_ThongTinKhachHang.SearchKhachHang(keyword);

            data_ThongTinKhachHang.DataSource = dt;
        }

        private void ufrm_CRUDThongTinKhachHang_Load(object sender, EventArgs e)
        {

        }
    }
}
