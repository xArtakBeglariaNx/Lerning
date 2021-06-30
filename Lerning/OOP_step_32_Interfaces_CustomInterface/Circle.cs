using System;

namespace OOP_step_32_Interfaces_CustomInterface
{
    class Circle : Shape, IDraw3D
    {
        public Circle() { }
        public Circle (string name) : base (name) { }

        public override void Draw()
        {
            Console.WriteLine("Circle drawing - {0}\n=============================", PetName);
        }

        public void Draw3D()
        {
            Console.WriteLine("Drawing Circle in 3D");
        }
    }
}
