using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Model;

namespace DAL.DAL
{
    public class DAL_ThongTinKhachHang
    {
        private string connectionString;

        public DAL_ThongTinKhachHang (string Dbconnection)
        {
            connectionString = Dbconnection;
        }

        //------------------------------------------------------------------------------------------------------------------------------------------

        // Tải dữ liệu bảng khách hàng
        public DataTable LoadKhachHang()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string getQuery = "SELECT * FROM KHACH_HANG";

                SqlDataAdapter adapterPhanQuyen = new SqlDataAdapter(getQuery, connection);

                adapterPhanQuyen.Fill(dt);

                return dt;
            }

        }
        //----------------------------------------------------------------------------------------------------------------------------------------------

        // thêm khách hàng mới
        public bool AddKhachHang(ThongTinKhachHang thongtinkhachhang) // goi PhanQuyen trong Model

        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string AddQuery = "INSERT INTO KHACH_HANG (HoTen, NgaySinh, GioiTinh, SDT, DiaChi, CCCD) values (@HoTen, @NgaySinh, @GioiTinh, @SDT, @DiaChi, @CCCD)";

                SqlCommand Addconmand = new SqlCommand(AddQuery, connection);


                Addconmand.Parameters.AddWithValue("@HoTen", thongtinkhachhang.HoTen);

                Addconmand.Parameters.AddWithValue("@NgaySinh", thongtinkhachhang.NgaySinh);

                Addconmand.Parameters.AddWithValue("@GioiTinh", thongtinkhachhang.GioiTinh);

                Addconmand.Parameters.AddWithValue("@SDT", thongtinkhachhang.SDT);

                Addconmand.Parameters.AddWithValue("@DiaChi", thongtinkhachhang.DiaChi);

                Addconmand.Parameters.AddWithValue("@CCCD", thongtinkhachhang.CCCD);


                return Addconmand.ExecuteNonQuery() > 0;
            }

        }

        //---------------------------------------------------------------------------------------------------------------------------------------

        //  sửa thông tin khách hàng

        public bool UpdateKhachHang(ThongTinKhachHang thongtinkhachhang)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string EditQuery = "UPDATE KHACH_HANG SET HoTen = @HoTen, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, SDT = @SDT, DiaChi = @DiaChi, CCCD = @CCCD WHERE MaKhachHang = @MaKhachHang";

                SqlCommand EditCommand = new SqlCommand(EditQuery, connection);

                EditCommand.Parameters.AddWithValue("@MaKhachHang", thongtinkhachhang.MaKhachHang);

                EditCommand.Parameters.AddWithValue("@HoTen", thongtinkhachhang.HoTen);

                EditCommand.Parameters.AddWithValue("@NgaySinh", thongtinkhachhang.NgaySinh);

                EditCommand.Parameters.AddWithValue("@GioiTinh", thongtinkhachhang.GioiTinh);

                EditCommand.Parameters.AddWithValue("@SDT", thongtinkhachhang.SDT);

                EditCommand.Parameters.AddWithValue("@DiaChi", thongtinkhachhang.DiaChi);

                EditCommand.Parameters.AddWithValue("@CCCD", thongtinkhachhang.CCCD);

                return EditCommand.ExecuteNonQuery() > 0;
            }
        }

        //---------------------------------------------------------------------------------------------------------------------------------------

        // xóa thông tin khách hàng

        public bool DeleteKhachHang(int MaKhachHang)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string DeleteQuery = "DELETE FROM KHACH_HANG WHERE MaKhachHang = @MaKhachHang";

                SqlCommand DeleteCommand = new SqlCommand(DeleteQuery, connection);

                DeleteCommand.Parameters.AddWithValue("@MaKhachHang", MaKhachHang);

                return DeleteCommand.ExecuteNonQuery() > 0;
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------------

        // tìm kiếm thông tin khách hàng

        public DataTable TimKiemKhachHang(string keyword)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string TimKiemQuery = "SELECT * FROM KHACH_HANG WHERE HoTen LIKE @HoTen";

                SqlDataAdapter TimKiemAdapter = new SqlDataAdapter(TimKiemQuery, connection);

                TimKiemAdapter.SelectCommand.Parameters.AddWithValue("@HoTen", "%" + keyword + "%");

                SqlDataAdapter adapterPhanQuyen = new SqlDataAdapter(TimKiemQuery, connection);

                DataTable dt = new DataTable();

                TimKiemAdapter.Fill(dt);

                return dt;
            }
        }

    }
}
