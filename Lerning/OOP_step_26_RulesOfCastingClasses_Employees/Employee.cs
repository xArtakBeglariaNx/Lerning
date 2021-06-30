using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_26_RulesOfCastingClasses_Employees
{
    abstract partial class Employee
    {

        public virtual void GiveBonus(float amount)
        {
            Pay += amount;
            Console.WriteLine($"Pay with bonus: {Pay}\n==============================");
        }

        public virtual void DisplayStats()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"EmployeeID: {ID}");
            Console.WriteLine($"Pay: {Pay}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"SocialNumber: {EmpSocialSerialNumber}");
        }

        #region Вложенный класс BenefitPackage в базовый Employee/ отношение меджу классами не "является" (менеджер(manager) ЯВЛЯЕТСЯ сотрудников) а "имеет" (сотрудник(Employee) ИМЕЕТ льготы и тд)

        public class BenefitPackage
        {
            public enum BenefitPackageLevel
            {
                None, Standart, Gold, Platinum
            }
            public double ComputePayDeducation()
            {
                return 125.0;
            }
        }

        protected BenefitPackage empBenefits = new BenefitPackage();

        public BenefitPackage Benefits
        {
            get => empBenefits;
            set => empBenefits = value;
        }
        #endregion

        public double GetBenefitCostForPtEmp(double cost)
        {
            return cost;
        }

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
        public string EmpSocialSerialNumber { get => empSSN; }
    }
}
