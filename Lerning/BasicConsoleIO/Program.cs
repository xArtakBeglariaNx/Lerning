using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConsoleIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Title = "-----Basic Console I/O-----";
            Console.WriteLine("-----Basic Console I/O-----");
            GetUserData();
            FormatNumericalData();
            DisplayMessage();
            Console.ReadLine();
            
        }

        private static void GetUserData()
        {            
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            Console.Write("Please enter your age: ");
            string userAge = Console.ReadLine();

            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Hi {0}! You are {1} years old", userName, userAge);

            Console.ForegroundColor = prevColor;
        }

        static void FormatNumericalData()
        {            
            Console.WriteLine("The value 99999 in various formats: ");
            Console.WriteLine("c format: {0:c}", 99999.ToString("C",CultureInfo.CreateSpecificCulture("en_US")));
            Console.WriteLine("d9 format: {0:d9}", 99999);
            Console.WriteLine("f3 format: {0:f3}", 99999);
            Console.WriteLine("n format: {0:n}", 99999);

            Console.WriteLine("E format: {0:E}", 99999);
            Console.WriteLine("e format: {0:E}", 99999);
            Console.WriteLine("X format: {0:X}", 99999);
            Console.WriteLine("x format: {0:x}", 99999);

        }

        static void DisplayMessage()
        {
            string userMessage = string.Format("100000 in hex is {0:c}", 100000);
            System.Windows.MessageBox.Show(userMessage);
        }

    }
}
