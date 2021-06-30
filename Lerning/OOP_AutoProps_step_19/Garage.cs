using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_AutoProps_step_19
{
    class Garage
    {
        public int NumberOfCars { get; set; } = 1;
        public Car MyAuto { get; set; }

        public Garage() { }

        public Garage(Car car, int number)
        {
            NumberOfCars = number;
            MyAuto = car;
        }
    }
}
