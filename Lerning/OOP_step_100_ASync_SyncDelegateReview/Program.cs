using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOP_step_100_ASync_SyncDelegateReview
{
    class Program
    {
        public delegate int BinaryOp(int x, int y);
        static void Main(string[] args)
        {
            Console.WriteLine("===== Synch delegate review =====");

            //displaying id of current thread
            Console.WriteLine($"Main() of thread {Thread.CurrentThread.ManagedThreadId}");

            //invoke Add in sync mode
            BinaryOp b = new BinaryOp(Add);

            //we can also to write b.Invoke(10,10)
            int answer = b(10, 10);

            //this lines not beginning before finishing method Add()
            Console.WriteLine("Doing more work in Main()");
            Console.WriteLine($"10+10 is {answer}");
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
