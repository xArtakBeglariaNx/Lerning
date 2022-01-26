using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using OOP_step_151_WPF_WpfComands.Models;

namespace OOP_step_151_WPF_WpfComands.Cmds
{
    public class ChangeColorCommand : CommandBase
    {        
        public override bool CanExecute(object parameter)
        {
            return (parameter as Inventory) != null;
        }

        public override void Execute(object parameter)
        {            
            ((Inventory)parameter).Color = "Pink";
        }
    }
}
