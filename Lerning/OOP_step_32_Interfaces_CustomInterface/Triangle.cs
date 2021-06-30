using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_32_Interfaces_CustomInterface
{
    class Triangle : Shape, IPointy
    {
        public Triangle() { }
        public Triangle(string name) : base(name) { }
        public override void Draw()
        {
            Console.WriteLine($"Triange drawing - {PetName}, Triange have {Points} points\n=============================");
        }
        public byte Points => 3;

    }
}
