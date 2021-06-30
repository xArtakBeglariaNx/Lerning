using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_StaticDataAndMembers_step_16
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingAccount savingAccount1 = new SavingAccount(50);
            Console.WriteLine($"For {nameof(savingAccount1)} = {savingAccount1.currBalance} :: InterestRate is {SavingAccount.CurrInterestRate}\n");

            SavingAccount savingAccount2 = new SavingAccount(100);
            SavingAccount.CurrInterestRate = 0.08;
            Console.WriteLine($"For {nameof(savingAccount2)} = {savingAccount2.currBalance} :: InterestRate is {SavingAccount.CurrInterestRate}\n");

            SavingAccount savingAccount3 = new SavingAccount(10000.75);
            Console.WriteLine($"For {nameof(savingAccount3)} = {savingAccount3.currBalance} :: InterestRate is {SavingAccount.CurrInterestRate}");

            Console.ReadLine();
        }
    }
}
