using DAL.DAL;
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
        

        //-------------------------------------------------------------
        // ham load du lieu
        public DataTable GetDataTaiKhoan()
        {
            return DAL_TaiKhoan.LoadTaiKhoan();
        }

        //-----------------------------------------------------------------------------------
        // hàm thêm tài khoản
        public bool AddTaiKhoan(TaiKhoan taikhoan)
        {

            
            if (DAL_TaiKhoan.CheckTaiKhoan(taikhoan.ID_TAIKHOAN.ToString()))
            {
                throw new Exception($"Tên Tài Khoản : {taikhoan.EMAIL} đã tồn tại");
            }
            
            return DAL_TaiKhoan.AddTaiKhoan(taikhoan);
        }

        //-----------------------------------------------------------------------------------
        // hàm cập nhật tài khoản
        public bool UpdateTaiKhoan(TaiKhoan taikhoan)
        {
            
            if (taikhoan == null)
            {
                throw new ArgumentNullException(nameof(taikhoan), "Tài khoản không được để trống!");
            }

            if (taikhoan.ID_TAIKHOAN <= 0 ||
                string.IsNullOrWhiteSpace(taikhoan.EMAIL) ||
                string.IsNullOrWhiteSpace(taikhoan.MATKHAU) ||
                taikhoan.ID_PHANQUYEN <= 0)
            {
                throw new Exception("Vui lòng nhập đầy đủ thông tin tài khoản hợp lệ!");
            }

           
            return DAL_TaiKhoan.UpdateTaiKhoan(taikhoan);
        }

        //-----------------------------------------------------------------------------------
        // hàm xóa tài khoản
        public bool DeleteTaiKhoan(int ID_TAIKHOAN)
        {
            
            if (ID_TAIKHOAN <= 0)
            {
                throw new Exception("Vui lòng chọn tài khoản hợp lệ để xóa!");
            }

            
            return DAL_TaiKhoan.DeleteTaiKhoan(ID_TAIKHOAN);
        }


        // Hàm tìm kiếm tài khoản theo tên tài khoản
        public DataTable SearchTaiKhoan(string EMAIL)
        {
            return DAL_TaiKhoan.SearchTaiKhoan(EMAIL);
        }
    }
}
