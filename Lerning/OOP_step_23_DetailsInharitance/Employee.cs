using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_23_DetailsInharitance_Employees
{
    partial class Employee
    {
        
        public void GiveBonus(float amount)
        {
            Pay += amount;            
            Console.WriteLine($"Pay with bonus: {Pay}\n==============================");
        }

        public void DisplayStats()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"EmployeeID: {ID}");
            Console.WriteLine($"Pay: {Pay}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"SocialNumber: {EmpSocialSerialNumber}");            
        }

        public class BenefitPackage
        {
            public enum BenefitPackageLevel
            {
                Standart, Gold, Platinum
            }
            public double ComputePayDeducation()
            {
                return 125.0;
            }
        }

        protected BenefitPackage empBenefits = new BenefitPackage();

        public double GetbenefitCost()
        {
            return empBenefits.ComputePayDeducation();
        }

        public BenefitPackage Benefits
        {
            get => empBenefits;
            set => empBenefits = value;
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
