using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_91_DynamicTypes_DynamicKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Dynamic Keyword ===");

            UseObjectVariable();
            ChangeDynamicDataType();
            InvokeMembersOnDynamicData();

            VeryDynamicClass veryDynamic = new VeryDynamicClass();
            dynamic exampleString = "Hi";
            dynamic exampleInt = 5;
            veryDynamic.DynamicMethod(exampleInt);

            Console.ReadLine();
        }

        static void ImplicitlyTypedVariable()
        {
            var a = new List<int> { 90 };
            //a = "Hello";
        }

        static void UseObjectVariable()
        {
            object s1 = "Getting";
            var s2 = "From";
            dynamic s3 = "Miniapolis";

            Console.WriteLine($"s1 is a get typeof : {s1.GetType()}");
            Console.WriteLine($"s1 is a get typeof : {s2.GetType()}");
            Console.WriteLine($"s1 is a get typeof : {s3.GetType()}");
        }

        static void ChangeDynamicDataType()
        {
            dynamic t = "Hello";
            Console.WriteLine($"dynamic t is of type: {t.GetType()}");

            t = false;
            Console.WriteLine($"dynamic t is of type: {t.GetType()}");

            t = new List<int>();
            Console.WriteLine($"dynamic t is of type: {t.GetType()}");

        }

        static void InvokeMembersOnDynamicData()
        {
            dynamic textData1 = "Hello";
            try
            {
                Console.WriteLine(textData1.ToUpper());
                //компилятор не выдает ошибки, однако во время вызова метода выедется ошибка
                Console.WriteLine(textData1.toupper());
                Console.WriteLine(textData1.Foo(10, "ee", DateTime.Now));
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    class VeryDynamicClass
    {
        private static dynamic myDynamicField;

        public dynamic DynamicProperty { get; set; }

        public VeryDynamicClass() { }
        public VeryDynamicClass(dynamic property, dynamic field)
        {
            DynamicProperty = property;
            myDynamicField = field;
        }

        public dynamic DynamicMethod(dynamic dynamicParam)
        {
            dynamic dynamicLocalVar = "Local Varieble";
            int myInt = 10;
            if (dynamicParam is int)
            {
                Console.WriteLine($"{nameof(dynamicParam)} = methodParams is int");
                return dynamicLocalVar;
            }
            else
            {
                Console.WriteLine($"{nameof(dynamicParam)} = methodParams is !int");
                return myInt;
            }
        }
    }
}
