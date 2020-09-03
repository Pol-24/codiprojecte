using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace WindowsFormsApp1
{
    public class Class1
    {
        public static SqlConnection ObtnerC0nexion ()
        {
            SqlConnection conn = new SqlConnection("Data source=MI-PC\\MSSQLSERVER01; Initial Catalog=PàginaWebLlibres");
            conn.Open();

            return conn;



        }
        
        
            

    }
}

