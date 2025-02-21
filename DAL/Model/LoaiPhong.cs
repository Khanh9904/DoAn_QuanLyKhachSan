using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class LoaiPhong
    {
        public int MaLoaiPhong { get; set; }

        public string TenLoaiPhong { get; set; }

        public decimal Gia { get; set; }

        public int SoNguoiToiDa { get; set; }
    }
}

