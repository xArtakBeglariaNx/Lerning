using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using OOP_step_149_WPF_WpfNotifications.Models;

namespace OOP_step_149_WPF_WpfNotifications
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IList<Inventory> _cars = new ObservableCollection<Inventory>();
        public MainWindow()
        {
            InitializeComponent();
            _cars.Add(new Inventory { CarId = 1, Color = "Blue", Make = "Chevy", PetName = "Kit", IsChanged = false});
            _cars.Add(new Inventory { CarId = 2, Color = "Red", Make = "Ford", PetName = "Red rider", IsChanged = false});
            cboCars.ItemsSource = _cars;
        }

        private void btnChangeColor_Click(object sender, RoutedEventArgs e)
        {
            _cars.First(x => x.CarId == ((Inventory)cboCars.SelectedItem)?.CarId).Color = "Pink";
        }

        private void btnAddCar_Click(object sender, RoutedEventArgs e)
        {
            var maxCout = _cars?.Max(x => x.CarId) ?? 0;
            _cars?.Add(new Inventory { CarId=++maxCout, Color = "Yellow", Make = "VW", PetName = "Birdie"});
        }
    }
}
