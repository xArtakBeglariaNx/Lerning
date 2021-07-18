using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_63_LINQ_LinkOverArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Fun with LINQ with Array (LINQ to Objact) =====\n");

            QuerryOverStrings();
            QuerryOverStringsWithExtensionMethods();
            QuerryOverStringsLongHand();
            QuerryOverInts();

            Console.ReadLine();
        }

        #region QuerryOverStrings
        static void QuerryOverStrings()
        {
            string[] currentVideoGames = { "MorrowWind", "TES Online", "Skyrim", "Forza Horizon 4", "Uncharted 2", "FallOut 3" };

            IEnumerable<string> subset = from game in currentVideoGames where game.Contains(" ") orderby game select game;

            ReflectOverQuerryResult(subset);

            foreach (var item in subset)
            {
                Console.WriteLine($"Item: {item}");
            }
            Console.WriteLine();
        }
        #endregion

        #region QuerryOverStringsWithExtensionMethods()
        static void QuerryOverStringsWithExtensionMethods()
        {
            string[] currentVideoGames = { "MorrowWind", "TES Online", "Skyrim", "Forza Horizon 4", "Uncharted 2", "FallOut 3" };

            IEnumerable<string> subset = currentVideoGames.Where(game => game.Contains(" ")).OrderBy(game => game).Select(game => game);

            ReflectOverQuerryResult(subset, "Expression Method");

            foreach (var item in subset)
            {
                Console.WriteLine($"Item: {item}");
            }
            Console.WriteLine();
        }
        #endregion

        #region QuerryOverStringsLongHand
        static void QuerryOverStringsLongHand()
        {
            string[] currentVideoGames = { "MorrowWind", "TES Online", "Skyrim", "Forza Horizon 4", "Uncharted 2", "FallOut 3" };

            string[] gamesWithSpace = new string[6];

            for (int i = 0; i < currentVideoGames.Length; i++)
            {
                if (currentVideoGames[i].Contains(" "))
                {
                    gamesWithSpace[i] = currentVideoGames[i];
                }
            }

            Array.Sort(gamesWithSpace);

            ReflectOverQuerryResult(gamesWithSpace, "Long Hand Way");

            foreach (string item in gamesWithSpace)
            {
                if (item != null)
                {
                    Console.WriteLine("Item: {0}", item);
                }
            }
            Console.WriteLine();
        }
        #endregion

        #region ReflectOverQuerryResult

        static void ReflectOverQuerryResult(object resultSet, string querryType = "Querry Expression")
        {
            Console.WriteLine();
            Console.WriteLine($"==== Info about querry using: {querryType} =====");
            Console.WriteLine($"resultSet of type: {resultSet.GetType().Name}");
            Console.WriteLine($"resultSet location: {resultSet.GetType().Assembly.GetName().Name}");
        }
        #endregion

        #region QuerryOverInts

        static void QuerryOverInts()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };

            //IEnumerable<int> subset = from num in numbers where num < 5 select num;
            //System.Collections.IEnumerable subset = from num in numbers where num < 5 select num;
            var subset = from num in numbers where num < 5 select num;

            ReflectOverQuerryResult(subset, "Querry Over Ints with variable types");

            foreach (var item in subset)
            {
                Console.WriteLine($"{item} < 5");
            }
            Console.WriteLine();
            numbers[0] = 4;
            foreach (var item in subset)
            {
                Console.WriteLine($"{item} < 5");
            }
        }
        #endregion

        #region ImmediateExecution
        static void ImmediateExecution()
        {
            int[] numbers = { 10, 20, 40, 1, 2, 3, 4 };

            int[] subsetAsIntArray = (from i in numbers where i < 10 select i).ToArray<int>();

            List<int> subsetAsListOfInts = (from j in numbers where j < 10 select j).ToList<int>();
        }
        #endregion
    }
}
