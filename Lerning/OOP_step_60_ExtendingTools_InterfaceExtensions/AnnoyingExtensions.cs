using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_60_ExtendingTools_InterfaceExtensions
{
    static class AnnoyingExtensions
    {
        public static void PrintDataAndBeep(this System.Collections.IEnumerable iterrator)
        {
            foreach (var item in iterrator)
            {
                Console.WriteLine(item);
                Console.Beep();
            }
        }
    }
}
