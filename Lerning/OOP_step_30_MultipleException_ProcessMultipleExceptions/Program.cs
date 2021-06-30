using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_30_MultipleException_ProcessMultipleExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Fun with Multiple Exceptions =====\n");

            Car myCar = new Car("Fairy", 90);

            try
            {
                myCar.Accelerate(2000);
            }
            catch (CarIsDeadException e) when (e.ErrorTimeStamp.DayOfWeek != DayOfWeek.Friday)
            {
                Console.WriteLine("Catching car is dead");
                Console.WriteLine($"{e.Message}\n");
                Console.WriteLine(e.HelpLink + "\n@@@@@@@@@@@@@@@@@@@@@");
                try
                {
                    FileStream fileStream = File.Open(@"C:\carErrors.txt", FileMode.Open);
                }
                catch (Exception e2)
                {
                    CarIsDeadException carIsDead = new CarIsDeadException("", e2.Message);
                    try
                    {
                        throw carIsDead;
                    }
                    catch (CarIsDeadException ex)
                    {
                        Console.WriteLine(ex.Message + "\n@@@@@@@@@@@@@@@@@@@@@");
                    }
                }
                finally
                {
                    Console.WriteLine("Go next\n");
                }
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                myCar.CrankTunes(false);
            }
            Console.ReadLine();
        }
    }
}
