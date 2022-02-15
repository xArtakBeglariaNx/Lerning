using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using OOP_step_152_WPF_WpfViewModel.Cmds;
using OOP_step_152_WPF_WpfViewModel.Models;
using OOP_step_152_WPF_WpfViewModel.ViewModels;

namespace OOP_step_152_WPF_WpfViewModel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        public MainWindowViewModel ViewModel { get; set; } = new MainWindowViewModel();
    }
}