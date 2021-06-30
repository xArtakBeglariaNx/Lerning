using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_25_PolymorphInterfaces_Shapes
{
    abstract class Shape
    {
        public Shape(string name = "NoName")
        {
            PetName = name;
        }
        public string PetName { get; set; }

        public abstract void Draw();
    }
}
