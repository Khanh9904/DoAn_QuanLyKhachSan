﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class PhanQuyen
    {
        public int ID_PHANQUYEN { get; set; }

        public string TENQUYEN { get; set; }

        public string MoTa { get; set; }

        public decimal MUCLUONGLAMVIEC { get; set; }
    }
}
