using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_23_DetailsInharitance_Employees
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
    }
}
