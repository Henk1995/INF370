using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using PETSystem;

namespace PETSystem
{
    class ConnectString
    {
        ////Jan se connection string
        public static string DBC = "Data Source=JWM\\SYSARCH;Initial Catalog=INF370;Integrated Security=True";

        ////John se connection string
        //public static string DBC = "Data Source=JOHN-MAC-WIN;Initial Catalog=INF370;Integrated Security=True";


        public static SqlConnection connectstring = new SqlConnection(DBC);
    }
}
