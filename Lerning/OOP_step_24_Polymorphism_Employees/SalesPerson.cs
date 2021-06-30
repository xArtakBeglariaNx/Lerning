using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_24_Polymorphism_Employees
{
    class SalesPerson : Employee
    {
        public SalesPerson() { }
        public SalesPerson(string fullName, int id, int age, float currPay, string ssn, int numbOfSales)
            : base(fullName, id, age, currPay, ssn)
        {
            SalesNumber = numbOfSales;
        }
        public int SalesNumber { get; set; }

        public override sealed void GiveBonus(float amount)
        {
            int salesBonus = 0;
            if (SalesNumber >= 0 && SalesNumber <= 100)
            {
                salesBonus = 10;
            }
            else
            {
                if (SalesNumber >= 101 && SalesNumber <= 200)
                {
                    salesBonus = 15;
                }
                else
                    salesBonus = 20;
            }
            base.GiveBonus(amount * salesBonus);
        }

        public override void DisplayStats()
        {
            base.DisplayStats();
        }

        public override void AdditionalStats()
        {
            Console.WriteLine($"Sale number: {SalesNumber}");
            Console.WriteLine($"Benefit cost: {Benefits.ComputePayDeducation()} and Benefit level : {BenefitPackage.BenefitPackageLevel.Platinum}");
        }
    }
}
