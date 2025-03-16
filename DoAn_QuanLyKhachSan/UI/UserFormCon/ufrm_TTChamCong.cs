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
    public partial class ufrm_TTChamCong : UserControl
    {
        Database db = new Database();
        private BLL_ChamCong BLL_ChamCong;
        private Timer nhanvienTimer;


        public ufrm_TTChamCong()
        {
            InitializeComponent();
            BLL_ChamCong = new BLL_ChamCong(new Database().GetDataSet());
            LoadChamcong();
            nhanvienTimer = new Timer();
            nhanvienTimer.Interval = 1000;
            nhanvienTimer.Tick += (s, i) => LoadCBnhanvien();
            nhanvienTimer.Start();

        }

        public void LoadChamcong()
        {
            try
            {
                data_TTChamCong.DataSource = BLL_ChamCong.GetDataChamcong();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin kết nối:" + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void LoadCBnhanvien()
        {
            string connectionString = new Database().GetDataSet();
            string query = "SELECT ID_NHANVIEN , HOTEN FROM NHAN_VIEN";


            var selectedValue = cb_nhanvien.SelectedValue;

            SqlDataAdapter da = new SqlDataAdapter(query, connectionString);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cb_nhanvien.DisplayMember = "HOTEN";
            cb_nhanvien.ValueMember = "ID_NHANVIEN";
            cb_nhanvien.DataSource = dt;


            if (selectedValue != null && dt.AsEnumerable().Any(row => row["ID_NHANVIEN"].ToString() == selectedValue.ToString()))
            {
                cb_nhanvien.SelectedValue = selectedValue;
            }
            else
            {

                cb_nhanvien.SelectedIndex = -1;
            }
        }

        private void txtTimKiemTTChamCong_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiemTTChamCong.Text.Trim();
            DataTable dt = BLL_ChamCong.timkiemchamcong(keyword);
            data_TTChamCong.DataSource = dt;
        }

        private void data_TTChamCong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow rowst = data_TTChamCong.Rows[e.RowIndex];


                txt_machamcong.Text = rowst.Cells["ID_CHAMCONG"]?.Value != DBNull.Value ? rowst.Cells["ID_CHAMCONG"].Value.ToString() : "";

                cb_trangthai.Text = rowst.Cells["TRANGTHAI"]?.Value != DBNull.Value ? rowst.Cells["TRANGTHAI"].Value.ToString() : "";



                if (rowst.Cells["NGAYLAMVIEC"]?.Value != DBNull.Value && rowst.Cells["NGAYLAMVIEC"]?.Value != null)
                {
                    dtngaylam.Text = rowst.Cells["NGAYLAMVIEC"].Value.ToString();
                }
                else
                {
                    dtngaylam.Value = DateTime.Now;
                }

                if (rowst.Cells["ID_NHANVIEN"]?.Value != null && rowst.Cells["ID_NHANVIEN"].Value != DBNull.Value)
                {
                    int manhanvien = Convert.ToInt32(rowst.Cells["ID_NHANVIEN"].Value);
                    cb_nhanvien.SelectedValue = manhanvien;
                }
                else
                {
                    cb_nhanvien.SelectedIndex = -1;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }

