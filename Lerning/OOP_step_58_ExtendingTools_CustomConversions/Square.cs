using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_58_ExtendingTools_CustomConversions
{
    public struct Square
    {
        public int Lenght { get; set; }

        public Square(int l) : this()
        {
            Lenght = l;
        }

        public void Draw()
        {
            for (int i = 0; i < Lenght; i++)
            {
                for (int j = 0; j < Lenght; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }        

        public override string ToString() => $"Lenght = {Lenght}";

        public static explicit operator Square(Reactangle r)
        {
            Square s = new Square { Lenght = r.Heigth };
            return s;
        }
        public static explicit operator Square(int sideLenght)
        {
            Square s = new Square { Lenght = sideLenght };
            return s;
        }
        public static explicit operator int (Square s) => s.Lenght;
    }
}
