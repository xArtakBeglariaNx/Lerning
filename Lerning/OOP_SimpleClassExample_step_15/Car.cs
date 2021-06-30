using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_SimpleClassExample_step_15
{
    class Car
    {
        public string petName;
        public int currSpeed;

        public void PrintState() => Console.WriteLine($"{petName} is going {currSpeed} km/h");
        public void SpeedUp(int delta) => currSpeed += delta;
                
        public Car() { }

        public Car(string nm) => petName = nm;

        public Car(int speed, string name)
        {
            petName = name;
            currSpeed = speed;
        }
    }
}
