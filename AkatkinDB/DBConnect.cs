using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkatkinDB
{
    class DBConnect
    {

        public static string conSt = "Data Source=tsoop.c6oo9thiejqr.us-east-1.rds.amazonaws.com;Initial" +
                     " Catalog=TSOOPEX;User ID=admin;Password=Geirby1799";
        public SqlConnection conection = new SqlConnection(conSt);

        public DBConnect()
        {
            
        }

       

    }
}
