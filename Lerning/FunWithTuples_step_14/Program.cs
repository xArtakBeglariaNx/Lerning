using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithTuples_step_14
{
    class Program
    {
        static void Main(string[] args)
        {
            (string, int, string) values = ("a", 5, "c");
            var values1 = ("a", 5, "c");
            Console.WriteLine($"First item: {values.Item1}");
            Console.WriteLine($"Second item: {values.Item2}");
            Console.WriteLine($"Third item: {values.Item3}\n");

            (string FirstLetter, int TheNumber, string SecondLetter) values3 = ("a", 5, "c");
            var values4 = (FirstLetter: "a", TheNumber: 5, SecondLetter: "c");
            Console.WriteLine($"FirstLetter: {values3.FirstLetter}");
            Console.WriteLine($"TheNumber: {values3.TheNumber}");
            Console.WriteLine($"SecondLetter: {values3.SecondLetter}\n");

            Console.WriteLine("Inferred Tuple Names");
            var foo = new { Prop1 = "first", Prop2 = "second" };
            var bar = (foo.Prop1, foo.Prop2);
            Console.WriteLine($"{bar.Prop1}:{bar.Prop2}");

            var sample = FillTheseValues();
            Console.WriteLine($"Int : {sample.a}");
            Console.WriteLine($"String : {sample.b}");
            Console.WriteLine($"Bool : {sample.c}\n");
            string nominalName = "";
            var fName = SplitName(nominalName);
            Console.WriteLine($"{fName.first}   ::  {fName.middle}  ::  {fName.last}");

            var (first, _, last) = SplitName("");
            Console.WriteLine($"{first} ::  {last}\n");

            Point p = new Point(7, 2);
            var pointValues = p.Deconstruct();
            Console.WriteLine($"X is {pointValues.PosX} :::: Y is {pointValues.PosY}");
            Console.ReadLine();
        }

        static void FillTheseValues(out int a, out string b, out bool c)
        {
            a = 5;
            b = "Enjoy your string";
            c = true;
        }

        static (int a, string b, bool c) FillTheseValues()
        {
            return (9, "Enjoy your string", true);
        }

        static (string first, string middle, string last) SplitName(string fullName)
        {
            return ("Philip", "F", "Japikse");
        }
    }

    struct Point
    {
        public int X;
        public int Y;

        public Point(int PosX, int PosY)
        {
            X = PosX;
            Y = PosY;
        }

        public (int PosX, int PosY) Deconstruct() => (X, Y);
    }
}
