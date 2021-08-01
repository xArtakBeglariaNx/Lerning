using System;
using MyShapes;
using OOP_step_73_ClassLibrary_CustomNameSpaces.My3DShapes;
using The3DCircle = OOP_step_73_ClassLibrary_CustomNameSpaces.My3DShapes.Circle; //псевдоним
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_73_ClassLibrary_CustomNameSpaces
{
    class Program
    {
        static void Main(string[] args)
        {
            MyShapes.Hexagon h = new MyShapes.Hexagon();
            MyShapes.Circle c = new MyShapes.Circle();
            MyShapes.Square s = new MyShapes.Square();
            My3DShapes.Hexagon hex = new My3DShapes.Hexagon();
            The3DCircle c2 = new The3DCircle(); //My3DShapes.Circle с использованием псевдонима
        }
    }
}
