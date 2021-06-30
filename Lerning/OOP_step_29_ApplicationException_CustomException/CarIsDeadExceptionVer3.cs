using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_29_ApplicationException_CustomException
{
    [Serializable]
    class CarIsDeadExceptionVer3 : ApplicationException
    {
        public CarIsDeadExceptionVer3() { }
        public CarIsDeadExceptionVer3(string message) : base(message) { }
        public CarIsDeadExceptionVer3(string message, SystemException inner) : base(message, inner) { }

        protected CarIsDeadExceptionVer3(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
