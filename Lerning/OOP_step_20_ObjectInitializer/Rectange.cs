using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_20_ObjectInitializer
{
    class Rectange
    {
        private Point topLeft = new Point();
        private Point bottomRight = new Point();

        public Point TopLeft { get => topLeft; set => topLeft = value; }
        public Point BottomRight { get => bottomRight; set => bottomRight = value; }

        public void DisplayStats()
        {
            Console.WriteLine($"TopLeft: {TopLeft.X} {TopLeft.Y} {TopLeft.Color}\nBottomRight: {BottomRight.X} {BottomRight.Y} {BottomRight.Color}");
        }

    }
}
