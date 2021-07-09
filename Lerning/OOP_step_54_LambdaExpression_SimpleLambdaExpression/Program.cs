using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_54_LambdaExpression_SimpleLambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            TraditionalDelegateSyntax();
            AnonimousDelegateSyntax();
            LambdaExpression();
            LambdaExpressionSyntax();
            Console.ReadLine();
        }

        #region Traditional syntax version
        static void TraditionalDelegateSyntax()
        {
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });

            Predicate<int> callBack = IsEvenNumber;

            List<int> evenNumbers = list.FindAll(callBack);

            Console.WriteLine("Here are your even numbers: ");

            foreach (int evenNumber in evenNumbers)
            {
                Console.Write($"{evenNumber}\t");
            }
            Console.WriteLine();
        }
        #endregion

        #region Anonimous method version
        static void AnonimousDelegateSyntax()
        {
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });

            List<int> evenNumbers = list.FindAll(delegate (int i) { return (i % 2) == 0; });
            Console.WriteLine("Here are your even numbers: ");
            foreach (int evenNumber in evenNumbers)
            {
                Console.Write($"{evenNumber}\t");
            }
            Console.WriteLine();
        }
        #endregion

        #region Lambda version
        static void LambdaExpression()
        {
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });

            List<int> evenNumbers = list.FindAll(i => (i % 2) == 0);
            Console.WriteLine("Here are your even numbers: ");
            foreach (int evenNumber in evenNumbers)
            {
                Console.Write($"{evenNumber}\t");
            }
            Console.WriteLine();
        }
        #endregion

        #region Lambda version with plenty operators

        static void LambdaExpressionSyntax()
        {
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });

            List<int> evenNumbers = list.FindAll((i) =>
            {
                Console.WriteLine($"value of i is currently {i}");
                bool isEven = (i % 2) == 0;
                return isEven;
            });

            Console.WriteLine("Here are your even numbers: ");
            foreach (int evenNumber in evenNumbers)
            {
                Console.Write($"{evenNumber}\t");
            }
            Console.WriteLine();
        }

        #endregion
        private static bool IsEvenNumber(int i)
        {
            return (i % 2) == 0;
        }
    }
}
