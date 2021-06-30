using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_30_MultipleException_ProcessMultipleExceptions
{
    class CarIsDeadException : ApplicationException
    {
        private string messageDetails = String.Empty;
        public DateTime ErrorTimeStamp { get; set; }
        public string CauseOfError { get; set; }

        public CarIsDeadException() { }
        public CarIsDeadException(string message, string cause) : this (message, cause, DateTime.Now) { }
        public CarIsDeadException(string message, string cause, DateTime time) : base (message)
        {
            CauseOfError = cause; 
            ErrorTimeStamp = time;
        }

        public override string Message => $"Car Error Message: {messageDetails} -|- {CauseOfError} -|- {ErrorTimeStamp}";
    }
}
