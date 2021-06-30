using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.DateTime;


namespace OOP_SimpleUtilityClass_step_17
{
    static class TimeUtilClass
    {
        //  public static void PrintTime()
        //  {
        //      Console.WriteLine(DateTime.Now.ToShortTimeString());
        //  }
        //  public static void PrintDate()
        //  {
        //      Console.WriteLine(DateTime.Today.ToShortDateString());
        //  }

        public static void PrintTime() => Console.WriteLine($"{Now.ToShortTimeString()}\n");
        
        public static void PrintDate() => Console.WriteLine(Today.ToShortDateString());
    }
}
