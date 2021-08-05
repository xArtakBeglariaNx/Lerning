using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_step_74_ClassLibrary_CarLibrary;

namespace OOP_step_75_ClassLibrary_CSharpCarClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====== C# ClassLibrary_CarLibrary Client App ======");

            SportCars sportCars1 = new SportCars() {PetName = "Lamborginy", CurrentSpeed = 120, MaxSpeed = 360 };
            sportCars1.TurboBoost();

            MiniVan miniVan1 = new MiniVan() {PetName = "MiniVan", CurrentSpeed = 60, MaxSpeed = 120 };
            miniVan1.TurboBoost();

            Console.WriteLine("Done. Press | Enter | to terminate programm");
            Console.ReadLine();
        }
    }
}
