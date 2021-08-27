using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace OOP_step_95_ProcessAppDomain_DefaultAppDomainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Fun with default Application Domain ===\n");
            DisplayADStats();
            ListAllAssembliesInAppDomain();
            Console.ReadLine();
        }

        private static void DisplayADStats()
        {
            AppDomain defaultAD = AppDomain.CurrentDomain;

            Console.WriteLine($"Name of this domain: {defaultAD.FriendlyName}");
            Console.WriteLine($"ID of domain in this process: {defaultAD.Id}");
            Console.WriteLine($"Is this a default domain? {defaultAD.IsDefaultAppDomain()}");
            Console.WriteLine($"Base directory in this domain: {defaultAD.BaseDirectory}");
            Console.WriteLine();
        }

        static void ListAllAssembliesInAppDomain()
        {
            AppDomain defaultAD = AppDomain.CurrentDomain;

            //Assembly[] loadedAssemblies = defaultAD.GetAssemblies();
            var loadedAssemblies = from a in defaultAD.GetAssemblies() orderby a.GetName().Name select a;

            Console.WriteLine($"Here are the assemblies loaded in {defaultAD.FriendlyName}");
            foreach (Assembly a in loadedAssemblies)
            {
                Console.WriteLine($"=====================\n-> Name: {a.GetName().Name}");
                Console.WriteLine($"-> Version: {a.GetName().Version}\n=====================");
                InitDAD();
            }
            Console.WriteLine();
        }

        private static void InitDAD()
        {
            AppDomain defaultAD = AppDomain.CurrentDomain;
            defaultAD.AssemblyLoad += (o, s) => Console.WriteLine($"=====================\n{s.LoadedAssembly.GetName().Name} has been loaded!\n=====================");
        }
    }
}
