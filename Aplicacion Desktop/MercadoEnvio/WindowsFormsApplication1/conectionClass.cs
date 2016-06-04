using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Data.SqlClient;
using System.Configuration;

namespace WindowsFormsApplication1
{
    public sealed class conectionDB
    {
         private static readonly conectionDB instance= new conectionDB();

        private conectionDB() { }

        public static conectionDB getInstance()
        {
            return instance;
        }

        public static SqlConnection getConnection()
        {
            string stringConfig = ConfigurationManager.AppSettings["stringConfig"].ToString();
        
            SqlConnection conection = new SqlConnection(stringConfig);

            return conection;
        }

    }
}
