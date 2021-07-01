using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_51_Events_CarEventArgs
{
    public class Car
    {
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; } = 100;
        public string PetName { get; set; }

        private bool carIsDead;

        public Car() { }
        public Car(string name, int currSpeed, int maxSpeed)
        {
            PetName = name;
            CurrentSpeed = currSpeed;
            MaxSpeed = maxSpeed;
        }
        //определяем тип делегата
        public delegate void CarEngineHandler(object sender, CarEventArgs e);

        //Add to events
        public event CarEngineHandler Explored;
        public event CarEngineHandler AboutToBlow;
        
        public void Accelerate(int delta)
        {
            if (carIsDead)
            {
                Explored?.Invoke(this, new CarEventArgs("Sorry! Your car is crashed"));
            }
            else
            {
                CurrentSpeed += delta;

                if (10 == (MaxSpeed - CurrentSpeed) & AboutToBlow != null)
                {
                    AboutToBlow(this, new CarEventArgs("Careful buddy! Goona blow!"));
                }

                if (CurrentSpeed >= MaxSpeed)
                {
                    carIsDead = true;
                }
                else
                {
                    Console.WriteLine($"Current Speed is : {CurrentSpeed}");
                }
            }
        }
    }
}
