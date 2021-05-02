using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows;

namespace LAB10.Models
{
    public class DBCommandsModel
    {
        public DBCommandsModel()
        {

        }

        public DataTable Select()
        {
            try
            {
                DBConnection.getDBConnection().Open();
                string Query = "SELECT * FROM PC_VIEW";
                SqlCommand sqlCommand = new SqlCommand(Query, DBConnection.getDBConnection());
                sqlCommand.CommandType = System.Data.CommandType.Text;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);

                DataTable dt = new DataTable("PC_VIEW");
                dataAdapter.Fill(dt);

                DBConnection.getDBConnection().Close();

                return dt;


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

                return null;
            }
        }
    }
}
