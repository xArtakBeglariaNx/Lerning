using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_StaticDataAndMembers_step_16
{
    class SavingAccount
    {
        public double currBalance;

        //public static double currInterestRate = 0.04;
        private static double currInterestRate;

        public static double CurrInterestRate { get => currInterestRate; set => currInterestRate = value; } //after change 

        static SavingAccount()
        {
            Console.WriteLine("In static ctor");
            CurrInterestRate = 0.04;
        }

        public SavingAccount(double balance)
        {
            //currInterestRate = 0.04;
            currBalance = balance;
        }

        //public static void SetInterestRate(double newRate)
        //{
        //    currInterestRate = newRate;
        //}

        //public static double GetInterestRate()
        //{
        //    return currInterestRate;
        //}
    }
}
