using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class ChamCong
    {
        public int ID_CHAMCONG { get; set; }

        public int ID_NHANVIEN { get; set; }

        public DateTime NGAYLAMVIEC { get; set; }

        public string TRANGTHAI { get; set; }
    }
}
