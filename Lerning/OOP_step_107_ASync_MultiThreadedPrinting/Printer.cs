using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOP_step_107_ASync_MultiThreadedPrinting
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
}
