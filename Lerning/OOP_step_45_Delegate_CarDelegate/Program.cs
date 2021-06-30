using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_45_Delegate_CarDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Delegates as event anablers =====\n");

            Car c1 = new Car("Narubayashi", 10, 100);

            c1.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEventHandler));

            Car.CarEngineHandler handler2 = new Car.CarEngineHandler(OnCarEventHandler2);
            c1.RegisterWithCarEngine(handler2);
            
            Console.WriteLine("***** Speeding up *****");
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);

            c1.UnRegisterWithCarEngine(handler2);

            Console.WriteLine("***** Speeding up *****");
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);

            Console.ReadLine();
        }
        
        private static void OnCarEventHandler(string msgForCaller)
        {
            Console.WriteLine("\n***** Message fro Car object *****");
            Console.WriteLine($"=> {msgForCaller}");
            Console.WriteLine("**********************************");
        }

        private static void OnCarEventHandler2(string msgForCaller)
        {
            Console.WriteLine("\n***** Message fro Car object *****");
            Console.WriteLine($"=> {msgForCaller.ToUpper()}");
            Console.WriteLine("**********************************");
        }
    }
}
