using DoAn_QuanLyKhachSan.Control;
using DoAn_QuanLyKhachSan.UI;
using DoAn_QuanLyKhachSan.UI.UserFormCon;
using DoAn_QuanLyKhachSan.UI.UserFormPhu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QuanLyKhachSan
{
    public partial class Form1 : Form
    {
        private PanelExpander quanLyNhanVienExpander;
        private PanelExpander quanLyCSVCExpander;
        private PanelExpander quanLyTKExpander;
        private PanelExpander quanLyThongKeExpander;





        public Form1()
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
            HighlightButton(sender as Button);
            quanLyNhanVienExpander.Start();
           
        }

        private void btnTTNV_Click(object sender, EventArgs e)
        {
            HighlightButton(sender as Button);
            ufrm_ManHinhHeThong1.Visible = false;
            ufrm_CRUDPhanQuyen1.Visible = false;
            ufrm_CRUDPhong1.Visible = false;
            ufrm_CRUDTaiKhoan1.Visible = false;
            ufrm_CRUDThongTinKhachHang1.Visible = false;
            ufrm_CRUDThongTinNhanVien1.Visible = true;
            ufrm_CRUDDichVu1.Visible = false;
            ufrm_CRUDLoaiPhong1.Visible = false;
            ufrm_CRUDTang1.Visible = false;
            ufrm_CRUDThietBi1.Visible = false;
            ufrm_Chamconglamviec1.Visible = false;
            ufrm_PhanCongCaLam1.Visible = false;
            ufrm_CaLam1.Visible = false;
            ufrm_ThongKe1.Visible = false;



        }

        private void btnPCCL_Click(object sender, EventArgs e)
        {
            HighlightButton(sender as Button);
            ufrm_ManHinhHeThong1.Visible = false;
            ufrm_CRUDPhanQuyen1.Visible = false;
            ufrm_CRUDPhong1.Visible = false;
            ufrm_CRUDTaiKhoan1.Visible = false;
            ufrm_CRUDThongTinKhachHang1.Visible = false;
            ufrm_CRUDThongTinNhanVien1.Visible = false;
            ufrm_CRUDDichVu1.Visible = false;
            ufrm_CRUDLoaiPhong1.Visible = false;
            ufrm_CRUDTang1.Visible = false;
            ufrm_CRUDThietBi1.Visible = false;
            ufrm_Chamconglamviec1.Visible = false;
            ufrm_PhanCongCaLam1.Visible = true;
            ufrm_CaLam1.Visible = false;
            ufrm_ThongKe1.Visible = false;


        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            HighlightButton(sender as Button);
            ufrm_ManHinhHeThong1.Visible = false;
            ufrm_CRUDPhanQuyen1.Visible = false;
            ufrm_CRUDPhong1.Visible = false;
            ufrm_CRUDTaiKhoan1.Visible = false;
            ufrm_CRUDThongTinKhachHang1.Visible = false;
            ufrm_CRUDThongTinNhanVien1.Visible = false;
            ufrm_CRUDDichVu1.Visible = false;
            ufrm_CRUDLoaiPhong1.Visible = false;
            ufrm_CRUDTang1.Visible = false;
            ufrm_CRUDThietBi1.Visible = false;
            ufrm_Chamconglamviec1.Visible = true;
            ufrm_PhanCongCaLam1.Visible = false;
            ufrm_CaLam1.Visible = false;
            ufrm_ThongKe1.Visible = false;


        }

        private void btnCaLam_Click(object sender, EventArgs e)
        {
            HighlightButton(sender as Button);
            ufrm_ManHinhHeThong1.Visible = false;
            ufrm_CRUDPhanQuyen1.Visible = false;
            ufrm_CRUDPhong1.Visible = false;
            ufrm_CRUDTaiKhoan1.Visible = false;
            ufrm_CRUDThongTinKhachHang1.Visible = false;
            ufrm_CRUDThongTinNhanVien1.Visible = false;
            ufrm_CRUDDichVu1.Visible = false;
            ufrm_CRUDLoaiPhong1.Visible = false;
            ufrm_CRUDTang1.Visible = false;
            ufrm_CRUDThietBi1.Visible = false;
            ufrm_Chamconglamviec1.Visible = false;
            ufrm_PhanCongCaLam1.Visible = false;
            ufrm_CaLam1.Visible = true;
            ufrm_ThongKe1.Visible = false;


        }

        private void btnQLKH_Click(object sender, EventArgs e)
        {
            HighlightButton(sender as Button);
            ufrm_ManHinhHeThong1.Visible = false;
            ufrm_CRUDPhanQuyen1.Visible = false;
            ufrm_CRUDPhong1.Visible = false;
            ufrm_CRUDTaiKhoan1.Visible = false;
            ufrm_CRUDThongTinKhachHang1.Visible = true;
            ufrm_CRUDThongTinNhanVien1.Visible = false;
            ufrm_CRUDDichVu1.Visible = false;
            ufrm_CRUDLoaiPhong1.Visible = false;
            ufrm_CRUDTang1.Visible = false;
            ufrm_CRUDThietBi1.Visible = false;
            ufrm_Chamconglamviec1.Visible = false;
            ufrm_PhanCongCaLam1.Visible = false;
            ufrm_CaLam1.Visible = false;
            ufrm_ThongKe1.Visible = false;


        }



        private void btnQLCSVC_Click(object sender, EventArgs e)
        {
            HighlightButton(sender as Button);
            quanLyCSVCExpander.Start();

        }

        private void btnThongTinPhong_Click(object sender, EventArgs e)
        {
            HighlightButton(sender as Button);
            ufrm_ManHinhHeThong1.Visible = false;
            ufrm_CRUDPhanQuyen1.Visible = false;
            ufrm_CRUDPhong1.Visible = true;
            ufrm_CRUDTaiKhoan1.Visible = false;
            ufrm_CRUDThongTinKhachHang1.Visible = false;
            ufrm_CRUDThongTinNhanVien1.Visible = false;
            ufrm_CRUDDichVu1.Visible = false;
            ufrm_CRUDLoaiPhong1.Visible = false;
            ufrm_CRUDTang1.Visible = false;
            ufrm_CRUDThietBi1.Visible = false;
            ufrm_Chamconglamviec1.Visible = false;
            ufrm_PhanCongCaLam1.Visible = false;
            ufrm_CaLam1.Visible = false;
            ufrm_ThongKe1.Visible = false;


        }

        private void btnThongTinLoaiPhong_Click(object sender, EventArgs e)
        {
            HighlightButton(sender as Button);
            ufrm_ManHinhHeThong1.Visible = false;
            ufrm_CRUDPhanQuyen1.Visible = false;
            ufrm_CRUDPhong1.Visible = false;
            ufrm_CRUDTaiKhoan1.Visible = false;
            ufrm_CRUDThongTinKhachHang1.Visible = false;
            ufrm_CRUDThongTinNhanVien1.Visible = false;
            ufrm_CRUDDichVu1.Visible = false;
            ufrm_CRUDLoaiPhong1.Visible = true;
            ufrm_CRUDTang1.Visible = false;
            ufrm_CRUDThietBi1.Visible = false;
            ufrm_Chamconglamviec1.Visible = false;
            ufrm_PhanCongCaLam1.Visible = false;
            ufrm_CaLam1.Visible = false;
            ufrm_ThongKe1.Visible = false;


        }

        private void btnThongTinTang_Click(object sender, EventArgs e)
        {
            HighlightButton(sender as Button);
            ufrm_ManHinhHeThong1.Visible = false;
            ufrm_CRUDPhanQuyen1.Visible = false;
            ufrm_CRUDPhong1.Visible = false;
            ufrm_CRUDTaiKhoan1.Visible = false;
            ufrm_CRUDThongTinKhachHang1.Visible = false;
            ufrm_CRUDThongTinNhanVien1.Visible = false;
            ufrm_CRUDDichVu1.Visible = false;
            ufrm_CRUDLoaiPhong1.Visible = false;
            ufrm_CRUDTang1.Visible = true;
            ufrm_CRUDThietBi1.Visible = false;
            ufrm_Chamconglamviec1.Visible = false;
            ufrm_PhanCongCaLam1.Visible = false;
            ufrm_CaLam1.Visible = false;
            ufrm_ThongKe1.Visible = false;

        }

        private void btnThongTinThietBi_Click(object sender, EventArgs e)
        {
            HighlightButton(sender as Button);
            ufrm_ManHinhHeThong1.Visible = false;
            ufrm_CRUDPhanQuyen1.Visible = false;
            ufrm_CRUDPhong1.Visible = false;
            ufrm_CRUDTaiKhoan1.Visible = false;
            ufrm_CRUDThongTinKhachHang1.Visible = false;
            ufrm_CRUDThongTinNhanVien1.Visible = false;
            ufrm_CRUDDichVu1.Visible = false;
            ufrm_CRUDLoaiPhong1.Visible = false;
            ufrm_CRUDTang1.Visible = false;
            ufrm_CRUDThietBi1.Visible = true;
            ufrm_Chamconglamviec1.Visible = false;
            ufrm_PhanCongCaLam1.Visible = false;
            ufrm_CaLam1.Visible = false;
            ufrm_ThongKe1.Visible = false;


        }

        private void btnThongTinDichVu_Click(object sender, EventArgs e)
        {
            HighlightButton(sender as Button);
            ufrm_ManHinhHeThong1.Visible = false;
            ufrm_CRUDPhanQuyen1.Visible = false;
            ufrm_CRUDPhong1.Visible = false;
            ufrm_CRUDTaiKhoan1.Visible = false;
            ufrm_CRUDThongTinKhachHang1.Visible = false;
            ufrm_CRUDThongTinNhanVien1.Visible = false;
            ufrm_CRUDDichVu1.Visible = true;
            ufrm_CRUDLoaiPhong1.Visible = false;
            ufrm_CRUDTang1.Visible = false;
            ufrm_CRUDThietBi1.Visible = false;
            ufrm_Chamconglamviec1.Visible = false;
            ufrm_PhanCongCaLam1.Visible = false;
            ufrm_CaLam1.Visible = false;
            ufrm_ThongKe1.Visible = false;


        }

        private void btn_QLTK_Click(object sender, EventArgs e)
        {
            HighlightButton(sender as Button);
            quanLyTKExpander.Start();

        }

        private void btnPQ_Click(object sender, EventArgs e)
        {
            HighlightButton(sender as Button);
            ufrm_ManHinhHeThong1.Visible = false;
            ufrm_CRUDPhanQuyen1.Visible = true;
            ufrm_CRUDPhong1.Visible = false;
            ufrm_CRUDTaiKhoan1.Visible = false;
            ufrm_CRUDThongTinKhachHang1.Visible = false;
            ufrm_CRUDThongTinNhanVien1.Visible = false;
            ufrm_CRUDDichVu1.Visible = false;
            ufrm_CRUDLoaiPhong1.Visible = false;
            ufrm_CRUDTang1.Visible = false;
            ufrm_CRUDThietBi1.Visible = false;
            ufrm_Chamconglamviec1.Visible = false;
            ufrm_PhanCongCaLam1.Visible = false;
            ufrm_CaLam1.Visible = false;
            ufrm_ThongKe1.Visible = false;


        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            HighlightButton(sender as Button);
            ufrm_ManHinhHeThong1.Visible = false;
            ufrm_CRUDPhanQuyen1.Visible = false;
            ufrm_CRUDPhong1.Visible = false;
            ufrm_CRUDTaiKhoan1.Visible = true;
            ufrm_CRUDThongTinKhachHang1.Visible = false;
            ufrm_CRUDThongTinNhanVien1.Visible = false;
            ufrm_CRUDDichVu1.Visible = false;
            ufrm_CRUDLoaiPhong1.Visible = false;
            ufrm_CRUDTang1.Visible = false;
            ufrm_CRUDThietBi1.Visible = false;
            ufrm_Chamconglamviec1.Visible = false;
            ufrm_PhanCongCaLam1.Visible = false;
            ufrm_CaLam1.Visible = false;
            ufrm_ThongKe1.Visible = false;


        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            HighlightButton(sender as Button);
            ufrm_ManHinhHeThong1.Visible = false;
            ufrm_CRUDPhanQuyen1.Visible = false;
            ufrm_CRUDPhong1.Visible = false;
            ufrm_CRUDTaiKhoan1.Visible = false;
            ufrm_CRUDThongTinKhachHang1.Visible = false;
            ufrm_CRUDThongTinNhanVien1.Visible = false;
            ufrm_CRUDDichVu1.Visible = false;
            ufrm_CRUDLoaiPhong1.Visible = false;
            ufrm_CRUDTang1.Visible = false;
            ufrm_CRUDThietBi1.Visible = false;
            ufrm_Chamconglamviec1.Visible = false;
            ufrm_PhanCongCaLam1.Visible = false;
            ufrm_CaLam1.Visible = false;
            ufrm_ThongKe1.Visible = true;

        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {

        }

        private void btnTKDichVu_Click(object sender, EventArgs e)
        {

        }

       

        private void btnManHinhChinh_Click_1(object sender, EventArgs e)
        {
            HighlightButton(sender as Button);
            ufrm_ManHinhHeThong1.Visible = true;
            ufrm_CRUDPhanQuyen1.Visible = false;
            ufrm_CRUDPhong1.Visible = false;
            ufrm_CRUDTaiKhoan1.Visible = false;
            ufrm_CRUDThongTinKhachHang1.Visible = false;
            ufrm_CRUDThongTinNhanVien1.Visible = false;
            ufrm_CRUDDichVu1.Visible = false;
            ufrm_CRUDLoaiPhong1.Visible = false;
            ufrm_CRUDTang1.Visible = false;
            ufrm_CRUDThietBi1.Visible = false;
            ufrm_Chamconglamviec1.Visible = false;
            ufrm_PhanCongCaLam1.Visible = false;
            ufrm_CaLam1.Visible = false;
            ufrm_ThongKe1.Visible = false;



        }

        private void Form1_Load(object sender, EventArgs e)
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












        //-------------------------------------------------------------------------------------------------------------------


    }
}
