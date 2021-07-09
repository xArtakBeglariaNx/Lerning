using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_57_ExpandingTools_OverloadedOps
{
    public class Point : IComparable<Point>
    {
        public int X { get; set; }
        public int Y { get; set; }

        //Overload operation +
        public static Point operator +(Point p1, Point p2) =>
            new Point(p1.X + p2.X, p1.Y + p2.Y);
        public static Point operator +(Point p1, int change) =>
            new Point(p1.X + change, p1.Y + change);
        public static Point operator ++(Point p1) =>
            new Point(p1.X + 1, p1.Y + 1);

        //Overload operation -
        public static Point operator -(Point p1, Point p2) =>
            new Point(p1.X - p2.X, p1.Y - p2.Y);
        public static Point operator -(Point p1, int change) =>
            new Point(p1.X - change, p1.Y - change);
        public static Point operator --(Point p1) =>
            new Point(p1.X - 1, p1.Y - 1);

        public Point(int xPos, int yPos)
        {
            X = xPos;
            Y = yPos;
        }

        public override string ToString() => $"[{this.X}, {this.Y}]";

        public override bool Equals(object obj) => obj.ToString() == this.ToString();
        public override int GetHashCode() => this.ToString().GetHashCode();

        public int CompareTo(Point other)
        {
            if (this.X > other.X && this.Y > other.Y)
            {
                return 1;
            };
            if (this.X < other.X && this.Y < other.Y)
            {
                return -1;
            }
            else
                return 0;
        }

        //Now to overload operators == & !=
        public static bool operator ==(Point p1, Point p2) => p1.Equals(p2);
        public static bool operator !=(Point p1, Point p2) => p1.Equals(p2);

        //Now to overload operators <, >, <=, >=
        public static bool operator <(Point p1, Point p2) => p1.CompareTo(p2) < 0;
        public static bool operator >(Point p1, Point p2) => p1.CompareTo(p2) > 0;
        public static bool operator <=(Point p1, Point p2) => p1.CompareTo(p2) <= 0;
        public static bool operator >=(Point p1, Point p2) => p1.CompareTo(p2) >= 0;

    }
}
