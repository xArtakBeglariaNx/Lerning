using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_57_ExpandingTools_OverloadedOps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Fun with Overloaded Operators =====\n");

            Point ptOne = new Point(100, 100);
            Point ptTwo = new Point(10, 10);
            Point ptThree = new Point(90, 5);
            Point ptFour = new Point(0, 500);
            Point ptFive = new Point(0, 0);
            Point ptSix = new Point(0, 0);

            //Display Points
            Console.WriteLine($"ptOne: {ptOne}");
            Console.WriteLine($"ptTwo: {ptTwo}");
            Console.WriteLine($"ptThree: {ptThree}");
            Console.WriteLine($"ptFour: {ptFour}");
            Console.WriteLine($"ptFive: {ptFive}");
            Console.WriteLine($"ptSix: {ptSix}");

            //Are get sum from two points if use operator +?
            Point biggerPoint = ptOne + 10;
            Console.WriteLine($"\nptOne + ptTwo: {ptOne + ptTwo}");
            Console.WriteLine($"ptOne + 10: {biggerPoint}");
            Console.WriteLine($"biggerPoint + 10: {biggerPoint + 10}");
            Console.WriteLine($"ptThree += ptTwo: {ptThree + ptTwo}");

            //Are get sum from two points if use operator +?
            Console.WriteLine($"++ptFive: {++ptFive}");

            //Operator == & !=
            Console.WriteLine($"ptOne==ptTwo: {ptOne==ptTwo}");
            Console.WriteLine($"ptOne!=ptTwo: {ptOne!=ptTwo}");

            //Are get subtract from two points if use operator -?
            Point lowerPoint = ptOne - 10;
            Console.WriteLine($"\nptOne + ptTwo: {ptOne - ptTwo}");
            Console.WriteLine($"ptOne 10: {lowerPoint}");
            Console.WriteLine($"ptFour -= ptThree: {ptFour -= ptThree}");

            //Are get subtract from two points if use operator -?
            Console.WriteLine($"--ptSix: {--ptSix}");

            Console.WriteLine();
            //Use Operator <, >, <=, >=
            Console.WriteLine($"ptOne: {ptOne}");
            Console.WriteLine($"ptTwo: {ptTwo}");

            Console.WriteLine($"ptOne < ptTwo: {ptOne < ptTwo}");
            Console.WriteLine($"ptOne > ptTwo: {ptOne > ptTwo}");
            Console.WriteLine($"ptOne <= ptTwo: {ptOne <= ptTwo}");
            Console.WriteLine($"ptOne >= ptTwo: {ptOne >= ptTwo}");

            Console.ReadLine();
        }
    }
}
