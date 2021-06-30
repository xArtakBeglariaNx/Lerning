using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_20_ObjectInitializer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Fun with ObjectInitializer =====");

            Point pointManualCr = new Point();
            pointManualCr.X = 20;
            pointManualCr.Y = 35;
            pointManualCr.DisplayStat();

            Point pointCtorCr = new Point(47, 122);
            pointCtorCr.DisplayStat();

            Point pointObjInit = new Point(PointColor.LightBlue) { X = 905, Y = 421 };
            pointObjInit.DisplayStat();

            Rectange rectange = new Rectange()
            {
                TopLeft = new Point() { X = 20, Y = 40, Color = PointColor.BloodRed },
                BottomRight = new Point(PointColor.LightBlue) { X = 30, Y = 30 }
            };
            rectange.DisplayStats();
            Console.ReadLine();
        }
    }
}
