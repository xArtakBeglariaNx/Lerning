using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_21_ConstData
{
    class MyMathClass
    {
        public const double PI = 3.14;
    }
    class MyMathClassReadonly
    {
        public readonly double PI;
        public static readonly double PI1;
        public MyMathClassReadonly()
        {
            PI = 3.14;            
        }

        static MyMathClassReadonly()
        {
            PI1 = 3.14;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Fun with Const data =====");

            Console.WriteLine(MyMathClass.PI);

            LocalConstStringVariable();

            MyMathClassReadonly myMathClassReadonly = new MyMathClassReadonly();
            Console.WriteLine(myMathClassReadonly.PI);
            Console.WriteLine(MyMathClassReadonly.PI1);

            Console.ReadLine();
        }

        static void LocalConstStringVariable()
        {
            const string fixString = "Fixed string";
            Console.WriteLine(fixString);
            //fixString = "home" --- константам прсваиваются значения на этапе объявления
        }

    }
}
