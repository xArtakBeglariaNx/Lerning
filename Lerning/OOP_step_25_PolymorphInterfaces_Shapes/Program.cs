using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_25_PolymorphInterfaces_Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle("Cindy");
            circle.Draw();

            Hexagon hexagon = new Hexagon("Dayana");
            hexagon.Draw();

            Shape[] myShapes = { new Hexagon(), new Circle("Tom"), new Circle() { PetName = "Tim" }, new Hexagon("Bony"), new Hexagon("Clide"), new Circle() };
            foreach (Shape s in myShapes)
            {
                s.Draw();
            }

            ThreeDCircle o = new ThreeDCircle() { PetName = "Layla"};
            o.Draw();
            ((Circle)o).Draw();

            Console.ReadLine();
        }
    }
}
