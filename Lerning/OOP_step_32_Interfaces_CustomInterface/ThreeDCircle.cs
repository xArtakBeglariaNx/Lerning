using System;

namespace OOP_step_32_Interfaces_CustomInterface
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
