using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_33_Interfaces_InterfaceNameClash
{
    class Octagon : IDrawToForm, IDrawToMemory, IDrawToPrint
    {
        void IDrawToForm.Draw()
        {
            Console.WriteLine("Draw to Form");
        }

        void IDrawToMemory.Draw()
        {
            Console.WriteLine("Draw to Memory");
        }

        void IDrawToPrint.Draw()
        {
            Console.WriteLine("Draw to Print");
        }

        internal void Draw()
        {
            Console.WriteLine("Draw to Form");
        }
    }
}
