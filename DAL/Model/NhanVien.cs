using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class NhanVien
    {
        public int ID_NHANVIEN { get; set; }
        public string TENNHANVIEN { get; set; }
        public string GIOITINH { get; set; }
        public DateTime NGAYSINH { get; set; }
        public string DIACHI { get; set; }
        public string SDT { get; set; }
        public string EMAIL { get; set; }
        public string TENDANGNHAP { get; set; }
        public string MATKHAU { get; set; }
        public int ID_PHANQUYEN { get; set; }
        public string HINHANH { get; set; }
        public bool TRANGTHAI { get; set; }

    }
}
