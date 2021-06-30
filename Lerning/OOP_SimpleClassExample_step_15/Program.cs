using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_SimpleClassExample_step_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Fun with Class Types ====");

            Car myCar = new Car();
            Car chukCar = new Car(103, "Alterra");
            Car puk = new Car("Terra");            

            Iter(myCar, 5, 5);

            Iter(chukCar, 30, 5);

            Iter(puk, 23, 5);

            Motocycle cy = new Motocycle(5, "Tomas");
            cy.PopAWeew();

            Motocycle nCy = new Motocycle(name: "Adarel");
            nCy.PopAWeew();

            Motocycle hondaz = new Motocycle(4);
            hondaz.PopAWeew();

            MakeSomeBikes();

            Console.ReadLine();
        }

        static void Iter(Car car, int delta, int j)
        {
            Console.WriteLine("==== Iter Start! =====");
            for (int i = 0; i <= j; i++)
            {
                Console.Write($"N{i}    ");
                car.SpeedUp(delta);
                car.PrintState();
            }
        }

        static void MakeSomeBikes()
        {
            Motocycle m1 = new Motocycle();
            Console.WriteLine($"Name = {m1.drivarName}, Intensity = {m1.driverIntensity}");

            Motocycle m2 = new Motocycle(name: "Tiriel");
            Console.WriteLine($"Name = {m2.drivarName}, Intensity = {m2.driverIntensity}");

            Motocycle m3 = new Motocycle(3);
            Console.WriteLine($"Name = {m3.drivarName}, Intensity = {m3.driverIntensity}");
        }
    }
}
