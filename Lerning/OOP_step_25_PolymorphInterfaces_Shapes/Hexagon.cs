using System;

namespace OOP_step_25_PolymorphInterfaces_Shapes
{
    class Hexagon : Shape
    {
        public Hexagon() { }
        public Hexagon (string name) : base(name) { }

        public override void Draw()
        {
            Console.WriteLine("Hexagon drawing - {0} \n=============================", PetName);
        }
    }
}
