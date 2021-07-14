using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_61_ExtendingTools_AnnonimousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Fun with Annonimous Type =====\n");

            BuildAnnonType("Misubishi", "Red", 35);

            Console.WriteLine("===================");

            var myCar = new { Make = "AstonMartin", Color = "DarkRed", Speed = 35};

            Console.WriteLine($"My car is {myCar.Color} {myCar.Make} going {myCar.Speed} km/h");
            Console.WriteLine(myCar.ToString());

            Console.ReadLine();
        }

        static void BuildAnnonType(string make, string color, int currSp)
        {
            //Build annonimous type with incoming params
            var car = new { Make = make, Color = color, Speed = currSp };

            //Now we can to use this type for getting his properties
            Console.WriteLine($"Yoe have {car.Color} {car.Make} going {car.Speed} km/h");

            //Annonimous type have special implementations for each virtual method
            Console.WriteLine($"ToString == {car.ToString()}");
        }
    }
}
