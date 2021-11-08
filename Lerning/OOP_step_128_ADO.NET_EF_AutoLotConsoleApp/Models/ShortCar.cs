using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_128_ADO.NET_EF_AutoLotConsoleApp.Models
{
    public class ShortCar
    {
        public int CarId { get; set; }
        public string Make { get; set; }
        public override string ToString()
        {
            return $"{this.Make} with ID {this.CarId}";
        }
    }
}
