using OOP_step_41_Collections_FunWithObservableCollections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_42_Generics_CustomGenericMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Fun with Generic Method =====\n");
            int a = 10; int b = 20;
            Console.WriteLine($"Before using Swap method: {nameof(a)} = {a} <<>> {nameof(b)} = {b}");
            MyGenericMethods.Swap<int>(ref a, ref b);
            Console.WriteLine($"After using Swap method: {nameof(a)} = {a} <<>> {nameof(b)} = {b}\n\n");

            string s1 = "Greatest man - Billy Dean";
            string s2 = "Little bitty - Alan Jackson";
            Console.WriteLine($"Before using Swap method: {nameof(s1)} = {s1} <<>> {nameof(s2)} = {s2}");
            MyGenericMethods.Swap<string>(ref s1,ref s2);
            Console.WriteLine($"After using Swap method: {nameof(s1)} = {s1} <<>> {nameof(s2)} = {s2}\n\n");

            bool b1 = false;
            bool b2 = true;
            Console.WriteLine($"Before using Swap method: {nameof(b1)} = {b1} <<>> {nameof(b1)} = {b1}");
            MyGenericMethods.Swap<bool>(ref b1, ref b2);
            Console.WriteLine($"After using Swap method: {nameof(b2)} = {b2} <<>> {nameof(b2)} = {b2}\n\n");

            MyGenericMethods.DisplayBaseClass<string, int, bool>();
            
            Console.ReadLine();
        }
        #region Swap for int type
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        #endregion

        #region Swap for Person type
        static void Swap(ref Person a, ref Person b)
        {
            Person temp = a;
            a = b;
            b = temp;
        }
        #endregion        
    }
}
