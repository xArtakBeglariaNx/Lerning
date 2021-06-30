using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_26_RulesOfCastingClasses_Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            CastingExamples();
            Using_As();
            Console.ReadLine();
        }

        static void CastingExamples()
        {
            object frank = new Manager("Frank", 35, 34, 22500, 300);
            GivePromotion((Manager)frank);
            TakeOutPromotion(nameof(frank) + " have hash code" + frank.GetHashCode());
            Hexagon hex;
            try
            {
                hex = (Hexagon)frank;
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine();
            }

            Employee moonUnit = new Manager("MoonUnit", 180, 642, 33_000, 600);
            GivePromotion(moonUnit);
            SwitchWithIsExample(moonUnit);

            SalesPerson jason = new PTSalesPerson("Jason", 333, 25, 25_000, "335-225-124", 135);
            GivePromotion(jason);
            SwitchWithIsExample(jason);

            Employee jill = new PTSalesPerson("Jill", 223, 35, 33_000, "325-254", 225);
            GivePromotion(jill);
            SwitchWithIsExample(jill);

            SalesPerson sonya = new SalesPerson("Sonya Blade", 666, 666, 111_111, "111-111-111", 1_111);
            sonya.DisplayStats();
            GivePromotion(sonya);
            SwitchWithIsExample(sonya);

            Intern pony = new Intern();            
            SwitchWithIsExample(pony);
        }

        static void GivePromotion(Employee emp)
        {
            Console.WriteLine("\n============================\n{0} was promoted", emp.Name);
            if (emp is SalesPerson s)
            {
                Console.WriteLine($"{emp.Name} made {s.SalesNumber} sale(s)");
            }
            if (emp is Manager m)
            {
                Console.WriteLine($"{emp.Name} have {m.StockOptions} stock options");
            }
            Console.WriteLine("\n============================");
        }

        static void TakeOutPromotion(object x)
        {
            Console.WriteLine("{0} & take out promotion", x);
        }

        static void Using_As()
        {
            object[] things = new object[4];
            things[0] = new Hexagon();
            things[1] = false;
            things[2] = new Manager();
            things[3] = "Last thing";

            foreach (object item in things)
            {
                Hexagon h = item as Hexagon;
                if (h == null)
                {
                    Console.WriteLine("Item is not a Hexagon");
                }
                else
                {
                    h.Draw();
                }

            }
        }

        static void SwitchWithIsExample(Employee emp)
        {
            Console.WriteLine("\n[][][][][][][][][][][][][][][]\n{0} was promoted", emp.Name);
            switch (emp)
            {
                case SalesPerson s:
                    Console.WriteLine($"{s.Name} made {s.SalesNumber} sale(s). You can more! i knew it");
                    break;
                case Manager m:
                    Console.WriteLine($"{m.Name} have {m.StockOptions} stock options. You can more! i knew it");
                    break;
                case Intern _:
                    Console.WriteLine("Not a off employee");
                    break;
                case null:
                    Console.WriteLine("This is null: fix it!!!");
                    break;
            }

            switch (emp)
            {
                case SalesPerson s when s.SalesNumber > 150:
                    Console.WriteLine($"{s.Name} made {s.SalesNumber} sale(s). Very nice result. Aplodise!!!");
                    break;
                case Manager m when m.StockOptions > 500:
                    Console.WriteLine($"{m.Name} have {m.StockOptions} stock options. Ohhhhh you are god. Aplodise!!!");
                    break;
            }
            Console.WriteLine("\n[][][][][][][][][][][][][][][]");
        }
    }
}
