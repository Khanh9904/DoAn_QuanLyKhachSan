using DAL.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL
{
    public class DAL_Tang
    {
        private string connectionString;
        public DAL_Tang(string Dbconnection)
        {
            this.connectionString = Dbconnection;
        }

        // load dữ liệu từ bảng TANG
        public DataTable LoadTang()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string getQuery = "SELECT * FROM TangLau";
                SqlDataAdapter adapterTang = new SqlDataAdapter(getQuery, connection);
                adapterTang.Fill(dt);
                return dt;
            }


        }

        // kiểm tra tầng có tồn tại không
        public bool CheckTang(string TenTang)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string CheckQuery = "SELECT COUNT(*) FROM TangLau WHERE TenTang = @TenTang";
                SqlCommand CheckComand = new SqlCommand(CheckQuery, connection);
                CheckComand.Parameters.AddWithValue("@TenTang", TenTang);
                return (int)CheckComand.ExecuteScalar() > 0;
            }
        }


        // thêm tầng mới
        public bool AddTang(Tang tang)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string AddQuery = "INSERT INTO TangLau(TenTang) VALUES(@TenTang)";
                SqlCommand AddComand = new SqlCommand(AddQuery, connection);
                AddComand.Parameters.AddWithValue("@TenTang", tang.TenTang);
                return AddComand.ExecuteNonQuery() > 0;
            }
        }

        // sửa tầng
        public bool UpdateTang(Tang tang)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string UpdateQuery = "UPDATE TangLau SET TenTang = @TenTang WHERE MaTang = @MaTang";
                SqlCommand UpdateComand = new SqlCommand(UpdateQuery, connection);
                
                UpdateComand.Parameters.AddWithValue("@TenTang", tang.TenTang);
                return UpdateComand.ExecuteNonQuery() > 0;
            }
        }

        // xóa tầng
        public bool DeleteTang(int MaTang)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string DeleteQuery = "DELETE FROM TangLau WHERE MaTang = @MaTang";
                SqlCommand DeleteComand = new SqlCommand(DeleteQuery, connection);
                DeleteComand.Parameters.AddWithValue("@MaTang", MaTang);
                return DeleteComand.ExecuteNonQuery() > 0;
            }
        }

        // tìm kiếm tầng
        public DataTable SearchTang(string TenTang)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string SearchQuery = "SELECT * FROM TangLau WHERE TenTang LIKE @TenTang";
                SqlCommand SearchComand = new SqlCommand(SearchQuery, connection);
                SearchComand.Parameters.AddWithValue("@TenTang", "%" + TenTang + "%");
                SqlDataAdapter adapterTang = new SqlDataAdapter(SearchQuery, connection);
             
                adapterTang.Fill(dt);
                return dt;
            }
        }

        

    }
}
