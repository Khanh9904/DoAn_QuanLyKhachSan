using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL
{
    public class DAL_DanhSachHoaDon
    {
        private string connectionSring;

        public DAL_DanhSachHoaDon(string Dbconnection)
        {
            connectionSring = Dbconnection;
        }

        public bool DeleteHoaDon(int MaHoaDon)
        {
            using (SqlConnection connection = new SqlConnection(connectionSring))
            {
                connection.Open();
                string query = "DELETE FROM HOA_DON WHERE MaHoaDon = @MaHoaDon";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@MaHoaDon", MaHoaDon);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public DataTable SearchHoaDon(string TenNhanVien)
        {
            using (SqlConnection connection = new SqlConnection(connectionSring))
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


        public DataTable LoadDataHoaDon()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSring))
            {
                connection.Open();
                string query = @"
                 SELECT 
                     hd.MaHoaDon,
                     hd.NgayLapHoaDon,
                     p.TenPhong,
                     pdp.NgayNhanPhong,
                     pdp.NgayTraPhong,
                     pdp.SoNguoiO,
                     pdp.TienCoc,
                     dv.TenDichVu,
                     dv.GiaDichVu,
                     hd.TongTienPhong,
                     hd.TongTienDichVu,
                     hd.TongTienThanhToan,
                     hd.PhuongThucThanhToan,
                     hd.TrangThai,
                     nv.HoTen AS TenNhanVien,
                     kh.HoTen AS TenKhachHang,  
                     kh.GioiTinh,
                     kh.SDT,             
                     kh.DiaChi                 
                 FROM HOA_DON hd
                 INNER JOIN PHIEU_DAT_PHONG pdp ON hd.MaLapPhieu = pdp.MaLapPhieu
                 INNER JOIN PHONG p ON pdp.MaPhong = p.MaPhong
                 LEFT JOIN DICH_VU dv ON pdp.MaDichVu = dv.MaDichVu
                 LEFT JOIN NHAN_VIEN nv ON pdp.ID_NHANVIEN = nv.ID_NHANVIEN
                 LEFT JOIN KHACH_HANG kh ON hd.MaKhachHang = kh.MaKhachHang";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dt);
            }
            return dt;
        }
    }
}
