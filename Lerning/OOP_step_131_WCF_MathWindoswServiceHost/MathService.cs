using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using OOP_step_131_WCF_MathServiceLibrary;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_131_WCF_MathWindoswServiceHost
{
    public partial class MathService : ServiceBase
    {
        private ServiceHost myHost;
        public MathService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            #region Another method
            //проверить для подствраховки
            //      myHost?.Close();
            //demonstrate ABC in code
            //      Uri address = new Uri("http://localhost:8080/OOP_step_131_WCF_MathServiceLibrary");
            //      WSHttpBinding binding = new WSHttpBinding();
            //      Type contract = typeof(IBasicMath);
            //      myHost.AddServiceEndpoint(contract, binding, address);
            #endregion

            //Just to be safe
            myHost?.Close();
            // Create the host and specify a URL for an HTTP binding.
            myHost = new ServiceHost(typeof(MathService), new Uri("http://localhost:8080/OOP_step_131_WCF_MathServiceLibrary"));
            myHost.AddDefaultEndpoints();
            myHost.Open();
        }

        protected override void OnStop()
        {
            myHost?.Close();
        }
    }
}
