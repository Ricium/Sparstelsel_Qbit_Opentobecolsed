using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;

namespace SparStelsel
{
    public class DataBaseConnection
    {
        public SqlConnection SqlConn()
        {
            //Defines which SQL-server to connect to, which database, and which user
            string strConn = "";

            foreach (ConnectionStringSettings item in ConfigurationManager.ConnectionStrings)
            {
                if (item.Name.Equals("SparConnect"))
                {
                    strConn = item.ConnectionString;
                }
            }

            SqlConnection con = new SqlConnection(strConn);
            return con;
        }

        public SqlConnection AuthConn()
        {
            //Defines which SQL-server to connect to, which database, and which user
            string strConn = "";

            foreach (ConnectionStringSettings item in ConfigurationManager.ConnectionStrings)
            {
                if (item.Name.Equals("SparConnect"))
                {
                    strConn = item.ConnectionString;
                }
            }

            SqlConnection con = new SqlConnection(strConn);
            return con;
        }
    }
}