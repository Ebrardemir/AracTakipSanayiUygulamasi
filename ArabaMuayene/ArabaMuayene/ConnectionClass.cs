using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabaMuayene
{
    internal class ConnectionClass
    {
        public static SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS04; Initial Catalog=araba;Integrated Security=True");
        public static void CheckConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
            else { }
        }
    }
}
