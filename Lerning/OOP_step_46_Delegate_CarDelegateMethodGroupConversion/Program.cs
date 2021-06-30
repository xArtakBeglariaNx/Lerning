using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_46_Delegate_CarDelegateMethodGroupConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Group Conversion *****\n");

            Car c1 = new Car("Ferrarya", 10, 100);
            c1.RegisterWithCarEngine(CallMeHere);

            Console.WriteLine($"**** Speeding up ****\n");
            for (int i = 0; i < 6; i++)
            {
                c1.Accelerate(20);
            }

            c1.UnRegisterWithCarEngine(CallMeHere);

            Console.WriteLine($"**** Speeding up ****\n");
            for (int i = 0; i < 6; i++)
            {
                c1.Accelerate(20);
            }
            Console.ReadLine();
        }

        private static void CallMeHere(string msgForCaller)
        {
            Console.WriteLine($"****************************\nMessage from Car: {msgForCaller}");
        }
    }
}
