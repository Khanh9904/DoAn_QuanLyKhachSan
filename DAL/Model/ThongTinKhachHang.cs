﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class ThongTinKhachHang
    {
        public int MaKhachHang { get; set; }

        public string HoTen { get; set; }

        public DateTime NgaySinh { get; set; }

        public string GioiTinh  { get; set; }

        public int SDT {  get; set; }

        public string DiaChi { get; set; }

        public string CCCD { get; set ; }
    }
}
