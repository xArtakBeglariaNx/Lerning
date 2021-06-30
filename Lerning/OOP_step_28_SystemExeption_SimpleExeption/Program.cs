using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_28_SystemExeption_SimpleExeption
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Fun with Exeptions =====\n");

            Car zappa = new Car("Zappa", 20);
            zappa.CrankTunes(true);
                        
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    zappa.Accelerate(10);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"\n ==== Errror ====");
                Console.WriteLine($"\nMember name: {e.TargetSite}");
                Console.WriteLine("\nClass define member: {0}", e.TargetSite.DeclaringType);
                Console.WriteLine($"\nMember type: {e.TargetSite.MemberType}");
                Console.WriteLine($"\nMessage: {e.Message}");
                Console.WriteLine($"\nSource: {e.Source}");
                Console.WriteLine($"\nHelp link: {e.HelpLink}");
                Console.WriteLine($"\n -> Custom data:");
                foreach (DictionaryEntry de in e.Data)
                {
                    Console.WriteLine($"->-> {de.Key} :: {de.Value}");
                }
                Console.WriteLine($"\nStackTrace: {e.StackTrace}");
            }

            NullReferenceException nullReference = new NullReferenceException();
            Console.WriteLine($"\n{nameof(NullReferenceException)} is a {nameof(SystemException)}? :" +
                $" {nullReference is SystemException}"); //пример проверки относится ли выпавшее исключение к SystemException  

            Console.ReadLine();
        }
    }
}
