using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lerning_step_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "My Rocking App";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("*******************************");
            Console.WriteLine("***Welcome to My Rocking App***");
            Console.WriteLine("*******************************");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ReadLine();            
            MessageBox.Show("Well DONE!!!");
        }        
    }
}
