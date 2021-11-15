using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using OOP_step_129_ADO.NET_EF_AutoLotDAL.EF;
using OOP_step_129_ADO.NET_EF_AutoLotDAL.Models;
using OOP_step_129_ADO.NET_EF_AutoLotDAL.Repos;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_129_ADO.NET_EF_AutoLotTestDrive
{
    class Program
    {
        static void Main(string[] args)
        {
            //Database.SetInitializer(new MyDataInitializer());
            Console.WriteLine("------ Fun With EF Code Fist ------");
            using (var context = new AutoLotEntities())
            {
                foreach (Inventory c in context.Cars)
                {
                    Console.WriteLine(c);
                }
            }

            Console.WriteLine("------ Using Repositiry ------");
            using (var repo = new InventoryRepo())
            {
                foreach (var c in repo.GetAll())
                {
                    Console.WriteLine(c);
                }
            }

            
            Console.ReadLine();
        }

        private static void AddNewRecord(Inventory car)
        {
            using (var repo = new InventoryRepo())
            {
                repo.Add(car);
            }
        }

        private static void UpdateRecord(int carId)
        {
            using (var repo = new InventoryRepo())
            {
                var carToUpdate = repo.GetOne(carId);
                if (carToUpdate == null) return;
                carToUpdate.Color = "Blue";
                repo.Save(carToUpdate);
            }
        }

        private static void RemoveRecordByCar(Inventory carToDelete)
        {
            using (var repo = new InventoryRepo())
            {
                repo.Delete(carToDelete);
            }
        }

        private static void RemoveRecordById(int carId, byte[] timeStamp)
        {
            using (var repo = new InventoryRepo())
            {
                repo.Delete(carId, timeStamp);
            }
        }
    }
}
