using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_51_Events_CarEventArgs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Fun with Event Args =====\n");

            Car c1 = new Car("Dizzy", 32, 62);
            c1.Explored += CarExplored;
            c1.AboutToBlow += CarAboutToBlow;
            c1.AboutToBlow += CarIsDoomed;

            for (int i = 0; i < 3; i++)
            {
                c1.Accelerate(20);
            }

            c1.Explored -= CarExplored;

            Console.ReadLine();
        }

        private static void CarExplored(object sender, CarEventArgs e)
        {
            if (sender is Car c)
            {
                Console.WriteLine($"{c.PetName} : {e.msg}");
            }
        }

        private static void CarAboutToBlow(object sender, CarEventArgs e)
        {
            if (sender is Car c)
            {
                Console.WriteLine($"{c.PetName} : {e.msg}");
            }
        }

        private static void CarIsDoomed(object sender, CarEventArgs e)
        {
            if (sender is Car c)
            {
                Console.WriteLine($"Critical message from {c.GetType().Name} : {e.msg}");
            }
        }
    }
}
