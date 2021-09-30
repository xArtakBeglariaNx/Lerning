using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOP_step_103_ASync_ThreadStats
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Primary Thread stats =====");

            //gitting name current thread
            Thread primaryThread = Thread.CurrentThread;
            primaryThread.Name = "ThePrimaryThread";

            //show details in servicing domain of app and context
            Console.WriteLine($"Name of current AppDomain: {Thread.GetDomain().FriendlyName}");
            Console.WriteLine($"ID of curr AppDomain: {Thread.GetDomainID()}");
            Console.WriteLine($"ID of current context: {Thread.CurrentContext.ContextID}\n");

            //show another stats of curr thread
            Console.WriteLine($"Thread name: {primaryThread.Name}");
            Console.WriteLine($"has thread started? {primaryThread.IsAlive}");
            Console.WriteLine($"Prioraty lavel: {primaryThread.Priority}");
            Console.WriteLine($"Thread state: {primaryThread.ThreadState}");
            Console.ReadLine();
        }
    }
}
