using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class PhanCongCaLam
    {
        public int ID_PHANCONG { get; set; }

        public int ID_NHANVIEN { get; set; }

        public int ID_CALAM { get; set; }

        public DateTime NGAYLAM { get; set; }
        
    }
}
