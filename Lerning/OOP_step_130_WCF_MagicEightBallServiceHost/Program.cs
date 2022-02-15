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
            Console.WriteLine("\t::-- Console based on WCF Host --::\n");
            using (ServiceHost serviceHost = new ServiceHost(typeof(MagicEightBallService)))
            {
                serviceHost.Open();
                DispleyHostInfo(serviceHost);
                Console.WriteLine("\tThe service is ready");
                Console.WriteLine("\tPress enter to terminate service");
                Console.ReadLine();
            }
        }

        static void DispleyHostInfo(ServiceHost host)
        {
            Console.WriteLine("\t---- Host ----\n");
            foreach (System.ServiceModel.Description.ServiceEndpoint se in host.Description.Endpoints)
            {
                Console.WriteLine($"\tAddress: {se.Address}");
                Console.WriteLine($"\tBinding: {se.Binding}");
                Console.WriteLine($"\tContract: {se.Contract}\n");
            }
            Console.WriteLine("\n\t<<---------------------->>\n");
        }
    }
}
