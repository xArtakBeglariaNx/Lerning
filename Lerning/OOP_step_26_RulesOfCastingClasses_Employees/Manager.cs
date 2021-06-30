using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_26_RulesOfCastingClasses_Employees
{
    class Manager : Employee
    {
        public Manager() { }
        public Manager(string fullName, int age, int empId, float currPay, int numbOfOpts) 
            : base (fullName, empId, age, currPay, "****")
        {
            StockOptions = numbOfOpts;
        }
        public int StockOptions {get; set;}

        public override void GiveBonus(float amount)
        {
            Random r = new Random();
            StockOptions += r.Next(500);
            base.GiveBonus(amount + StockOptions);
        }

        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine($"Stock options: {StockOptions}");
            Console.WriteLine($"Benefit cost: {Benefits.ComputePayDeducation()} and Benefit level : {BenefitPackage.BenefitPackageLevel.Gold}");
        }
    }
}
