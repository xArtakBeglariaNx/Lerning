using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace OOP_step_131_WCF_MathServiceLibrary
{    
    [ServiceContract(Namespace ="http://MyCompany.com")]
    public interface IBasicMath
    {
        int Add(int x, int y);
    }
}
