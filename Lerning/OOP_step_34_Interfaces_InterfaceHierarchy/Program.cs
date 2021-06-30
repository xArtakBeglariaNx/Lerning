using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_34_Interfaces_InterfaceHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fun with interface hierarchy\n");

            BitmapImage bitmap = new BitmapImage();
            bitmap.Draw();
            bitmap.DrawBoundingBox(10, 10, 10, 10);
            bitmap.DrawUpsideDown();

            IAdvancedDraw iAdvDrw = bitmap as IAdvancedDraw;
            if (bitmap is IAdvancedDraw ex)
            {
                ex.DrawUpsideDown();
            }
            if (iAdvDrw != null)
            {
                iAdvDrw.DrawUpsideDown();
            }

            Console.ReadLine();
        }
    }
}
