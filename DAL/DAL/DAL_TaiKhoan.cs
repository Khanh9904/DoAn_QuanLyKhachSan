using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Collections;
    //using DAL.Model;
    using global::DAL.Model;

    namespace DoAn_QuanLyKhachSan.DAL
    {
        public class DAL_TaiKhoan
        {
            private string connectionString;

            public DAL_TaiKhoan(string Dbconnection)
            {
                this.connectionString = Dbconnection;
            }

            public DataTable LoadTaiKhoan()
            {
                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string getQuery = "SELECT * FROM TAIKHOAN";
                        SqlDataAdapter adapter = new SqlDataAdapter(getQuery, connection);
                        adapter.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Lỗi khi tải danh sách tài khoản: " + ex.Message);
                    }
                }
                return dt;
            }

            public bool Login(string username, string password)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "SELECT COUNT(*) FROM TaiKhoan WHERE TenTK = @username AND MATKHAU = @password";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Lỗi đăng nhập: " + ex.Message);
                        return false;
                    }
                }
            }

            public bool CheckTaiKhoan(string TenTaiKhoan)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string checkQuery = "SELECT COUNT(*) FROM TAIKHOAN WHERE TENTK = @TENTK";
                        SqlCommand cmd = new SqlCommand(checkQuery, connection);
                        cmd.Parameters.AddWithValue("@TENTK", TenTaiKhoan);
                        return (int)cmd.ExecuteScalar() > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Lỗi kiểm tra tài khoản: " + ex.Message);
                        return false;
                    }
                }
            }

            public bool AddTaiKhoan(TaiKhoan taikhoan)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string addQuery = "INSERT INTO NHANVIEN (TENTK, MATKHAU, ID_PHANQUYEN) VALUES (@TENTK, @MATKHAU, @ID_PHANQUYEN)";
                        SqlCommand cmd = new SqlCommand(addQuery, connection);
                        cmd.Parameters.AddWithValue("@TENTK", taikhoan.TENTK);
                        cmd.Parameters.AddWithValue("@MATKHAU", taikhoan.MATKHAU);
                        cmd.Parameters.AddWithValue("@ID_PHANQUYEN", taikhoan.ID_PHANQUYEN);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Lỗi thêm tài khoản: " + ex.Message);
                        return false;
                    }
                }
            }

            public bool UpdateTaiKhoan(TaiKhoan taikhoan)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string updateQuery = "UPDATE TAIKHOAN SET TENTK = @TENTK, MATKHAU = @MATKHAU, ID_PHANQUYEN = @ID_PHANQUYEN, WHERE IDTK = @IDTK";
                        SqlCommand cmd = new SqlCommand(updateQuery, connection);
                        cmd.Parameters.AddWithValue("@IDTK", taikhoan.IDTK);
                        cmd.Parameters.AddWithValue("@TENTK", taikhoan.TENTK);
                        cmd.Parameters.AddWithValue("@MATKHAU", taikhoan.MATKHAU);
                        cmd.Parameters.AddWithValue("@ID_PHANQUYEN", taikhoan.ID_PHANQUYEN);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Lỗi cập nhật tài khoản: " + ex.Message);
                        return false;
                    }
                }
            }

            public bool DeleteTaiKhoan(int IDTK)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string deleteQuery = "DELETE FROM TAIKHOAN WHERE IDTK = @IDTK";
                        SqlCommand cmd = new SqlCommand(deleteQuery, connection);
                        cmd.Parameters.AddWithValue("@IDTK", IDTK);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Lỗi xóa tài khoản: " + ex.Message);
                        return false;
                    }
                }
            }

            public DataTable SearchTaiKhoan(string TenTaiKhoan)
            {
                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string searchQuery = "SELECT * FROM TAIKHOAN WHERE TENTK LIKE @TENTK";
                        SqlCommand cmd = new SqlCommand(searchQuery, connection);
                        cmd.Parameters.AddWithValue("@TENTK", "%" + TenTaiKhoan + "%");
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Lỗi tìm kiếm tài khoản: " + ex.Message);
                    }
                }
                return dt;
            }
        }
    }
}
