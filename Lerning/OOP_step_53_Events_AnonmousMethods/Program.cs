using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_53_Events_AnonmousMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Fun with Anonimous Methods =====\n");

            int aboutToBlow = 0;

            Car c1 = new Car("Poly", 32, 62);
            c1.AboutToBlow += delegate
            {
                aboutToBlow++;
                Console.WriteLine("Eak, to slowly plsss");
            };
            c1.AboutToBlow += delegate (object sender, CarEventArgs e)
            {
                aboutToBlow++;
                Console.WriteLine($"Hey! You have message from {sender.GetType().Name}: {e.msg}");
            };
            c1.Explored += delegate (object sender, CarEventArgs e)
            {
                if (sender is Car c)
                {
                    Console.WriteLine($"Stuppid {c.PetName} your {e.msg}");
                }
            };

            for (int i = 0; i < 3; i++)
            {
                c1.Accelerate(20);
            }

            Console.WriteLine($"AboutToBlow to fired: {aboutToBlow}");

            c1.Explored -= delegate { };

            Console.ReadLine();
        }
    }
}
