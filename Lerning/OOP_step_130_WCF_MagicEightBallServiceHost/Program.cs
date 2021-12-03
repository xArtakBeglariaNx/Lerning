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
            Console.WriteLine("::-- Console based on WCF Host --::\n");
            using (ServiceHost serviceHost = new ServiceHost(typeof(MagicEightBallService)))
            {
                serviceHost.Open();
                DispleyHostInfo(serviceHost);
                Console.WriteLine("The service is ready");
                Console.WriteLine("Press enter to terminate service");
                Console.ReadLine();
            }
        }

        static void DispleyHostInfo(ServiceHost host)
        {
            Console.WriteLine("---- Host ----\n");
            foreach (System.ServiceModel.Description.ServiceEndpoint se in host.Description.Endpoints)
            {
                Console.WriteLine($"Adress: {se.Address}");
                Console.WriteLine($"Binding: {se.Binding}");
                Console.WriteLine($"Contract: {se.Contract}");
            }
            Console.WriteLine("\n<<********************>>\n");
        }
    }
}
