using BLL;
using DAL.DAL.DoAn_QuanLyKhachSan.DAL;
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

namespace DoAn_QuanLyKhachSan.UI.UserFormCon
{
    public partial class ufrm_CRUDTaiKhoan : UserControl
    {

        Database db = new Database();

        private BLL_TaiKhoan BLL_TaiKhoan;

        private Timer taiKhoanTimer;


        public ufrm_CRUDTaiKhoan()
        {
            InitializeComponent();

            BLL_TaiKhoan = new BLL_TaiKhoan(new Database().GetDataSet());

            LoadTaiKhoan();

            // LoadTaiKhoan();

            taiKhoanTimer = new Timer();
            taiKhoanTimer.Interval = 1000;
            taiKhoanTimer.Tick += (s, e) => LoadTaiKhoanComboBox();
            taiKhoanTimer.Start();
        }



        private void btnTroLaiTaiKhoan_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            ufrm_QuanLyTaiKhoan quanly = new ufrm_QuanLyTaiKhoan();
            this.Controls.Add(quanly);
            quanly.Dock = DockStyle.Fill;
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------

        public void LoadTaiKhoanComboBox()
        {
            string connectionString = new Database().GetDataSet();

            string query = "SELECT ID_PHANQUYEN, TENQUYEN FROM PHANQUYEN";


            var selectedValue = cbIDPhanQuyen.SelectedValue;

            SqlDataAdapter da = new SqlDataAdapter(query, connectionString);

            DataTable dt = new DataTable();

            da.Fill(dt);

            cbIDPhanQuyen.DisplayMember = "TENQUYEN";

            cbIDPhanQuyen.ValueMember = "ID_PHANQUYEN";

            cbIDPhanQuyen.DataSource = dt;


            if (selectedValue != null && dt.AsEnumerable().Any(row => row["ID_PHANQUYEN"].ToString() == selectedValue.ToString()))
            {
                cbIDPhanQuyen.SelectedValue = selectedValue;
            }
            else
            {

                cbIDPhanQuyen.SelectedIndex = 0;
            }
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------
        // HÀM LOAD DỮ LIỆU TÀI KHOẢN
        public void LoadTaiKhoan()
        {
            try
            {
                data_TaiKhoan.DataSource = BLL_TaiKhoan.GetDataTaiKhoan();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin liên kết nối : " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //-----------------------------------------------------------------------------------------------------------------------------------------------



        private void tAIKHOANBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tAIKHOANBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.heThongKhachSanDataSet);

        }
        //-----------------------------------------------------------------------------------------------------------------------------------------------
        //nut tro lai
        private void btnTroLaiQLTTP_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            ufrm_QuanLyTaiKhoan quanly = new ufrm_QuanLyTaiKhoan();
            this.Controls.Add(quanly);
            quanly.Dock = DockStyle.Fill;
        }

        //------------------------------------------------------------------------------------------------------------------------------------------------


        // HÀM TÌM KIẾM TÀI KHOẢN
        private void btnTimKiemTaiKhoan_Click(object sender, EventArgs e)
        {
            try
            {
                data_TaiKhoan.DataSource = BLL_TaiKhoan.SearchTaiKhoan(eMAILTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin liên kết nối : " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------

        // HÀM LÀM MỚI THÔNG TIN

        private void btnDonThongTin()
        {
            iD_TAIKHOANTextBox.Text = "";
            eMAILTextBox.Text = "";
            mATKHAUTextBox.Text = "";
            cbIDPhanQuyen.SelectedIndex = 0;
        }
        //-----------------------------------------------------------------------------------------------------------------------------------------------

        // HÀM HIỂN THỊ DỮ LIỆU TỪ DATAGRIDVIEW LÊN TEXTBOX

        private void data_TaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow rowst = data_TaiKhoan.Rows[e.RowIndex];

                iD_TAIKHOANTextBox.Text = rowst.Cells["ID_TAIKHOAN"]?.Value != DBNull.Value ? rowst.Cells["ID_TAIKHOAN"].Value.ToString() : "";

                eMAILTextBox.Text = rowst.Cells["EMAIL"]?.Value != DBNull.Value ? rowst.Cells["EMAIL"].Value.ToString() : "";

                mATKHAUTextBox.Text = rowst.Cells["MATKHAU"]?.Value != DBNull.Value ? rowst.Cells["MATKHAU"].Value.ToString() : "";

                if (rowst.Cells["ID_PHANQUYEN"]?.Value != null && rowst.Cells["ID_PHANQUYEN"].Value != DBNull.Value)
                {
                    int idTaiKhoan = Convert.ToInt32(rowst.Cells["ID_PHANQUYEN"].Value);
                    cbIDPhanQuyen.SelectedValue = idTaiKhoan;
                }
                else
                {
                    cbIDPhanQuyen.SelectedIndex = -1;
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin liên kết nối : " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------

        // HÀM THÊM TÀI KHOẢN
        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {
            try
            {

                TaiKhoan taikhoan = new TaiKhoan()
                {
                    EMAIL = eMAILTextBox.Text,
                    MATKHAU = mATKHAUTextBox.Text,
                    ID_PHANQUYEN = (int)cbIDPhanQuyen.SelectedValue,
                };

                BLL_TaiKhoan.AddTaiKhoan(taikhoan);

                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadTaiKhoan();

                btnDonThongTin();

            }

            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin liên kết nối : " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------

        // HÀM XÓA TÀI KHOẢN
        private void btnSuaTaiKhoan_Click(object sender, EventArgs e)
        {
            try
            {
                TaiKhoan taikhoan = new TaiKhoan()
                {
                    ID_TAIKHOAN = int.Parse(iD_TAIKHOANTextBox.Text),
                    EMAIL = eMAILTextBox.Text,
                    MATKHAU = mATKHAUTextBox.Text,
                    ID_PHANQUYEN = (int)cbIDPhanQuyen.SelectedValue,
                };
                BLL_TaiKhoan.UpdateTaiKhoan(taikhoan);
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTaiKhoan();
                btnDonThongTin();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin liên kết nối : " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //-----------------------------------------------------------------------------------------------------------------------------------------------

        // HÀM CẬP NHẬT TÀI KHOẢN
        private void btnXoaTaiKhoan_Click(object sender, EventArgs e)
        {
            try
            {
                int ID_TAIKHOAN = int.Parse(iD_TAIKHOANTextBox.Text);

                BLL_TaiKhoan.DeleteTaiKhoan(ID_TAIKHOAN);

                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadTaiKhoan();

                btnDonThongTin();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin liên kết nối : " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearTaiKhoan_Click(object sender, EventArgs e)
        {
            btnDonThongTin();
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------
        // HÀM TÌM KIẾM TÀI KHOẢN
        
        private void txtTimKiemnTaiKhoan_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiemTaiKhoan.Text.Trim();

            DataTable dt = BLL_TaiKhoan.SearchTaiKhoan(keyword);

            data_TaiKhoan.DataSource = dt;
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------
    }
}
