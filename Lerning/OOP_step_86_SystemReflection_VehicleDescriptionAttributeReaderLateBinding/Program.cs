using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace OOP_step_86_SystemReflection_VehicleDescriptionAttributeReaderLateBinding
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==== Value of VehicleDescriptionAttribute ====");

            ReflectAttributesUsingLateBinding();
            Console.ReadLine();
        }

        private static void ReflectAttributesUsingLateBinding()
        {
            try
            {
                Assembly asm = Assembly.Load("OOP_step_84_SystemReflection_AttributedCarLibrary");
                Type vehicleDesc = asm.GetType("OOP_step_84_SystemReflection_AttributedCarLibrary.VehicleDescriptionAttribute");
                PropertyInfo propDesc = vehicleDesc.GetProperty("Description");

                Type[] types = asm.GetTypes();

                foreach (Type t in types)
                {
                    object[] objs = t.GetCustomAttributes(false);

                    foreach (object o in objs)
                    {
                        Console.WriteLine("-> {0} : {1}", t.Name, propDesc.GetValue(o, null));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
