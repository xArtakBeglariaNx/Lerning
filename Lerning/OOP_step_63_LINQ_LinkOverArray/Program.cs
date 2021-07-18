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

        static void ReflectOverQuerryResult(object resultSet, string querryType= "Querry Expression")
        {
            Console.WriteLine($"==== Info about querry using: {querryType} =====");
            Console.WriteLine($"resultSet of type: {resultSet.GetType().Name}");
            Console.WriteLine($"resultSet location: {resultSet.GetType().Assembly.GetName().Name}");
        }
        #endregion
    }
}
