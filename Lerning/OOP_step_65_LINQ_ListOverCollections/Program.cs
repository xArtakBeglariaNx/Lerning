using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_65_LINQ_ListOverCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Linq over Generic Collection ====\n");

            List<Car> myCar = new List<Car>()
            {
                new Car {PetName = "Henry", Color = "Red", Speed = 100, Make = "BMW"},
                new Car {PetName = "Daisy", Color = "Tan", Speed = 90, Make = "BMW"},
                new Car {PetName = "Tommy", Color = "Gray", Speed = 10, Make = "VM"},
                new Car {PetName = "Elvia", Color = "Green", Speed = 5, Make = "Ferrari"},
                new Car {PetName = "Hadum", Color = "Yellow", Speed = 80, Make = "Yaguar"}
            };

            GetFastCars(myCar);
                        
            Console.ReadLine();
        }

        static void GetFastCars(List<Car> myCars)
        {
            var fastCars1 = from c in myCars where c.Speed > 55 select c;

            foreach (var item in fastCars1)
            {
                Console.WriteLine($"{item.PetName} is going to fast");
            }

            var fastCars2 = from c in myCars where c.Speed > 90 && c.Make == "BMW" select c;

            foreach (var item in fastCars2)
            {
                Console.WriteLine($"{item.PetName} : {item.Make} is going to fast");
            }
        }
    }
}
