using DAL.DAL;
using DAL.Database;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Phong
    {
        public DAL_Phong DAL_Phong;

        public BLL_Phong(string Dbconnection)
        {
            DAL_Phong = new DAL_Phong(Dbconnection);
        }

        //--------------------------------------------------------------------------------------------------------------------------------------

        // ham load du lieu
        public System.Data.DataTable GetDataPhong()
        {
            return DAL_Phong.LoadPhong();
        }
        //--------------------------------------------------------------------------------------------------------------------------------------

        // ham them du lieu
        public bool AddPhong(Phong phong)
        {

            return DAL_Phong.AddPhong(phong);
        }

        //--------------------------------------------------------------------------------------------------------------------------------------

        // ham sua du lieu
        public bool UpdatePhong(Phong phong)
        {
            return DAL_Phong.UpdatePhong(phong);
        }

        //--------------------------------------------------------------------------------------------------------------------------------------

        // ham xoa du lieu
        public bool DeletePhong( int MaPhong)
        {
            if (MaPhong <= 0)
            {
                throw new Exception("Vui lòng chọn nhân viên cần xóa");
            }

            return DAL_Phong.DeletePhong(MaPhong);
        }

        //--------------------------------------------------------------------------------------------------------------------------------------

        // ham tim kiem du lieu
        public DataTable SearchPhong(string TENPHONG)
        {
            return DAL_Phong.SearchPhong(TENPHONG);
        }
        //--------------------------------------------------------------------------------------------------------------------------------------

        // check phong
        public bool CheckPhong(string TENPHONG)
        {
            return DAL_Phong.CheckPhong(TENPHONG);
        }
    }
}
