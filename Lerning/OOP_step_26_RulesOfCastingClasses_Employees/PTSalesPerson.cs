using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_26_RulesOfCastingClasses_Employees
{
    sealed class PTSalesPerson : SalesPerson
    {
        public PTSalesPerson() : base ("SomeEmployee", 0000, 18, 20000, "*****", 20) { }

        public PTSalesPerson(string fullName, int id, int age, float currPay, string ssn, int numOfSales) : base (fullName, id, age, currPay, ssn, numOfSales)
        {
        }
        
        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine($"Benefit: {GetBenefitCostForPtEmp(75)} and Benefit level: {BenefitPackage.BenefitPackageLevel.None}");
        }
    }
}
