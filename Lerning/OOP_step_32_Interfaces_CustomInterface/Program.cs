using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_32_Interfaces_CustomInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Fun with interfaces =====\n");

            Hexagon hex = new Hexagon("Andy");
            hex.Draw();
            Console.WriteLine("{0} have a {1} Points\n", nameof(Hexagon), hex.Points);

            Triangle trn = new Triangle("Annet");
            trn.Draw();
            Console.WriteLine($"[{trn.GetType().Name}] have a = {trn.Points} points\n");

            Hexagon hex2 = new Hexagon("Peter");
            IPointy itfPt2 = hex2 as IPointy;
            if (hex2 is IPointy)
            {
                Console.WriteLine("Hey bro you have a points in your shape");
                if (itfPt2 != null)
                {
                    hex2.Draw();
                    Console.WriteLine("\n===================");
                }
            }            
            else
            {
                Console.WriteLine("OOOPs {0} not a have this {1} interface", hex2.GetType().Name, itfPt2.GetType().Name);
            }

            Shape[] myShapes = {new Circle(), new Hexagon("Timmy"), new Circle("Den"), new Triangle("Cony"), new ThreeDCircle()};
            IPointy firstPointyItem = FindFirstPoint(myShapes);
            for (int i = 0; i < myShapes.Length; i++)
            {
                if (myShapes[i] is IDraw3D)
                {
                    DrawingIn3D((IDraw3D)myShapes[i]);
                }
                if (myShapes[i] is IPointy ip)
                {
                    Console.WriteLine($"\n**************\n->-> {myShapes.GetValue(i)} have a {ip.Points} Points\n**************");
                }
                else
                {
                    Console.WriteLine($"\n**************\n{myShapes.GetValue(i)} have't Points\n**************");
                }
            }

            IPointy[] myPointyObjects = { new Triangle(), new Knife(), new Fork(), new PithcFork(), new Hexagon() };
            Console.WriteLine("My objects:  ");
            foreach (IPointy i in myPointyObjects) { Console.WriteLine($" -> {i.GetType().Name} has {i.Points} points"); }

            Console.ReadLine();
        }
        static void DrawingIn3D(IDraw3D itf3D)
        {
            itf3D.Draw3D();
            Console.WriteLine("-> Drawing IDraw3D compability type\n");
        }

        static IPointy FindFirstPoint(Shape[] shapes)
        {
            foreach (Shape s in shapes)
            {
                if (s is IPointy ip)
                {
                    Console.WriteLine($"This item: {s.GetType().Name} ({s.PetName})  has {ip.Points} points\n");
                    return ip;
                }
            }
            return null;
        }
    }
}
