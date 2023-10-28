 using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ürün_Kontrol_Sistemi
{
    class MyConnection
    {
        string ConnectionString = @"Server=DESKTOP-C8HD7CS\SQLEXPRESS; Database=Film; Trusted_Connection=True";

        public SqlConnection Connection()
        {
            SqlConnection cnn = new SqlConnection(ConnectionString);

            if (cnn.State != System.Data.ConnectionState.Open)
            {
                try
                {
                    cnn.Open();
                }
                catch 
                {

                    
                }
            }

            return cnn;

        }
    }
}
