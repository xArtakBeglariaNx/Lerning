using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_55_LambdaExpression_LambdaExpressionsMultipleParams
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleMath m = new SimpleMath();
            m.SetMathHandler((msg, result) => 
            { Console.WriteLine("Message: {0}, Reseult: {1}", msg, result); });
            m.Add(10, 10);
            SimpleDelegate.VerySimpleDelegate sD = new SimpleDelegate.VerySimpleDelegate(() => { return "Enjoy your string"; });
            Console.WriteLine(sD());
            Console.ReadLine();
        }
    }
}
