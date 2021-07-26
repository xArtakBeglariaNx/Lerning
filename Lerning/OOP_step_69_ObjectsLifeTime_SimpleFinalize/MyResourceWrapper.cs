using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_69_ObjectsLifeTime_SimpleFinalize
{
    class MyResourceWrapper
    {
        //переопределить system.object.finalize() посредством синтаксиса финализатора
        ~MyResourceWrapper() => Console.Beep();
    }
}
