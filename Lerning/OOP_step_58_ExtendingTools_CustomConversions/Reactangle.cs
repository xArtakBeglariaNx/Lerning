using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_58_ExtendingTools_CustomConversions
{
    public struct Reactangle
    {
        public int Width { get; set; }
        public int Heigth { get; set; }

        public Reactangle (int w, int h) : this()
        {
            Width = w;
            Heigth = h;
        }

        public void Draw()
        {
            for (int i = 0; i < Heigth; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public override string ToString() => $"Width = {Width} ; Height = {Heigth}";

        public static implicit operator Reactangle(Square s)
        {
            Reactangle r = new Reactangle
            {
                Width = s.Lenght * 2,
                Heigth = s.Lenght
            };
            return r;
        }
    }
}
