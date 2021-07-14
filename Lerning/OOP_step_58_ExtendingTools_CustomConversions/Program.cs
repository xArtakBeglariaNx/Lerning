using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_58_ExtendingTools_CustomConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Fun with Conversions =====\n");

            Reactangle r = new Reactangle { Width = 15, Heigth = 4 };
            Console.WriteLine(r.ToString());
            r.Draw();

            Console.WriteLine();

            Square s = (Square)r;
            Console.WriteLine(s.ToString());
            s.Draw();

            Console.WriteLine();

            SquareDraw((Square)r);

            Console.WriteLine();

            //Conversion int to Square
            Square sq2 = (Square)90;
            Console.WriteLine($"sq2 lenght: {sq2}");

            //Conversion Square to int
            int side = (int)sq2;
            Console.WriteLine($"side lenght of sq2: {side}");

            Console.WriteLine();

            Square s3 = new Square { Lenght = 83};
            Reactangle rect2 = s3;
            Console.WriteLine(rect2.ToString());

            Square s4 = new Square { Lenght = 7};
            Reactangle rect3 = (Reactangle)s4;
            Console.WriteLine(rect3.ToString());

            Console.ReadLine();
        }

        static void SquareDraw(Square sq)
        {
            Console.WriteLine(sq.ToString());
            sq.Draw();
        }
    }
}
