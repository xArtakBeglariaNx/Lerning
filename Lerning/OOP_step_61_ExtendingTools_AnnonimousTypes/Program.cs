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

            Console.WriteLine("===================");

            ReflectOverAnnonimousType(myCar);

            Console.WriteLine("===================");

            EquiltyTest();

            Console.WriteLine("===================");

            var buyCar = new
            {
                TimeBought = DateTime.Now,
                ItemBought = myCar
            };
            var buyCar2 = new
            {
                TimeBought = DateTime.Now,
                ItemBought = new {Make = "Lancer", Color = "Yellow", Speed = 290}
            };

            ReflectOverAnnonimousType(buyCar);
            ReflectOverAnnonimousType(buyCar2);

            Console.ReadLine();
        }

        static void BuildAnnonType(string make, string color, int currSp)
        {
            //Build annonimous type with incoming params
            var car = new { Make = make, Color = color, Speed = currSp };

            //Now we can to use this type for getting his properties
            Console.WriteLine($"Yoe have {car.Color} {car.Make} going {car.Speed} km/h");

            //Annonimous type have special implementations for each virtual method
            Console.WriteLine($"ToString == {car}");
        }

        static void ReflectOverAnnonimousType(object obj)
        {
            Console.WriteLine($"obj is an instance of: {obj.GetType().Name}");
            Console.WriteLine($"Base class of {obj.GetType().Name} is {obj.GetType().BaseType}");
            Console.WriteLine("obj.ToString() == {0}", obj.ToString());
            Console.WriteLine("obj.GetHashCode() == {0}", obj.GetHashCode());
        }

        static void EquiltyTest()
        {
            var firstCar = new { Make = "Top", Color = "Green", Speed = 55 };
            var secondCar = new { Make = "Top", Color = "Green", Speed = 55 };

            Console.WriteLine("\nUse method Equals: ");
            if (firstCar.Equals(secondCar))
            {
                Console.WriteLine("==> Same annonimous object!");
            }
            else
            {
                Console.WriteLine("==> Not the same annonimous object!");
            }

            Console.WriteLine("\nUse operator == :");
            if (firstCar == secondCar)
            {
                Console.WriteLine("==> Same annonimous object!");
            }
            else
            {
                Console.WriteLine("==> Not the same annonimous object!");
            }
            if (firstCar.GetType().Name == secondCar.GetType().Name)
            {
                Console.WriteLine("We are both the same type");
            }
            else
            {
                Console.WriteLine("We are different types");
            }

            Console.WriteLine();
            //Display all ditails
            ReflectOverAnnonimousType(firstCar);
            Console.WriteLine();
            ReflectOverAnnonimousType(secondCar);
        }
    }
}
