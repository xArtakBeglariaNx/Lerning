using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_43_Generics_GenericPoint
{
    internal static class GenericMethods
    {
        internal static void DisplyaValueType<T>(T x)
        {
            Console.WriteLine($"{typeof(T)} from {typeof(T).BaseType}");
        }
    }
}
