using DAL.DAL;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_ThongTinKhachHang
    {
        public DAL_ThongTinKhachHang DAL_ThongTinKhachHang;

        public BLL_ThongTinKhachHang(string Dbconnection)
        {
            DAL_ThongTinKhachHang = new DAL_ThongTinKhachHang(Dbconnection);
        }
        //----------------------------------------------------------------------------------------------------------------------------------------------

        // Hàm load dữ liệu từ bảng KHACH_HANG
        public System.Data.DataTable GetDataKhachHang()
        {
            return DAL_ThongTinKhachHang.LoadKhachHang();
        }
        //----------------------------------------------------------------------------------------------------------------------------------------------

        // Hàm thêm khách hàng mới
        public bool AddKhachHang(ThongTinKhachHang thongtinkhachhang)
        {
            
            if (string.IsNullOrWhiteSpace(thongtinkhachhang.HoTen) || string.IsNullOrWhiteSpace(thongtinkhachhang.GioiTinh) ||  string.IsNullOrWhiteSpace(thongtinkhachhang.DiaChi) || string.IsNullOrWhiteSpace(thongtinkhachhang.CCCD))
            {
                throw new Exception("Vui lòng nhập đầy đủ thông tin khách hàng");
            }
            
            return DAL_ThongTinKhachHang.AddKhachHang(thongtinkhachhang);
        }
        //----------------------------------------------------------------------------------------------------------------------------------------------

        // Hàm sửa thông tin khách hàng
        public bool UpdateKhachHang(ThongTinKhachHang thongtinkhachhang)
        {
            if (thongtinkhachhang.MaKhachHang <= 0 || string.IsNullOrWhiteSpace(thongtinkhachhang.HoTen) || string.IsNullOrWhiteSpace(thongtinkhachhang.GioiTinh) || string.IsNullOrWhiteSpace(thongtinkhachhang.DiaChi) || string.IsNullOrWhiteSpace(thongtinkhachhang.CCCD))
            {
                throw new Exception("Vui lòng nhập đầy đủ thông tin khách hàng");
            }
            return DAL_ThongTinKhachHang.UpdateKhachHang(thongtinkhachhang);
        }
        //----------------------------------------------------------------------------------------------------------------------------------------------

        // Hàm xóa khách hàng
        public bool DeleteKhachHang(int MaKhachHang)
        {
            if (MaKhachHang <= 0)
            {
                throw new Exception("Vui lòng chọn khách hàng cần xóa");
            }
            return DAL_ThongTinKhachHang.DeleteKhachHang(MaKhachHang);
        }
        //----------------------------------------------------------------------------------------------------------------------------------------------

        // Hàm tìm kiếm khách hàng
        public System.Data.DataTable SearchKhachHang(string TenKhachHang)
        {
            return DAL_ThongTinKhachHang.TimKiemKhachHang(TenKhachHang);
        }
    }
}
