using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_29_ApplicationException_CustomException
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==== Fun with Custom Error ====\n");

            Car myCar = new Car("Troll", 90);

            try
            {
                myCar.Accelerate(50);
            }
            catch (CarIsDeadException ex)
            {

                Console.WriteLine($"{ex.Message}");
                Console.WriteLine($"Error Time Stamp: {ex.ErrorTimeStamp}");
                Console.WriteLine($"Cause: {ex.CauseOfError}\n");
            }

            Car myCarVer2 = new Car("Goblin", 90);


            try
            {
                myCarVer2.AccelerateVer2(50);
            }
            catch (CarIsDeadExceptionVer2 ex)
            {
                Console.WriteLine($"Message: {ex.Message}");
                Console.WriteLine($"Error Time Stamp: {ex.ErrorTimeStamp}");
                Console.WriteLine($"Cause: {ex.CauseOfError}\n");
            }

            Car myCarVer3 = new Car("Fairy", 90);

            try
            {
                myCarVer3.AccelerateVer3(50);
            }
            catch (CarIsDeadExceptionVer3 ex)
            {
                Console.WriteLine($"Message: {ex.Message}");
                Console.WriteLine($"Error time: {DateTime.Now}");
                Console.WriteLine($"Stack trace: {ex.HelpLink}");
            }

            Console.ReadLine();
        }        
    }
}
