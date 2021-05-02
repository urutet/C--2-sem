using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;

namespace LAB10
{
    public static class DBConnection
    {

        static SqlConnection dbConnection = null;

        public static SqlConnection getDBConnection()
        {
            if (dbConnection == null)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
                dbConnection = new SqlConnection(connectionString);
            }

            return dbConnection;
        }
    }
}
