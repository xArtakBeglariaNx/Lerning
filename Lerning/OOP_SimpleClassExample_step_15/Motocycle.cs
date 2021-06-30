using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_SimpleClassExample_step_15
{
    class Motocycle
    {
        public int driverIntensity;
        public string drivarName;

        public void PopAWeew()
        {
            SetDriverName(drivarName);
            for (int i = 0; i <= driverIntensity; i++)
            {
                Console.WriteLine($"N{i}:   AAAAAAA....... Intensity is \"{driverIntensity}\"");
            }
        }
        public Motocycle()
        {

        }
        //public Motocycle(int intensity) : this(intensity, "Arhael")
        //{
        //    Console.WriteLine("\nIn ctor taking an int");
        //}

        //public Motocycle(string name) : this(7, name)
        //{
        //    Console.WriteLine("\nIn ctor taking string");
        //}

        //public Motocycle(int intensity, string name)
        //{
        //    if (intensity > 10)
        //    {
        //        intensity = 10;
        //    }
        //    driverIntensity = intensity;
        //    drivarName = name;
        //}

        public Motocycle(int intensity = 0, string name = "")
        {
            if (intensity > 10)
            {
                intensity = 10;
            }
            driverIntensity = intensity;
            drivarName = name;
        }

        public void SetDriverName(string name)
        {
            drivarName = name;
            Console.WriteLine($"{drivarName} saying:");
        }
    }
}
