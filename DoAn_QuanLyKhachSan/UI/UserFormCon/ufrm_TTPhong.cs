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
    public partial class ufrm_TTPhong : UserControl
    {
        Database db = new Database();

        private BLL_Phong BLL_Phong;

        private Timer taiKhoanTimer;


        public ufrm_TTPhong()
        {
            InitializeComponent();
            BLL_Phong = new BLL_Phong(new Database().GetDataSet());

            LoadPhong();

            taiKhoanTimer = new Timer();
            taiKhoanTimer.Interval = 1000;
            taiKhoanTimer.Tick += (s, e) => LoadMaLoaiPhongComboBox();
            taiKhoanTimer.Start();


            taiKhoanTimer = new Timer();
            taiKhoanTimer.Interval = 1000;
            taiKhoanTimer.Tick += (s, e) => LoadTangLauComboBox();
            taiKhoanTimer.Start();

        }

        public void LoadPhong()
        {
            try
            {
                data_TTPhong.DataSource = BLL_Phong.GetDataPhong();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin liên kết nối : " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadMaLoaiPhongComboBox()
        {
            string connectionString = new Database().GetDataSet();

            string query = "SELECT MaLoaiPhong, TenLoaiPhong FROM LOAI_PHONG";


            var selectedValue = cbMaLoaiPhong.SelectedValue;

            SqlDataAdapter da = new SqlDataAdapter(query, connectionString);

            DataTable dt = new DataTable();

            da.Fill(dt);

            cbMaLoaiPhong.DisplayMember = "TenLoaiPhong";

            cbMaLoaiPhong.ValueMember = "MaLoaiPhong";

            cbMaLoaiPhong.DataSource = dt;


            if (selectedValue != null && dt.AsEnumerable().Any(row => row["MaLoaiPhong"].ToString() == selectedValue.ToString()))
            {
                cbMaLoaiPhong.SelectedValue = selectedValue;
            }
            else
            {

                cbMaLoaiPhong.SelectedIndex = -1;
            }
        }

        //-----------------------------------------------------------------------------------------------------------------------------------

        public void LoadTangLauComboBox()
        {
            string connectionString = new Database().GetDataSet();

            string query = "SELECT MaTang, TenTang FROM TangLau";


            var selectedValue = cbTang.SelectedValue;

            SqlDataAdapter da = new SqlDataAdapter(query, connectionString);

            DataTable dt = new DataTable();

            da.Fill(dt);

            cbTang.DisplayMember = "TenTang";

            cbTang.ValueMember = "MaTang";

            cbTang.DataSource = dt;


            if (selectedValue != null && dt.AsEnumerable().Any(row => row["MaTang"].ToString() == selectedValue.ToString()))
            {
                cbTang.SelectedValue = selectedValue;
            }
            else
            {

                cbTang.SelectedIndex = -1;
            }
        }

        //-----------------------------------------------------------------------------------------------------------------------------------



        private void txtTimKiemTTPhong_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiemTTPhong.Text.Trim();

            DataTable dt = BLL_Phong.SearchPhong(keyword);

            data_TTPhong.DataSource = dt;
        }

        private void data_TTPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow rowst = data_TTPhong.Rows[e.RowIndex];

                maPhongTextBox.Text = rowst.Cells["MaPhong"]?.Value != DBNull.Value ? rowst.Cells["MaPhong"].Value.ToString() : "";


                tenPhongTextBox.Text = rowst.Cells["TenPhong"]?.Value != DBNull.Value ? rowst.Cells["TenPhong"].Value.ToString() : "";

                tinhTrangTextBox.Text = rowst.Cells["TinhTrang"]?.Value != DBNull.Value ? rowst.Cells["TinhTrang"].Value.ToString() : "";


                if (rowst.Cells["MaLoaiPhong"]?.Value != null && rowst.Cells["MaLoaiPhong"].Value != DBNull.Value)
                {
                    int MaLoaiPhong = Convert.ToInt32(rowst.Cells["MaLoaiPhong"].Value);
                    cbMaLoaiPhong.SelectedValue = MaLoaiPhong;
                }
                else
                {
                    cbMaLoaiPhong.SelectedIndex = -1;
                }

                if (rowst.Cells["MaTang"]?.Value != null && rowst.Cells["MaTang"].Value != DBNull.Value)
                {
                    int MaThietBi = Convert.ToInt32(rowst.Cells["MaTang"].Value);
                    cbTang.SelectedValue = MaThietBi;
                }
                else
                {
                    cbTang.SelectedIndex = -1;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void data_TTPhong_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (data_TTPhong.Columns[e.ColumnIndex].Name == "Gia" && e.Value != null)
            {
                if (decimal.TryParse(e.Value.ToString(), out decimal mucLuong))
                {

                    e.Value = string.Format("{0:N0} VND", mucLuong);
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
