using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace OOP_step_133_WPF_WpfTesterApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            Application.Current.Properties["GodMode"] = false;

            foreach (var arg in e.Args)
            {
                if (arg.Equals("GodMode", StringComparison.OrdinalIgnoreCase))
                {
                    Application.Current.Properties["GodMode"] = true;
                    break;
                }
            }
        }

        private void App_OnExit(object sender, ExitEventArgs e)
        {

        }
    }
}
