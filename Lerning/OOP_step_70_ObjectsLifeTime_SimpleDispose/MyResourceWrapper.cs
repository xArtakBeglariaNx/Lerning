using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_70_ObjectsLifeTime_SimpleDispose
{
    class MyResourceWrapper : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("====== I Dispose ======");
        }
    }
}
