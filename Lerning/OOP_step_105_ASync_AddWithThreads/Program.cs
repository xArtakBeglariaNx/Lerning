using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOP_step_105_ASync_AddWithThreads
{
    class AddParams
    {
        public int a, b;
        public AddParams(int num1, int num2)
        {
            a = num1;
            b = num2;
        }
    }

    class Program
    {
        private static AutoResetEvent waitHandle = new AutoResetEvent(false);
        static void Main(string[] args)
        {
            Console.WriteLine("==== Adding with Threads ofbjects ====");
            Console.WriteLine($"Id of thread in Main(): {Thread.CurrentThread.ManagedThreadId}");


            //Create AddParams for adding in secondary thread
            AddParams ap = new AddParams(10, 10);
            Thread t = new Thread(new ParameterizedThreadStart(Add));
            t.Start(ap);

            //waiting before thread is finished
            waitHandle.WaitOne();
            Console.WriteLine("Other thread is done!");

            Console.ReadLine();
        }

        static void Add(object data)
        {
            if (data is AddParams)
            {
                Console.WriteLine($"Id of thread in Add(): {Thread.CurrentThread.ManagedThreadId}");

                AddParams ap = (AddParams)data;
                Console.WriteLine($"{ap.a} + {ap.b} is {ap.a + ap.b}");

                //notify another thread that the work is completed
                waitHandle.Set();
            }
        }
    }
}
