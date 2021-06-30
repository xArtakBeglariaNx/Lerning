using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithEnums_step_10
{
    class Program
    {
        enum EmpType : byte
        {
            Manager = 0,
            Grunt = 1,
            Contractor = 2,
            VicePresident = 3
        }
        #region Такие Варианты реализации тоже правильные

        /*enum EmpType
        {
            Manager = 102,  //102
            Grunt,          //103
            Contractor,     //104
            VicePresident   //105
        }*/

        //enum EmpType
        //{
        //    Manager = 10,
        //    Grunt = 1,
        //    Contractor = 100,
        //    VicePresident = 9
        //}

        /*enum EmpType : byte //Данный код приведет к ошибке т.к. 999 лежит за пределами значений типа byte
        {
            Manager = 10,
            Grunt = 1,
            Contractor = 100,
            VicePresident = 999
        }*/
        #endregion

        static void Main(string[] args)
        {
            Console.WriteLine("=> Fun with enums");

            Console.WriteLine("=================================");
                        
            EmpType emp = EmpType.Grunt;
            
            AskForBonus(emp);

            Console.WriteLine("emp is a {0}", emp.ToString());
            Console.WriteLine("emp is a {0} = {1}", emp.ToString(), (byte)emp);

            Console.WriteLine($"Get [enum EmpType] imType {Enum.GetUnderlyingType(emp.GetType())}");
            Console.WriteLine($"Get [enum EmpType] imType {Enum.GetUnderlyingType(typeof(EmpType))}");

            Console.WriteLine("=================================");

            EmpType e = EmpType.Contractor;
            DayOfWeek day = DayOfWeek.Monday;
            ConsoleColor cc = ConsoleColor.Green;
            EvaluetEnum(e);
            EvaluetEnum(day);
            EvaluetEnum(cc);

            Console.WriteLine("=================================");

            EvaluetEnum(emp);

            Console.WriteLine("=================================");

            Console.ReadLine();
        }

        static void AskForBonus(EmpType empType)
        {     
            switch (empType)
            {
                case EmpType.Manager:
                    Console.WriteLine("How about stock options instead?");
                    break;
                case EmpType.Grunt:
                    Console.WriteLine("You have got to be kidding?");
                    break;
                case EmpType.Contractor:
                    Console.WriteLine("You already get enough cash...");
                    break;
                case EmpType.VicePresident:
                    Console.WriteLine("Very GOOD, sir");
                    break;                
            }
            
        }

        static void EvaluetEnum(System.Enum e)
        {
            Console.WriteLine("Underlying storage type {0}", Enum.GetUnderlyingType(e.GetType()));

            Array enumData = Enum.GetValues(e.GetType());
            Console.WriteLine("This enum has members {0}", enumData.Length);

            for (int i = 0; i < enumData.Length; i++)
            {
                Console.WriteLine(enumData.GetValue(i));
            }
            Console.WriteLine();
        }
    }
}
