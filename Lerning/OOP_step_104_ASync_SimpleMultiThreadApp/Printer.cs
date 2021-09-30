using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOP_step_104_ASync_SimpleMultiThreadApp
{
    public class Printer
    {
        //Show info of thread
        public void PrintNumbers()
        {
            Console.WriteLine($"-> {Thread.CurrentThread.Name} is executing PrintNumbers()");

            //show numbers
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i + 1);
                Thread.Sleep(2000);
            }

            Console.WriteLine();
        }
    }
}
