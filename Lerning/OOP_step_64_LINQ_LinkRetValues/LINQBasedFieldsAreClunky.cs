using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP_step_64_LINQ_LinkRetValues
{
    class LINQBasedFieldsAreClunky
    {
        private static string[] currentVideoGames = { "Morrowind", "Unchardet 2", "Dexter", "FallOut 2", "System Shock 2" };

        private IEnumerable<string> subset = from g in currentVideoGames where g.Contains(" ") orderby g select g;

        public void PrintGames()
        {
            foreach (var item in subset)
            {
                Console.WriteLine(item);
            }
        }
    }
}
