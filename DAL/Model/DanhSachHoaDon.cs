using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class DanhSachHoaDon
    {
        public int MaHoaDon { get; set; }

        public  DateTime NgayLapHoaDon { get; set; }

        public decimal TongTienPhong { get; set; }

        public decimal TongTienDichVu { get; set; }

        public decimal TongTienThanhToan { get; set; }

        public string PhuongThucThanhToan { get; set; } 

        public string TrangThai { get; set; }

        public string MaLapPhieu { get; set; }
    }
}
