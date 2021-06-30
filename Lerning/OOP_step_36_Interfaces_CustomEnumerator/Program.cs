using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_36_Interfaces_CustomEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****** Fun with IEnumerable / IEnumerator *****");

            Garage carLot = new Garage();
            
            foreach (Car c in carLot)
            {
                Console.WriteLine($"Sample with GetEnumerator: {c.PetName} going {c.CurrentSpeed} km/h");
            }
            Console.WriteLine("====================");

            IEnumerator i = carLot.GetEnumerator();

            while (i.MoveNext() && i.Current != null)
            {
                Car myCar = (Car)i.Current;
                Console.WriteLine($"Sample with GetEnumerator through While: {myCar.PetName} is going {myCar.CurrentSpeed} km/h");
                Console.WriteLine($"HashCode: {myCar.GetHashCode()}");
            }
            Console.WriteLine("====================");

            IEnumerator i2 = carLot.StartEnumeratorWithYield();

            while (i2.MoveNext() && i.Current != null)
            {
                Car myCar = (Car)i2.Current;
                Console.WriteLine($"Sample with GetEnumerator through Foreach: {myCar.PetName} is going {myCar.CurrentSpeed} km/h");
                Console.WriteLine($"HashCode: {myCar.GetHashCode()}");
            }
                        
            Console.WriteLine("====================");

            DisplyaInfo(i2);
            Console.WriteLine("====================");

            IEnumerator i3 = carLot.GetEnumeratorWithLocalFunction();

            foreach (Car c in carLot)
            {
                i3.MoveNext();
                Car myCar = (Car)i3.Current;
                Console.WriteLine($"Sample GetEnumerator through Foreach and Exeption: {myCar.PetName} is going {myCar.CurrentSpeed} km/h");
            }
            Console.WriteLine("====================");

            foreach (Car c in carLot.GetTheCars(true))
            {
                Console.WriteLine($"Sample GetEnumerator through Foreach and Exeption with named iterator: {c.PetName} is going {c.CurrentSpeed} km/h");
            }
            Console.ReadLine();
        }

        static void DisplyaInfo(IEnumerator ie)
        {
            ie = new Garage().StartEnumeratorWithYield();

            while (ie.MoveNext() && ie.Current != null)
            {
                Car car = (Car)ie.Current;
                Console.WriteLine($"Sample GetEnumerator through While and key word Yield: {car.PetName} && {car.CurrentSpeed} km/h");
                Console.WriteLine($"HashCode: {car.GetHashCode()}");
            }
        }
    }
}
