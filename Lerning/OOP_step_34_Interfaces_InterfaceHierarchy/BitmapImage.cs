using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_34_Interfaces_InterfaceHierarchy
{
    class BitmapImage : IAdvancedDraw
    {        
        public void Draw()
        {
            Console.WriteLine("Drawing .....\n");
        }

        public void DrawBoundingBox(int top, int left, int bottom, int right)
        {
            Console.WriteLine($"Drawing in a box:\n{nameof(top)} = {top}\n{nameof(left)} = {left}\n{nameof(bottom)} = {bottom}\n{nameof(right)} = {right}\n");
        }

        public void DrawUpsideDown()
        {
            Console.WriteLine("Drawing upside to down\n");
        }
    }
}
