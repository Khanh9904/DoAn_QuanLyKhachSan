using DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL
{
    public class DAL_LoaiPhong
    {
        private string connectionString;

        public DAL_LoaiPhong(string Dbconnection)
        {
            connectionString = Dbconnection;
        }

        // Load dữ liệu
        public DataTable LoadLoaiPhong()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM LOAI_PHONG";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dt);
            }
            return dt;
        }

        // Kiểm tra loại phòng đã tồn tại chưa
        public bool CheckLoaiPhong(string TenLoaiPhong)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM LOAI_PHONG WHERE TenLoaiPhong = @TenLoaiPhong";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@TenLoaiPhong", TenLoaiPhong);
                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        // Thêm loại phòng mới
        public bool AddLoaiPhong(LoaiPhong lp)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO LOAI_PHONG (TenLoaiPhong, Gia, SoNguoiToiDa) VALUES (@TenLoaiPhong, @Gia, @SoNguoiToiDa)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@TenLoaiPhong", lp.TenLoaiPhong);
                cmd.Parameters.AddWithValue("@Gia", lp.Gia);
                cmd.Parameters.AddWithValue("@SoNguoiToiDa", lp.SoNguoiToiDa);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Cập nhật loại phòng
        public bool UpdateLoaiPhong(LoaiPhong lp)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE LOAI_PHONG SET TenLoaiPhong = @TenLoaiPhong, Gia = @Gia, SoNguoiToiDa = @SoNguoiToiDa WHERE MaLoaiPhong = @MaLoaiPhong";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@MaLoaiPhong", lp.MaLoaiPhong);
                cmd.Parameters.AddWithValue("@TenLoaiPhong", lp.TenLoaiPhong);
                cmd.Parameters.AddWithValue("@Gia", lp.Gia);
                cmd.Parameters.AddWithValue("@SoNguoiToiDa", lp.SoNguoiToiDa);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Xóa loại phòng
        public bool DeleteLoaiPhong(int MaLoaiPhong)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM LOAI_PHONG WHERE MaLoaiPhong = @MaLoaiPhong";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@MaLoaiPhong", MaLoaiPhong);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Tìm kiếm loại phòng
        public DataTable SearchLoaiPhong(string TenLoaiPhong)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM LOAI_PHONG WHERE TenLoaiPhong LIKE @TenLoaiPhong";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@TenLoaiPhong", "%" + TenLoaiPhong + "%");
                adapter.Fill(dt);
            }
            return dt;
        }
    }
}
