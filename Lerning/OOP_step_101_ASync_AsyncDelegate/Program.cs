using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOP_step_101_ASync_AsyncDelegate
{
    class Program
    {
        public delegate int BinaryOp(int x, int y);

        static void Main(string[] args)
        {
            Console.WriteLine("===== Asynch delegate review =====");

            //displaying id of current thread
            Console.WriteLine($"Main() of thread {Thread.CurrentThread.ManagedThreadId}");

            //invoke Add() in secondary thread
            BinaryOp b = new BinaryOp(Add);
            IAsyncResult ar = b.BeginInvoke(10, 10, null, null);

            //doing another work in 1st thread
            //this message will be displayed until the Add method is completed
            while (!ar.IsCompleted)
            {
                Console.WriteLine($"Doing more work in Main()");
                Thread.Sleep(1000);
            }

            //get result method Add() if all ready do this
            int answer = b.EndInvoke(ar);

            //this lines not beginning before finishing method Add()
            Console.WriteLine($"10 + 10 is {answer}");
            Console.ReadLine();
        }

        static int Add(int x, int y)
        {
            //displaying id of current thread
            Console.WriteLine("Add() invoked on thread {0}", Thread.CurrentThread.ManagedThreadId);

            //to do pause for modeling long operation
            Thread.Sleep(5000);
            return x + y;
        }
    }
}
