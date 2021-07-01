using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_49_Delegate_PublicDelegateProblems
{
    class Car
    {
        public delegate void CarEngineHandler(string msgForCaller);

        public CarEngineHandler listOfHandlers;

        public void Accelerate(int delta)
        {
            if (listOfHandlers != null)
            {
                listOfHandlers("Sorry car is crashed!!!");
            }
        }
    }
}
