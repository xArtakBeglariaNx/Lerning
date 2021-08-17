using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: CLSCompliant(true)]

namespace OOP_step_84_SystemReflection_AttributedCarLibrary
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = false, Inherited = false)]
    public sealed class VehicleDescriptionAttribute : Attribute
    {
        public string Description { get; set; }
        public VehicleDescriptionAttribute(string vehicleDescription)
            => Description = vehicleDescription;
        public VehicleDescriptionAttribute() { }
    }

    [Serializable]
    [VehicleDescription(Description = "My Rocking Harley")]
    public class Motorcycle
    {

    }

    [Serializable]
    [Obsolete("Use another vehicle")]
    [VehicleDescription("The old gray mare, she ain't what she used to be...")]
    public class HorseAndBuggy
    {

    }

    [VehicleDescription("A very long, slow, but feature - rich auto")]
    public class Winnebago
    {

    }
}
