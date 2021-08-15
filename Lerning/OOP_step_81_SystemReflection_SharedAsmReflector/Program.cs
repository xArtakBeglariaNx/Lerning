using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace OOP_step_81_SystemReflection_SharedAsmReflector
{
    class Program
    {
        private static void DisplayInfo(Assembly a)
        {
            Console.WriteLine("==== Display Info ====");

            Console.WriteLine($"Loaded from GAG: {a.GlobalAssemblyCache}");
            Console.WriteLine($"Assembly Name: {a.GetName().Name}");
            Console.WriteLine($"Assembly version: {a.GetName().Version}");
            Console.WriteLine($"Assembly Culture: {a.GetName().CultureInfo.DisplayName}");

            Type[] types = a.GetTypes();
            var publicEnum = from pe in types where pe.IsEnum && pe.IsPublic select pe;

            foreach (var pE in publicEnum)
            {
                Console.WriteLine(pE);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=== The Shared Asm Reflector ===");

            string displayName = null;
            displayName = "System.Windows.Forms," +
              "Version=4.0.0.0," +
              "PublicKeyToken=b77a5c561934e089," +
              @"Culture=""";
            Assembly asm = Assembly.Load(displayName);
            DisplayInfo(asm);
            Console.WriteLine("Done!");
            Console.ReadLine();
        }
    }
}
