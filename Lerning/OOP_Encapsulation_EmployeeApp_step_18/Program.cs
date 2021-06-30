using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Encapsulation_EmployeeApp_step_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Fun with Encapsulation");
            Employee employee = new Employee("Tomas", 456, 32, 30000, "124541");
            employee.GiveBonus(1000);
            employee.DisplayStats();
            employee.Name = "Marv";
            Console.WriteLine($"Employee is named: {employee.Name}");
            employee.DisplayStats();

            Employee joe = new Employee("Ellen", 322, 23000);
            joe.DisplayStats();
            joe.Age++;
            joe.DisplayStats();
            Console.ReadLine();
        }
    }
}
