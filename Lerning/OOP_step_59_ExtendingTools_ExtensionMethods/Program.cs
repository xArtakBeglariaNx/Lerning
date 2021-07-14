using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_59_ExtendingTools_ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Fun with Extension methods =====\n");
            
            //In int add new func
            int myInt = 12345678;
            myInt.DisplayDifiningAssambly();

            //And in DataSet
            System.Data.DataSet d = new System.Data.DataSet();
            d.DisplayDifiningAssambly();

            //And in Media.SoundPlayer 
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer();
            sp.DisplayDifiningAssambly();

            Console.WriteLine($"\nValue of myInt: {myInt}");
            Console.WriteLine($"Value of myInt: {myInt.ReverseDigits()}");

            Console.ReadLine();
        }
    }
}
