using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_37_Interfaces_ICloneable_CloneablePoint
{
    class Point : ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public PointDescription desc = new PointDescription();

        public Point(int xPos, int yPos, string petName)
        {
            X = xPos; Y = yPos;
            desc.PetName = petName;
        }
        public Point(int xPos, int yPos) { X = xPos; Y = yPos; }
        public Point() { }

        public override string ToString()
        {
            return $"X = {X}, Y = {Y}, PetName = {desc.PetName}, PointID = {desc.PointID}";
        }

        public object Clone()
        {
            Point newPoint = (Point)this.MemberwiseClone();

            PointDescription currentDesc = new PointDescription();
            currentDesc.PetName = this.desc.PetName;
            newPoint.desc = currentDesc;
            return newPoint;
        }
    }
}
