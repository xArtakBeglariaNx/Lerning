using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_38_Interfaces_IComparable_ComparableCar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ==== Fun with Object Sorting ==== ");

            Car[] myCarArray = new Car[5];
            myCarArray[0] = new Car("Rusty", 12, 31);
            myCarArray[1] = new Car("Tony", 1, 18);
            myCarArray[2] = new Car("Jen", 3, 222);
            myCarArray[3] = new Car("Foxy", 123, 318);
            myCarArray[4] = new Car("Rudika", 22, 38);

            Console.WriteLine("Here is unordered set of Cars: \n");
            foreach (Car c in myCarArray)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine();

            //Отсортируем массив по CarID
            Array.Sort(myCarArray);
            Console.WriteLine("Here is ordered set of Cars by CarID: \n");
            foreach (Car c in myCarArray)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine();

            //Отсортируем массив по CarID и PetName
            Array.Sort(myCarArray, Car.SortByPetName);
            Console.WriteLine("Here is ordered set of Cars by CarID adn PetName: \n");
            foreach(Car c in myCarArray)
            {
                Console.WriteLine(c);
            }

            Console.ReadLine();
        }
    }
}
