using DAL.DAL;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_PhanCongCaLam
    {
        public DAL_PhanCongCaLam DAL_PhanCongCaLam;

        public BLL_PhanCongCaLam(string Dbconnection)
        {
            DAL_PhanCongCaLam = new DAL_PhanCongCaLam(Dbconnection);
        }
        //ham load du lieu
        public System.Data.DataTable GetDataPhanCongCaLam()
        {
            return DAL_PhanCongCaLam.LoadPhanCongCaLam();
        }

        //ham them du lieu
        public bool AddPhanCongCaLam(PhanCongCaLam phanCongCaLam)
        {
            // Kiểm tra dữ liệu đầu vào
            if (phanCongCaLam.ID_NHANVIEN <= 0 || phanCongCaLam.ID_CALAM <= 0)
            {
                throw new ArgumentException("Vui lòng nhập đầy đủ thông tin phân công ca làm.");
            }

            if (phanCongCaLam.NGAYLAM == default)
            {
                throw new ArgumentException("Ngày làm không hợp lệ.");
            }

            // Kiểm tra phân công ca làm đã tồn tại chưa
            if (DAL_PhanCongCaLam.CheckPhanCongCaLam(phanCongCaLam.ID_CALAM, phanCongCaLam.ID_NHANVIEN, phanCongCaLam.NGAYLAM))
            {
                throw new Exception($"Phân công ca làm cho nhân viên {phanCongCaLam.ID_NHANVIEN} đã tồn tại.");
            }

            // Thêm phân công ca làm
            return DAL_PhanCongCaLam.AddPhanCongCaLam(phanCongCaLam);
        }


        //ham sua phan cong ca lam
        public bool UpdatePhanCongCaLam(PhanCongCaLam phanCongCaLam)
        {
            // Kiểm tra dữ liệu đầu vào
            if (phanCongCaLam.ID_PHANCONG <= 0 || phanCongCaLam.ID_NHANVIEN <= 0 || phanCongCaLam.ID_CALAM <= 0)
            {
                throw new ArgumentException("Vui lòng nhập đầy đủ thông tin phân công ca làm.");
            }

            if (phanCongCaLam.NGAYLAM == default)
            {
                throw new ArgumentException("Ngày làm không hợp lệ.");
            }

            // Kiểm tra phân công ca làm đã tồn tại chưa
            if (DAL_PhanCongCaLam.CheckPhanCongCaLam(phanCongCaLam.ID_CALAM, phanCongCaLam.ID_NHANVIEN, phanCongCaLam.NGAYLAM))
            {
                throw new Exception($"Phân công ca làm cho nhân viên {phanCongCaLam.ID_NHANVIEN} đã tồn tại.");
            }

            // Cập nhật phân công ca làm
            return DAL_PhanCongCaLam.UpdatePhanCongCaLam(phanCongCaLam);
        }


        //ham xoa phan cong ca lam
        public bool DeletePhanCongCaLam(int ID_PHANCONG)
        {
            if (ID_PHANCONG <= 0)
            {
                throw new Exception("Vui lòng chọn phân công ca làm cần xóa");
            }
            return DAL_PhanCongCaLam.DeletePhanCongCaLam(ID_PHANCONG);
        }

        //ham tim kiem phan cong ca lam theo ngay
        public System.Data.DataTable SearchPhanCongCaLam(DateTime NGAYLAM)
        {
            return DAL_PhanCongCaLam.SearchPhanCongCaLam(NGAYLAM);
        }
        // check phan cong ca lam
        public bool CheckPhanCongCaLam(int ID_NHANVIEN, int ID_CALAM, DateTime NGAYLAM)
        {
            if (ID_NHANVIEN <= 0)
                throw new ArgumentException("ID nhân viên không hợp lệ.");

            if (ID_CALAM <= 0)
                throw new ArgumentException("ID ca làm không hợp lệ.");

            if (NGAYLAM == default)
                throw new ArgumentException("Ngày làm không hợp lệ.");

            return DAL_PhanCongCaLam.CheckPhanCongCaLam(ID_CALAM, ID_NHANVIEN, NGAYLAM);
        }



    }
}
