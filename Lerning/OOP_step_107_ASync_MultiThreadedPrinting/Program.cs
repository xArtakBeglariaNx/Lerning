using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP_step_106_ASync_SimpleMultiThreadsChanged;

namespace OOP_step_107_ASync_MultiThreadedPrinting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==== Synchronizing Treads ====\n");
            
            Thread primaryThread = Thread.CurrentThread;
            primaryThread.Name = "Primary";
            Console.WriteLine($"->{Thread.CurrentThread.Name} thread is executing Main()");

            //Create working class and 10 threads which indicate to 1 thread
            Printer p = new Printer();
            Thread[] threads = new Thread[10];
            for (int i = 0; i < 10; i++)
            {
                threads[i] = new Thread(new ThreadStart(p.PrintNumbers))
                {
                    Name = $"Worker thread # {i}"
                };
            }

            //now start all threads
            foreach (Thread t in threads)
            {
                t.Start();
            }
            Console.ReadLine();
        }
    }
}
