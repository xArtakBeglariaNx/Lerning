using System;
using OOP_step_128_ADO.NET_EF_AutoLotConsoleApp.EF;
using OOP_step_128_ADO.NET_EF_AutoLotConsoleApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace OOP_step_128_ADO.NET_EF_AutoLotConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("=== Fun with ADO.NET EF ===");
            int carId = AddNewRecord();
            WriteLine(carId);
            ReadLine();
        }

        private static int AddNewRecord()
        {
            using (var context = new AutoLotEntities())
            {
                try
                {
                    var car = new Car() { Make = "Yugo", Color = "Brown", CarNickName = "Brownie" };
                    context.Cars.Add(car);
                    context.SaveChanges();
                    return car.CarId;
                }
                catch (Exception ex)
                {
                    WriteLine(ex.InnerException?.Message);
                    return 0;
                }
            }
        }

        private static void AddRangeRecords(IEnumerable<Car> carsToAdd)
        {
            using (var context = new AutoLotEntities())
            {
                context.Cars.AddRange(carsToAdd);
                context.SaveChanges();
            }
        }

        private static void PrintAllInventory()
        {
            using (var context = new AutoLotEntities())
            {
                foreach (Car c in context.Cars.Where(c => c.Make == "BMW"))
                {
                    WriteLine(c);
                }
                WriteLine(context.Cars.Find(5));

                //Lazy (ленивая) Loading == On
                foreach (Car c in context.Cars)
                {
                    foreach (Order o in context.Orders)
                    {
                        WriteLine(o.OrderId);
                    }
                }

                //Vigorous (энергичная) loading
                foreach (Car c in context.Cars.Include(c => c.Orders))
                {
                    foreach (Order o in c.Orders)
                    {
                        WriteLine(o.OrderId);
                    }
                }

                //LazyLoading == Off, explicit (явная) loading
                context.Configuration.LazyLoadingEnabled = false;
                foreach (Car c in context.Cars)
                {
                    context.Entry(c).Collection(x => x.Orders).Load();
                    foreach (Order o in context.Orders)
                    {
                        WriteLine(o.OrderId);
                    }
                }
                foreach (Order o in context.Orders)
                {
                    context.Entry(o).Reference(x => x.Car).Load(); ;
                }
            }
        }

        //Get Data with Sql command from DbSet<T>
        private static void PrintAllInventorySql()
        {
            using (var context = new AutoLotEntities())
            {
                foreach (Car c in context.Cars.SqlQuery(
                    "Select CarId, Make, Color, PetName as CarNickName from Inventory where Make=@p0", "BMW"))
                {
                    WriteLine(c);
                }
            }
        }

        //Get data for ShortCar with Sql command
        private static void PrintShotCarData()
        {
            using (var context = new AutoLotEntities())
            {
                foreach (ShortCar c in context.Database.SqlQuery(typeof(ShortCar),
                    "Select CarId, Make from Inventory"))
                {
                    WriteLine(c);
                }

            }
        }

        private static void FunWithLinqQueries()
        {
            using (var context = new AutoLotEntities())
            {
                var colorsMakes = from item in context.Cars select new { item.Color, item.Make };
                foreach (var item in colorsMakes)
                {
                    WriteLine(item);
                }
            }
        }
        private static void ChainingLinqQueris()
        {
            using (var context = new AutoLotEntities())
            {
                //not doing
                DbSet<Car> allData = context.Cars;

                //not doing
                var colorsMakes = from item in allData select new { item.Color, item.Make };

                //now doing
                foreach (var item in colorsMakes)
                {
                    WriteLine(item);
                }
            }
        }

        private static void RemoveRecord(int carId)
        {
            using (var context = new AutoLotEntities())
            {
                Car carToDelete = context.Cars.Find(carId);
                if (carToDelete != null)
                {
                    context.Cars.Remove(carToDelete);
                }
                if (context.Entry(carToDelete).State != EntityState.Deleted)
                {
                    throw new Exception("Unable to delete the record");
                }
                context.SaveChanges();
            }
        }

        private static void RemoveMultipleRecords(IEnumerable<Car> carToRemoves)
        {
            using (var context = new AutoLotEntities())
            {
                Car carToDelete = context.Cars.Find(carToRemoves);
                if (carToDelete != null)
                {
                    context.Cars.RemoveRange(carToRemoves);
                }
                if (context.Entry(carToDelete).State != EntityState.Deleted)
                {
                    throw new Exception("unable to delete the record");
                }
                context.SaveChanges();
            }
        }

        private static void RemoveRecordusingEntityState(int carId)
        {
            using (var context = new AutoLotEntities())
            {
                Car carToDelete = new Car { CarId = carId };
                context.Entry(carToDelete).State = EntityState.Deleted;
                try
                {
                    context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    WriteLine(ex);
                }
            }
        }

        private static void UpdateRecord(int carId)
        {
            using (var context = new AutoLotEntities())
            {
                Car carToUpdate = context.Cars.Find(carId);
                if (carToUpdate != null)
                {
                    WriteLine(context.Entry(carToUpdate).State);
                    carToUpdate.Color = "Blue";
                    WriteLine(context.Entry(carToUpdate).State);
                    context.SaveChanges();
                }
            }
        }
    }
}
