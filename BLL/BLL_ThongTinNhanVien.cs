using DAL.DAL;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_ThongTinNhanVien
    {
        public DAL_ThongTinNhanVien DAL_ThongTinNhanVien;

        public BLL_ThongTinNhanVien(string Dbconnection)
        {
            DAL_ThongTinNhanVien = new DAL_ThongTinNhanVien(Dbconnection);
        }

        //-------------------------------------------------------------
        // ham load du lieu
        public DataTable GetDataNhanVien()
        {
            return DAL_ThongTinNhanVien.LoadNhanVien();
        }
        //-------------------------------------------------------------
        // ham kiem tra ten nhan vien co ton tai khong
        public bool CheckNhanVien(string TenNhanVien)
        {
            return DAL_ThongTinNhanVien.CheckNhanVien(TenNhanVien);
        }

        //-------------------------------------------------------------
        // ham them du lieu
        public bool AddNhanVien(NhanVien nhanVien)
        {
            // Kiem tra du lieu dau vao
            if (string.IsNullOrWhiteSpace(nhanVien.HOTEN) || string.IsNullOrWhiteSpace(nhanVien.DIACHI) || string.IsNullOrWhiteSpace(nhanVien.SDT))
            {
                throw new Exception("Vui lòng nhập đủ thông tin");
            }
            // Kiem tra ten nhan vien da ton tai chua
            if (DAL_ThongTinNhanVien.CheckNhanVien(nhanVien.HOTEN))
            {
                throw new Exception($"Tên Nhân Viên : {nhanVien.HOTEN} đã tồn tại");
            }
            // tra ve thong tin them thanh cong
            return DAL_ThongTinNhanVien.AddNhanVien(nhanVien);
        }


        //-------------------------------------------------------------
        // ham sua du lieu
        public bool UpdateNhanVien(NhanVien nhanVien)
        {
            // Kiem tra du lieu dau vao
            if (nhanVien.ID_NHANVIEN <= 0 || string.IsNullOrWhiteSpace(nhanVien.HOTEN) || string.IsNullOrWhiteSpace(nhanVien.DIACHI) || string.IsNullOrWhiteSpace(nhanVien.SDT))
            {
                throw new Exception("Vui lòng nhập đủ thông tin");
            }
            // tra ve thong tin sua thanh cong
            return DAL_ThongTinNhanVien.UpdateNhanVien(nhanVien);
        }

        //-------------------------------------------------------------
        // ham xoa du lieu
        public bool DeleteNhanVien(int ID_NHANVIEN)
        {
            // Kiem tra du lieu dau vao
            if (ID_NHANVIEN <= 0)
            {
                throw new Exception("Vui lòng chọn nhân viên cần xóa");
            }
            // tra ve thong tin xoa thanh cong
            return DAL_ThongTinNhanVien.DeleteNhanVien(ID_NHANVIEN);
        }

        //-------------------------------------------------------------
        // ham tim kiem du lieu
        public DataTable SearchNhanVien(string HOTEN)
        {
            return DAL_ThongTinNhanVien.SearchNhanVien(HOTEN);
        }


    }
}
