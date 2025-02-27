using BLL;
using DAL.DAL;
using DAL.Database;
using DAL.Model;
using DoAn_QuanLyKhachSan.UI.UseForm;
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

namespace DoAn_QuanLyKhachSan.UI.UserFormPhu
{
    public partial class ufrm_CRUDThongTinNhanVien : UserControl
    {

        // tạo đối tượng gọi kết nối
        Database db = new Database();

        private BLL_ThongTinNhanVien BLL_ThongTinNhanVien;
        //--------------------------------------------------------------------------------

        private Timer taiKhoanTimer;




        public ufrm_CRUDThongTinNhanVien()
        {
            InitializeComponent();

            BLL_ThongTinNhanVien = new BLL_ThongTinNhanVien(new Database().GetDataSet());

            LoadNhanVien();

            taiKhoanTimer = new Timer();
            taiKhoanTimer.Interval = 1000;
            taiKhoanTimer.Tick += (s, e) => LoadNhanVienComboBox();
            taiKhoanTimer.Start();


        }
        //--------------------------------------------------------------------------------
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

                cbIDTaiKhoan.SelectedIndex = 0;
            }
        }

        //--------------------------------------------------------------------------------
        //Hàm load dữ liệu nhân viên
        public void LoadNhanVien()
        {
            try
            {
                data_NhanVien.DataSource = BLL_ThongTinNhanVien.GetDataNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin liên kết nối : " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void nHAN_VIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nHAN_VIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.heThongKhachSanDataSet);

        }


        //--------------------------------------------------------------------------------
        private void btnTroLaiNhanVien_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            ufrm_QuanLyNhanVien quanly = new ufrm_QuanLyNhanVien();
            this.Controls.Add(quanly);
            quanly.Dock = DockStyle.Fill;
        }

        //---------------------------------------------------------------------------------
        //hàm dọn thông tin
        public void btnDonThongTin()
        {
            iD_NHANVIENTextBox.Text = "";
            hOTENTextBox.Text = "";
            nGAYSINHDateTimePicker.Text = "";
            dIACHITextBox.Text = "";
            sDTTextBox.Text = "";
        }
        



        //-------------------------------------------------------------------------------------------------------------------------------------------------
        // Ham them nhan vien
        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime ngaysinh = nGAYSINHDateTimePicker.Value;

                NhanVien nhanVien = new NhanVien()
                {
                    HOTEN = hOTENTextBox.Text,
                    NGAYSINH = ngaysinh,
                    DIACHI = dIACHITextBox.Text,
                    SDT = sDTTextBox.Text,
                    TONGNGAYCONG = int.Parse(tONGNGAYCONGTextBox.Text.Trim()),
                    TONGLUONG = int.Parse(tONGLUONGTextBox.Text.Trim()),
                    ID_TAIKHOAN = (int)cbIDTaiKhoan.SelectedValue,
                };

                BLL_ThongTinNhanVien.AddNhanVien(nhanVien);

                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadNhanVien();

                btnDonThongTin();

            }

            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin liên kết nối : " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //------------------------------------------------------------------------------------------------------------------------------------------------
       

        private void data_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow rowst = data_NhanVien.Rows[e.RowIndex];

                iD_NHANVIENTextBox.Text = rowst.Cells["ID_NHANVIEN"]?.Value != DBNull.Value ? rowst.Cells["ID_NHANVIEN"].Value.ToString() : "";

                hOTENTextBox.Text = rowst.Cells["HOTEN"]?.Value != DBNull.Value ? rowst.Cells["HOTEN"].Value.ToString() : "";

                //nGAYSINHDateTimePicker.Text = rowst.Cells["NGAYSINH"]?.Value != DBNull.Value ? rowst.Cells["NGAYSINH"].Value.ToString() : "";

                if (rowst.Cells["NGAYSINH"]?.Value != DBNull.Value && rowst.Cells["NGAYSINH"]?.Value != null)
                {
                    nGAYSINHDateTimePicker.Text = rowst.Cells["NGAYSINH"].Value.ToString();
                }
                else { 
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

        //---------------------------------------------------------------------------------------------------------------------------------------------
        //hàm xóa nhân viên

        private void btnXoaNhanVien_Click(object sender, EventArgs e)
        {
            try
            {
                if (data_NhanVien.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn nhân viên cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int ID_NHANVIEN = Convert.ToInt32(data_NhanVien.CurrentRow.Cells["ID_NHANVIEN"].Value);

                BLL_ThongTinNhanVien.DeleteNhanVien(ID_NHANVIEN);

                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadNhanVien();

                btnDonThongTin();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin liên kết nối : " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        //------------------------------------------------------------------------------------------------------------------------------------------------
        //hàm sửa nhân viên

        private void btnSuaNhanVien_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime ngaysinh = nGAYSINHDateTimePicker.Value;

                NhanVien nhanVien = new NhanVien()
                {
                    ID_NHANVIEN = Convert.ToInt32(data_NhanVien.CurrentRow.Cells["ID_NHANVIEN"].Value), 

                    HOTEN = hOTENTextBox.Text.Trim(),

                    NGAYSINH = ngaysinh,

                    DIACHI = dIACHITextBox.Text.Trim(),

                    SDT = sDTTextBox.Text.Trim(),

                    TONGNGAYCONG = int.Parse(tONGNGAYCONGTextBox.Text.Trim()),

                    TONGLUONG = int.Parse(tONGLUONGTextBox.Text.Trim()),

                    ID_TAIKHOAN = (int)cbIDTaiKhoan.SelectedValue,

                };

                BLL_ThongTinNhanVien.UpdateNhanVien(nhanVien);

                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadNhanVien();

                btnDonThongTin();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin liên kết nối : " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //------------------------------------------------------------------------------------------------------------------------------------------------
        //hàm clear thông tin

        private void btnClearNhanVien_Click(object sender, EventArgs e)
        {
            btnDonThongTin();
        }

        private void cbIDTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        //------------------------------------------------------------------------------------------------------------------------------------------------
        //hàm tìm kiếm nhân viên
        private void txtTimKiemNhanVien_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiemNhanVien.Text.Trim();

            DataTable dt = BLL_ThongTinNhanVien.SearchNhanVien(keyword);

            data_NhanVien.DataSource = dt;
        }

        private void data_NhanVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (data_NhanVien.Columns[e.ColumnIndex].Name == "TONGLUONG" && e.Value != null)
            {
                if (decimal.TryParse(e.Value.ToString(), out decimal mucLuong))
                {

                    e.Value = string.Format("{0:N0} VND", mucLuong);
                    e.FormattingApplied = true;
                }
            }
        }

        //------------------------------------------------------------------------------------------------------------------------------------------------



    }
}
