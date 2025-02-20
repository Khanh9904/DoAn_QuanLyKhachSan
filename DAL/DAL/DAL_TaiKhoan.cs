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
            //-----------------------------------------------------------------------------------
            // Load dữ liệu từ bảng TAIKHOAN
            public DataTable LoadTaiKhoan()
            {
                DataTable dt = new DataTable();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        string getQuery = @"SELECT TAIKHOAN.ID_TAIKHOAN, TAIKHOAN.EMAIL, TAIKHOAN.MATKHAU, TAIKHOAN.ID_PHANQUYEN, PHANQUYEN.TENQUYEN FROM TAIKHOAN JOIN PHANQUYEN ON TAIKHOAN.ID_PHANQUYEN = PHANQUYEN.ID_PHANQUYEN";

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
            //-----------------------------------------------------------------------------------
            // 
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
            //-----------------------------------------------------------------------------------
            // Kiểm tra tài khoản đã tồn tại chưa
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
            //-----------------------------------------------------------------------------------
            // Thêm tài khoản
            public bool AddTaiKhoan(TaiKhoan taikhoan)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        string addQuery = "INSERT INTO TAIKHOAN (EMAIL, MATKHAU, ID_PHANQUYEN) VALUES (@EMAIL, @MATKHAU, @ID_PHANQUYEN)";

                        SqlCommand cmd = new SqlCommand(addQuery, connection);

                        cmd.Parameters.AddWithValue("@EMAIL", taikhoan.EMAIL);

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
            //-----------------------------------------------------------------------------------
            // Cập nhật thông tin tài khoản
            public bool UpdateTaiKhoan(TaiKhoan taikhoan)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string updateQuery = "UPDATE TAIKHOAN SET EMAIL = @EMAIL, MATKHAU = @MATKHAU, ID_PHANQUYEN = @ID_PHANQUYEN, WHERE ID_TAIKHOAN = @ID_TAIKHOAN";

                        SqlCommand cmd = new SqlCommand(updateQuery, connection);

                        cmd.Parameters.AddWithValue("@ID_TAIKHOAN", taikhoan.ID_TAIKHOAN);

                        cmd.Parameters.AddWithValue("@TENTK", taikhoan.EMAIL);

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
            //-----------------------------------------------------------------------------------
            // Xóa tài khoản
            public bool DeleteTaiKhoan(int ID_TAIKHOAN)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        string deleteQuery = "DELETE FROM TAIKHOAN WHERE ID_TAIKHOAN = @ID_TAIKHOAN";

                        SqlCommand cmd = new SqlCommand(deleteQuery, connection);

                        cmd.Parameters.AddWithValue("@ID_TAIKHOAN", ID_TAIKHOAN);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Lỗi xóa tài khoản: " + ex.Message);
                        return false;
                    }
                }
            }
            //-----------------------------------------------------------------------------------
            // Tìm kiếm tài khoản theo tên tài khoản
            public DataTable SearchTaiKhoan(string EMAIL)
            {
             
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string TimKiemQuery = "SELECT * FROM TAIKHOAN WHERE EMAIL LIKE @EMAIL";

                        SqlDataAdapter TimKiemAdapter = new SqlDataAdapter(TimKiemQuery, connection);

                        TimKiemAdapter.SelectCommand.Parameters.AddWithValue("@EMAIL", "%" + EMAIL + "%");

                        SqlDataAdapter adapterPhanQuyen = new SqlDataAdapter(TimKiemQuery, connection);

                        DataTable dt = new DataTable();

                        TimKiemAdapter.Fill(dt);

                        return dt;
                    }
               
               
            }
        }
    }
}
