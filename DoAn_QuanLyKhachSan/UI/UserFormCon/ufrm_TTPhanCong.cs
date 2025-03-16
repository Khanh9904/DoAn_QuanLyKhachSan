using BLL;
using DAL.DAL;
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
    public partial class ufrm_TTPhanCong : UserControl
    {
        Database db = new Database();

        private BLL_PhanCongCaLam BLL_PhanCongCaLam;

        private Timer taiKhoanTimer;


        public ufrm_TTPhanCong()
        {
            InitializeComponent();
            BLL_PhanCongCaLam = new BLL_PhanCongCaLam(new Database().GetDataSet());

            LoadPhanCong();

            taiKhoanTimer = new Timer();
            taiKhoanTimer.Interval = 1000;
            taiKhoanTimer.Tick += (s, e) => LoadNhanVienComboBox();
            taiKhoanTimer.Start();


            taiKhoanTimer = new Timer();
            taiKhoanTimer.Interval = 1000;
            taiKhoanTimer.Tick += (s, e) => LoadMaCaComboBox();
            taiKhoanTimer.Start();
        }

        public void LoadPhanCong()
        {
            try
            {
                data_TTPhanCong.DataSource = BLL_PhanCongCaLam.GetDataPhanCongCaLam();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin liên kết nối : " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadNhanVienComboBox()
        {
            string connectionString = new Database().GetDataSet();

            string query = "SELECT ID_NHANVIEN, HOTEN FROM NHAN_VIEN";


            var selectedValue = cbNhanVien.SelectedValue;

            SqlDataAdapter da = new SqlDataAdapter(query, connectionString);

            DataTable dt = new DataTable();

            da.Fill(dt);

            cbNhanVien.DisplayMember = "HOTEN";

            cbNhanVien.ValueMember = "ID_NHANVIEN";

            cbNhanVien.DataSource = dt;


            if (selectedValue != null && dt.AsEnumerable().Any(row => row["ID_NHANVIEN"].ToString() == selectedValue.ToString()))
            {
                cbNhanVien.SelectedValue = selectedValue;
            }
            else
            {

                cbNhanVien.SelectedIndex = -1;
            }
        }

        // ham load combobox ma ca
        public void LoadMaCaComboBox()
        {
            string connectionString = new Database().GetDataSet();

            string query = "SELECT ID_CALAM, TENCA FROM CALAMVIEC";


            var selectedValue = cbMaCa.SelectedValue;

            SqlDataAdapter da = new SqlDataAdapter(query, connectionString);

            DataTable dt = new DataTable();

            da.Fill(dt);

            cbMaCa.DisplayMember = "TENCA";

            cbMaCa.ValueMember = "ID_CALAM";

            cbMaCa.DataSource = dt;


            if (selectedValue != null && dt.AsEnumerable().Any(row => row["ID_CALAM"].ToString() == selectedValue.ToString()))
            {
                cbMaCa.SelectedValue = selectedValue;
            }
            else
            {

                cbMaCa.SelectedIndex = -1;
            }
        }


        private void ufrm_TTPhanCong_Load(object sender, EventArgs e)
        {

        }

        private void txtTimKiemTTPhanCong_TextChanged(object sender, EventArgs e)
        {
            //string keyword = txtTimKiemTTPhanCong.Text.Trim();
            //DataTable dt = BLL_PhanCongCaLam.SearchPhanCongCaLam(keyword);
            //data_TTPhanCong.DataSource = dt;
        }

        private void data_TTPhanCong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow rowst = data_TTPhanCong.Rows[e.RowIndex];

                iD_PHANCONGTextBox.Text = rowst.Cells["ID_PHANCONG"]?.Value != DBNull.Value ? rowst.Cells["ID_PHANCONG"].Value.ToString() : "";


                if (rowst.Cells["NGAYLAM"]?.Value != DBNull.Value && rowst.Cells["NGAYLAM"]?.Value != null)
                {
                    nGAYLAMDateTimePicker.Text = rowst.Cells["NGAYLAM"].Value.ToString();
                }
                else
                {
                    nGAYLAMDateTimePicker.Value = DateTime.Now;
                }

                if (rowst.Cells["ID_NHANVIEN"]?.Value != null && rowst.Cells["ID_NHANVIEN"].Value != DBNull.Value)
                {
                    int ID_NHANVIEN = Convert.ToInt32(rowst.Cells["ID_NHANVIEN"].Value);
                    cbNhanVien.SelectedValue = ID_NHANVIEN;
                }
                else
                {
                    cbNhanVien.SelectedIndex = -1;
                }

                if (rowst.Cells["ID_CALAM"]?.Value != null && rowst.Cells["ID_CALAM"].Value != DBNull.Value)
                {
                    int ID_CALAM = Convert.ToInt32(rowst.Cells["ID_CALAM"].Value);
                    cbMaCa.SelectedValue = ID_CALAM;
                }
                else
                {
                    cbMaCa.SelectedIndex = -1;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
