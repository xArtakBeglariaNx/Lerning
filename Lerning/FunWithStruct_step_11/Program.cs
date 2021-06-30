using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithStruct_step_11
{
    class Program
    {
        struct Point
        {
            public int X;
            public int Y;

            public Point(int XPos, int YPos)
            {
                X = XPos;
                Y = YPos;
            }

            public void Inctrement()
            {
                X++;  Y++;
            }

            public void Decrement()
            {
                X--; Y--;
            }

            public void Display()
            {
                Console.WriteLine("x = {0}, y = {1}", X, Y);
            }
        }

        static void Main(string[] args)
        {
            Point myPoint;
            myPoint.X = 349;
            myPoint.Y = 76;
            myPoint.Display();
            myPoint.Inctrement();
            myPoint.Display();
            myPoint.Decrement();
            myPoint.Display();

            Point p1;

            p1 = new Point();
            p1.Display();

            Point p2;
            p2 = new Point(25,36);
            p2.Inctrement();
            p2.Display();
            Console.WriteLine("================");
            AsigmentValueTypes();
            Console.WriteLine("================");
            PointRef.ReferenceTypeAssingment();
            Console.WriteLine("================");
            Rectangle.ValueTypeContaningRefType();
            Console.ReadLine();
        }

        static void AsigmentValueTypes()
        {
            Console.WriteLine("AsigmentValueTypes: \n");
            Point p1, p2;
            p1 = new Point(10, 10);
            p2 = p1;
            p1.Display();
            p2.Display();

            p1.X = 100;
            Console.WriteLine("\n=> changed p1.X");
            p1.Display();
            p2.Display();

        }
    }

    class PointRef
    {
        public int X;
        public int Y;

        public PointRef(int XPos, int YPos)
        {
            X = XPos;
            Y = YPos;
        }

        public void Inctrement()
        {
            X++; Y++;
        }

        public void Decrement()
        {
            X--; Y--;
        }

        public void Display()
        {
            Console.WriteLine("x = {0}, y = {1}", X, Y);
        }

        public static void ReferenceTypeAssingment()
        {
            Console.WriteLine("ReferenceTypeAssingment: \n");
            PointRef p1, p2;
            p1 = new PointRef(10, 10);
            p2 = p1;
            p1.Display();
            p2.Display();

            p1.X = 100;
            Console.WriteLine("\n=> changed p1.X");
            p1.Display();
            p2.Display();
        }
    }

    class ShapeInfo
    {
        public string InfoString;
        public ShapeInfo(string info)   
        {
            InfoString = info;
        }        
    }

    struct Rectangle
    {
        public ShapeInfo RectInfo;
        public int RectTop, RectLeft, RectBottom, RectRight;
        public Rectangle(string info, int top, int left, int bottom, int right)
        {
            RectInfo = new ShapeInfo(info);
            RectTop = top; RectLeft = left;
            RectBottom = bottom; RectRight = right;
        }

        public void Display()
        {
            Console.WriteLine("String = {0}, Top = {1}, Left = {2}, Bottom = {3}, Right = {4}", RectInfo.InfoString, RectTop, RectLeft, RectBottom, RectRight);
        }

        public static void ValueTypeContaningRefType()
        {
            Console.WriteLine("=> Creating r1");
            Rectangle r1 = new Rectangle("FistRect", 10, 10, 50, 50);
            Console.WriteLine("=> Assining r2 to r1");
            Rectangle r2 = r1;
            Console.WriteLine("=> Changing values of r2");
            r2.RectInfo.InfoString = "This is new info";
            r2.RectBottom = 4444;
            Console.WriteLine("=> Display values of Rectangle variables");
            r1.Display();
            r2.Display();
        }
    }
}
