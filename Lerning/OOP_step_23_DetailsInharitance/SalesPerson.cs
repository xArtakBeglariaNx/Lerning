using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_23_DetailsInharitance_Employees
{
    class SalesPerson : Employee
    {        
        public SalesPerson() { }
        public SalesPerson(string fullName, int id, int age, float currPay, string ssn, int numbOfSales) 
            : base (fullName, id, age, currPay, ssn)
        {
            SalesNumber = numbOfSales;
        }
        public int SalesNumber { get; set; }
    }
}
