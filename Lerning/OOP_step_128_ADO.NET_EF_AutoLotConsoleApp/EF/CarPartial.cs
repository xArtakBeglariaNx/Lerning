using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_128_ADO.NET_EF_AutoLotConsoleApp.EF
{
    public partial class Car
    {
        public override string ToString()
        {
            return $"{this.CarNickName ?? "-- No Name --"} is a {this.Color} {this.Make} with ID {this.CarId}";
        }
    }
}
