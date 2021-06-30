using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_47_Delegate_GenerinDelegat
{
    class Program
    {
        public delegate void MyGenericDelegate<T>(T arg);
        static void Main(string[] args)
        {
            Console.WriteLine("Fun with Generic Delegate\n");
            MyGenericDelegate<string> strDelegate = new MyGenericDelegate<string>(StringTarget);
            strDelegate("Some string data");

            MyGenericDelegate<int> intDelegate = new MyGenericDelegate<int>(IntTarget);
            intDelegate(25);
            Console.ReadLine();
        }

        private static void IntTarget(int arg)
        {
            Console.WriteLine($"\n++arg is : {++arg}");
        }

        private static void StringTarget(string arg)
        {
            Console.WriteLine($"arg in uppercase: {arg.ToUpper()} & arg lengh: {arg.Length}");
        }
    }
}
