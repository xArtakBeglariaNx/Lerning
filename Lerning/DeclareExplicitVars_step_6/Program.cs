using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclareExplicitVars_step_6
{
    class Program
    {
        static void Main(string[] args)
        {
            DeclareExplicitVars();
            Console.WriteLine("------------------------");
            LinqQueryOverInts();
            Console.ReadLine();
        }

        static void DeclareExplicitVars()
        {
            #region Неявланя типизация локальных переменных
            var myInt = 5;   //пример явной типизации выглядел бы так : int myInt = 5
            var myBool = false;  //пример явной типизации выглядел бы так : bool myBool = false
            var myString = "Hi, my dear friend....";   //пример явной типизации выглядел бы так : string myString = "Hi, my dear friend...."

            Console.WriteLine("myInt is a: {0} == {1}", myInt, myInt.GetType().Name);
            Console.WriteLine("myBool is a: {0} == {1}", myBool, myBool.GetType().Name);
            Console.WriteLine("myString is a: ''{0}'' == {1}", myString, myString.GetType().Name);
            #endregion
        }
        
        static void LinqQueryOverInts()
        {
            int[] numbers = { 10, 20, 30, 5, 7, 4 };

            // Linq запрос
            var subset = from i in numbers where i < 10 select i;

            Console.Write("Values in subset:  ");

            foreach (var i in subset)
            {
                Console.Write("{0},", i);
            }
            Console.WriteLine();

            Console.WriteLine($"subset is a: {subset} = {subset.GetType().Name}");
            Console.WriteLine("subset is defined in: {0}", subset.GetType().Namespace);
        }
    }
}
