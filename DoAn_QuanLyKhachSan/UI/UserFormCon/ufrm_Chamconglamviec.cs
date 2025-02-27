using BLL;
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
    public partial class ufrm_Chamconglamviec : UserControl
    {
        Database db = new Database();
        private BLL_ChamCong BLL_ChamCong;
        private Timer nhanvienTimer;
        public ufrm_Chamconglamviec()
        {
            InitializeComponent();
           
        }

        private void ufrm_Chamconglamviec_Load(object sender, EventArgs e)
        {
            BLL_ChamCong = new BLL_ChamCong(new Database().GetDataSet());
            LoadChamcong();
            nhanvienTimer = new Timer();
            nhanvienTimer.Interval = 1000;
            nhanvienTimer.Tick += (s, i) => LoadCBnhanvien();
            nhanvienTimer.Start();
        }
        //-----------------------------------------------------------------------------------------------------------------------------------

        //load cham cong
        public void LoadChamcong()
        {
            try
            {
                dgv_chamcong.DataSource = BLL_ChamCong.GetDataChamcong();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin kết nối:" + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //-----------------------------------------------------------------------------------------------------------------------------------

        //load combobox nhan vien
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

                cb_nhanvien.SelectedIndex = 0;
            }
        }
        //-----------------------------------------------------------------------------------------------------------------------------------

        public void Clear()
        {
            txt_machamcong.Text = "";
            cb_trangthai.SelectedIndex = 0;
            dtngaylam.Value = DateTime.Now;
            cb_nhanvien.SelectedIndex = 0;
        }
        //-----------------------------------------------------------------------------------------------------------------------------------

        //them cong
        private void btnThemCong_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime ngaylamviec = dtngaylam.Value;



                ChamCong chamcong = new ChamCong
                {
                    TRANGTHAI = cb_trangthai.Text.Trim(),
                    NGAYLAMVIEC = ngaylamviec,

                    ID_NHANVIEN = (int)cb_nhanvien.SelectedValue,


                };

                if (!BLL_ChamCong.themchamcong(chamcong))
                {
                    MessageBox.Show("Thêm thất bại ! Nhân viên này đã chấm công hôm nay ròi ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadChamcong();

                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("vui long nhap du thong tin:" + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //-----------------------------------------------------------------------------------------------------------------------------------

        // sua cong
        private void btnSuaCong_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_chamcong.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn phân quyền cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                ChamCong chamcong = new ChamCong
                {
                    ID_CHAMCONG = Convert.ToInt32(dgv_chamcong.CurrentRow.Cells["ID_CHAMCONG"].Value),

                    ID_NHANVIEN = (int)cb_nhanvien.SelectedValue,

                    TRANGTHAI = cb_trangthai.Text.Trim(),
                    NGAYLAMVIEC = dtngaylam.Value,
                };

                BLL_ChamCong.suachamcong(chamcong);


                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadChamcong();
                Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //-----------------------------------------------------------------------------------------------------------------------------------

        //xoa cong
        private void btnXoaCong_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_chamcong.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn loại khách hàng cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                int machamcong = Convert.ToInt32(dgv_chamcong.CurrentRow.Cells["ID_CHAMCONG"].Value);
                BLL_ChamCong.xoachamcong(machamcong);
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadChamcong();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //-----------------------------------------------------------------------------------------------------------------------------------

        public void DonThongTin()
        {
            txt_machamcong.Text = "";
            cb_trangthai.SelectedIndex = 0;
            dtngaylam.Value = DateTime.Now;
            cb_nhanvien.SelectedIndex = 0;
        }

        private void dgv_chamcong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow rowst = dgv_chamcong.Rows[e.RowIndex];


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

        private void btnClearCong_Click(object sender, EventArgs e)
        {
            DonThongTin();
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            ufrm_QuanLyNhanVien quanly = new ufrm_QuanLyNhanVien();
            this.Controls.Add(quanly);
            quanly.Dock = DockStyle.Fill;
        }

        private void txtTimKiemCong_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiemCong.Text.Trim();
            DataTable dt = BLL_ChamCong.timkiemchamcong(keyword);
            dgv_chamcong.DataSource = dt;
        }


        //-----------------------------------------------------------------------------------------------------------------------------------



    }
}
