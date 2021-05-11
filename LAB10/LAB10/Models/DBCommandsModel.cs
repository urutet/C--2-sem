using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LAB10.Models
{
    public class DBCommandsModel
    {
        public DBCommandsModel()
        {

        }

        public DataSet Select()
        {
            try
            {
                DBConnection.getDBConnection().Open();
                string Query = "SELECT * FROM dbo.PC_VIEW";
                SqlCommand sqlCommand = new SqlCommand(Query, DBConnection.getDBConnection());
                sqlCommand.CommandType = CommandType.Text;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);

                MessageBox.Show("БД: " + DBConnection.getDBConnection().Database + " \nСтатус подключения: " + 
                    DBConnection.getDBConnection().State);

                DataSet ds = new DataSet("PC_VIEW");
                dataAdapter.Fill(ds);

                DBConnection.getDBConnection().Close();

                return ds;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                DBConnection.getDBConnection().Close();
                return null;
            }
        }

        public void Insert(string RAM_NAME, int CLOCK_HZ, int RAM_SIZE, string PROCESSOR_NAME, int PROCESSOR_CORES, int PCLOCK_HZ, int L3_CACHE,
            string GPU_NAME, int GRAM_SIZE)
        {
            try
            {
                DBConnection.getDBConnection().Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.InsertCommand = new SqlCommand("InsertRAM", DBConnection.getDBConnection());
                dataAdapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.InsertCommand.Parameters.Add(new SqlParameter("@RAM_NAME", RAM_NAME));
                dataAdapter.InsertCommand.Parameters.Add(new SqlParameter("@CLOCK_HZ", CLOCK_HZ));
                dataAdapter.InsertCommand.Parameters.Add(new SqlParameter("@RAM_SIZE", RAM_SIZE));

                dataAdapter.InsertCommand.ExecuteNonQuery();

                dataAdapter.InsertCommand = new SqlCommand("InsertCPU", DBConnection.getDBConnection());
                dataAdapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.InsertCommand.Parameters.Add(new SqlParameter("@PROCESSOR_NAME", PROCESSOR_NAME));
                dataAdapter.InsertCommand.Parameters.Add(new SqlParameter("@CORES", PROCESSOR_CORES));
                dataAdapter.InsertCommand.Parameters.Add(new SqlParameter("@CLOCK_HZ", PCLOCK_HZ));
                dataAdapter.InsertCommand.Parameters.Add(new SqlParameter("@L3_CACHE", L3_CACHE));

                dataAdapter.InsertCommand.ExecuteNonQuery();

                dataAdapter.InsertCommand = new SqlCommand("InsertGPU", DBConnection.getDBConnection());
                dataAdapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.InsertCommand.Parameters.Add(new SqlParameter("@GPU_NAME", GPU_NAME));
                dataAdapter.InsertCommand.Parameters.Add(new SqlParameter("@GRAM_SIZE", GRAM_SIZE));

                dataAdapter.InsertCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
