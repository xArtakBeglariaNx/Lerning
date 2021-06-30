using System;

namespace OOP_step_25_PolymorphInterfaces_Shapes
{
    class ThreeDCircle : Circle
    {
        public new string PetName { get; set; }

        public new void Draw()
        {
            Console.WriteLine("\n********************\nThreeD circle drawing - {0}\n********************", PetName);
        }
    }
}
