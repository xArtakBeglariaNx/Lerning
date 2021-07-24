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

            Car refToMyCar = new Car("Zato", 60);
            Console.WriteLine(refToMyCar.ToString());
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
