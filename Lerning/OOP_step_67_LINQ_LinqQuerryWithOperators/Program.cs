using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_67_LINQ_LinqQuerryWithOperators
{
    class VeryComplexQueryExpression
    {
        public static void QueryStringsWithRawDelegaets()
        {
            Console.WriteLine("****** Using Raw Delegates ******");
            string[] currentGames = { "Morrowind", "Uncharted 2", "Skyrim", "TES 6" };
            Func<string, bool> filter = new Func<string, bool>(Filter);
            Func<string, string> itemInProcess = new Func<string, string>(ItemInProcess);
            var subset = currentGames.Where(filter).OrderBy(itemInProcess).Select(itemInProcess);
            foreach (var item in subset)
            {
                Console.WriteLine(item);
            }
        }

        public static bool Filter(string game) { return game.Contains(" "); }
        public static string ItemInProcess(string game) { return game; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            QuerryStringWithOperator();
            QueryStringWithEnumerableAndLambdas();
            QueryStringWithEnumerableAndLambdas2();
            QueryStringsWithAnonimousMethods();
            VeryComplexQueryExpression.QueryStringsWithRawDelegaets();
            Console.ReadLine();
        }

        static void QuerryStringWithOperator()
        {
            Console.WriteLine("***** Query string with Operator *****");
            string[] currentGames = { "Morrowind", "Uncharted 2", "Skyrim", "TES 6" };
            var subset = from game in currentGames where game.Contains(" ") orderby game select game;
            foreach (string s in subset)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
        }

        static void QueryStringWithEnumerableAndLambdas()
        {
            Console.WriteLine("***** Using Enumerable / Lambda Expressions *****");
            string[] currentGames = { "Morrowind", "Uncharted 2", "Skyrim", "TES 6" };
            var subset = currentGames.Where(game => game.Contains(" ")).OrderBy(game => game).Select(game => game);
            foreach (var s in subset)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
        }

        static void QueryStringWithEnumerableAndLambdas2()
        {
            Console.WriteLine("***** Using Enumerable / Lambda Expressions *****");
            string[] currentGames = { "Morrowind", "Uncharted 2", "Skyrim", "TES 6" };
            var gamesWithSpaces = currentGames.Where(game => game.Contains(" "));
            var orderedGames = gamesWithSpaces.OrderBy(game => game);
            var subset = orderedGames.Select(game => game);
            foreach (var s in subset)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
        }

        static void QueryStringsWithAnonimousMethods()
        {
            Console.WriteLine("***** Using Anonimous Methods *****");
            string[] currentGames = { "Morrowind", "Uncharted 2", "Skyrim", "TES 6" };
            Func<string, bool> searchFilter = delegate (string game) { return game.Contains(" "); };
            Func<string, string> itemToProcess = delegate (string s) { return s; };
            var subset = currentGames.Where(searchFilter).OrderBy(itemToProcess).Select(itemToProcess);
            foreach (var s in subset)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
        }
    }
}
