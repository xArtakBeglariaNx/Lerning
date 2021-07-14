using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_60_ExtendingTools_InterfaceExtensions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Fun with Compatible Type =====\n");

            //System Array realizing IEnumerable!!!
            string[] data = { "Wow", "this", "is", "sort", "annoying", "but", "in", "a", "weired", "way", "fun"};

            data.PrintDataAndBeep();
            Console.WriteLine();

            //List<T> realizing IEnumerable
            List<int> myInts = new List<int>() { 10, 20, 30, 40};
            myInts.PrintDataAndBeep();
            Console.ReadLine();
        }
    }
}
