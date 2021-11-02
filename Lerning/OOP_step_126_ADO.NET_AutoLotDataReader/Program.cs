using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace OOP_step_126_ADO.NET_AutoLotDataReader
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("=== Fun with Data Reader ===\n");

            //using connectionStringBuilder
            //var cnStringBuilder = new SqlConnectionStringBuilder()
            //{
            //    InitialCatalog = "AutoLot",
            //    DataSource = @"(localdb)\mssqllocaldb",
            //    IntegratedSecurity = true,
            //    ConnectTimeout = 30
            //};
            string connectioString = @"Data Source=(localdb)\mssqllocaldb;Integrated Security =true;Initial Catalog=AutoLot;Connect TimeOut=30";
            SqlConnectionStringBuilder cnStringBuilder = new SqlConnectionStringBuilder(connectioString);
            cnStringBuilder.ConnectTimeout = 5;

            //Create and open connection
            using (SqlConnection connection = new SqlConnection())
            {
                //connection.ConnectionString = @"Data Source=(localdb)\mssqllocaldb;
                //                                Integrated Security =true;Initial Catalog=AutoLot;Connect TimeOut=30";
                connection.ConnectionString = cnStringBuilder.ConnectionString;
                connection.Open();

                ShowConnectionStatus(connection);

                //Create object of command SQL
                string sql = "Select * From Inventory;Select * From Customers";
                SqlCommand myCommand = new SqlCommand(sql, connection);

                //Get object of DataReader with ExecuteReader()
                using (SqlDataReader myDataReader = myCommand.ExecuteReader())
                {
                    #region previouse  method
                    //while (myDataReader.Read())
                    //{
                    //    WriteLine("***** Record *****");
                    //    for (int i = 0; i < myDataReader.FieldCount; i++)
                    //    {
                    //        WriteLine($"{myDataReader.GetName(i)} = {myDataReader.GetValue(i)}");
                    //    }
                    //    WriteLine();
                    //}
                    #endregion

                    #region last method
                    do
                    {
                        while (myDataReader.Read())
                        {
                            WriteLine("***** Record *****");
                            for (int i = 0; i < myDataReader.FieldCount; i++)
                            {
                                WriteLine($"{myDataReader.GetName(i)} = {myDataReader.GetValue(i)}");
                            }
                            WriteLine();
                        }                        
                    } while (myDataReader.NextResult());
                    #endregion

                }
                connection.Close();
                ShowConnectionStatus(connection);
            }
            ReadLine();
        }

        static void ShowConnectionStatus(SqlConnection connection)
        {
            WriteLine("**** Info about your connection ******\n");
            WriteLine($"DataBase location: {connection.DataSource}");
            WriteLine($"DataBase Name: {connection.Database}");
            WriteLine($"Connection Timeout: {connection.ConnectionTimeout}");
            WriteLine($"Connection state: {connection.State}");
        }
    }
}
