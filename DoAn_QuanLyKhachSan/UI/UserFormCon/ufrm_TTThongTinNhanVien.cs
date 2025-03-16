using BLL;
using DAL.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            LoadNhanVienComboBox();

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

        public void LoadNhanVienComboBox()
        {
            string connectionString = new Database().GetDataSet();

            string query = "SELECT ID_TAIKHOAN, EMAIL FROM TAIKHOAN";


            var selectedValue = cbIDTaiKhoan.SelectedValue;

            SqlDataAdapter da = new SqlDataAdapter(query, connectionString);

            DataTable dt = new DataTable();

            da.Fill(dt);

            cbIDTaiKhoan.DisplayMember = "EMAIL";

            cbIDTaiKhoan.ValueMember = "ID_TAIKHOAN";

            cbIDTaiKhoan.DataSource = dt;


            if (selectedValue != null && dt.AsEnumerable().Any(row => row["ID_TAIKHOAN"].ToString() == selectedValue.ToString()))
            {
                cbIDTaiKhoan.SelectedValue = selectedValue;
            }
            else
            {

                cbIDTaiKhoan.SelectedIndex = -1;
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

        private void data_TTNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow rowst = data_TTNhanVien.Rows[e.RowIndex];

                iD_NHANVIENTextBox.Text = rowst.Cells["ID_NHANVIEN"]?.Value != DBNull.Value ? rowst.Cells["ID_NHANVIEN"].Value.ToString() : "";

                hOTENTextBox.Text = rowst.Cells["HOTEN"]?.Value != DBNull.Value ? rowst.Cells["HOTEN"].Value.ToString() : "";

                //nGAYSINHDateTimePicker.Text = rowst.Cells["NGAYSINH"]?.Value != DBNull.Value ? rowst.Cells["NGAYSINH"].Value.ToString() : "";

                if (rowst.Cells["NGAYSINH"]?.Value != DBNull.Value && rowst.Cells["NGAYSINH"]?.Value != null)
                {
                    nGAYSINHDateTimePicker.Text = rowst.Cells["NGAYSINH"].Value.ToString();
                }
                else
                {
                    nGAYSINHDateTimePicker.Value = DateTime.Now;
                }

                dIACHITextBox.Text = rowst.Cells["DIACHI"]?.Value != DBNull.Value ? rowst.Cells["DIACHI"].Value.ToString() : "";

                sDTTextBox.Text = rowst.Cells["SDT"]?.Value != DBNull.Value ? rowst.Cells["SDT"].Value.ToString() : "";

                tONGNGAYCONGTextBox.Text = rowst.Cells["TONGNGAYCONG"]?.Value != DBNull.Value ? rowst.Cells["TONGNGAYCONG"].Value.ToString() : "";

                tONGLUONGTextBox.Text = rowst.Cells["TONGLUONG"]?.Value != DBNull.Value ? rowst.Cells["TONGLUONG"].Value.ToString() : "";

                //cbIDTaiKhoan.SelectedValue = rowst.Cells["ID_TAIKHOAN"]?.Value != DBNull.Value ? rowst.Cells["ID_TAIKHOAN"].Value : 0;

                if (rowst.Cells["ID_TAIKHOAN"]?.Value != null && rowst.Cells["ID_TAIKHOAN"].Value != DBNull.Value)
                {
                    int idTaiKhoan = Convert.ToInt32(rowst.Cells["ID_TAIKHOAN"].Value);
                    cbIDTaiKhoan.SelectedValue = idTaiKhoan;
                }
                else
                {
                    cbIDTaiKhoan.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void data_TTNhanVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (data_TTNhanVien.Columns[e.ColumnIndex].Name == "TONGLUONG" && e.Value != null)
            {
                if (decimal.TryParse(e.Value.ToString(), out decimal mucLuong))
                {

                    e.Value = string.Format("{0:N0} VND", mucLuong);
                    e.FormattingApplied = true;
                }
            }
        }

        private void tONGLUONGTextBox_TextChanged(object sender, EventArgs e)
        {
            string input = tONGLUONGTextBox.Text.Replace(".", "").Replace(" VND", "").Trim();

            if (decimal.TryParse(input, out decimal mucLuong))
            {

                tONGLUONGTextBox.Text = string.Format("{0:N0} VND", mucLuong);
                tONGLUONGTextBox.SelectionStart = tONGLUONGTextBox.Text.Length;
            }
        }
    }
}
