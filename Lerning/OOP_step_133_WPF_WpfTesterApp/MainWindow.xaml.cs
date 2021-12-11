using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OOP_step_133_WPF_WpfTesterApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Closed += MainWindow_OnClosed;
            this.Closing += MainWindow_Closing;
            this.MouseMove += MainWindow_MouseMove;
            this.KeyDown += MainWindow_KeyDown;
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            ClickMe.Content = e.Key.ToString();
        }

        private void MainWindow_MouseMove(object sender, MouseEventArgs e)
        {
            this.Title = e.GetPosition(this).ToString();
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string msg = "Do you want close without saving?";
            MessageBoxResult result = MessageBox.Show(msg, "My App", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }

        private void MainWindow_OnClosed(object sender, EventArgs e)
        {
            MessageBox.Show("See ya!");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)Application.Current.Properties["GodMode"])
            {
                MessageBox.Show("Cheater!");
            }
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            this.Title = e.GetPosition(this).ToString();
        }

        private void MyCalendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
