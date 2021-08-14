using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace OOP_step_79_SystemReflection_MyTypeViewer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Welcom to MyTypeViewer ===\n");

            string typeName = "";
            do
            {
                Console.WriteLine("\nEnter a type name to evaluate");
                Console.Write("or enter Q to quit:");
                typeName = Console.ReadLine();
                if (typeName.Equals("Q", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                try
                {
                    Type t = Type.GetType(typeName);
                    Console.WriteLine("");
                    ListVariousStats(t);
                    ListMethods(t);
                    //ListMethodsLINQ(t);
                    ListFields(t);
                    ListProperties(t);
                    ListInterfaces(t);
                }
                catch (Exception)
                {
                    Console.WriteLine("Sorry, Cant find type");
                }
            } while (true);
        }

        #region Reflection Methods
        static void ListMethods(Type t)
        {
            int count = 1;
            Console.WriteLine("==== Methods =====\n");
            MethodInfo[] mi = t.GetMethods();            
            foreach (var m in mi)
            {
                string retVal = m.ReturnType.FullName;
                string paramInfo = "( ";

                foreach (ParameterInfo pi in m.GetParameters())
                {
                    paramInfo += string.Format("{0}, {1}", pi.ParameterType, pi.Name);
                }

                paramInfo += " )";

                Console.WriteLine($"{count++} -> {retVal} -- {m.Name} -- {paramInfo}");
            }
            Console.WriteLine();
        }

        //static void ListMethodsLINQ(Type t)
        //{
        //    int count = 1;
        //    Console.WriteLine("==== Methods LINQ =====\n");
        //    var methodInfo = from m in t.GetMethods() select m.Name;
        //    var methodInfoAt = from m in t.GetMethods() select m.Attributes;

        //    foreach (var n in methodInfo)
        //    {
        //        foreach (var m in methodInfoAt)
        //        {
        //            Console.WriteLine("{0} -> {1} -- {2}", count++, n, m);
        //        }
        //    }
        //    Console.WriteLine();
        //}

        #endregion

        #region Reflection Fields & Properties

        static void ListFields(Type t)
        {
            int count = 1;
            Console.WriteLine("==== Fields ====\n");
            var listFields = from f in t.GetFields() select f.Name;
            foreach (var lF in listFields)
            {
                Console.WriteLine("(+_+) -> {0}({1}) -- {2}", count++, nameof(lF), lF);
            }
            Console.WriteLine();
        }

        static void ListProperties(Type t)
        {
            int count = 1;
            Console.WriteLine("===== Properties =====\n");
            var listProperties = from p in t.GetProperties() select p.Name;
            var listPropertiesType = from p in t.GetProperties() select p.PropertyType;
            foreach (var pN in listProperties)
            {
                foreach (var pT in listPropertiesType)
                {
                    Console.WriteLine($"(*._.*) {count++} --> ({nameof(pN)}) : {pN} -- ({nameof(pT)}) : {pT}");
                }
            }
            Console.WriteLine();
        }
        #endregion

        #region Reflection Interfaces

        static void ListInterfaces(Type t)
        {
            int count = 1;
            Console.WriteLine("==== Interfaces ====\n");

            var listInterfaces = from i in t.GetInterfaces() select i.Name;
            foreach (var lI in listInterfaces)
            {
                Console.WriteLine($"{count++} --> {nameof(lI)} -- {lI}");
            }
            Console.WriteLine();
        }

        #endregion

        #region Reflection more Stats

        static void ListVariousStats(Type t)
        {
            Console.WriteLine("=== Various Statistics ===\n");

            Console.WriteLine($"Base class is: {t.BaseType}");
            Console.WriteLine($"Is type abstract ? {t.IsAbstract}");
            Console.WriteLine($"Is type sealed ? {t.IsSealed}");
            Console.WriteLine($"Is type generic ? {t.IsGenericTypeDefinition}");
            Console.WriteLine($"Is type class ? {t.IsClass}");
            Console.WriteLine();
        }

        #endregion
    }
}
