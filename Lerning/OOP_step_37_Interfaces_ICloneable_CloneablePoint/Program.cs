using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_37_Interfaces_ICloneable_CloneablePoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Fun with Objact Cloning =====\n");

            Console.WriteLine("Clone p1 and stored new Point p2");

            Console.WriteLine("Before modification: p2");
            Point p1 = new Point(50, 50, "Jane");
            Point p2 = (Point)p1.Clone();
            Console.WriteLine($"p1: {p1}\np2: {p2}\n");
            Console.WriteLine($"Changed p2.desc.PetName and p2.X");
            p2.desc.PetName = "My new Point";
            p2.X = 20;
            Console.WriteLine($"p1: {p1}\np2: {p2}");
            Console.WriteLine("====================");

            Console.WriteLine("Clone p3 and stored new Point p4");

            Point p3 = new Point(100, 100);
            Point p4 = (Point)p3.Clone();
            Console.WriteLine("Before modification: p4");
            Console.WriteLine($"p3: {p3}\np4: {p4}\n");
            p4.desc.PetName = "Hayase";
            p4.X = 32;
            Console.WriteLine($"Changed p4.desc.PetName and p4.X");
            Console.WriteLine($"p3: {p3}\np4: {p4}\n");

            Console.WriteLine("====================");
            Console.ReadLine();
        }
    }
}
