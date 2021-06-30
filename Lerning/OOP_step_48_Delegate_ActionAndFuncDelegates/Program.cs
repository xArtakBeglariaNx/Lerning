using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_48_Delegate_ActionAndFuncDelegates
{
    class Program
    {
        static void DisplayMessage(string msg, ConsoleColor txtColor, int printCount)
        {
            ConsoleColor prevoius = Console.ForegroundColor;
            Console.ForegroundColor = txtColor;

            for (int i = 0; i < printCount; i++)
            {
                Console.WriteLine(msg + $"{i + 1}");
            }

            Console.ForegroundColor = prevoius;

            for (int i = 0; i < printCount; i++)
            {
                Console.WriteLine(msg + $"{i + 1}");
            }
        }

        static int Add(int x, int y)
        {
            Console.WriteLine($"x + y: {x + y}");
            return x + y;
        }

        static string SumToString(int x, int y)
        {
            return (x + y).ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Action<> and Func<> *****\n");

            Action<string, ConsoleColor, int> actionTarget = new Action<string, ConsoleColor, int>(DisplayMessage);
            actionTarget($"Delegate Action<T>: ", ConsoleColor.Yellow, 5);

            Func<int, int, int> funcTarget = new Func<int, int, int>(Add);
            funcTarget(40, 30);

            Func<int, int, string> actionTarget2 = new Func<int, int, string>(SumToString);            
            string sum = actionTarget2(23, 30);
            string sum2 = actionTarget2.Invoke(22, 15);
            Console.WriteLine($"x + y = {sum}");
            Console.WriteLine($"x + y = {sum2}");

            Console.ReadLine();
        }
    }
}
