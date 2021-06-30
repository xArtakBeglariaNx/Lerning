using System;
using System.Collections.Generic;
using OOP_step_34_Interfaces_InterfaceHierarchy;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_43_Generics_GenericPoint
{
    class Draw : IDrawable
    {
        void IDrawable.Draw()
        {
            Console.WriteLine("Draing");
        }
    }
}
