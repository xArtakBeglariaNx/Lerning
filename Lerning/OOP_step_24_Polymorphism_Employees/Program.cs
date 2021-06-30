using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_24_Polymorphism_Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager chucky = new Manager("Chucky", 23, 517, 33000, 120);
            chucky.DisplayStats();
            chucky.AdditionalStats();
            chucky.GiveBonus(5600);

            SalesPerson franchaska = new SalesPerson("Francheska", 326, 30, 35000, "23-156-45", 205);
            franchaska.DisplayStats();
            franchaska.AdditionalStats();
            franchaska.GiveBonus(800);

            PTSalesPerson pTJackson = new PTSalesPerson("Jackson", 225, 19, 20000, "22-143-20", 135);
            pTJackson.DisplayStats();
            pTJackson.AdditionalStats();
            pTJackson.GiveBonus(560);
            Console.ReadLine();
        }
    }
}
