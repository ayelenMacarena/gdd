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
        //string server = ConfigurationManager.AppSettings["server"].ToString();
        //string user = ConfigurationManager.AppSettings["user"].ToString();
        //string password = ConfigurationManager.AppSettings["password"].ToString();
        //string database= ConfigurationManager.AppSettings["database"].ToString();

        private static readonly conectionDB instance = new conectionDB();

        private conectionDB() { }

        public static conectionDB getInstance()
        {
            return instance;
        }

        public static SqlConnection getConnection()
        {
            string stringConection = "server=RR-HOME\\SQLSERVER2012 ; database=GD1C2016; integrated security = false; user ID=gd ; password=gd2016";

            SqlConnection conection = new SqlConnection(stringConection);

            return conection;
        }

    }
}

