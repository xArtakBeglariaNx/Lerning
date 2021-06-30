using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_35_Interfaces_MuIntercesHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fun with multiplier interface hierarchy\n");

            Rectange rectange = new Rectange();
            ((IDrawable)rectange).Draw();
            ((IPrintable)rectange).Draw();
            rectange.Print();
            rectange.GetNumberOfSides();

            Console.ReadLine();
        }
    }
}
