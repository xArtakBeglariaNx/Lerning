using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Encapsulation_EmployeeApp_step_18
{
    partial class Employee
    {
        private string empName;
        private int empID;
        private float currPay;
        private int empAge;
        private string empSSN;

        public Employee() { }
        public Employee(string name, int id, float pay)
            : this(name, id, 18, pay, "*****") { }
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
