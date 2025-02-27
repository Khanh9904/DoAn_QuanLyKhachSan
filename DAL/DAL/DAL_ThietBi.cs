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
    public class DAL_ThietBi
    {
        private string connectionString;

        public DAL_ThietBi(string Dbconnection)
        {
            connectionString = Dbconnection;
        }

        // Load dữ liệu

        public DataTable LoadThietBi()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM THIET_BI";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dt);
            }
            return dt;
        }

        // Kiểm tra thiết bị đã tồn tại chưa
        public bool CheckThietBi(string TenThietBi)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM THIET_BI WHERE TenThietBi = @TenThietBi";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@TenThietBi", TenThietBi);
                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        // Thêm thiết bị mới
        public bool AddThietBi(ThietBi tb)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO THIET_BI (TenThietBi, SoLuongThietBi, TinhTrang) VALUES (@TenThietBi, @SoLuongThietBi, @TinhTrang)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@TenThietBi", tb.TenThietBi);
                cmd.Parameters.AddWithValue("@SoLuongThietBi", tb.SoLuongThietBi);
                cmd.Parameters.AddWithValue("@TinhTrang", tb.TinhTrang);
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        // Sửa thiết bị

        public bool UpdateThietBi(ThietBi tb)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE THIET_BI SET TenThietBi = @TenThietBi, SoLuongThietBi = @SoLuongThietBi, TinhTrang = @TinhTrang WHERE MaThietBi = @MaThietBi";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@MaThietBi", tb.MaThietBi);
                cmd.Parameters.AddWithValue("@TenThietBi", tb.TenThietBi);
                cmd.Parameters.AddWithValue("@SoLuongThietBi", tb.SoLuongThietBi);
                cmd.Parameters.AddWithValue("@TinhTrang", tb.TinhTrang);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Xóa thiết bị

        public bool DeleteThietBi(int MaThietBi)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM THIET_BI WHERE MaThietBi = @MaThietBi";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@MaThietBi", MaThietBi);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Tìm kiếm thiết bị
        public DataTable SearchThietBi(string tenthietbi)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM THIET_BI WHERE TenThietBi LIKE @TenThietBi";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@TenThietBi", "%" + tenthietbi + "%");
                adapter.Fill(dt);
            }
            return dt;
        }

    }
}
