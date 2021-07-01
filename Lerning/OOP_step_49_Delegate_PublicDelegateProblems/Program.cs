using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_49_Delegate_PublicDelegateProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.listOfHandlers = new Car.CarEngineHandler(CallWhenExplored);
            myCar.Accelerate(20);

            myCar.listOfHandlers = new Car.CarEngineHandler(CallHereToo);
            myCar.Accelerate(20);

            myCar.listOfHandlers.Invoke("hehehehe...");

            Console.ReadLine();
        }
        private static void CallWhenExplored(string msgForCaller)
        {
            Console.WriteLine(msgForCaller);
        }
        private static void CallHereToo(string msgForCaller)
        {
            Console.WriteLine(msgForCaller);
        }

        
    }
}
