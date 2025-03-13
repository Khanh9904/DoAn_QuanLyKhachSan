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
    public class DAL_CaLam
    {
        private string connectionString;

        public DAL_CaLam(string Dbconnection)
        {
            this.connectionString = Dbconnection;
        }

        // load du lieu
        public DataTable LoadCaLam()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM CALAMVIEC";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                da.Fill(dt);
            }
            return dt;
        }
        // Kiểm tra ca lam đã tồn tại chưa
        public bool CheckCaLam(string TENCA)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM CALAMVIEC WHERE TENCA = @TENCA";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@TENCA", TENCA);
                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        // Thêm ca lam mới
        public bool AddCaLam(CaLam cl)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO CALAMVIEC (TENCA, GIOBATDAU, GIOKETTHUC) VALUES (@TENCA, @GIOBATDAU, @GIOKETTHUC)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@TENCA", cl.TENCA);
                cmd.Parameters.AddWithValue("@GIOBATDAU", cl.GIOBATDAU);
                cmd.Parameters.AddWithValue("@GIOKETTHUC", cl.GIOKETTHUC);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Sửa ca lam
        public bool UpdateCaLam(CaLam cl)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE CALAMVIEC SET TENCA = @TENCA, GIOBATDAU = @GIOBATDAU, GIOKETTHUC = @GIOKETTHUC WHERE ID_CALAM = @ID_CALAM";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ID_CALAM", cl.ID_CALAM);
                cmd.Parameters.AddWithValue("@TENCA", cl.TENCA);
                cmd.Parameters.AddWithValue("@GIOBATDAU", cl.GIOBATDAU);
                cmd.Parameters.AddWithValue("@GIOKETTHUC", cl.GIOKETTHUC);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Xóa ca lam
        public bool DeleteCaLam(int ID_CALAM)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM CALAMVIEC WHERE ID_CALAM = @ID_CALAM";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ID_CALAM", ID_CALAM);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // tim kiem ca lam
        public DataTable SearchCaLam(string TENCA)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM CALAMVIEC WHERE TENCA LIKE @TENCA";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                da.SelectCommand.Parameters.AddWithValue("@TENCA", "%" + TENCA + "%");
                da.Fill(dt);
            }
            return dt;
        }


    }
}
