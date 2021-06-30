using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Encapsulation_EmployeeApp_step_18
{
    partial class Employee
    {
        
        public void GiveBonus(float amount)
        {
            Pay += amount;
        }

        public void DisplayStats()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"EmployeeID: {ID}");
            Console.WriteLine($"Pay: {Pay}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"SocialNumber: {EmpSocialSerialNumber}\n");
            //Console.WriteLine($"Pay with Bonus: {GiveBonus()}");
        }

        //public string GetName()
        //{
        //    return empName;
        //}

        //public void SetName(string name)
        //{
        //    if (name.Length > 15)
        //        Console.WriteLine($"Error Employee name exceed 15 characters!");
        //    else
        //        empName = name;
        //}

        public string Name
        {
            get { return empName; }
            set
            {
                if (value.Length > 15)
                    Console.WriteLine("Error! Employee name exceed 15 characters");
                else
                    empName = value;
            }

        }

        public int ID
        {
            get { return empID; }
            set { empID = value; }
        }

        public float Pay
        {
            get { return currPay; }
            set { currPay = value; }
        }

        public int Age { get => empAge; set => empAge = value; }
        public string EmpSocialSerialNumber { get => empSSN;}
    }
}
