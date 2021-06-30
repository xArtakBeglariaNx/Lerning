using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_23_DetailsInharitance_Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==== The Employee Hierarchy ====\n");
            SalesPerson tomas = new SalesPerson("Tomas", 37, 56, 35000, "22-33-432", 522);
            double costSalePerson = tomas.GetbenefitCost();
            Employee.BenefitPackage.BenefitPackageLevel packageLevel1 = Employee.BenefitPackage.BenefitPackageLevel.Platinum;
            tomas.DisplayStats();
            Console.WriteLine($"BenefitCost: {costSalePerson} and BenefitLevel: {packageLevel1}");
            tomas.GiveBonus(13000);

            SalesPerson tomasOld = new SalesPerson();
            tomasOld.DisplayStats();
            tomasOld.GiveBonus(3000);

            Manager tim = new Manager("Tim", 23, 246, 28000, 23);
            Employee.BenefitPackage.BenefitPackageLevel benefitLevel = Employee.BenefitPackage.BenefitPackageLevel.Gold;
            double cost = tim.GetbenefitCost();            
            tim.DisplayStats();
            Console.WriteLine($"Benefit cost: {cost} and BenefitLevel: {benefitLevel}");
            tim.GiveBonus(5000);

            Manager timNew = new Manager();
            timNew.DisplayStats();
            timNew.GiveBonus(2000);

            PTSalesPerson pT = new PTSalesPerson();
            pT.DisplayStats();
            pT.GiveBonus(2500);
            Console.ReadLine();
        }
    }
}
