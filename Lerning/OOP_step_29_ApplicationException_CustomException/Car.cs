using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_29_ApplicationException_CustomException
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

                    CarIsDeadException ex = new CarIsDeadException($"{PetName} has overheated", "You have a lead foot", DateTime.Now);
                    ex.HelpLink = "www.I_KNOW_WHAT_YOU_DONE_IN_LAST_SUMMER.com";
                    throw ex;                    
                }
                else
                    Console.WriteLine("=> {0} = {1}", nameof(CurrentSpeed), CurrentSpeed);
            }
        }
        public void AccelerateVer2(int delta)
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

                    CarIsDeadExceptionVer2 exV2 = new CarIsDeadExceptionVer2($"{PetName} has overheated", "You have a lead foot", DateTime.Now);
                    exV2.HelpLink = "www.I_KNOW_WHAT_YOU_DONE_IN_LAST_SUMMER.com";
                    throw exV2;
                }
                else
                    Console.WriteLine("=> {0} = {1}", nameof(CurrentSpeed), CurrentSpeed);
            }
        }
        public void AccelerateVer3(int delta)
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

                    CarIsDeadExceptionVer3 exV3 = new CarIsDeadExceptionVer3($"{PetName} has overheated");
                    exV3.HelpLink = "www.I_KNOW_WHAT_YOU_DONE_IN_LAST_SUMMER.com";
                    throw exV3;
                }
                else
                    Console.WriteLine("=> {0} = {1}", nameof(CurrentSpeed), CurrentSpeed);
            }
        }
    }
}
