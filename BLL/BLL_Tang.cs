using DAL.DAL;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Tang
    {
        public DAL_Tang DAL_Tang;

       public BLL_Tang(string Dbconnection)
        {
            DAL_Tang = new DAL_Tang(Dbconnection);
        }


        //hàm load dữ liệu từ bảng TANG
        public DataTable GetDataTang()
        {
            return DAL_Tang.LoadTang();
        }


        // hàm thêm tầng mới
        public bool AddTang(Tang tang)
        {
            
            if (string.IsNullOrWhiteSpace(tang.TenTang))
            {
                throw new Exception("Vui lòng nhập đủ thông tin");
            }

           
            if (DAL_Tang.CheckTang(tang.TenTang))
            {
                throw new Exception($"Tên tầng : {tang.TenTang} đã tồn tại");

            }
           
            return DAL_Tang.AddTang(tang);
        }

        // hàm sửa tầng
        public bool UpdateTang(Tang tang)
        {
            if (tang.MaTang <= 0 || string.IsNullOrWhiteSpace(tang.TenTang))
            {
                throw new Exception("Vui lòng nhập đủ thông tin");
            }
            return DAL_Tang.UpdateTang(tang);
        }

        // hàm xóa tầng
        public bool DeleteTang(int MaTang)
        {
            if (MaTang <= 0)
            {
                throw new Exception("Vui lòng chọn tầng cần xóa");
            }
            return DAL_Tang.DeleteTang(MaTang);
        }



        // hàm tìm kiếm tầng
        public DataTable SearchTang(string TenTang)
        {
            return DAL_Tang.SearchTang(TenTang);
        }
    }
}
