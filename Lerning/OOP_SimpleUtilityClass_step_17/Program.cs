using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_SimpleUtilityClass_step_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Fun with Static Class ====");

            TimeUtilClass.PrintTime();
            TimeUtilClass.PrintDate();

            Console.ReadLine();
        }
    }
}
