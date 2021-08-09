using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP_step_74_ClassLibrary_CarLibrary;

namespace OOP_step_77_ClassLibrary_CodeBaseClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==== Code Base Client ====");

            SportCars sportCars = new SportCars();
            Console.WriteLine("Sports car has been allocated");
            Console.ReadLine();
        }
    }
}
