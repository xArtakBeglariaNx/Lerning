using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_69_ObjectsLifeTime_SimpleFinalize
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Finalize");
            Console.WriteLine("Press Enter to finish app");
            Console.ReadLine();
            MyResourceWrapper rw = new MyResourceWrapper();
        }
    }
}
