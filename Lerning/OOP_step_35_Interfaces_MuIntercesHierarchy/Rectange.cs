using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_35_Interfaces_MuIntercesHierarchy
{
    class Rectange : IShape
    {
        
        void IDrawable.Draw()
        {
            Console.WriteLine("Drawing for Drawing interface");
        }

        void IPrintable.Draw()
        {
            Console.WriteLine("Drawing for Printable interface");
        }

        public int GetNumberOfSides()
        {
            Console.WriteLine($"Sides: {4}");

            return 4;
        }

        public void Print()
        {
            Console.WriteLine("Printing ......");
        }
    }
}
