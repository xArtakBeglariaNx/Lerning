using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_29_ApplicationException_CustomException
{
    class CarIsDeadExceptionVer2 : ApplicationException
    {
        public DateTime ErrorTimeStamp { get; set; }
        public string CauseOfError { get; set; }

        public CarIsDeadExceptionVer2() { }
        public CarIsDeadExceptionVer2(string message ,string cause, DateTime time) : base(message)
        {            
            CauseOfError = cause;
            ErrorTimeStamp = time;
        }
    }
}
