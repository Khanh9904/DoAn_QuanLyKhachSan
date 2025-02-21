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
        public Form1()
        {
            InitializeComponent();
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

        private void btnManHinhHeThong_Click(object sender, EventArgs e)
        {
            ufrm_ManHinhHeThong1.Visible = true;
            ufrm_QuanLyNhanVien1.Visible = false;
            ufrm_QuanLyCSVC1.Visible = false;
            ufrm_QuanLyKhachHang1.Visible = false;

            ufrm_QuanLyTaiKhoan1.Visible = false;
            ufrm_ThongTinKhachHang1.Visible = false;
            ufrm_BaoCaoThongKe1.Visible = false;
            HighlightButton((Button)sender);
            
        }

        

        private void btnThongTinKhachHang_Click(object sender, EventArgs e)
        {
            ufrm_ManHinhHeThong1.Visible = false;
            ufrm_QuanLyNhanVien1.Visible = false;
            ufrm_QuanLyCSVC1.Visible = false;
            ufrm_QuanLyKhachHang1.Visible = false;

            ufrm_QuanLyTaiKhoan1.Visible = false;
            ufrm_ThongTinKhachHang1.Visible = true;
            ufrm_BaoCaoThongKe1.Visible = false;
            HighlightButton((Button)sender);
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            ufrm_ManHinhHeThong1.Visible = false;
            ufrm_QuanLyNhanVien1.Visible = false;
            ufrm_QuanLyCSVC1.Visible = false;
            ufrm_QuanLyKhachHang1.Visible = false;

            ufrm_QuanLyTaiKhoan1.Visible = false;
            ufrm_ThongTinKhachHang1.Visible = false;
            ufrm_BaoCaoThongKe1.Visible = true;
            HighlightButton((Button)sender);
        }

        private void btnQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            ufrm_ManHinhHeThong1.Visible = false;
            ufrm_QuanLyNhanVien1.Visible = true;
            ufrm_QuanLyCSVC1.Visible = false;
            ufrm_QuanLyKhachHang1.Visible = false;

            ufrm_QuanLyTaiKhoan1.Visible = false;
            ufrm_ThongTinKhachHang1.Visible = false;
            ufrm_BaoCaoThongKe1.Visible = false;
            HighlightButton((Button)sender);
        }

        private void btnQuanLyCoSoVatChat_Click(object sender, EventArgs e)
        {
            ufrm_ManHinhHeThong1.Visible = false;
            ufrm_QuanLyNhanVien1.Visible = false;
            ufrm_QuanLyCSVC1.Visible = true;
            ufrm_QuanLyKhachHang1.Visible = false;

            ufrm_QuanLyTaiKhoan1.Visible = false;
            ufrm_ThongTinKhachHang1.Visible = false;
            ufrm_BaoCaoThongKe1.Visible = false;
            HighlightButton((Button)sender);
        }

        private void btnQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            ufrm_ManHinhHeThong1.Visible = false;
            ufrm_QuanLyNhanVien1.Visible = false;
            ufrm_QuanLyCSVC1.Visible = false;
            ufrm_QuanLyKhachHang1.Visible = false;

            ufrm_QuanLyTaiKhoan1.Visible = true;
            ufrm_ThongTinKhachHang1.Visible = false;
            ufrm_BaoCaoThongKe1.Visible = false;
            HighlightButton((Button)sender);
        }

        private void btnQuanLyKhachHang_Click(object sender, EventArgs e)
        {
            ufrm_ManHinhHeThong1.Visible = false;
            ufrm_QuanLyNhanVien1.Visible = false;
            ufrm_QuanLyCSVC1.Visible = false;
            ufrm_QuanLyKhachHang1.Visible = true;

            ufrm_QuanLyTaiKhoan1.Visible = false;
            ufrm_ThongTinKhachHang1.Visible = false;
            ufrm_BaoCaoThongKe1.Visible = false;
            HighlightButton((Button)sender);
        }



        //-------------------------------------------------------------------------------------------------------------------


    }
}
