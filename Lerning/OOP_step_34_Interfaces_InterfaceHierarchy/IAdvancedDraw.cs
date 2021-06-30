using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_34_Interfaces_InterfaceHierarchy
{
    public interface IAdvancedDraw : IDrawable
    {
        void DrawBoundingBox(int top, int left, int bottom, int right);
        void DrawUpsideDown();
    }
}
