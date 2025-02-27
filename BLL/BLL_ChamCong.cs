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
    public class BLL_ChamCong
    {
        public DAL_ChamCong DAL_ChamCong;
        public BLL_ChamCong(string DBconnection)
        {
            DAL_ChamCong = new DAL_ChamCong(DBconnection);
        }
        //-----------------load data-----------------
        public DataTable GetDataChamcong()
        {
            return DAL_ChamCong.LoadDataChamcong();
        }
        //==========================================

        //========================================
        public bool themchamcong(ChamCong chamcong)
        {

            //kiem tra du lieu
            //kiem tra du lieu
            if (chamcong.ID_NHANVIEN <= 0 || string.IsNullOrWhiteSpace(chamcong.TRANGTHAI) || chamcong.NGAYLAMVIEC == default)

                throw new Exception("Du lieu khong hop le");

            if (DAL_ChamCong.kiemtrachamcong(chamcong.ID_NHANVIEN, chamcong.NGAYLAMVIEC))
            {
                return false;

            }
            DAL_ChamCong.themchamcong(chamcong);

            if (chamcong.TRANGTHAI == "Có mặt")
            {
                DAL_ChamCong.UpdateTongCong(chamcong.ID_NHANVIEN, 1);

            }
            return true;


        }
        public bool suachamcong(ChamCong chamcong)
        {
            if (chamcong.ID_CHAMCONG <= 0 || chamcong.ID_NHANVIEN <= 0 || string.IsNullOrWhiteSpace(chamcong.TRANGTHAI) || chamcong.NGAYLAMVIEC == default)
            {
                throw new Exception("Du lieu khong hop le");
            }


            //tra ve ket qua
            return DAL_ChamCong.suachamconglamviec(chamcong);


        }
        //================================================
        public bool xoachamcong(int ID_CHAMCONG)
        {
            //kiem tra du lieu
            if (ID_CHAMCONG <= 0)
                throw new Exception("vui lòng chọn phân quyền cần xóa");
            //tra ve ket qua
            return DAL_ChamCong.xoachamcong(ID_CHAMCONG);

        }
        //=================================================


        public DataTable timkiemchamcong(string keyword)
        {
            return DAL_ChamCong.timkiemchamcong(keyword);
        }
    }
}
