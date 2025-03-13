﻿using BLL;
using DAL.DAL;
using DAL.Database;
using DAL.Model;
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
    public partial class ufrm_PhanCongCaLam : UserControl
    {

        Database db = new Database();

        private BLL_PhanCongCaLam BLL_PhanCongCaLam;

        private Timer taiKhoanTimer;

        public ufrm_PhanCongCaLam()
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

        //ham load combobox nhan vien
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

                cbNhanVien.SelectedIndex = 0;
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

                cbMaCa.SelectedIndex = 0;
            }
        }

        //ham load phan cong
        public void LoadPhanCong()
        {
            try
            {
                data_PhanCong.DataSource = BLL_PhanCongCaLam.GetDataPhanCongCaLam();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin liên kết nối : " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //ham don thong tin
        public void DonThongTin()
        {
            iD_PHANCONGTextBox.Text = "";
            cbMaCa.SelectedIndex = 0;
            cbNhanVien.SelectedIndex = 0;
            nGAYLAMDateTimePicker.Value = DateTime.Now;
        }

        //ham them phan cong
        private void btnThemPhanCong_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra nếu nhân viên hoặc ca làm chưa được chọn
                if (cbNhanVien.SelectedValue == null || cbMaCa.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn nhân viên và ca làm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo đối tượng PhanCongCaLam
                PhanCongCaLam phanCong = new PhanCongCaLam()
                {
                    ID_NHANVIEN = Convert.ToInt32(cbNhanVien.SelectedValue),
                    ID_CALAM = Convert.ToInt32(cbMaCa.SelectedValue),
                    NGAYLAM = nGAYLAMDateTimePicker.Value
                };

                // Gọi phương thức thêm phân công
                BLL_PhanCongCaLam.AddPhanCongCaLam(phanCong);

                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadPhanCong();
                DonThongTin();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm phân công: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //ham sửa phan cong
        private void btnSuaPhanCong_Click(object sender, EventArgs e)
        {
            try
            {

                PhanCongCaLam PhanCongCaLam = new PhanCongCaLam()

                {
                    ID_PHANCONG = Convert.ToInt32(data_PhanCong.CurrentRow.Cells["ID_PHANCONG"].Value),

                    ID_NHANVIEN = (int)cbNhanVien.SelectedValue,

                    ID_CALAM = (int)cbMaCa.SelectedValue,

                    NGAYLAM = nGAYLAMDateTimePicker.Value





                };

                BLL_PhanCongCaLam.UpdatePhanCongCaLam(PhanCongCaLam);

                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadPhanCong();

                DonThongTin();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin liên kết nối : " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //ham xoa phan cong
        private void btnXoaPhanCong_Click(object sender, EventArgs e)
        {
            try
            {
                if (data_PhanCong.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn dữ liệu cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int ID_PHANCONG = Convert.ToInt32(data_PhanCong.CurrentRow.Cells["ID_PHANCONG"].Value);

                BLL_PhanCongCaLam.DeletePhanCongCaLam(ID_PHANCONG);

                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadPhanCong();

                DonThongTin();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin liên kết nối : " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnClearPhanCong_Click(object sender, EventArgs e)
        {
            DonThongTin();
        }

        private void data_PhanCong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow rowst = data_PhanCong.Rows[e.RowIndex];

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

