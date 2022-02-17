using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using  OOP_step_153_WPF_WpfMvvm.Cmds;
using OOP_step_153_WPF_WpfMvvm.ViewModels;

namespace OOP_step_153_WPF_WpfMvvm
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