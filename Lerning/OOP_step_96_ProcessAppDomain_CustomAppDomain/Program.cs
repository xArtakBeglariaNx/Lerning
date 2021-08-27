using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
using OOP_step_74_ClassLibrary_CarLibrary;

namespace OOP_step_96_ProcessAppDomain_CustomAppDomain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Fun with Custom AppDomain ===\n");
            AppDomain defaultAD = AppDomain.CurrentDomain;
            defaultAD.ProcessExit += (o, s) =>
            {
                Console.WriteLine("Default AD unloaded");
            };
            ListAllAssembliesInAppDomain(defaultAD);
            MakeNewAppDomain();
            Console.ReadLine();
        }

        private static void MakeNewAppDomain()
        {
            AppDomain newAD = AppDomain.CreateDomain("SecondAppDomain");
            newAD.DomainUnload += (o, s) =>
            {
                Console.WriteLine("The Second AppDomain hes been unloaded");
            };
            try
            {
                newAD.Load("OOP_step_74_ClassLibrary_CarLibrary");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            ListAllAssembliesInAppDomain(newAD);
            AppDomain.Unload(newAD);
        }

        static void ListAllAssembliesInAppDomain(AppDomain ad)
        {
            var loadedAssembiles = from a in ad.GetAssemblies() orderby a.GetName().Name select a;
            Console.WriteLine($"Here are the assemblies loaded in {ad.FriendlyName}");
            foreach (Assembly a in loadedAssembiles)
            {
                Console.WriteLine($"=====================\n-> Name: {a.GetName().Name}");
                Console.WriteLine($"-> Version: {a.GetName().Version}\n=====================");
            }
            Console.WriteLine();
        }
    }
}
