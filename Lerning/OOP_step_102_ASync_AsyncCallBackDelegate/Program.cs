using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Runtime.Remoting.Messaging;
using System.Threading.Tasks;

namespace OOP_step_102_ASync_AsyncCallBackDelegate
{
    public delegate int BinaryOp(int x, int y);
    class Program
    {
        private static bool isDone = false;
        static void Main(string[] args)
        {
            Console.WriteLine("===== AsyncCallback Delegat example =====");

            //displaying id of current thread
            Console.WriteLine($"Main() of thread {Thread.CurrentThread.ManagedThreadId}");

            BinaryOp b = new BinaryOp(Add);
            IAsyncResult ar = b.BeginInvoke(10, 10, new AsyncCallback(AddComplete), "Main() thanks you for adding these numbers");

            while (!isDone)
            {
                Console.WriteLine("Working....");
                Thread.Sleep(1000);
            }
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

        static void AddComplete(IAsyncResult iar)
        {
            Console.WriteLine($"AddComplete() invoked on thread {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine("Your addition is complete");
            AsyncResult ar = (AsyncResult)iar;
            BinaryOp b = (BinaryOp)ar.AsyncDelegate;
            string msg = (string)iar.AsyncState;
            Console.WriteLine($"10 + 10 is {b.EndInvoke(iar)}");
            Console.WriteLine(msg);
            isDone = true;
        }
    }
}
