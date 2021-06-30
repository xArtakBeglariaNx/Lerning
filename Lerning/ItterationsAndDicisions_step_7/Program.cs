using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItterationsAndDicisions_step_7
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor textColor = ConsoleColor.Cyan;
            Console.ForegroundColor = textColor;
            ForLoopExample();
            Console.WriteLine("*************************");
            ForEachLoopExample();
            Console.WriteLine("*************************");
            WhileLoopExample();
            Console.WriteLine("*************************");
            DoWhileLoopExample();
            Console.WriteLine("*************************");
            IfElseExample();
            Console.WriteLine("*************************");
            ExecuteIfElseUsingConditionalOperator();
            Console.WriteLine("*************************");
            SwitchExample();
            Console.WriteLine("*************************");
            SwitchStringExample();
            Console.WriteLine("*************************");
            SwitchOnEnumExample();
            Console.WriteLine("*************************");
            SwitchWithGoTo();
            Console.WriteLine("*************************");
            ExectutePatternMatchinSwitch();
            Console.WriteLine("*************************");
            ExecutePatternMatchingSwitchWithWhen();
            Console.ReadLine();
        }

        static void ForLoopExample()
        {
            Console.WriteLine("=> \"For\" example: <=");

            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine($"Numbers is a: {i}");
            }
            Console.WriteLine("-------------------------");
            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine("Numbers is a: {0}", i);
            }
        }

        static void ForEachLoopExample()
        {
            Console.WriteLine("=> \"Foreach\" example: <=");

            string[] myString = { "Tony", "Throw", "Timmy", "TaleTale_Games" };

            int[] myInt = { 20, 5, 32, 17 };

            foreach (string i in myString)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-------------------------");
            foreach (int c in myInt)
            {
                Console.WriteLine(c);
            }
        }

        static void WhileLoopExample()
        {
            Console.WriteLine("=> \"While\" example: <=");

            string userIsDone = "";

            while (userIsDone.ToLower() != "yes")
            {
                Console.WriteLine("In while loop");
                Console.Write("If you ready to stop it pls enter [yes]: ");
                userIsDone = Console.ReadLine();
                if (userIsDone == null)
                {
                    userIsDone = "no";
                }
            }
        }

        static void DoWhileLoopExample()
        {
            Console.WriteLine("=> \"Do|While\" example: <=");

            string userIsDone = "";

            do
            {
                Console.WriteLine("In do/while loop");
                Console.Write("If you ready to stop it pls enter [yes]: ");
                userIsDone = Console.ReadLine();
                if (userIsDone == null)
                {
                    userIsDone = "no";
                }
            } while (userIsDone.ToLower() != "yes");
        }

        static void IfElseExample()
        {
            Console.WriteLine("=> \"If|Else\" example: <=");

            string myData = "My textual data";

            if (myData.Length > 4 && myData.Length < 36)
            {
                Console.WriteLine($"\"{ myData}\" => String is greater than 4 characters");
            }
            else
            {
                Console.WriteLine($"\"{myData}\" => String is not greater than 36 characters");
            }
        }

        private static void ExecuteIfElseUsingConditionalOperator()
        {
            Console.WriteLine("=> \"If|Else\" через условного поператора example: <=");

            string stringData = "My life after insight";
            Console.WriteLine(stringData.Length > 36 || stringData.Contains("Life")
                ? $"\"{stringData}\" => String is greater than 4 characters"
                : $"\"{stringData}\" => String is not greater than 36 characters");
        }

        static void SwitchExample()
        {
            Console.WriteLine("=> \"Switch\" example: <=");

            Console.WriteLine("Programming languages: 1 [C#], 2 [VB]");
            Console.Write("Please pick your language preferense: ");
            string langChoice = Console.ReadLine();

            int n = int.TryParse(langChoice, out int c) ? c : n = 0;

            switch (n)
            {
                case 1:
                    Console.WriteLine("Good choice, C# is a fine language.");

                    break;
                case 2:
                    Console.WriteLine("VB: OOP lang with more futures");

                    break;
                default:
                    Console.WriteLine("Well.... Good luck with that!");

                    break;
            }
        }

        static void SwitchStringExample()
        {
            Console.WriteLine("=> \"Switch\" string example: <=");

            Console.WriteLine("Programming languages: C#, VB");
            Console.Write("Please pick your language preferense: ");
            string langChoice = Console.ReadLine();
            if (langChoice == null)
            {
                langChoice = default;
            }
            switch (langChoice)
            {
                case "C#":
                    Console.WriteLine("Good choice, C# is a fine language.");

                    break;
                case "VB":
                    Console.WriteLine("VB: OOP lang with more futures");

                    break;
                default:

                    Console.WriteLine("Well.... Good luck with that!");
                    break;
            }
        }

        static void SwitchOnEnumExample()
        {
            Console.WriteLine("=> \"Switch\" ENUM example: <=");

            Console.Write("Pls enter your favorite day of the Week : ");
            DayOfWeek favDay;

            try
            {
                favDay = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Bad input!");

                return;
            }

            switch (favDay)
            {
                case DayOfWeek.Sunday:
                case DayOfWeek.Saturday:
                    Console.WriteLine("A great day indeed");

                    break;
                case DayOfWeek.Monday:
                    Console.WriteLine("Another day, another dollar");

                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("At least a not a Monday");

                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("A fine day");

                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("Almost Friday");

                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("Yes, Friday rules");

                    break;
            }
        }

        static void SwitchWithGoTo()
        {
            Console.WriteLine("=> \"Switch\" GOTO example: <=");

            int foo = 5;

            switch (foo)
            {
                case 1:
                    Console.WriteLine("in 1st step");
                    goto case 2;
                case 2:
                    Console.WriteLine("in 2nd step");
                    goto case 3;
                case 3:
                    Console.WriteLine("in 3rd step");
                    goto default;
                default:
                    Console.WriteLine("it is the END");
                    break;
            }
        }

        static void ExectutePatternMatchinSwitch()
        {
            Console.WriteLine("=> \"Switch\" Pattern Matchin example: <=");

            Console.WriteLine("1 [Integer (5)], 2 [String (\" Hi dear friend\")], 3 [Decimal (2.5)]");
            Console.WriteLine("PLZ choose your option: ");
            string userChoice = Console.ReadLine();
            object choice;
            switch (userChoice)
            {
                case "1":
                    choice = 5;
                    break;
                case "2":
                    choice = "Hi dear friend";
                    break;
                case "3":
                    choice = 2.5;
                    break;
                default:
                    choice = 5;
                    break;
            }

            switch (choice)
            {
                case int i:
                    Console.WriteLine("Your choice is an integer {0}", i);
                    break;
                case string s:
                    Console.WriteLine("Your choice is a string {0}", s);
                    break;
                case decimal d:
                    Console.WriteLine("Your choice is a decimal {0}", d);
                    break;
                default:
                    Console.WriteLine("Your choice is something else");
                    break;
            }
        }

        static void ExecutePatternMatchingSwitchWithWhen()
        {
            Console.WriteLine("1 [C#], 2 [VB]");
            Console.WriteLine("Please pick your lang preference: ");
            object langChoice = Console.ReadLine();
            var choice = int.TryParse(langChoice.ToString(), out int c) ? c : langChoice;

            switch (choice)
            {
                case int i when i == 2:
                case string s when s.Equals("VB", StringComparison.OrdinalIgnoreCase):
                    Console.WriteLine("VB is a good lang");
                    break;
                case int i when i == 1:
                case string s when s.Equals("C#", StringComparison.OrdinalIgnoreCase):
                    Console.WriteLine("C# good choice");
                    break;
                default:
                    Console.WriteLine("Well......good luck with that choice");
                    break;
            }
        }
    }
}
