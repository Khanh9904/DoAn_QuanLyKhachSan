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
            
            
                // Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrWhiteSpace(caLam.TENCA))
                    throw new ArgumentException("Vui lòng nhập tên ca làm.");

                if (caLam.TENCA.Length > 50)
                    throw new ArgumentException("Tên ca làm không được quá 50 ký tự.");

                if (caLam.GIOBATDAU == null || caLam.GIOKETTHUC == null)
                    throw new ArgumentException("Vui lòng nhập giờ bắt đầu và kết thúc.");

                if (caLam.GIOBATDAU >= caLam.GIOKETTHUC)
                    throw new ArgumentException("Giờ bắt đầu phải nhỏ hơn giờ kết thúc.");

                if (DAL_CaLam.CheckCaLam(caLam.TENCA))
                {
                    throw new Exception($"Tên ca làm '{caLam.TENCA}' đã tồn tại");
                }

                return DAL_CaLam.AddCaLam(caLam);
            
            
        }

        //ham sua ca lam
        public bool UpdateCaLam(CaLam caLam)
        {
            
            
                if (caLam.ID_CALAM <= 0)
                    throw new ArgumentException("Vui lòng chọn ca làm hợp lệ để cập nhật.");

                if (string.IsNullOrWhiteSpace(caLam.TENCA))
                    throw new ArgumentException("Vui lòng nhập tên ca làm.");

                if (caLam.GIOBATDAU == null || caLam.GIOKETTHUC == null)
                    throw new ArgumentException("Vui lòng nhập giờ bắt đầu và kết thúc.");

                if (caLam.GIOBATDAU >= caLam.GIOKETTHUC)
                    throw new ArgumentException("Giờ bắt đầu phải nhỏ hơn giờ kết thúc.");

                if (DAL_CaLam.CheckCaLam(caLam.TENCA))
                {
                    throw new Exception($"Tên ca làm '{caLam.TENCA}' đã tồn tại");
                }
                return DAL_CaLam.UpdateCaLam(caLam);
            
           
        }

        //ham xoa ca lam
        public bool DeleteCaLam(int ID_CALAM)
        {
            try
            {
                if (ID_CALAM <= 0)
                    throw new ArgumentException("Vui lòng chọn ca làm hợp lệ để xóa.");

                
                return DAL_CaLam.DeleteCaLam(ID_CALAM);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi xóa ca làm: {ex.Message}");
                return false;
            }
        }

        //ham tim kiem ca lam
        public DataTable SearchCaLam(string TENCA)
        {
            return DAL_CaLam.SearchCaLam(TENCA);
        }

    }
}
