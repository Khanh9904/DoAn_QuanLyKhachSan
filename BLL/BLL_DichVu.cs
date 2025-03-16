using DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DAL;

namespace BLL
{
    public class BLL_DichVu
    {
        public DAL_DichVu DAL_DichVu;

        //--------------------------------------------------------------------------------
        // Hàm khởi tạo và truyền chuỗi kết nối
        public BLL_DichVu(string Dbconnection)
        {
            DAL_DichVu = new DAL_DichVu(Dbconnection);
        }

        //--------------------------------------------------------------------------------
        // Hàm load dữ liệu từ bảng DICHVU
        public DataTable GetDataDichVu()
        {
            return DAL_DichVu.LoadDichVu();
        }

        //--------------------------------------------------------------------------------
        // Hàm thêm dịch vụ mới
        public bool AddDichVu(DichVu dichVu)
        {
            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(dichVu.TenDichVu) || dichVu.SoLuongDichVu <= 0 || string.IsNullOrWhiteSpace(dichVu.TrangThaiDichVu))
            {
                throw new Exception("Vui lòng nhập đầy đủ thông tin dịch vụ");
            }

            // Kiểm tra tên dịch vụ đã tồn tại chưa
            if (DAL_DichVu.CheckDichVu(dichVu.TenDichVu))
            {
                throw new Exception($"Tên dịch vụ '{dichVu.TenDichVu}' đã tồn tại");
            }

            // Thêm dịch vụ thành công
            return DAL_DichVu.AddDichVu(dichVu);
        }

        //--------------------------------------------------------------------------------
        // Hàm sửa thông tin dịch vụ
        public bool UpdateDichVu(DichVu dichVu)
        {
            if (dichVu.MaDichVu <= 0 || string.IsNullOrWhiteSpace(dichVu.TenDichVu) || dichVu.SoLuongDichVu <= 0 || string.IsNullOrWhiteSpace(dichVu.TrangThaiDichVu))
            {
                throw new Exception("Vui lòng nhập đầy đủ thông tin dịch vụ");
            }

            // Kiểm tra tên dịch vụ đã tồn tại chưa
            if (DAL_DichVu.CheckDichVu(dichVu.TenDichVu))
            {
                throw new Exception($"Tên dịch vụ '{dichVu.TenDichVu}' đã tồn tại");
            }

            return DAL_DichVu.UpdateDichVu(dichVu);
        }

        //--------------------------------------------------------------------------------
        // Hàm xóa dịch vụ
        public bool DeleteDichVu(int MaDichVu)
        {
            if (MaDichVu <= 0)
            {
                throw new Exception("Vui lòng chọn dịch vụ cần xóa");
            }

            return DAL_DichVu.DeleteDichVu(MaDichVu);
        }

        //--------------------------------------------------------------------------------
        // Hàm tìm kiếm dịch vụ
        public DataTable SearchDichVu(string TenDichVu)
        {
            return DAL_DichVu.SearchDichVu(TenDichVu);
        }
    }
}

