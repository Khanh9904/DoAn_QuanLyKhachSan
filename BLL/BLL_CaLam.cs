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
    public class BLL_CaLam
    {
        public DAL_CaLam DAL_CaLam;


        public BLL_CaLam(string Dbconnection)
        {
            DAL_CaLam = new DAL_CaLam(Dbconnection);
        }

        //ham load du lieu 
        public DataTable GetDataCaLam()
        {
            return DAL_CaLam.LoadCaLam();
        }

        //ham them ca lam moi
        public bool AddCaLam(CaLam caLam)
        {
            //kiem tra du lieu dau vao
            if (string.IsNullOrWhiteSpace(caLam.TENCA) || caLam.GIOBATDAU == null || caLam.GIOKETTHUC == null)
            {
                throw new Exception("Vui lòng nhập đầy đủ thông tin ca làm");
            }
            //kiem tra ten ca lam da ton tai chua
            if (DAL_CaLam.CheckCaLam(caLam.TENCA))
            {
                throw new Exception($"Tên ca làm '{caLam.TENCA}' đã tồn tại");
            }
            //them ca lam thanh cong
            return DAL_CaLam.AddCaLam(caLam);
        }

        //ham sua ca lam
        public bool UpdateCaLam(CaLam caLam)
        {
            if (caLam.ID_CALAM <= 0 || string.IsNullOrWhiteSpace(caLam.TENCA) || caLam.GIOBATDAU == null || caLam.GIOKETTHUC == null)
            {
                throw new Exception("Vui lòng nhập đầy đủ thông tin ca làm");
            }
            return DAL_CaLam.UpdateCaLam(caLam);
        }

        //ham xoa ca lam
        public bool DeleteCaLam(int ID_CALAM)
        {
            if (ID_CALAM <= 0)
            {
                throw new Exception("Vui lòng chọn ca làm cần xóa");
            }
            return DAL_CaLam.DeleteCaLam(ID_CALAM);
        }

        //ham tim kiem ca lam
        public DataTable SearchCaLam(string TENCA)
        {
            return DAL_CaLam.SearchCaLam(TENCA);
        }

    }
}
