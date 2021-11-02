using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace OOP_step_125_ADO.NET_DataProviderFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("=== Fun with Data Provider Factories ===\n");

            string dataProvider = ConfigurationManager.AppSettings["provider"];

            //string connectionString =
            //	ConfigurationManager.AppSettings["connectionString"];
            //string connectionString =
            //	ConfigurationManager.ConnectionStrings["AutoLotSqlProvider"].ConnectionString;
            string connectionString = ConfigurationManager.ConnectionStrings["AutoLotOleDbProvider"].ConnectionString;

            //Get data factories
            DbProviderFactory factory = DbProviderFactories.GetFactory(dataProvider);

            //Get connection object
            using (DbConnection connection = factory.CreateConnection())
            {
                if (connection == null)
                {
                    ShowError("Connection");
                    return;
                }
                WriteLine($"Your connection is a: {connection.GetType().Name}");
                connection.ConnectionString = connectionString;
                connection.Open();

                var sqlConnection = connection as SqlConnection;
                if (sqlConnection != null)
                {
                    WriteLine(sqlConnection.ServerVersion);
                }

                //Get command object
                DbCommand command = factory.CreateCommand();
                if (command == null)
                {
                    ShowError("Command");
                    return;
                }
                WriteLine($"Your command is a: {command.GetType().Name}");
                command.Connection = connection;
                command.CommandText = "Select * From Inventory";

                //show data with DbDataReader object
                using (DbDataReader dataReader = command.ExecuteReader())
                {
                    WriteLine($"Your data reder object is a: {dataReader.GetType().Name}");

                    WriteLine("\n****** Current Inventory ********");
                    while (dataReader.Read())
                    {
                        WriteLine($"-> Car # {dataReader["CarId"]} is a {dataReader["Make"]}.");
                    }
                }
            }
            ReadLine();
        }

        private static void ShowError(string objectName)
        {
            WriteLine($"There was an issue creating the {objectName}");
            ReadLine();
        }
    }
}
