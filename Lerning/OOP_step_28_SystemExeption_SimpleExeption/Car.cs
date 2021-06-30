using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_28_SystemExeption_SimpleExeption
{
    class Car
    {
        public const int maxSpeed = 100;

        public int CurrentSpeed { get; set; }
        public string PetName { get; set; }

        private bool carIsDead;

        private Radio theMusicBox = new Radio();

        public Car() { }

        public Car(string name, int currSpeed)
        {
            CurrentSpeed = currSpeed;
            PetName = name;
        }

        public void CrankTunes(bool state)
        {
            theMusicBox.TurnOn(state);
        }

        public void Accelerate(int delta)
        {
            if (carIsDead)
            {
                Console.WriteLine("GG...Your car is crashed!!!");
                CrankTunes(false);
            }
            else
            {
                CurrentSpeed += delta;
                if (CurrentSpeed > maxSpeed)
                {
                    carIsDead = true;
                    CurrentSpeed = 0;

                    Exception ex = new Exception($"{PetName} has overheated");
                    ex.HelpLink = "www.I_NO_WHAT_YOU_DO_IN_LAST_SUMMER.com";
                    ex.Data.Add("TimeStamp", $"The Car explored at {DateTime.Now}");
                    ex.Data.Add("Cause", "You have a lead foot");
                    throw ex;
                }
                else
                    Console.WriteLine("=> {0} = {1}", nameof(CurrentSpeed), CurrentSpeed);
            }
        }
    }
}
