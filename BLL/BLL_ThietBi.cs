using DAL.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_ThietBi
    {
        public DAL_ThietBi DAL_ThietBi;

        public BLL_ThietBi(string Dbconnection)
        {
            DAL_ThietBi = new DAL_ThietBi(Dbconnection);
        }

        //hamf load du lieu tu
        public System.Data.DataTable GetDataThietBi()
        {
            return DAL_ThietBi.LoadThietBi();
        }


        //ham them thiet bi
        public bool AddThietBi(DAL.Model.ThietBi thietBi)
        {
            if (thietBi == null)
            {
                throw new ArgumentNullException(nameof(thietBi), "Thông tin thiết bị không được để trống.");
            }

            thietBi.TenThietBi = thietBi.TenThietBi.Trim();

            if (string.IsNullOrWhiteSpace(thietBi.TenThietBi) || thietBi.SoLuongThietBi <= 0 || string.IsNullOrWhiteSpace(thietBi.TinhTrang))
            {
                throw new ArgumentException("Vui lòng nhập đầy đủ và hợp lệ thông tin thiết bị.");
            }

            if (DAL_ThietBi.CheckThietBi(thietBi.TenThietBi))
            {
                throw new ArgumentException($"Thiết bị '{thietBi.TenThietBi}' đã tồn tại.");
            }

            return DAL_ThietBi.AddThietBi(thietBi);
        }


        //ham sua thiet bi

        public bool UpdateThietBi(DAL.Model.ThietBi thietBi)
        {
            if (thietBi.MaThietBi <= 0 || string.IsNullOrWhiteSpace(thietBi.TenThietBi) || thietBi.SoLuongThietBi <= 0 || string.IsNullOrWhiteSpace(thietBi.TinhTrang))
            {
                throw new Exception("Vui lòng nhập đầy đủ thông tin thiết bị");
            }
            if (DAL_ThietBi.CheckThietBi(thietBi.TenThietBi))
            {
                throw new Exception($"Tên thiết bị '{thietBi.TenThietBi}' đã tồn tại");
            }
            return DAL_ThietBi.UpdateThietBi(thietBi);
        }

        //ham xoa thiet bi
        public bool DeleteThietBi(int MathietBi)
        {
            if (MathietBi <= 0)
            {
                throw new Exception("Vui lòng chọn dịch vụ cần xóa");
            }

            return DAL_ThietBi.DeleteThietBi(MathietBi);
        }

        //ham tim kiem thiet bi
        public System.Data.DataTable SearchThietBi(string TenThietBi)
        {
            return DAL_ThietBi.SearchThietBi(TenThietBi);
        }

    }
}
