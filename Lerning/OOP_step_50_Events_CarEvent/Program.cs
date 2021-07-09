using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_50_Events_CarEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****** Fun with event ******\n");

            Console.WriteLine("********************************");

            #region Example n1 Events using

            Car myCar = new Car("Crysler", 10, 100);
            Car.CarEngineHandler handler = new Car.CarEngineHandler(CarExploredEventHandler);
            myCar.Explored += handler;
            myCar.AboutToBlow += handler;
            for (int i = 0; i < 6; i++)
            {
                myCar.Accelerate(20);
            }
            myCar.Explored -= handler;

            #endregion

            Console.WriteLine("********************************");

            #region Example n2 Events using

            Car c1 = new Car("Toby's McGuaer Car", 30, 100);
            c1.AboutToBlow += new Car.CarEngineHandler(CarAboutToBlow);
            c1.AboutToBlow += new Car.CarEngineHandler(CarIsDoomed);

            Car.CarEngineHandler d = new Car.CarEngineHandler(CarExplored);
            c1.Explored += d;

            for (int i = 0; i < 4; i++)
            {
                c1.Accelerate(30);
            }

            c1.Explored -= d;

            #endregion


            Console.WriteLine("********************************");

            #region Example n3 Events using

            Car c2 = new Car("Maddona's car", 150, 260);
            c2.AboutToBlow += CarAboutToBlow;
            c2.AboutToBlow += CarIsDoomed;
            c2.Explored += CarExplored;
            Console.WriteLine("Speeding up");
            for (int i = 0; i < 4; i++)
            {
                c2.Accelerate(50);
            }

            c2.Explored -= CarExplored;

            #endregion

            Console.WriteLine("********************************");

            #region Example with LambdaExpressions

            Car myCar2 = new Car("Lambda", 120, 190);
            myCar2.AboutToBlow += (sender, e) => { Console.WriteLine(e.msg); };
            myCar2.Explored += (sender, e) => { Console.WriteLine(e.msg); };

            Console.WriteLine("\n***** Speeding up *****");
            for (int i = 0; i < 5; i++)
            {
                myCar2.Accelerate(20);
            }

            #endregion

            Console.ReadLine();
        }

        #region Event handlers
        private static void CarExplored(object sender, CarEventArgs e)
        {
            Console.WriteLine($"{sender} : {e.msg}");
        }

        private static void CarAboutToBlow(object sender, CarEventArgs e)
        {
            if (sender is Car c)
            {
                Console.WriteLine($"{c.PetName} : {e.msg}");
            }
        }

        private static void CarIsDoomed(object sender, CarEventArgs e)
        {
            if (sender is Car c)
            {
                Console.WriteLine($"Critical message from {c.PetName} : {e.msg}");
            }
        }

        private static void CarExploredEventHandler(object sender, CarEventArgs e)
        {
            Console.WriteLine($"{sender} : {e.msg}");
        }
        #endregion

    }
}
