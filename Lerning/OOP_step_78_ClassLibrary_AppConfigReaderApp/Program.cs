using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace OOP_step_78_ClassLibrary_AppConfigReaderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            AppSettingsReader ar = new AppSettingsReader();
            int numberOfTimes = (int)ar.GetValue("RepeatCount", typeof(int));
            string textColor = (string)ar.GetValue("TextColor", typeof(string));

            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), textColor);

            for (int i = 0; i < numberOfTimes; i++)
            {
                Console.WriteLine($"N:{i+1} Howdy");
            }
            Console.ReadLine();
        }
    }
}
