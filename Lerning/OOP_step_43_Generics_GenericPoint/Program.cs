using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_43_Generics_GenericPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Point<int> point = new Point<int>(25, 13);
            Console.WriteLine(point);
            point.ResetPoint();
            Console.WriteLine("After reset values:");
            Console.WriteLine(point);
            Console.WriteLine("What value types has in struct/class:\n");
            GenericMethods.DisplyaValueType(point);

            MyGenericClass<object> my = new MyGenericClass<object>();
            if (my != null)
            {
                Console.WriteLine(my);
            }
            else
            {
                Console.WriteLine($"{nameof(my)} is null or empty");
            }

            MyGenericClassHardMode<Draw> mode = new MyGenericClassHardMode<Draw>();
            if (mode != null)
            {
                Console.WriteLine($"{mode}");
            }
            else
            {
                Console.WriteLine($"{nameof(mode)} is null");
            }
            Console.ReadLine();
        }
    }
}
