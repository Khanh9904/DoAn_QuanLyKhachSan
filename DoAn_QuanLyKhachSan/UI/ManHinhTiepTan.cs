﻿using DoAn_QuanLyKhachSan.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QuanLyKhachSan.UI
{
    public partial class ManHinhTiepTan : Form
    {
        private PanelExpander quanLyNhanVienExpander;
        private PanelExpander quanLyCSVCExpander;
        private PanelExpander quanLyTKExpander;
        private PanelExpander quanLyThongKeExpander;

        public ManHinhTiepTan()
        {
            InitializeComponent();
            quanLyNhanVienExpander = new PanelExpander(QLNVContainer, QLNVTimer, true);
            quanLyCSVCExpander = new PanelExpander(panel_QLCSVC, QLCSVC, true);
            quanLyTKExpander = new PanelExpander(panel_TaiKhoan, QLTK_Timer, true);
            quanLyThongKeExpander = new PanelExpander(panel_ThongKe, ThongKe_timer, true);
        }

        // Hiển thị màu các button ở form chính
        private Button _currentButton = null;

        private void HighlightButton(Button selectedButton)
        {
            if (_currentButton != null)
            {

                // chưa chọn 
                _currentButton.BackColor = Color.FromArgb(113, 187, 178); // màu nút chưa chọn 
                _currentButton.ForeColor = Color.Black; // màu chữ 
                _currentButton.FlatAppearance.BorderSize = 0;
            }

            // hành động chọn 
            selectedButton.BackColor = Color.FromArgb(235, 91, 0);
            selectedButton.ForeColor = Color.White;
            _currentButton = selectedButton;
        }

        // Hiển thị các form con

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            quanLyNhanVienExpander.Start();

        }

        private void btnTTNV_Click(object sender, EventArgs e)
        {
            HighlightButton(sender as Button);

            ufrm_ManHinhHeThong1.Visible = false;
            ufrm_TTThongTinNhanVien1.Visible = true;
            ufrm_TTPhanCong1.Visible = false;
            ufrm_TTChamCong1.Visible = false;
            ufrm_TTCaLam1.Visible = false;
            ufrm_TTThongTinKhachHang1.Visible = false;
            ufrm_TTPhong1.Visible = false;
            ufrm_TTLoaiPhong1.Visible = false;
            ufrm_TTTang1.Visible = false;
            ufrm_TTThietBi1.Visible = false;
            ufrm_TTDichVu1.Visible = false;
            ufrm_TTPhanQuyen1.Visible = false;
            ufrm_TTTaiKhoan1.Visible = false;
            ufrm_ThongKe1.Visible = false;




        }

        private void btnPCCL_Click(object sender, EventArgs e)
        {
            HighlightButton(sender as Button);

            ufrm_ManHinhHeThong1.Visible = false;
            ufrm_TTThongTinNhanVien1.Visible = false;
            ufrm_TTPhanCong1.Visible = true;
            ufrm_TTChamCong1.Visible = false;
            ufrm_TTCaLam1.Visible = false;
            ufrm_TTThongTinKhachHang1.Visible = false;
            ufrm_TTPhong1.Visible = false;
            ufrm_TTLoaiPhong1.Visible = false;
            ufrm_TTTang1.Visible = false;
            ufrm_TTThietBi1.Visible = false;
            ufrm_TTDichVu1.Visible = false;
            ufrm_TTPhanQuyen1.Visible = false;
            ufrm_TTTaiKhoan1.Visible = false;
            ufrm_ThongKe1.Visible = false;

        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            HighlightButton(sender as Button);

            ufrm_ManHinhHeThong1.Visible = false;
            ufrm_TTThongTinNhanVien1.Visible = false;
            ufrm_TTPhanCong1.Visible = false;
            ufrm_TTChamCong1.Visible = true;
            ufrm_TTCaLam1.Visible = false;
            ufrm_TTThongTinKhachHang1.Visible = false;
            ufrm_TTPhong1.Visible = false;
            ufrm_TTLoaiPhong1.Visible = false;
            ufrm_TTTang1.Visible = false;
            ufrm_TTThietBi1.Visible = false;
            ufrm_TTDichVu1.Visible = false;
            ufrm_TTPhanQuyen1.Visible = false;
            ufrm_TTTaiKhoan1.Visible = false;
            ufrm_ThongKe1.Visible = false;

        }

        private void btnCaLam_Click(object sender, EventArgs e)
        {
            HighlightButton(sender as Button);

            ufrm_ManHinhHeThong1.Visible = false;
            ufrm_TTThongTinNhanVien1.Visible = false;
            ufrm_TTPhanCong1.Visible = false;
            ufrm_TTChamCong1.Visible = false;
            ufrm_TTCaLam1.Visible = true;
            ufrm_TTThongTinKhachHang1.Visible = false;
            ufrm_TTPhong1.Visible = false;
            ufrm_TTLoaiPhong1.Visible = false;
            ufrm_TTTang1.Visible = false;
            ufrm_TTThietBi1.Visible = false;
            ufrm_TTDichVu1.Visible = false;
            ufrm_TTPhanQuyen1.Visible = false;
            ufrm_TTTaiKhoan1.Visible = false;
            ufrm_ThongKe1.Visible = false;

        }

        private void btnQLKH_Click(object sender, EventArgs e)
        {
            HighlightButton(sender as Button);

            ufrm_ManHinhHeThong1.Visible = false;
            ufrm_TTThongTinNhanVien1.Visible = false;
            ufrm_TTPhanCong1.Visible = false;
            ufrm_TTChamCong1.Visible = false;
            ufrm_TTCaLam1.Visible = false;
            ufrm_TTThongTinKhachHang1.Visible = true;
            ufrm_TTPhong1.Visible = false;
            ufrm_TTLoaiPhong1.Visible = false;
            ufrm_TTTang1.Visible = false;
            ufrm_TTThietBi1.Visible = false;
            ufrm_TTDichVu1.Visible = false;
            ufrm_TTPhanQuyen1.Visible = false;
            ufrm_TTTaiKhoan1.Visible = false;
            ufrm_ThongKe1.Visible = false;

        }

        private void btnThongTinPhong_Click(object sender, EventArgs e)
        {
            HighlightButton(sender as Button);

            ufrm_ManHinhHeThong1.Visible = false;
            ufrm_TTThongTinNhanVien1.Visible = false;
            ufrm_TTPhanCong1.Visible = false;
            ufrm_TTChamCong1.Visible = false;
            ufrm_TTCaLam1.Visible = false;
            ufrm_TTThongTinKhachHang1.Visible = false;
            ufrm_TTPhong1.Visible = true;
            ufrm_TTLoaiPhong1.Visible = false;
            ufrm_TTTang1.Visible = false;
            ufrm_TTThietBi1.Visible = false;
            ufrm_TTDichVu1.Visible = false;
            ufrm_TTPhanQuyen1.Visible = false;
            ufrm_TTTaiKhoan1.Visible = false;
            ufrm_ThongKe1.Visible = false;

        }

        private void btnThongTinLoaiPhong_Click(object sender, EventArgs e)
        {
            HighlightButton(sender as Button);

            ufrm_ManHinhHeThong1.Visible = false;
            ufrm_TTThongTinNhanVien1.Visible = false;
            ufrm_TTPhanCong1.Visible = false;
            ufrm_TTChamCong1.Visible = false;
            ufrm_TTCaLam1.Visible = false;
            ufrm_TTThongTinKhachHang1.Visible = false;
            ufrm_TTPhong1.Visible = false;
            ufrm_TTLoaiPhong1.Visible = true;
            ufrm_TTTang1.Visible = false;
            ufrm_TTThietBi1.Visible = false;
            ufrm_TTDichVu1.Visible = false;
            ufrm_TTPhanQuyen1.Visible = false;
            ufrm_TTTaiKhoan1.Visible = false;
            ufrm_ThongKe1.Visible = false;

        }

        private void btnThongTinTang_Click(object sender, EventArgs e)
        {
            HighlightButton(sender as Button);

            ufrm_ManHinhHeThong1.Visible = false;
            ufrm_TTThongTinNhanVien1.Visible = false;
            ufrm_TTPhanCong1.Visible = false;
            ufrm_TTChamCong1.Visible = false;
            ufrm_TTCaLam1.Visible = false;
            ufrm_TTThongTinKhachHang1.Visible = false;
            ufrm_TTPhong1.Visible = false;
            ufrm_TTLoaiPhong1.Visible = false;
            ufrm_TTTang1.Visible = true;
            ufrm_TTThietBi1.Visible = false;
            ufrm_TTDichVu1.Visible = false;
            ufrm_TTPhanQuyen1.Visible = false;
            ufrm_TTTaiKhoan1.Visible = false;
            ufrm_ThongKe1.Visible = false;

        }

        private void btnThongTinThietBi_Click(object sender, EventArgs e)
        {
            HighlightButton(sender as Button);

            ufrm_ManHinhHeThong1.Visible = false;
            ufrm_TTThongTinNhanVien1.Visible = false;
            ufrm_TTPhanCong1.Visible = false;
            ufrm_TTChamCong1.Visible = false;
            ufrm_TTCaLam1.Visible = false;
            ufrm_TTThongTinKhachHang1.Visible = false;
            ufrm_TTPhong1.Visible = false;
            ufrm_TTLoaiPhong1.Visible = false;
            ufrm_TTTang1.Visible = false;
            ufrm_TTThietBi1.Visible = true;
            ufrm_TTDichVu1.Visible = false;
            ufrm_TTPhanQuyen1.Visible = false;
            ufrm_TTTaiKhoan1.Visible = false;
            ufrm_ThongKe1.Visible = false;

        }

        private void btnThongTinDichVu_Click(object sender, EventArgs e)
        {
            HighlightButton(sender as Button);

            ufrm_ManHinhHeThong1.Visible = false;
            ufrm_TTThongTinNhanVien1.Visible = false;
            ufrm_TTPhanCong1.Visible = false;
            ufrm_TTChamCong1.Visible = false;
            ufrm_TTCaLam1.Visible = false;
            ufrm_TTThongTinKhachHang1.Visible = false;
            ufrm_TTPhong1.Visible = false;
            ufrm_TTLoaiPhong1.Visible = false;
            ufrm_TTTang1.Visible = false;
            ufrm_TTThietBi1.Visible = false;
            ufrm_TTDichVu1.Visible = true;
            ufrm_TTPhanQuyen1.Visible = false;
            ufrm_TTTaiKhoan1.Visible = false;
            ufrm_ThongKe1.Visible = false;

        }

        private void btn_QLTK_Click(object sender, EventArgs e)
        {
            

            quanLyTKExpander.Start();

        }

        private void btnPQ_Click(object sender, EventArgs e)
        {
            HighlightButton(sender as Button);

            ufrm_ManHinhHeThong1.Visible = false;
            ufrm_TTThongTinNhanVien1.Visible = false;
            ufrm_TTPhanCong1.Visible = false;
            ufrm_TTChamCong1.Visible = false;
            ufrm_TTCaLam1.Visible = false;
            ufrm_TTThongTinKhachHang1.Visible = false;
            ufrm_TTPhong1.Visible = false;
            ufrm_TTLoaiPhong1.Visible = false;
            ufrm_TTTang1.Visible = false;
            ufrm_TTThietBi1.Visible = false;
            ufrm_TTDichVu1.Visible = false;
            ufrm_TTPhanQuyen1.Visible = true;
            ufrm_TTTaiKhoan1.Visible = false;
            ufrm_ThongKe1.Visible = false;

        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            HighlightButton(sender as Button);

            ufrm_ManHinhHeThong1.Visible = false;
            ufrm_TTThongTinNhanVien1.Visible = false;
            ufrm_TTPhanCong1.Visible = false;
            ufrm_TTChamCong1.Visible = false;
            ufrm_TTCaLam1.Visible = false;
            ufrm_TTThongTinKhachHang1.Visible = false;
            ufrm_TTPhong1.Visible = false;
            ufrm_TTLoaiPhong1.Visible = false;
            ufrm_TTTang1.Visible = false;
            ufrm_TTThietBi1.Visible = false;
            ufrm_TTDichVu1.Visible = false;
            ufrm_TTPhanQuyen1.Visible = false;
            ufrm_TTTaiKhoan1.Visible = true;
            ufrm_ThongKe1.Visible = false;

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            HighlightButton(sender as Button);

            ufrm_ManHinhHeThong1.Visible = false;
            ufrm_TTThongTinNhanVien1.Visible = false;
            ufrm_TTPhanCong1.Visible = false;
            ufrm_TTChamCong1.Visible = false;
            ufrm_TTCaLam1.Visible = false;
            ufrm_TTThongTinKhachHang1.Visible = false;
            ufrm_TTPhong1.Visible = false;
            ufrm_TTLoaiPhong1.Visible = false;
            ufrm_TTTang1.Visible = false;
            ufrm_TTThietBi1.Visible = false;
            ufrm_TTDichVu1.Visible = false;
            ufrm_TTPhanQuyen1.Visible = false;
            ufrm_TTTaiKhoan1.Visible = false;
            ufrm_ThongKe1.Visible = true;

        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {

        }

        private void btnTKDichVu_Click(object sender, EventArgs e)
        {

        }

        private void btnManHinhChinh_Click(object sender, EventArgs e)
        {
            HighlightButton(sender as Button);

            ufrm_ManHinhHeThong1.Visible = true;
            ufrm_TTThongTinNhanVien1.Visible = false;
            ufrm_TTPhanCong1.Visible = false;
            ufrm_TTChamCong1.Visible = false;
            ufrm_TTCaLam1.Visible = false;
            ufrm_TTThongTinKhachHang1.Visible = false;
            ufrm_TTPhong1.Visible = false;
            ufrm_TTLoaiPhong1.Visible = false;
            ufrm_TTTang1.Visible = false;
            ufrm_TTThietBi1.Visible = false;
            ufrm_TTDichVu1.Visible = false;
            ufrm_TTPhanQuyen1.Visible = false;
            ufrm_TTTaiKhoan1.Visible = false;
            ufrm_ThongKe1.Visible = false;

        }

        private void btnQLCSVC_Click(object sender, EventArgs e)
        {
            

            quanLyCSVCExpander.Start();

        }

        private void ManHinhTiepTan_Load(object sender, EventArgs e)
        {

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            HighlightButton(sender as Button);

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Xác nhận đăng xuất",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Ẩn form hiện tại
                this.Hide();

                // Mở lại form login
                Login loginForm = new Login();
                loginForm.ShowDialog();

                // Thoát toàn bộ chương trình nếu đăng xuất
                Application.Exit();
            }
        }
    }

}
