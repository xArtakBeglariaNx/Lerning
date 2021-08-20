using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace OOP_step_92_DynamicTypes_LateBindingWithDynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Late binding with dynamic ===");

            Console.WriteLine("Reflection method:");
            AddWithReflection();
            Console.WriteLine("Dynamic method:");
            AddWithDynamic();

            Console.ReadLine();
        }

        private static void AddWithReflection()
        {
            Assembly asm = Assembly.Load("OOP_step_92_DynamicTypes_MathLibrary");

            try
            {
                Type math = asm.GetType("OOP_step_92_DynamicTypes_MathLibrary.SimpleMath");
                object objMath = Activator.CreateInstance(math);
                MethodInfo mi = math.GetMethod("Add");

                object[] args = { 11, 27 };
                Console.WriteLine("Result is: {0}", mi.Invoke(objMath, args));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void AddWithDynamic()
        {
            Assembly asm = Assembly.Load("OOP_step_92_DynamicTypes_MathLibrary");
            try
            {
                Type math = asm.GetType("OOP_step_92_DynamicTypes_MathLibrary.SimpleMath");
                dynamic objMath = Activator.CreateInstance(math);
                Console.WriteLine($"Result (with dynamic Keyword) is: {objMath.Add(11, 27)}");
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
