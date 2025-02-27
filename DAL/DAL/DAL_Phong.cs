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
    public class DAL_Phong
    {
        private string connectionString;

        public DAL_Phong(string Dbconnection)
        {
            connectionString = Dbconnection;
        }
        //----------------------------------------------------------------------------------------------------------------------------------------------



        // Tải dữ liệu bảng phòng
        public DataTable LoadPhong()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string getQuery = @"
                    SELECT PHONG.MaPhong, PHONG.TenPhong, PHONG.TinhTrang, LOAI_PHONG.MaLoaiPhong, DICH_VU.MaDichVu, THIET_BI.MaThietBi  from PHONG 
                    inner join 
                    LOAI_PHONG on PHONG.MaLoaiPhong  =  LOAI_PHONG.MaLoaiPhong 
                    inner join
                    DICH_VU on PHONG.MaDichVu = DICH_VU.MaDichVu
                    inner join
                    THIET_BI on PHONG.MaThietBi = THIET_BI.MaThietBi
                ";

                SqlDataAdapter adapterPhanQuyen = new SqlDataAdapter(getQuery, connection);

                adapterPhanQuyen.Fill(dt);

                return dt;
            }

        }
        //----------------------------------------------------------------------------------------------------------------------------------------------

        // kiểm tra tên phòng có tồn tại không
        public bool CheckPhong(string TenPhong)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string CheckQuery = "SELECT COUNT(*) FROM PHONG WHERE TenPhong = @TenPhong";

                SqlCommand CheckComand = new SqlCommand(CheckQuery, connection);

                CheckComand.Parameters.AddWithValue("@TenPhong", TenPhong);

                return (int)CheckComand.ExecuteScalar() > 0;
            }
        }

        //----------------------------------------------------------------------------------------------------------------------------------------------
        // thêm phòng mới
        public bool AddPhong(Phong phong)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string AddQuery = "INSERT INTO PHONG (TenPhong, TinhTrang, MaLoaiPhong, MaThietBi, MaDichVu ) VALUES (@TenPhong, @TinhTrang, @MaLoaiPhong, @MaThietBi, @MaDichVu )";

                SqlCommand AddCommand = new SqlCommand(AddQuery, connection);

                AddCommand.Parameters.AddWithValue("@TenPhong", phong.TenPhong);

                AddCommand.Parameters.AddWithValue("@TinhTrang", phong.TinhTrang);

                AddCommand.Parameters.AddWithValue("@MaLoaiPhong", phong.MaLoaiPhong);

                AddCommand.Parameters.AddWithValue("@MaThietBi", phong.MaThietBi);

                AddCommand.Parameters.AddWithValue("@MaDichVu", phong.MaDichVu);

               
                return AddCommand.ExecuteNonQuery() > 0;

            }
        }

        //----------------------------------------------------------------------------------------------------------------------------------------------

        // sửa thông tin phòng
        public bool UpdatePhong(Phong phong)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string UpdateQuery = "UPDATE PHONG SET TenPhong = @TenPhong, TinhTrang = @TinhTrang, MaLoaiPhong = @MaLoaiPhong, MaThietBi = @MaThietBi, MaDichVu = @MaDichVu WHERE MaPhong = @MaPhong";
                SqlCommand UpdateCommand = new SqlCommand(UpdateQuery, connection);

                UpdateCommand.Parameters.AddWithValue("@MaPhong", phong.MaPhong);

                UpdateCommand.Parameters.AddWithValue("@TenPhong", phong.TenPhong);

                UpdateCommand.Parameters.AddWithValue("@TinhTrang", phong.TinhTrang);

                UpdateCommand.Parameters.AddWithValue("@MaLoaiPhong", phong.MaLoaiPhong);

                UpdateCommand.Parameters.AddWithValue("@MaThietBi", phong.MaThietBi);

                UpdateCommand.Parameters.AddWithValue("@MaDichVu", phong.MaDichVu);

                return UpdateCommand.ExecuteNonQuery() > 0;
            }
        }

        //----------------------------------------------------------------------------------------------------------------------------------------------


        // xóa phòng
        public bool DeletePhong(int MaPhong)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string DeleteQuery = "DELETE FROM PHONG WHERE MaPhong = @MaPhong";

                SqlCommand DeleteCommand = new SqlCommand(DeleteQuery, connection);

                DeleteCommand.Parameters.AddWithValue("@MaPhong", MaPhong);

                return DeleteCommand.ExecuteNonQuery() > 0;
            }
        }

        //----------------------------------------------------------------------------------------------------------------------------------------------

        // tìm kiếm phòng
        public DataTable SearchPhong(string TenPhong)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string TimKiemQuery = "SELECT * FROM PHONG WHERE TenPhong LIKE @TenPhong";

                SqlDataAdapter TimKiemAdapter = new SqlDataAdapter(TimKiemQuery, connection);

                TimKiemAdapter.SelectCommand.Parameters.AddWithValue("@TenPhong", "%" + TenPhong + "%");

                DataTable dt = new DataTable();

                TimKiemAdapter.Fill(dt);

                return dt;
            }
        }

    }
}
