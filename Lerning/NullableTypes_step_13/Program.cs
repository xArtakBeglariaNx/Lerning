using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes_step_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Fun with Nullable Data =====");
            DatabaseReader dr = new DatabaseReader();

            int? i = dr.numericValue;
            if (i.HasValue)
            {
                Console.WriteLine("Value of [i] is: {0}", i.Value);
            }
            else
            {
                Console.WriteLine("Value of [i] undefind");
            }

            bool? b = dr.boolValue;
            if (b != null)
            {
                Console.WriteLine("Value of [b] is: {0}", b.Value);
            }
            else
            {
                Console.WriteLine("Value of [b] is undefind");
            }

            int myData = dr.GetIntFromDatabase() ?? 100;

            int? myData1 = dr.GetIntFromDatabase();

            if (!myData1.HasValue)
            {
                myData1 = 100;
                Console.WriteLine("Value of [myData1] is: {0}", myData1);
            }

            Console.WriteLine("Value of [myData] is: {0}", myData);
            string[] hrya = null;
            TesterMethod(hrya);
            TesterMethodWithoutIf(hrya);
            Console.ReadLine();
        }

        /// <summary>
        /// Example with a short approach(method)
        /// </summary>
        static void LocalNulableVarieables()
        {
            int? nullableInt = 10;
            double? nullableDouble = 3.14;
            bool? nullablesBool = null;
            char? nullableChar = 'a';
            int?[] nullableArray = new int?[5];

            //string? nullableString = "oops"; - ссылочный тиип данных
        }

        /// <summary>
        /// Example with Nullable <T>
        /// </summary>
        static void localNullableVarieablesUsingNullable()
        {
            Nullable<int> nullableInt = 10;
            Nullable<double> nullableDouble = 3.14;
            Nullable<bool> nullableBool = null;
            Nullable<char> nullableChar = 'a';
            Nullable<int>[] nullableArray = new Nullable<int>[10];
        }

        static void TesterMethod(string[] args)
        {
            if (args != null)
            {
                Console.WriteLine($"Your sent me {args.Length} arguments");
            }
        }
        static void TesterMethodWithoutIf(string[] args)
        {

            Console.WriteLine($"Your sent me {args?.Length} arguments");
            Console.WriteLine($"Your sent me {args?.Length ?? 0} arguments");

        }
    }

    class DatabaseReader
    {
        public int? numericValue = null;
        public bool? boolValue = true;

        public int? GetIntFromDatabase()
        {
            return numericValue;
        }
        public bool? GetBoolFromDatabase()
        {
            return boolValue;
        }
    }
}
