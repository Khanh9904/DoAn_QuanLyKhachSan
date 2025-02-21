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
    public class BLL_LoaiPhong
    {
        public DAL_LoaiPhong DAL_LoaiPhong;

        //--------------------------------------------------------------------------------
        // Hàm khởi tạo và truyền chuỗi kết nối
        public BLL_LoaiPhong(string Dbconnection)
        {
            DAL_LoaiPhong = new DAL_LoaiPhong(Dbconnection);
        }

        //--------------------------------------------------------------------------------
        // Hàm load dữ liệu từ bảng LOAIPHONG
        public DataTable GetDataLoaiPhong()
        {
            return DAL_LoaiPhong.LoadLoaiPhong();
        }

        //--------------------------------------------------------------------------------
        // Hàm thêm loại phòng mới
        public bool AddLoaiPhong(LoaiPhong loaiPhong)
        {
            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(loaiPhong.TenLoaiPhong) || loaiPhong.Gia <= 0 || loaiPhong.SoNguoiToiDa <= 0)
            {
                throw new Exception("Vui lòng nhập đầy đủ thông tin loại phòng");
            }

            // Kiểm tra tên loại phòng đã tồn tại chưa
            if (DAL_LoaiPhong.CheckLoaiPhong(loaiPhong.TenLoaiPhong))
            {
                throw new Exception($"Tên loại phòng '{loaiPhong.TenLoaiPhong}' đã tồn tại");
            }

            // Thêm loại phòng thành công
            return DAL_LoaiPhong.AddLoaiPhong(loaiPhong);
        }

        //--------------------------------------------------------------------------------
        // Hàm sửa loại phòng
        public bool UpdateLoaiPhong(LoaiPhong loaiPhong)
        {
            if (loaiPhong.MaLoaiPhong <= 0 || string.IsNullOrWhiteSpace(loaiPhong.TenLoaiPhong) || loaiPhong.Gia <= 0 || loaiPhong.SoNguoiToiDa <= 0)
            {
                throw new Exception("Vui lòng nhập đầy đủ thông tin loại phòng");
            }

            return DAL_LoaiPhong.UpdateLoaiPhong(loaiPhong);
        }

        //--------------------------------------------------------------------------------
        // Hàm xóa loại phòng
        public bool DeleteLoaiPhong(int MaLoaiPhong)
        {
            if (MaLoaiPhong <= 0)
            {
                throw new Exception("Vui lòng chọn loại phòng cần xóa");
            }

            return DAL_LoaiPhong.DeleteLoaiPhong(MaLoaiPhong);
        }

        //--------------------------------------------------------------------------------
        // Hàm tìm kiếm loại phòng
        public DataTable SearchLoaiPhong(string TenLoaiPhong)
        {
            return DAL_LoaiPhong.SearchLoaiPhong(TenLoaiPhong);
        }
    }
}
