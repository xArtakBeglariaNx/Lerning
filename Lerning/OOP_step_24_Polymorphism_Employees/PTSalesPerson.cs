using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_24_Polymorphism_Employees
{
    sealed class PTSalesPerson : SalesPerson
    {
        public PTSalesPerson() : base ("SomePTEmployee", 0000, 18, 20000, "*****", 20) { }

        public PTSalesPerson(string fullName, int id, int age, float currPay, string ssn, int numOfSales) : base (fullName, id, age, currPay, ssn, numOfSales)
        {
        }
        
        public override void DisplayStats()
        {
            base.DisplayStats();
        }
        public override void AdditionalStats()
        {
            Console.WriteLine($"Sale number: {SalesNumber}");
            Console.WriteLine($"Benefit: {GetBenefitCostForPtEmp(75)} and Benefit level: {BenefitPackage.BenefitPackageLevel.None}");
        }
    }
}
