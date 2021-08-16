using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_83_SystemReflection_ApplyingAttributes
{
    [Serializable]
    public class Motorcycle
    {
        /// <summary>
        /// this field not saved
        /// </summary>
        [NonSerialized]
        float weightOfCurrentPassengers;

        /// <summary>
        /// this fields also [Serializable]
        /// </summary>
        bool hasRadioSystem;
        bool hasHeadSet;
        bool hasSyssyBar;

    }
}
