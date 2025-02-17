using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class TaiKhoan
    {
        public int IDTK { get; set; }
        public string TENTK { get; set; }
        public string MATKHAU { get; set; }
        public int ID_PHANQUYEN { get; set; }
    }
}
