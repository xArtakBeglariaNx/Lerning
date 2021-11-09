using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using OOP_step_129_ADO.NET_EF_AutoLotDAL.EF;
using OOP_step_129_ADO.NET_EF_AutoLotDAL.Models;
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
            Console.ReadLine();
        }
    }
}
