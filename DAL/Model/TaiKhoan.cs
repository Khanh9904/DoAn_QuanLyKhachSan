using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class TaiKhoan
    {
        public int ID_TAIKHOAN { get; set; }
        public string EMAIL { get; set; }
        public string MATKHAU { get; set; }
        public int ID_PHANQUYEN { get; set; }
    }
}
