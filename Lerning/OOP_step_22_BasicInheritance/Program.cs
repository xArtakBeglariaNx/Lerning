using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_22_BasicInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Fun with Basic Inharitance =====");

            Car myCar = new Car(80);
            myCar.Speed = 95;
            Console.WriteLine($"My car is going {myCar.Speed} km/h ");

            MiniVan miniVan = new MiniVan() { Speed = 35};              
            Console.WriteLine($"My car is going {miniVan.Speed} km/h ");
            Console.ReadLine();
        }
    }
}
