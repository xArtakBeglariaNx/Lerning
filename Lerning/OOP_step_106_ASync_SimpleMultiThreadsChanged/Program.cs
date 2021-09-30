using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace OOP_step_106_ASync_SimpleMultiThreadsChanged
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==== Amazing Thread App ====\n");
            Console.Write("Do you want [1] or [2] threads?");
            string threadCount = Console.ReadLine();

            Thread primaryThread = Thread.CurrentThread;
            primaryThread.Name = "Primary";
            Console.WriteLine($"->{Thread.CurrentThread.Name} is executing Main()");

            //Create working class
            Printer p = new Printer();
            switch (threadCount)
            {
                case "2":
                    Thread backgroundThread = new Thread(new ThreadStart(p.PrintNumbers));
                    backgroundThread.Name = "Secondary";
                    backgroundThread.IsBackground = true;
                    backgroundThread.Start();
                    break;
                case "1":
                    p.PrintNumbers();
                    break;
                default:
                    Console.WriteLine("I dont know what you want...you get 1 thread");
                    goto case "1";
            }

            //doing another additional work
            MessageBox.Show("Im busy!", "Working in main thread...");
        }
    }
}
