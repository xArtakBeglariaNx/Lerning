using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using OOP_step_84_SystemReflection_AttributedCarLibrary;

namespace OOP_step_85_SystemReflection_VehicleDescriptionAttributeReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==== Value of Description Attributes ====");

            ReflectOnAttributesUsingEarlyBinding();
            Console.ReadLine();
        }

        private static void ReflectOnAttributesUsingEarlyBinding()
        {
            Type t = typeof(Winnebago);
            object[] customAtts = t.GetCustomAttributes(false);
            foreach (VehicleDescriptionAttribute v in customAtts)
            {
                Console.WriteLine("-> \n", v.Description);
            }
            Console.WriteLine();
        }
    }
}
