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
    public class DAL_PhanCongCaLam
    {
        private string connectionString;

        public DAL_PhanCongCaLam(string Dbconnection)
        {
            this.connectionString = Dbconnection;
        }

        // Load dữ liệu
        public DataTable LoadPhanCongCaLam()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string getQuery = @"
                    SELECT PHANCONGCALAM.ID_PHANCONG, CALAMVIEC.ID_CALAM, NHAN_VIEN.ID_NHANVIEN, PHANCONGCALAM.NGAYLAM    from PHANCONGCALAM 
                    inner join 
                    CALAMVIEC on PHANCONGCALAM.ID_CALAM  =  CALAMVIEC.ID_CALAM 
                    inner join
                    NHAN_VIEN on PHANCONGCALAM.ID_NHANVIEN = NHAN_VIEN.ID_NHANVIEN
                  
                ";

                SqlDataAdapter adapterPhanQuyen = new SqlDataAdapter(getQuery, connection);

                adapterPhanQuyen.Fill(dt);

                return dt;
            }
        }

        //them phan cong ca lam
        public bool AddPhanCongCaLam(PhanCongCaLam pccl)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO PHANCONGCALAM (ID_CALAM, ID_NHANVIEN, NGAYLAM) VALUES (@ID_CALAM, @ID_NHANVIEN, @NGAYLAM)";
                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@ID_CALAM", pccl.ID_CALAM);

                cmd.Parameters.AddWithValue("@ID_NHANVIEN", pccl.ID_NHANVIEN);

                cmd.Parameters.AddWithValue("@NGAYLAM", pccl.NGAYLAM);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Sửa phân công ca làm
        public bool UpdatePhanCongCaLam(PhanCongCaLam pccl)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE PHANCONGCALAM SET ID_CALAM = @ID_CALAM, ID_NHANVIEN = @ID_NHANVIEN, NGAYLAM = @NGAYLAM WHERE ID_PHANCONG = @ID_PHANCONG";
                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@ID_CALAM", pccl.ID_CALAM);

                cmd.Parameters.AddWithValue("@ID_NHANVIEN", pccl.ID_NHANVIEN);

                cmd.Parameters.AddWithValue("@NGAYLAM", pccl.NGAYLAM);

                cmd.Parameters.AddWithValue("@ID_PHANCONG", pccl.ID_PHANCONG);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Xóa phân công ca làm
        public bool DeletePhanCongCaLam(int ID_PHANCONG)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM PHANCONGCALAM WHERE ID_PHANCONG = @ID_PHANCONG";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ID_PHANCONG", ID_PHANCONG);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Kiểm tra phân công ca làm đã tồn tại chưa
        public bool CheckPhanCongCaLam(int ID_CALAM, int ID_NHANVIEN, DateTime NGAYLAM)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"
                    SELECT COUNT(*) 
                    FROM PHANCONGCALAM 
                    WHERE ID_CALAM = @ID_CALAM 
                        AND ID_NHANVIEN = @ID_NHANVIEN 
                        AND CAST(NGAYLAM AS DATE) = @NGAYLAM";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.Add("@ID_CALAM", SqlDbType.Int).Value = ID_CALAM;
                    cmd.Parameters.Add("@ID_NHANVIEN", SqlDbType.Int).Value = ID_NHANVIEN;
                    cmd.Parameters.Add("@NGAYLAM", SqlDbType.Date).Value = NGAYLAM.Date;

                    return (int)cmd.ExecuteScalar() > 0;
                }
            }
        }


        // tim kiem phan cong ca lam theo ngay
        public DataTable SearchPhanCongCaLam(DateTime NGAYLAM)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM PHANCONGCALAM WHERE CAST(NGAYLAM AS DATE) = @NGAYLAM";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                da.SelectCommand.Parameters.AddWithValue("@NGAYLAM", NGAYLAM.Date);
                da.Fill(dt);
            }
            return dt;
        }

    }
}
