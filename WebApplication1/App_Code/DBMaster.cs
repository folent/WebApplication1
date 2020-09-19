using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication1.App_Code
{
    public class DBMaster
    {
        private SqlConnection connect;
        public SqlConnection getConnection()
        {
            string connStr = "Server=localhost;Database=cars;Integrated Security=SSPI;";
            connect = new SqlConnection(connStr);
            connect.Open();
            return connect;
        }

        public SqlDataReader getReader(string query)
        {
            SqlCommand cmd = new SqlCommand(query);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = this.getConnection();

            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public void closeConnection()
        {
            if(connect != null && connect.State == System.Data.ConnectionState.Open)
            {
                this.connect.Close();
            }
        }
    }
}