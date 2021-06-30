using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_20_ObjectInitializer
{
    enum PointColor
    { LightBlue, BloodRed, Gold}
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public PointColor Color { get; set; }

        public Point(int xVal, int yVal)
        {
            X = xVal;
            Y = yVal;
            Color = PointColor.Gold;
        }
        public Point(PointColor ptColor)
        {
            Color = ptColor;
        }

        public Point() : this(PointColor.BloodRed) { }
        public void DisplayStat()
        {
            Console.WriteLine($"{nameof(X)} = {X}, {nameof(Y)} = {Y}");
            Console.WriteLine($"{nameof(Color)} = {Color}\n============================");
        }
    }
}
