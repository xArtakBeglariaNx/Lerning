using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_AutoProps_step_19
{
    class Car
    {
        private int numberOfDoors = 2;
        public Car() { }
        public Car(int speed, string name, ConsoleColor color, int doors)
        {
            Speed = speed;
            PetName = name;
            Color = color;
            NumberOfDoors = doors;
            
        }

        public int Speed { get; set; }
        public string PetName { get; set; }
        public ConsoleColor Color { get; set; }
        public int NumberOfDoors { get => numberOfDoors; set => numberOfDoors = value; }

        public void DisplayStat()
        {
            Console.WriteLine($"Car name: {PetName}");
            Console.WriteLine($"Speed: {Speed} km/h");
            Console.WriteLine($"Car color: {Color}");
            Console.WriteLine($"Doors: {NumberOfDoors}\n");
        }
    }
}
