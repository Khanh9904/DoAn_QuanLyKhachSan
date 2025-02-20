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
    public class DAL_QuanLyPhanQuyen
    {
        private string connectionString;

        public DAL_QuanLyPhanQuyen(string Dbconnection)
        {
            connectionString = Dbconnection;
        }


        //--------------------------------------------------------------------------------
        // 1 Tải dữ liệu từ bảng PHANQUYEN
        public DataTable LoadPhanQuyen()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string getQuery = "SELECT * FROM PHANQUYEN";

                SqlDataAdapter adapterPhanQuyen = new SqlDataAdapter(getQuery, connection);

                adapterPhanQuyen.Fill(dt);

                return dt;
            }

        }

        //--------------------------------------------------------------------------------
        // 2 Kiem tra ten quyen co ton tai khong
        public bool CheckPhanQuyen(string TenPhanQuyen)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string CheckQuery = "SELECT COUNT(*) FROM PHANQUYEN WHERE TENQUYEN = @TENQUYEN";

                SqlCommand CheckComand = new SqlCommand(CheckQuery, connection);

                CheckComand.Parameters.AddWithValue("@TENQUYEN", TenPhanQuyen); 


                return (int)CheckComand.ExecuteScalar() > 0;

            }
        }
        //--------------------------------------------------------------------------------
        // 3 Thêm quyền mới
        public bool AddPhanQuyen(PhanQuyen phanquyen) // goi PhanQuyen trong Model

        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string AddQuery = "INSERT INTO PHANQUYEN (TENQUYEN, MOTA, MUCLUONGLAMVIEC) values (@TENQUYEN, @MOTA, @MUCLUONGLAMVIEC)";

                SqlCommand Addconmand = new SqlCommand(AddQuery, connection);


                Addconmand.Parameters.AddWithValue("@TENQUYEN", phanquyen.TENQUYEN);

                Addconmand.Parameters.AddWithValue("@MOTA", phanquyen.MoTa);

                Addconmand.Parameters.AddWithValue("@MUCLUONGLAMVIEC", phanquyen.MUCLUONGLAMVIEC);

                return Addconmand.ExecuteNonQuery() > 0;
            }

        }

        //--------------------------------------------------------------------------------
        // 4 cap nhat quyen

        public bool UpdatePhanQuyen(PhanQuyen phanquyen)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string UpdateQuery = "UPDATE PHANQUYEN SET TENQUYEN = @TENQUYEN, MOTA = @MOTA, MUCLUONGLAMVIEC = @MUCLUONGLAMVIEC WHERE ID_PHANQUYEN = @ID_PHANQUYEN";

                SqlCommand UpdateCommand = new SqlCommand(UpdateQuery, connection);

                UpdateCommand.Parameters.AddWithValue("@ID_PHANQUYEN", phanquyen.ID_PHANQUYEN);

                UpdateCommand.Parameters.AddWithValue("@TENQUYEN", phanquyen.TENQUYEN);

                UpdateCommand.Parameters.AddWithValue("@MOTA", phanquyen.MoTa);

                UpdateCommand.Parameters.AddWithValue("@MUCLUONGLAMVIEC", phanquyen.MUCLUONGLAMVIEC);

                return UpdateCommand.ExecuteNonQuery() > 0;
            }
        }

        //--------------------------------------------------------------------------------
        // 5 Xoa quyen

        public bool DeletePhanQuyen(int ID_PHANQUYEN)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string DeleteQuery = "DELETE FROM PHANQUYEN WHERE ID_PHANQUYEN = @ID_PHANQUYEN";

                SqlCommand DeleteCommand = new SqlCommand(DeleteQuery, connection);

                DeleteCommand.Parameters.AddWithValue("@ID_PHANQUYEN", ID_PHANQUYEN);

                return DeleteCommand.ExecuteNonQuery() > 0;
            }
        }

        //--------------------------------------------------------------------------------
        // 6 Tim kiem quyen

        public DataTable TimKiemPhanQuyen(string keyword)
        {
           
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string TimKiemQuery = "SELECT * FROM PHANQUYEN WHERE TENQUYEN LIKE @TENQUYEN";

                SqlDataAdapter TimKiemAdapter = new SqlDataAdapter(TimKiemQuery, connection);

                TimKiemAdapter.SelectCommand.Parameters.AddWithValue("@TENQUYEN", "%" + keyword + "%");

                SqlDataAdapter adapterPhanQuyen = new SqlDataAdapter(TimKiemQuery, connection);
                        
                DataTable dt = new DataTable();

                TimKiemAdapter.Fill(dt);

                return dt;
            }
        }
    }
}
