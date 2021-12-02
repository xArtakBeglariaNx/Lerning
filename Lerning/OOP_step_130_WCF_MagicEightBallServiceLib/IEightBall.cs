using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_130_WCF_MagicEightBallServiceLib
{
    [ServiceContract(Namespace = "hhtp://MyCompany.com")]
    public interface IEightBall
    {
        [OperationContract]
        string ObuainAnswerToQuestion(string userQuestion);
    }
}
