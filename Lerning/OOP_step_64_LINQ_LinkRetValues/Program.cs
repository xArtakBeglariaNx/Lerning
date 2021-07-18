using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_64_LINQ_LinkRetValues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Fun with LINQ retuns Values =====\n");

            IEnumerable<string> subset = GetStringSubset();

            foreach (var item in subset)
            {
                Console.WriteLine(item);
            }

            foreach (var item in GetStringSubsetAsArray())
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        static IEnumerable<string> GetStringSubset()
        {
            string[] colors = { "Light Red", "Green", "Dark Red", "Red", "Yellow" };

            IEnumerable<string> theColorsRed =
                from s in colors where s.Contains("Red") select s;

            return theColorsRed;
        }

        static string[] GetStringSubsetAsArray()
        {
            string[] colors = { "Light Red", "Green", "Dark Red", "Red", "Yellow" };

            var theColorsRed = from s in colors where s.Contains("Red") select s;

            return theColorsRed.ToArray();
        }
    }
}
