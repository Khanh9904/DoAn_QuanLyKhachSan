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
        private string connectionString;

        //--------------------------------------------------------------------------------
        // Hàm khởi tạo và truyền chuỗi kết nối
        public BLL_DichVu(string Dbconnection)
        {
            DAL_DichVu = new DAL_DichVu(Dbconnection);
        }

        // Load dữ liệu
        public DataTable LoadDichVu()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM DichVu";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dt);
            }
            return dt;
        }

        // Kiểm tra dịch vụ đã tồn tại chưa
        public bool CheckDichVu(string TenDichVu)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM DichVu WHERE TenDichVu = @TenDichVu";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@TenDichVu", TenDichVu);
                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        // Thêm dịch vụ mới
        public bool AddDichVu(DichVu dv)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO DICH_VU (TenDichVu, GiaDichVu, MoTa) VALUES (@TenDichVu, @GiaDichVu, @MoTa)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@TenDichVu", dv.TenDichVu);
                cmd.Parameters.AddWithValue("@GiaDichVu", dv.GiaDichVu);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Cập nhật dịch vụ
        public bool UpdateDichVu(DichVu dv)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE DichVu SET TenDichVu = @TenDichVu, GiaDichVu = @GiaDichVu, MoTa = @MoTa WHERE MaDichVu = @MaDichVu";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@MaDichVu", dv.MaDichVu);
                cmd.Parameters.AddWithValue("@TenDichVu", dv.TenDichVu);
                cmd.Parameters.AddWithValue("@GiaDichVu", dv.GiaDichVu);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Xóa dịch vụ
        public bool DeleteDichVu(int MaDichVu)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM DichVu WHERE MaDichVu = @MaDichVu";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@MaDichVu", MaDichVu);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Tìm kiếm dịch vụ
        public DataTable SearchDichVu(string TenDichVu)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM DichVu WHERE TenDichVu LIKE @TenDichVu";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@TenDichVu", "%" + TenDichVu + "%");
                adapter.Fill(dt);
            }
            return dt;
        }
    }
}

