using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    class DB
    {

        public string connstr = "data source=localhost; initial catalog=108;user id=sa;password=sa;max pool size=1000;";

        public SqlConnection conn;
        public SqlCommand com;
        public SqlDataReader read;


        public SqlConnection openconn()
        {
            conn = new SqlConnection(connstr);
            conn.Open();
            return conn;
        }
        public void closeconn()
        {
            conn.Close();
        }
        public SqlCommand sqlcom(SqlConnection conn)
        {
            com = new SqlCommand();
            com = conn.CreateCommand();
            return com;
            
        }
        public SqlDataReader sqlread(SqlCommand com)
        {
            read = com.ExecuteReader();
            return read;

        }

    }
}
