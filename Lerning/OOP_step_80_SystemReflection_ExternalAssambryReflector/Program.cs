using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace OOP_step_80_SystemReflection_ExternalAssambryReflector
{
    class Program
    {
        static void DisplayTypesInAsm(Assembly asm)
        {
            Console.WriteLine("==== Types in Assambry ====");
            Console.WriteLine("-> {0}", asm.FullName);

            Type[] types = asm.GetTypes();

            foreach(Type t in types)
                Console.WriteLine("Type: {0}", t);

            Console.WriteLine("");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("==== External Assembly Reflector ====");
            
            do
            {
                string asmName = "";
                Assembly asm = null;

                Console.WriteLine("\nEnter assembly evaluate");
                Console.Write("or enter Q to quit:");

                asmName = Console.ReadLine();

                if (asmName.Equals("Q", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                try
                {
                    asm = Assembly.LoadFrom(asmName);
                    DisplayTypesInAsm(asm);
                }
                catch (Exception)
                {
                    Console.WriteLine("Can't find this assembly");
                }
            } while (true);
            Console.ReadLine();
        }
    }
}
