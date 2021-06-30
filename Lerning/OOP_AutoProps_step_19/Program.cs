using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_AutoProps_step_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fun with AutoProps");
            Car car = new Car();
            car.PetName = "Mitsubishi";
            car.Speed = 205;
            car.Color = ConsoleColor.Red;
            car.DisplayStat();

            Car carOne = new Car(127, "Honda", ConsoleColor.Cyan, 6);
            carOne.DisplayStat();
            carOne.Color++;
            carOne.DisplayStat();

            Garage garage = new Garage();
            garage.MyAuto = car;
            Console.WriteLine($"Number of car: {garage.NumberOfCars}");
            Console.WriteLine(garage.MyAuto.PetName);
            Console.ReadLine();
        }
    }
}
