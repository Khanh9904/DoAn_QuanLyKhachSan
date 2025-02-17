using DAL.DAL.DoAn_QuanLyKhachSan.DAL;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_TaiKhoan
    {
        public DAL_TaiKhoan DAL_TaiKhoan;

        public BLL_TaiKhoan(string Dbconnection)
        {
            DAL_TaiKhoan = new DAL_TaiKhoan(Dbconnection);
        }
        public DataTable GetDataTaiKhoan()
        {
            return DAL_TaiKhoan.LoadTaiKhoan();
        }

        public bool AddTaiKhoan(TaiKhoan taikhoan)
        {

            // Kiểm tra tên tài khoản đã tồn tại chưa
            if (DAL_TaiKhoan.CheckTaiKhoan(taikhoan.IDTK.ToString())) // Chuyển IDTK sang string nếu cần
            {
                throw new Exception($"Tên Tài Khoản : {taikhoan.TENTK} đã tồn tại");
            }
            // Trả về thông tin thêm thành công
            return DAL_TaiKhoan.AddTaiKhoan(taikhoan);
        }
        public bool UpdateTaiKhoan(TaiKhoan taikhoan)
        {
            // Kiểm tra dữ liệu đầu vào
            if (taikhoan == null)
            {
                throw new ArgumentNullException(nameof(taikhoan), "Tài khoản không được để trống!");
            }

            if (taikhoan.IDTK <= 0 ||
                string.IsNullOrWhiteSpace(taikhoan.TENTK) ||
                string.IsNullOrWhiteSpace(taikhoan.MATKHAU) ||
                taikhoan.ID_PHANQUYEN <= 0)
            {
                throw new Exception("Vui lòng nhập đầy đủ thông tin tài khoản hợp lệ!");
            }

            // Gọi phương thức cập nhật từ DAL và trả về kết quả
            return DAL_TaiKhoan.UpdateTaiKhoan(taikhoan);
        }


        public bool DeleteTaiKhoan(int IDTK)
        {
            // Kiểm tra dữ liệu đầu vào
            if (IDTK <= 0)
            {
                throw new Exception("Vui lòng chọn tài khoản hợp lệ để xóa!");
            }

            // Gọi phương thức xóa từ DAL và trả về kết quả
            return DAL_TaiKhoan.DeleteTaiKhoan(IDTK);
        }


        // Hàm tìm kiếm tài khoản theo tên tài khoản
        public DataTable SearchTaiKhoan(string TENTK)
        {
            return DAL_TaiKhoan.SearchTaiKhoan(TENTK);
        }
    }
}
