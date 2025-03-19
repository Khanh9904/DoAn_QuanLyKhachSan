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
    public class DAL_ChamCong
    {
        private string connectionString;

        public DAL_ChamCong(string Dbconnection)
        {
            this.connectionString = Dbconnection;
        }
        //-------------------------------------------------------------------------------------------------------------------------------

        public DataTable LoadDataChamcong()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))

            {
                connection.Open();

                string query = "select CHAMCONGLAMVIEC.ID_CHAMCONG, CHAMCONGLAMVIEC.ID_NHANVIEN, NHAN_VIEN.HOTEN, CHAMCONGLAMVIEC.NGAYLAMVIEC, CHAMCONGLAMVIEC.TRANGTHAI FROM CHAMCONGLAMVIEC JOIN NHAN_VIEN ON CHAMCONGLAMVIEC.ID_NHANVIEN= NHAN_VIEN.ID_NHANVIEN";

                SqlDataAdapter da = new SqlDataAdapter(query, connection);

                da.Fill(dt);
            }
            return dt;

        }
        //-------------------------------------------------------------------------------------------------------------------------------

        // kiểm tra 
        public bool kiemtrachamcong(int ID_NHANVIEN, DateTime NGAYLAMVIEC)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string kiemtraQuery = "SELECT COUNT(*) FROM CHAMCONGLAMVIEC WHERE ID_NHANVIEN = @ID_NHANVIEN AND CAST(NGAYLAMVIEC AS DATE) = @NGAYLAMVIEC";


                SqlCommand kiemtracmd = new SqlCommand(kiemtraQuery, connection);//thuc hien lenh truy van

                kiemtracmd.Parameters.AddWithValue("@ID_NHANVIEN", ID_NHANVIEN);

                kiemtracmd.Parameters.AddWithValue("@NGAYLAMVIEC", NGAYLAMVIEC.Date);

                return (int)kiemtracmd.ExecuteScalar() > 0;
            }
        }
        //-------------------------------------------------------------------------------------------------------------------------------

        // Cập nhật tổng công 
        public bool UpdateTongCong(int maNV, int increment, ChamCong chamCong)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string getOldStatusQuery = "SELECT TRANGTHAI FROM CHAMCONGLAMVIEC WHERE ID_CHAMCONG = @MaChamCong";
                string oldStatus = "";
                using (SqlCommand cmd = new SqlCommand(getOldStatusQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@MaChamCong", chamCong.ID_CHAMCONG);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                        oldStatus = result.ToString();
                }

                string updateQuery = "UPDATE CHAMCONGLAMVIEC SET TRANGTHAI = @TrangThai, NGAYLAMVIEC = @NgayCong WHERE ID_CHAMCONG = @MaChamCong";
                using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@MaChamCong", chamCong.ID_CHAMCONG);
                    cmd.Parameters.AddWithValue("@TrangThai", chamCong.TRANGTHAI);
                    cmd.Parameters.AddWithValue("@NgayCong", chamCong.NGAYLAMVIEC);
                    cmd.ExecuteNonQuery();
                }

                // Cập nhật lại tổng ngày công của nhân viên -----------------------------------------------------------------------------------

                if (oldStatus == "Có mặt" && chamCong.TRANGTHAI == "Vắng mặt")
                {
                    increment = -1;
                }
                else if (oldStatus == "Vắng mặt" && chamCong.TRANGTHAI == "Có mặt")
                {
                    increment = 1;
                }

                if (increment != 0)
                {
                    string updateTongCongQuery = "UPDATE NHAN_VIEN SET TONGNGAYCONG = TONGNGAYCONG + @Increment WHERE ID_NHANVIEN = @MaNV";
                    using (SqlCommand cmd = new SqlCommand(updateTongCongQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@Increment", increment);
                        cmd.Parameters.AddWithValue("@MaNV", chamCong.ID_NHANVIEN);
                        cmd.ExecuteNonQuery();
                    }
                }

                return true;
            }
        }
        public bool CheckChamCongExists(int maNV, DateTime ngayCong)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM CHAMCONGLAMVIEC WHERE ID_NHANVIEN = @ID_NHANVIEN AND NGAYLAMVIEC = @NGAYLAMVIEC";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ID_NHANVIEN", maNV);
                    cmd.Parameters.AddWithValue("@NGAYLAMVIEC", ngayCong);
                    return (int)cmd.ExecuteScalar() > 0;
                }
            }
        }


        public bool themchamcong(ChamCong chamcong)// trong model
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string themQuery = "insert into CHAMCONGLAMVIEC (ID_NHANVIEN, NGAYLAMVIEC, TRANGTHAI) values (@ID_NHANVIEN, @NGAYLAMVIEC, @TRANGTHAI)";

                SqlCommand themcmd = new SqlCommand(themQuery, connection);//thuc hien lenh truy van

                // goi lai lenh thuc hien

                themcmd.Parameters.AddWithValue("@ID_NHANVIEN", chamcong.ID_NHANVIEN);
                themcmd.Parameters.AddWithValue("@NGAYLAMVIEC", chamcong.NGAYLAMVIEC);
                themcmd.Parameters.AddWithValue("@TRANGTHAI", chamcong.TRANGTHAI);

                return themcmd.ExecuteNonQuery() > 0;
            }

        }
        //========================================================
        public bool suachamconglamviec(ChamCong chamcong)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string suaQuery = "update CHAMCONGLAMVIEC set ID_NHANVIEN = @ID_NHANVIEN, NGAYLAMVIEC = @NGAYLAMVIEC, TRANGTHAI = @TRANGTHAI where ID_CHAMCONG = @ID_CHAMCONG";
                SqlCommand suacmd = new SqlCommand(suaQuery, connection);//thuc hien lenh truy van
                suacmd.Parameters.AddWithValue("@ID_NHANVIEN", chamcong.ID_NHANVIEN);
                suacmd.Parameters.AddWithValue("@NGAYLAMVIEC", chamcong.NGAYLAMVIEC);
                suacmd.Parameters.AddWithValue("@TRANGTHAI", chamcong.TRANGTHAI);
                suacmd.Parameters.AddWithValue("@ID_CHAMCONG", chamcong.ID_CHAMCONG);

                return suacmd.ExecuteNonQuery() > 0;
            }
        }
        //========================================================
        public bool xoachamcong(int ID_CHAMCONG)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // chưa chọn nhân viên để xóa ngày công 
                string selectNV = "Select ID_NHANVIEN , TRANGTHAI from CHAMCONGLAMVIEC where ID_CHAMCONG = @MaCC";

                int maNhanVien = -1;

                string trangThaiCong = "";

                using (SqlCommand selectCmd = new SqlCommand(selectNV, connection))
                {
                    selectCmd.Parameters.AddWithValue("@MaCC", ID_CHAMCONG);
                    using (SqlDataReader reader = selectCmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            maNhanVien = Convert.ToInt32(reader["ID_NHANVIEN"]);
                            trangThaiCong = reader["TRANGTHAI"].ToString();
                        }
                    }

                }
                // cập nhật nếu xóa và trừ lại tổng công 
                if (maNhanVien != -1 && trangThaiCong == "Có mặt")
                {
                    string updateTongCong = "UPDATE NHAN_VIEN SET TONGNGAYCONG = CASE WHEN TONGNGAYCONG > 0 THEN TONGNGAYCONG - 1 ELSE 0 END WHERE ID_NHANVIEN = @MaNhanVien";

                    using (SqlCommand updateCmd = new SqlCommand(updateTongCong, connection))
                    {
                        updateCmd.Parameters.AddWithValue("@MaNhanVien", maNhanVien);
                        updateCmd.ExecuteNonQuery();
                    }
                }


                string xoaQuery = "delete from CHAMCONGLAMVIEC where ID_CHAMCONG = @ID_CHAMCONG";
                SqlCommand xoacmd = new SqlCommand(xoaQuery, connection);//thuc hien lenh truy van
                xoacmd.Parameters.AddWithValue("@ID_CHAMCONG", ID_CHAMCONG);// goi lai lenh thuc hien
                return xoacmd.ExecuteNonQuery() > 0;
            }
        }
        //============================================================
        public DataTable timkiemchamcong(string keyword)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string timkiemQuery = "select CHAMCONGLAMVIEC.ID_CHAMCONG, CHAMCONGLAMVIEC.ID_NHANVIEN, NHAN_VIEN.HOTEN, CHAMCONGLAMVIEC.NGAYLAMVIEC, CHAMCONGLAMVIEC.TRANGTHAI FROM CHAMCONGLAMVIEC JOIN NHAN_VIEN ON CHAMCONGLAMVIEC.ID_NHANVIEN= NHAN_VIEN.ID_NHANVIEN where HOTEN like @keyword";
                SqlCommand timkiemcmd = new SqlCommand(timkiemQuery, connection);
                timkiemcmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                SqlDataAdapter da = new SqlDataAdapter(timkiemcmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }

        }

    }
}
