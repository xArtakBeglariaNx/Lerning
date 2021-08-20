using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace OOP_step_82_SystemReflection_LateBindingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Late Binding ===\n");

            Assembly a = null;

            try
            {
                a = Assembly.Load("OOP_step_74_ClassLibrary_CarLibrary");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"{ex.Message}");
                return;
            }
            if (a != null)
            {
                CreateUsingLateBinding(a);
            }
        }

        static void CreateUsingLateBinding(Assembly asm)
        {
            try
            {
                Type miniVan = asm.GetType("OOP_step_74_ClassLibrary_CarLibrary.MiniVan");
                object objMiniV = Activator.CreateInstance(miniVan);
                Console.WriteLine($"Created a {objMiniV} using late binding");
                MethodInfo mi = miniVan.GetMethod("TurboBoost");
                mi.Invoke(objMiniV, null);

                Type sport = asm.GetType("OOP_step_74_ClassLibrary_CarLibrary.SportCars");
                object objSport = Activator.CreateInstance(sport);
                Console.WriteLine($"Created a {objSport} using late binding");
                MethodInfo miS = sport.GetMethod("TurnOnRadio");
                miS.Invoke(objSport, new object[] { true, 2 });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            Console.ReadLine();
        }

        //static void CreateusingLateBindingWhisDynamic(Assembly asm)
        //{
        //    try
        //    {
        //        Type miniVan = asm.GetType("OOP_step_74_ClassLibrary_CarLibrary.MiniVan");
        //        dynamic object objMiniV = Activator.CreateInstance(miniVan);
        //        objMiniV.TurboBoost();

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //}
    }
}
