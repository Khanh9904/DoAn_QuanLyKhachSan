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
    public class DAL_ThongTinNhanVien
    {
        private string connectionString;

        public DAL_ThongTinNhanVien(string Dbconnection)
        {
            this.connectionString = Dbconnection;
        }
        //-------------------------------------------------------------
        // ham load du lieu
        public DataTable LoadNhanVien()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string getQuery = "SELECT * FROM NHAN_VIEN";

                SqlDataAdapter adapterNhanVien = new SqlDataAdapter(getQuery, connection);

                adapterNhanVien.Fill(dt);

                return dt;
            }

        }

        //-------------------------------------------------------------
        // ham kiem tra ten nhan vien co ton tai khong
        public bool CheckNhanVien(string TenNhanVien)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string CheckQuery = "SELECT COUNT(*) FROM NHAN_VIEN WHERE HOTEN = @HOTEN";

                SqlCommand CheckComand = new SqlCommand(CheckQuery, connection);

                CheckComand.Parameters.AddWithValue("@HOTEN", TenNhanVien);

                return (int)CheckComand.ExecuteScalar() > 0;

            }
        }

        //-------------------------------------------------------------
        // ham them du lieu
        public bool AddNhanVien(NhanVien nhanVien)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string AddQuery = "INSERT INTO NHAN_VIEN(HOTEN, NGAYSINH, DIACHI, SDT, EMAIL) VALUES(@HOTEN, @NGAYSINH, @DIACHI, @SDT, @EMAIL)";
                SqlCommand AddCommand = new SqlCommand(AddQuery, connection);
                AddCommand.Parameters.AddWithValue("@HOTEN", nhanVien.TENNHANVIEN);
                AddCommand.Parameters.AddWithValue("@NGAYSINH", nhanVien.NGAYSINH);
                AddCommand.Parameters.AddWithValue("@DIACHI", nhanVien.DIACHI);
                AddCommand.Parameters.AddWithValue("@SDT", nhanVien.SDT);
                AddCommand.Parameters.AddWithValue("@EMAIL", nhanVien.EMAIL);
                
                return AddCommand.ExecuteNonQuery() > 0;
            }
        }

        //-------------------------------------------------------------
        // ham sua du lieu
        public bool UpdateNhanVien(NhanVien nhanVien)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string UpdateQuery = "UPDATE NHAN_VIEN SET HOTEN = @HOTEN, NGAYSINH = @NGAYSINH, DIACHI = @DIACHI, SDT = @SDT, EMAIL = @EMAIL WHERE ID_NHANVIEN = @ID_NHANVIEN";
                SqlCommand UpdateCommand = new SqlCommand(UpdateQuery, connection);
                UpdateCommand.Parameters.AddWithValue("@HOTEN", nhanVien.TENNHANVIEN);
                UpdateCommand.Parameters.AddWithValue("@NGAYSINH", nhanVien.NGAYSINH);
                UpdateCommand.Parameters.AddWithValue("@DIACHI", nhanVien.DIACHI);
                UpdateCommand.Parameters.AddWithValue("@SDT", nhanVien.SDT);
                UpdateCommand.Parameters.AddWithValue("@EMAIL", nhanVien.EMAIL);
                return UpdateCommand.ExecuteNonQuery() > 0;
            }
            
        }

        //-------------------------------------------------------------
        // ham xoa du lieu
        public bool DeleteNhanVien(int ID_NHANVIEN)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string DeleteQuery = "DELETE FROM NHAN_VIEN WHERE ID_NHANVIEN = @ID_NHANVIEN";
                SqlCommand DeleteCommand = new SqlCommand(DeleteQuery, connection);
                DeleteCommand.Parameters.AddWithValue("@ID_NHANVIEN", ID_NHANVIEN);
                return DeleteCommand.ExecuteNonQuery() > 0;
            }
        }

        //-------------------------------------------------------------
        //tìm kiếm nhân viên
        public DataTable SearchNhanVien(string TenNhanVien)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string SearchQuery = "SELECT * FROM NHAN_VIEN WHERE HOTEN LIKE @HOTEN";
                SqlCommand SearchCommand = new SqlCommand(SearchQuery, connection);
                SearchCommand.Parameters.AddWithValue("@HOTEN", "%" + TenNhanVien + "%");
                SqlDataAdapter adapterPhanQuyen = new SqlDataAdapter(SearchQuery, connection);
                adapterPhanQuyen.Fill(dt);
                return dt;
            }
        }
    }
}
