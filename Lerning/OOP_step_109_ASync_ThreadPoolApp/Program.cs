using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOP_step_109_ASync_ThreadPoolApp
{
    public class Printer
    {
        private object threadLock = new object();
        //Show info of thread
        public void PrintNumbers()
        {
            lock (threadLock)
            {
                Console.WriteLine($"-> {Thread.CurrentThread.Name} is executing PrintNumbers()");

                //show numbers
                Console.Write("Your numbers:");
                for (int i = 0; i < 10; i++)
                {
                    Random r = new Random();
                    Thread.Sleep(1000 * r.Next(0));
                    Console.Write(i + 1);
                }

                Console.WriteLine();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Fun with CLR Thread Pool ===\n");

            Console.WriteLine($"Main Thread started. ThradID = {Thread.CurrentThread.ManagedThreadId}");

            Printer newPrinter = new Printer();
            WaitCallback workItem = new WaitCallback(PrintTheNumbers);

            for (int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(workItem, newPrinter);
            }
            Console.WriteLine("All task queued");
            Console.ReadLine();
        }

        static void PrintTheNumbers(object state)
        {
            Printer task = (Printer)state;
            task.PrintNumbers();
        }
    }
}
