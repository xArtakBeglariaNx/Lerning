using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_step_127_ADO.NET_AutoLotDAL.DataOperations;
using OOP_step_127_ADO.NET_AutoLotDAL.Models;
using OOP_step_127_ADO.NET_AutoLotDAL.Bulkimport;

using static System.Console;

namespace OOP_step_127_ADO.NET_AutoLotClient
{
    class Program
    {
        static void Main(string[] args)
        {
            InventoryDAL dal = new InventoryDAL();
            var list = dal.GetAllInventory();
            WriteLine("========= All Cars =========");
            WriteLine("CarId\tMake\tColor\tPetName");
            foreach (var itm in list)
            {
                WriteLine($"{itm.CarId}\t{itm.Make}\t{itm.Color}\t{itm.PetName}");
            }
            WriteLine();

            var car = dal.GetCar(list.OrderBy(x=>x.Color).Select(x=>x.CarId).First());
            WriteLine("======= First Car by Color =======");
            WriteLine("CarId\tMake\tColor\tPetName");
            WriteLine($"{car.CarId}\t{car.Make}\t{car.Color}\t{car.PetName}");

            try
            {
                dal.DeleteCar(5);
                WriteLine("Info about Car deleted.");
            }
            catch (Exception ex)
            {
                WriteLine($"An exeption occurred: {ex.Message}");
            }

            dal.InsertAuto(new Car { Color = "Blue", Make = "Pilot", PetName = "TowMonster"});
            list = dal.GetAllInventory();
            var newCar = list.First(x=>x.PetName == "TowMonster");
            WriteLine("======= New Car ======= ");
            WriteLine("CarId\tMake\tColor\tPetName");
            WriteLine($"{newCar.CarId}\t{newCar.Make}\t{newCar.Color}\t{newCar.PetName}");

            dal.DeleteCar(newCar.CarId);
            var petName = dal.LookUpPetName(car.CarId);
            WriteLine("======== New Car =========");
            WriteLine($"Car pet name: {petName}");
            Write("Press to continue...");
            ReadLine();

            MoveCustomer();

            DoBulkCopy();
        }

        public static void MoveCustomer()
        {
            WriteLine("========== Simple Transaction ==========");

            bool throwEx = true;

            Write("Do you want to throw an Exeption? (Y or N)");
            var userAnswer = ReadLine();
            if (userAnswer?.ToLower() == "n")
            {
                throwEx = false;
            }

            var dal = new InventoryDAL();
            dal.ProcessCreditRisks(throwEx, 2);
            WriteLine("Check Credit Risks table for result");
            ReadLine();
        }

        public static void DoBulkCopy()
        {
            WriteLine("***************** Do bulk copy *****************");
            var cars = new List<Car>
            {
                new Car(){Color = "Blue", Make = "Honda", PetName = "MyCar1"},
                new Car(){Color = "Red", Make = "Volvo", PetName = "MyCar2"},
                new Car(){Color = "White", Make = "VW", PetName = "MyCar3"},
                new Car(){Color = "Yellow", Make = "Toyota", PetName = "MyCar4"}
            };

            ProcessBulkImport.ExecuteBulkImport(cars, "Inventory");
            InventoryDAL dal = new InventoryDAL();
            var list = dal.GetAllInventory();
            WriteLine("------------ All Cars --------------------");
            WriteLine("CarId\tMake\tColor\tPetName");
            foreach (var itm in list)
            {
                WriteLine($"{itm.CarId}\t{itm.Make}\t{itm.Color}\t{itm.PetName}");
            }
            ReadLine();
        }
    }
}
