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

namespace OOP_step_144_WPF_ObjectResourcesApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Ok_OnClick(object sender, RoutedEventArgs e)
        {

            if (Resources["myBrush"] is RadialGradientBrush)
            {
                var brush = (RadialGradientBrush)Resources["myBrush"];                
                brush.GradientStops[1] = new GradientStop(Colors.Black, 0.0);
                //brush.GradientStops.Add(new GradientStop(Colors.Coral, 0.15));
            }
            else
            {
                Resources["myBrush"] = new RadialGradientBrush();
            }
        }

        private void Cancel_OnClick(object sender, RoutedEventArgs e)
        {
            if (Resources["myBrush"] is RadialGradientBrush)
            {
                Resources["myBrush"] = new SolidColorBrush(Colors.Gray);
            }
            else
            {
                Resources["myBrush"] = new RadialGradientBrush(Colors.Violet, Colors.WhiteSmoke);
            }
        }
    }
}
