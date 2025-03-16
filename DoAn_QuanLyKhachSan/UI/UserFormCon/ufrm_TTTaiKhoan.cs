using BLL;
using DAL.DAL.DoAn_QuanLyKhachSan.DAL;
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
    public partial class ufrm_TTTaiKhoan : UserControl
    {
        Database db = new Database();

        private BLL_TaiKhoan BLL_TaiKhoan;
        private Timer taiKhoanTimer;


        public ufrm_TTTaiKhoan()
        {
            InitializeComponent();

            BLL_TaiKhoan = new BLL_TaiKhoan(new Database().GetDataSet());

            LoadTaiKhoan();

            taiKhoanTimer = new Timer();
            taiKhoanTimer.Interval = 1000;
            taiKhoanTimer.Tick += (s, e) => LoadTaiKhoanComboBox();
            taiKhoanTimer.Start();
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

                cbIDPhanQuyen.SelectedIndex = -1;
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

        private void data_TTTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow rowst = data_TTTaiKhoan.Rows[e.RowIndex];

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
    }
}
