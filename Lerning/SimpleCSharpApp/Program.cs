using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCSharpApp
{
    class Program
    {

        static int Main(string[] args)
        {
            Console.Title = "*****My 1st C# App*****";
            Console.WriteLine("My 1st C# App");
            Console.WriteLine("Hello World");
            Console.ForegroundColor = ConsoleColor.Yellow;
            EmptyString();

            Console.WriteLine("__For__");
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("Arg: {0}", args[i]);
            }
            EmptyString();

            Console.WriteLine("__Foreach__");
            foreach (string arg in args)
            {
                Console.WriteLine("Arg: {0}", arg);
            }
            EmptyString();

            Console.WriteLine("__Foreach__Environment.GetCommandLineArgs()");
            string[] theArgs = Environment.GetCommandLineArgs();
            foreach (string arg in theArgs)
            {
                Console.WriteLine("Arg: {0}", arg);
            }
            EmptyString();

            ShowEnvironmentDetails();
            Console.ReadLine();

            return -1;
        }

        static void EmptyString() => Console.WriteLine();


        static void ShowEnvironmentDetails()
        {
            foreach (string drive in Environment.GetLogicalDrives())
            {
                Console.WriteLine("Drive {0}", drive);
            }
            
            Console.WriteLine("OS: {0}", Environment.OSVersion);
            Console.WriteLine("Processors: {0}", Environment.ProcessorCount);
            Console.WriteLine(".NET version: {0}", Environment.Version);
        }
    }
}
