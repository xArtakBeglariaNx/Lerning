using System;
using System.Collections.Generic;
using System.Linq;
using OOP_step_131_WCF_MathWindoswClient.ServiceReference1;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOP_step_131_WCF_MathWindoswClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- Async my client ----\n");
            using (BasicMathClient proxy = new BasicMathClient())
            {
                proxy.Open();
                IAsyncResult result = proxy.BeginAdd(2, 3, 
                    ar => { Console.WriteLine($"2 + 3 = {proxy.EndAdd(ar)}"); },
                    null);
                while (!result.IsCompleted)
                {
                    Thread.Sleep(2000);
                    Console.WriteLine("Client is working");
                }
            }
            Console.ReadLine();
        }
    }
}
