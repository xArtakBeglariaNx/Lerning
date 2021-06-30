using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_23_DetailsInharitance_Employees
{
    partial class Employee
    {
        private string empName;
        private int empID;
        private float currPay;
        private int empAge;
        private string empSSN;

        public Employee() { }
        public Employee(string name, int id, int age, float pay)
            : this(name, id, age, pay, "*****") { }
        public Employee(string name, int id, int age, float pay, string ssn)
        {
            Name = name;
            ID = id;
            Age = age;
            Pay = pay;
            //EmpSocialSerialNumber = ssn; // так сделать нельзя т.к. переменная имеет свойство только чтение
            empSSN = ssn;
        }
    }
}
