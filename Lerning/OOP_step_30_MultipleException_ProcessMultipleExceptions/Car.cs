using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_30_MultipleException_ProcessMultipleExceptions
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
            if (delta < 0)
            {
                ArgumentOutOfRangeException rangeException = new ArgumentOutOfRangeException(nameof(delta), "Speed must be greater than zero");
                throw rangeException;
            }
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

                    CarIsDeadException ex = new CarIsDeadException($"{PetName} has overheated", "You have a lead foot", DateTime.Now);
                    ex.HelpLink = "www.I_KNOW_WHAT_YOU_DONE_IN_LAST_SUMMER.com\n";
                    throw ex;                    
                }
                else
                    Console.WriteLine("=> {0} = {1}", nameof(CurrentSpeed), CurrentSpeed);
            }
        }
    }
}
