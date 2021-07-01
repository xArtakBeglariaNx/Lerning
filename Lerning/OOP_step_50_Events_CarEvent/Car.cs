using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_50_Events_CarEvent
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

        #region In time using events no need to create variable for delegate and methods Register & UnRegister

        ////определяем переменную этого делегата
        //private CarEngineHandler listOfHandlers;

        ////добавляем регистрационный метод для вызывающего кода
        //public void RegisterWithCarEngine(CarEngineHandler methodToCall)
        //{
        //    listOfHandlers += methodToCall;
        //}
        //public void UnRegisterWithCarEngine(CarEngineHandler methodToCall)
        //{
        //    listOfHandlers -= methodToCall;
        //}

        #endregion        

        /* Альтернатива написания метода RegisterWithCarEngine(CarEngineHandler methodToCall)
         * public void RegisterWithCarEngine(CarEngineHandler methodToCall)
        {
            if(listOfHandlers == null)
            {
               listOfHandlers = methodToCall;
            }
            else
            {
               Delegate.Combine(listOfHandlers, methodToCall) 
            }
        }
         */

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
