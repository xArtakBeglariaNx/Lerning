using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOP_step_108_ASync_TimerApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("==== Working with Timer type ====");
            Console.WriteLine("Time is: ");

            //Create delegate
            TimerCallback timerCB = new TimerCallback(PrintTime);
            Timer timer = new Timer(timerCB, null, 0, 1000);
            Console.ReadLine();
        }

        static void PrintTime(object state)
        {
            Console.WriteLine($"==== {DateTime.Now.ToLongTimeString()} ====");
        }
    }
}
