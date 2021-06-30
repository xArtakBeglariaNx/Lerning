using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_33_Interfaces_InterfaceNameClash
{
    class Program
    {
        static void Main(string[] args)
        {
            Octagon oct = new Octagon();              // при одинаковых названиях методов в интерфейсах необходима явная реализация интерфейсов
            IDrawToForm itfForm = (IDrawToForm)oct;                                             // I   способ
            oct.Draw();

            ((IDrawToMemory)oct).Draw();                                                        // II  способ

            if (oct is IDrawToPrint itfPrint)                                                   // III способ
            {
                itfPrint.Draw();
            }

            Console.ReadLine();
        }
    }
}
