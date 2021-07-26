using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_71_ObjectsLifeTime_FinalizableDisposableClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dispose()/Destructor Combo platter");

            MyResourceWrapper rw = new MyResourceWrapper();
            rw.Dispose(); // не приводит к вызову финализатора

            //не вызывая метод Dispose() это приведет к вызову финализатора
            MyResourceWrapper rw2 = new MyResourceWrapper();

            Console.ReadLine();
        }
    }
}
