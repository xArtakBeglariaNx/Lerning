using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: CLSCompliant(true)]

namespace OOP_step_84_SystemReflection_AttributedCarLibrary
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, Inherited = false)]
    public sealed class VehicleDescriptionAttribute : System.Attribute
    {
        public string Description { get; set; }
        public VehicleDescriptionAttribute(string vehicleDescription)
            => Description = vehicleDescription;
        public VehicleDescriptionAttribute() { }
    }
}
