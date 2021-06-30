using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_37_Interfaces_ICloneable_CloneablePoint
{
    class PointDescription
    {
        public string PetName { get; set; }
        public Guid PointID { get; set; }

        public PointDescription()
        {
            PetName = "No-Name";
            PointID = Guid.NewGuid();
        }
    }
}
