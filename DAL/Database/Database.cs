using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Database
{
    public class Database
    {
        // chuoi ket noi

        string connectionString = "Data Source=HAN;Initial Catalog=HeThongKhachSan;Integrated Security=True;TrustServerCertificate=True";

        // tao chuoi ket noi

        public string GetDataSet()
        {
            return connectionString;
        }
    }
}
