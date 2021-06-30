using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_36_Interfaces_CustomEnumerator
{
    class Radio
    {
        public void TurnOn(bool turnOn)
        {
            Console.WriteLine(turnOn ? "You lesson top radio..." : "Radio crashed too...");
        }
    }
}
