using System;
using static System.Console;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace OOP_step_124_ADO.NET_MyConnectionFactory
{
    enum DataProvider
    {
        SqlServer, Odbc, OleDb, None
    }

    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("=== Very simple connection Factory ===\n");

            string dataProviderString = ConfigurationManager.AppSettings["provider"];
            DataProvider dataProvider = DataProvider.None;
            if (Enum.IsDefined(typeof(DataProvider), dataProviderString))
            {
                dataProvider = (DataProvider)Enum.Parse(typeof(DataProvider), dataProviderString);
            }
            else
            {
                WriteLine("Sorry provider no exist!");
                ReadLine();
                return;
            }
            IDbConnection myConnection = GetConnection(dataProvider);
            WriteLine($"Your connection is a {myConnection.GetType().Name ?? "unrecognized type"}");
            ReadLine();            
        }

        static IDbConnection GetConnection(DataProvider dataProvider)
        {
            IDbConnection connection = null;
            switch (dataProvider)
            {
                case DataProvider.SqlServer:
                    connection = new SqlConnection();
                    break;
                case DataProvider.Odbc:
                    connection = new OdbcConnection();
                    break;
                case DataProvider.OleDb:
                    connection = new OleDbConnection();
                    break;
            }
            return connection;

        }
    }
}
