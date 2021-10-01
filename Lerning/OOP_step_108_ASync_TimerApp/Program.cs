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

            //Create delegate
            TimerCallback timerCB = new TimerCallback(PrintTime);
            Timer timer = new Timer(timerCB, "Hello from Main", 0, 1000);
            Console.ReadLine();
        }

        static void PrintTime(object state)
        {
            Console.WriteLine($"==== Time is: {DateTime.Now.ToLongTimeString()}, Params: {state} ====");
        }
    }
}
