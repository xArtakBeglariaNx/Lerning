using System.Drawing;
using System.Windows;
using System.Windows.Input;

namespace OOP_step_136_WPF_WPFRoutedEvents
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string _mouseActivity = string.Empty;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnClickMe_Clicked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Clicked the button!");
            MessageBox.Show(_mouseActivity, "Your Event Info");
            _mouseActivity = "";
        }

        private void AddEventInfo(object sender, RoutedEventArgs e)
        {
            _mouseActivity += string.Format(
                $"{sender} sent a {e.RoutedEvent.RoutingStrategy} event named {e.RoutedEvent.Name}.");
        }

        private void outerEllipse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            AddEventInfo(sender, e);
        }

        private void outerEllipse_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            AddEventInfo(sender, e);
        }
    }
}
