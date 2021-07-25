using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_68_Object_sLifeTime_SimpleGC
{
    class Car
    {
        public int CurrentSpeed { get; set; }
        public string PetName { get; set; }
        public Car() { }
        public Car(string name, int speed)
        {
            CurrentSpeed = speed;
            PetName = name;
        }
        public override string ToString() => $"{PetName} is going {CurrentSpeed} km/h";
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== GC Basics =====");

            Console.WriteLine("Estimated bytes on heap: {0}", GC.GetTotalMemory(false));

            Console.WriteLine($"This OS has {GC.MaxGeneration + 1}  object generations.");

            Car refToMyCar = new Car("Zato", 60);
            Console.WriteLine(refToMyCar.ToString());

            Console.WriteLine($"Generation of refToMyCar: {GC.GetGeneration(refToMyCar)}");

            object[] tonsOfObjects = new object[50000];
            for (int i = 0; i < 50000; i++)
            {
                tonsOfObjects[i] = new object();
            }

            GC.Collect(0, GCCollectionMode.Forced);
            GC.WaitForPendingFinalizers();


            Console.WriteLine($"Generation of refToMyCar: {GC.GetGeneration(refToMyCar)}");

            if (tonsOfObjects[9000] != null)
            {
                Console.WriteLine($"Generation of tonsOfObjects[9000] is: {GC.GetGeneration(tonsOfObjects[9000])}");
            }
            else
            {
                Console.WriteLine("tonsOfObjects[9000] is not longer alive");
            }

            Console.WriteLine($"Gen 0 has been swept: {GC.CollectionCount(0)} times");
            Console.WriteLine($"Gen 1 has been swept: {GC.CollectionCount(1)} times");
            Console.WriteLine($"Gen 2 has been swept: {GC.CollectionCount(2)} times");
            
            Console.ReadLine();
        }
        static void MakeACar()
        {
            //Если myCar удинственная ссылка на объект Car то после 
            //завершения этого метода объект Car *может* быть уничтожен
            Car myCar = new Car();
        }
    }
}
