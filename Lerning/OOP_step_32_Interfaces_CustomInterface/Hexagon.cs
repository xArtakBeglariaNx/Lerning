﻿using System;

namespace OOP_step_32_Interfaces_CustomInterface
{
    class Hexagon : Shape, IPointy, IDraw3D
    {
        public Hexagon() { }
        public Hexagon (string name) : base(name) { }

        public byte Points => 6;

        public override void Draw()
        {
            Console.WriteLine("Hexagon drawing - {0}, Hexagon have {1} points \n=============================", PetName, Points);
        }

        public void Draw3D()
        {
            Console.WriteLine("Drawing Hexagon in 3D");
        }
    }
}
