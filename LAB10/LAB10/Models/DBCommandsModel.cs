using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;



namespace LAB10.Models
{
    public class DBCommandsModel
    {
        [DllImport("Kernel32")]
        public static extern void AllocConsole();

        [DllImport("Kernel32")]
        public static extern void FreeConsole();

        public DBCommandsModel()
        {

        }

        public DataTable Select()
        {
            try
            {
                DBConnection.getDBConnection().Open();
                string Query = "SELECT * FROM dbo.PC_VIEW";
                SqlCommand sqlCommand = new SqlCommand(Query, DBConnection.getDBConnection());
                sqlCommand.CommandType = CommandType.Text;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);

                AllocConsole();

                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);

                foreach (DataColumn column in dt.Columns)
                    Console.Write("\t{0}", column.ColumnName);
                Console.WriteLine();
                // перебор всех строк таблицы
                foreach (DataRow row in dt.Rows)
                {
                    // получаем все ячейки строки
                    var cells = row.ItemArray;
                    foreach (object cell in cells)
                        Console.Write("\t{0}", cell);
                    Console.WriteLine();
                }


                DBConnection.getDBConnection().Close();

                return dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                DBConnection.getDBConnection().Close();
                return null;
            }
        }

        public void Insert(string RAM_NAME, int CLOCK_HZ, int RAM_SIZE, string PROCESSOR_NAME, int PROCESSOR_CORES, int PCLOCK_HZ, int L3_CACHE,
            string GPU_NAME, int GRAM_SIZE, string PC_NAME)
        {
            try
            {
                DBConnection.getDBConnection().Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.InsertCommand = new SqlCommand("InsertRAM", DBConnection.getDBConnection());
                dataAdapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                Random rnd = new Random();
                int RAM_ID = rnd.Next(0, 1000);
                dataAdapter.InsertCommand.Parameters.Add(new SqlParameter("@ID", RAM_ID));
                dataAdapter.InsertCommand.Parameters.Add(new SqlParameter("@RAM_NAME", RAM_NAME));
                dataAdapter.InsertCommand.Parameters.Add(new SqlParameter("@CLOCK_HZ", CLOCK_HZ));
                dataAdapter.InsertCommand.Parameters.Add(new SqlParameter("@RAM_SIZE", RAM_SIZE));

                dataAdapter.InsertCommand.ExecuteNonQuery();

                dataAdapter.InsertCommand = new SqlCommand("InsertCPU", DBConnection.getDBConnection());
                dataAdapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                int PROCESSOR_ID = rnd.Next(1001, 2000);

                dataAdapter.InsertCommand.Parameters.Add(new SqlParameter("@PROCESSOR_ID", PROCESSOR_ID));
                dataAdapter.InsertCommand.Parameters.Add(new SqlParameter("@PROCESSOR_NAME", PROCESSOR_NAME));
                dataAdapter.InsertCommand.Parameters.Add(new SqlParameter("@CORES", PROCESSOR_CORES));
                dataAdapter.InsertCommand.Parameters.Add(new SqlParameter("@CLOCK_HZ", PCLOCK_HZ));
                dataAdapter.InsertCommand.Parameters.Add(new SqlParameter("@L3_CACHE", L3_CACHE));

                dataAdapter.InsertCommand.ExecuteNonQuery();

                dataAdapter.InsertCommand = new SqlCommand("InsertGPU", DBConnection.getDBConnection());
                dataAdapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                int GPU_ID = rnd.Next(2001, 3000);

                dataAdapter.InsertCommand.Parameters.Add(new SqlParameter("@ID", GPU_ID));
                dataAdapter.InsertCommand.Parameters.Add(new SqlParameter("@GPU_NAME", GPU_NAME));
                dataAdapter.InsertCommand.Parameters.Add(new SqlParameter("@GRAM_SIZE", GRAM_SIZE));

                dataAdapter.InsertCommand.ExecuteNonQuery();

                dataAdapter.InsertCommand = new SqlCommand("InsertComputer", DBConnection.getDBConnection());
                dataAdapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                int PC_ID = rnd.Next(3001, 4000);
                dataAdapter.InsertCommand.Parameters.Add(new SqlParameter("@ID", PC_ID));
                dataAdapter.InsertCommand.Parameters.Add(new SqlParameter("@PC_NAME", PC_NAME));
                dataAdapter.InsertCommand.Parameters.Add(new SqlParameter("@PROCESSOR_ID", PROCESSOR_ID));
                dataAdapter.InsertCommand.Parameters.Add(new SqlParameter("@RAM_ID", RAM_ID));
                dataAdapter.InsertCommand.Parameters.Add(new SqlParameter("@GPU_ID", GPU_ID));

                dataAdapter.InsertCommand.ExecuteNonQuery();

                DBConnection.getDBConnection().Close();
                MessageBox.Show("Объект успешно добавлен");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
