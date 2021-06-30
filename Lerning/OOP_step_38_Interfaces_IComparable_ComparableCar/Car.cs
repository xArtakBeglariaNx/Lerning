using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_38_Interfaces_IComparable_ComparableCar
{
    class Car : IComparable
    {
        public const int maxSpeed = 100;

        public int CurrentSpeed { get; set; }
        public string PetName { get; set; }
        public int CarID { get; set; }
        public static IComparer SortByPetName { get => (IComparer)new PetNameComparer(); }

        public Exception InnerException { get; set; }

        private bool carIsDead;

        public Car() { }

        public Car(string name, int currSpeed, int carId)
        {
            CurrentSpeed = currSpeed;
            PetName = name;
            CarID = carId;
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
            }
            else
            {
                CurrentSpeed += delta;
                if (CurrentSpeed > maxSpeed)
                {
                    carIsDead = true;

                    InnerException = new Exception("You have a lead foot");
                    SystemException ex = new SystemException ($"{PetName} has overheated", InnerException);
                    ex.HelpLink = "www.I_KNOW_WHAT_YOU_DONE_IN_LAST_SUMMER.com\n";
                    throw ex;                    
                }
                else
                    Console.WriteLine("=> {0} = {1}", nameof(CurrentSpeed), CurrentSpeed);
            }
        }

        public override string ToString()
        {
            return $"   {nameof(PetName)} = {PetName}\n   {nameof(CarID)} = {CarID}\n   {nameof(CurrentSpeed)} = {CurrentSpeed}\n===========";
        }

        //int IComparable.CompareTo(object obj)
        //{
        //    Car temp = obj as Car;
        //    if (temp != null)
        //    {
        //        if (this.CarID > temp.CarID)
        //        {
        //            return 1;
        //        }
        //        if (this.CarID < temp.CarID)
        //        {
        //            return -1;
        //        }
        //        else
        //        {
        //            return 0;
        //        }
        //    }
        //    else
        //    {
        //        throw new ArgumentException("Parameter is not a Car");
        //    }
        //}

        int IComparable.CompareTo(object obj)
        {
            Car temp = obj as Car;
            if (temp != null)
            {
                return this.CarID.CompareTo(temp.CarID);
            }
            else
            {
                throw new ArgumentException("Parameter is not a Car");
            }
        }
    }
}
