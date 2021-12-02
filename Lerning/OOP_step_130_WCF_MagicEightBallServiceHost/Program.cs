using System;
using System.Collections.Generic;
using System.Linq;
using OOP_step_130_WCF_MagicEightBallServiceLib;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_130_WCF_MagicEightBallServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("::-- Console based on WCF Host --::");
            using (ServiceHost serviceHost = new ServiceHost(typeof(MagicEightBallService)))
            {
                serviceHost.Open();
                Console.WriteLine("The service is ready");
                Console.WriteLine("Press enter to terminate service");
                Console.ReadLine();
            }
        }
    }
}
