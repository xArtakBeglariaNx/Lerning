using OOP_step_129_ADO.NET_EF_AutoLotDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_129_ADO.NET_EF_AutoLotDAL.Repos
{
    public class InventoryRepo : BaseRepo<Inventory>
    {
        public override List<Inventory> GetAll()
            => Context.Cars.OrderBy(x => x.PetName).ToList();
    }
}
