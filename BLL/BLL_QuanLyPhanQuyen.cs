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
    public class BLL_QuanLyPhanQuyen
    {
        public DAL_QuanLyPhanQuyen DAL_QuanLyPhanQuyen;

        //--------------------------------------------------------------------------------
        public BLL_QuanLyPhanQuyen(string Dbconnection)
        {
            DAL_QuanLyPhanQuyen = new DAL_QuanLyPhanQuyen(Dbconnection);
        }


        //--------------------------------------------------------------------------------
        // Ham load du lieu
        public DataTable GetDataPhanQuyen()
        {
            return DAL_QuanLyPhanQuyen.LoadPhanQuyen();
        }

        //--------------------------------------------------------------------------------
        //ham them du lieu

        public bool AddNewPhanQuyen(PhanQuyen phanQuyen)
        {
            // Kiem tra du lieu dau vao
            if (string.IsNullOrWhiteSpace(phanQuyen.TENQUYEN) || string.IsNullOrWhiteSpace(phanQuyen.MoTa) || phanQuyen.MUCLUONGLAMVIEC <= 0)
            {
                throw new Exception("Vui lòng nhập đủ thông tin");
            }

            // Kiem tra ten phan quyen da ton tai chua
            if (DAL_QuanLyPhanQuyen.CheckPhanQuyen(phanQuyen.TENQUYEN))
            {
                throw new Exception($"Tên Phân Quyền : {phanQuyen.TENQUYEN} đã tồn tại");

            }
            // tra ve thong tin them thanh cong
            return DAL_QuanLyPhanQuyen.AddPhanQuyen(phanQuyen);

            

        }
        //--------------------------------------------------------------------------------
        //ham sua du lieu
        public bool UpdatePhanQuyen(PhanQuyen phanQuyen)
        {
            // Kiem tra du lieu dau vao
            if (phanQuyen.ID_PHANQUYEN <=0 || string.IsNullOrWhiteSpace(phanQuyen.TENQUYEN) || string.IsNullOrWhiteSpace(phanQuyen.MoTa) || phanQuyen.MUCLUONGLAMVIEC <= 0)
            {
                throw new Exception("Vui lòng nhập đủ thông tin");
            }
            
            // tra ve thong tin them thanh cong
            return DAL_QuanLyPhanQuyen.UpdatePhanQuyen(phanQuyen);
        }

        //--------------------------------------------------------------------------------
        //ham xoa du lieu
        public bool DeletePhanQuyen(int ID_PHANQUYEN)
        {
            // Kiem tra du lieu dau vao
            if (ID_PHANQUYEN <= 0)
            {
                throw new Exception("Vui lòng chọn phân quyền cần xóa");
            }
            // tra ve thong tin them thanh cong
            return DAL_QuanLyPhanQuyen.DeletePhanQuyen(ID_PHANQUYEN);
        }

        //--------------------------------------------------------------------------------
        //ham tim kiem du lieu
        public DataTable TimKiemPhanQuyen(string TENQUYEN)
        {
            return DAL_QuanLyPhanQuyen.TimKiemPhanQuyen(TENQUYEN);
        }
    }
}
