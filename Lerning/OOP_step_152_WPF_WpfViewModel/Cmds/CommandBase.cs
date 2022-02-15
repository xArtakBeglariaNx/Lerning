using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using OOP_step_152_WPF_WpfViewModel.Models;

namespace OOP_step_152_WPF_WpfViewModel.Cmds
{
    public abstract class CommandBase : ICommand
    {

        public abstract bool CanExecute(object parameter);
        public abstract void Execute(object parameter);

        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }
    }
}
