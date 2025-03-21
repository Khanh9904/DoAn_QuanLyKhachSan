﻿using System;
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
                try
                {
                    connection.Open();


                    string getQuery = @" SELECT NHAN_VIEN.ID_NHANVIEN, NHAN_VIEN.HOTEN, NHAN_VIEN.NGAYSINH, NHAN_VIEN.DIACHI, NHAN_VIEN.SDT, NHAN_VIEN.TONGNGAYCONG, NHAN_VIEN.TONGLUONG, NHAN_VIEN.ID_TAIKHOAN, TAIKHOAN.EMAIL  FROM NHAN_VIEN JOIN TAIKHOAN ON NHAN_VIEN.ID_TAIKHOAN = TAIKHOAN.ID_TAIKHOAN";

                    SqlDataAdapter adapterNhanVien = new SqlDataAdapter(getQuery, connection);

                    adapterNhanVien.Fill(dt);
                }

                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi khi tải danh sách tài khoản: " + ex.Message);
                }

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

                string AddQuery = "INSERT INTO NHAN_VIEN (HOTEN, NGAYSINH, DIACHI, SDT, TONGNGAYCONG,TONGLUONG, ID_TAIKHOAN ) VALUES (@HOTEN, @NGAYSINH, @DIACHI, @SDT, @TONGNGAYCONG,@TONGLUONG, @ID_TAIKHOAN )";

                SqlCommand AddCommand = new SqlCommand(AddQuery, connection);

                AddCommand.Parameters.AddWithValue("@HOTEN", nhanVien.HOTEN);

                AddCommand.Parameters.AddWithValue("@NGAYSINH", nhanVien.NGAYSINH);

                AddCommand.Parameters.AddWithValue("@DIACHI", nhanVien.DIACHI);

                AddCommand.Parameters.AddWithValue("@SDT", nhanVien.SDT);

                AddCommand.Parameters.AddWithValue("@TONGNGAYCONG", nhanVien.TONGNGAYCONG);

                AddCommand.Parameters.AddWithValue("@TONGLUONG", nhanVien.TONGLUONG);

                AddCommand.Parameters.AddWithValue("@ID_TAIKHOAN", nhanVien.ID_TAIKHOAN); // <---

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

                string UpdateQuery = "UPDATE NHAN_VIEN SET HOTEN = @HOTEN, NGAYSINH = @NGAYSINH, DIACHI = @DIACHI, SDT = @SDT, TONGNGAYCONG = @TONGNGAYCONG, TONGLUONG = @TONGLUONG, ID_TAIKHOAN = @ID_TAIKHOAN WHERE ID_NHANVIEN = @ID_NHANVIEN";

                SqlCommand UpdateCommand = new SqlCommand(UpdateQuery, connection);

                UpdateCommand.Parameters.AddWithValue("@HOTEN", nhanVien.HOTEN);

                UpdateCommand.Parameters.AddWithValue("@NGAYSINH", nhanVien.NGAYSINH);

                UpdateCommand.Parameters.AddWithValue("@DIACHI", nhanVien.DIACHI);

                UpdateCommand.Parameters.AddWithValue("@SDT", nhanVien.SDT);

                UpdateCommand.Parameters.AddWithValue("@TONGNGAYCONG", nhanVien.TONGNGAYCONG);

                UpdateCommand.Parameters.AddWithValue("@TONGLUONG", nhanVien.TONGLUONG);

                UpdateCommand.Parameters.AddWithValue("@ID_NHANVIEN", nhanVien.ID_NHANVIEN);

                UpdateCommand.Parameters.AddWithValue("@ID_TAIKHOAN", nhanVien.ID_TAIKHOAN);



                return UpdateCommand.ExecuteNonQuery() > 0;
            }

        }

        //-------------------------------------------------------------
        // ham xoa du lieu
        public bool DeleteNhanVien(int maNhanVien)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string DeleteQuery = "DELETE FROM NHAN_VIEN WHERE ID_NHANVIEN = @ID_NHANVIEN";

                SqlCommand DeleteCommand = new SqlCommand(DeleteQuery, connection);

                DeleteCommand.Parameters.AddWithValue("@ID_NHANVIEN", maNhanVien);

                return DeleteCommand.ExecuteNonQuery() > 0;
            }
        }

        //-------------------------------------------------------------
        //tìm kiếm nhân viên
        public DataTable SearchNhanVien(string TenNhanVien)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string TimKiemQuery = "SELECT * FROM NHAN_VIEN WHERE HOTEN LIKE @HOTEN";

                SqlDataAdapter TimKiemAdapter = new SqlDataAdapter(TimKiemQuery, connection);

                TimKiemAdapter.SelectCommand.Parameters.AddWithValue("@HOTEN", "%" + TenNhanVien + "%");

                SqlDataAdapter adapterPhanQuyen = new SqlDataAdapter(TimKiemQuery, connection);

                DataTable dt = new DataTable();

                TimKiemAdapter.Fill(dt);

                return dt;
            }
        }
    }
}
