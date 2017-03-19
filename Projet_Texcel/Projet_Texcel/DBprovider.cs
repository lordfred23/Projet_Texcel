using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Texcel
{
    class DBprovider
    {
        public DBprovider() {
        }

        public void connection()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "Server=[server_name];Database=[database_name];Trusted_Connection=true";
                // using the code here...
            };
        }

    }
}
