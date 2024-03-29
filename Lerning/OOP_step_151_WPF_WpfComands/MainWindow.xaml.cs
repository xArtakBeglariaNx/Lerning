﻿using System;
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
using OOP_step_151_WPF_WpfCommands.Cmds;
using OOP_step_151_WPF_WpfCommands.Models;

namespace OOP_step_151_WPF_WpfCommands
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
            _cars.Add(new Inventory { CarId = 1, Color = "Blue", Make = "Chevy", PetName = "Kit", IsChanged = false });
            _cars.Add(new Inventory { CarId = 2, Color = "Red", Make = "Ford", PetName = "Red rider", IsChanged = false });
            cboCars.ItemsSource = _cars;
        }
        
        private ICommand _changeColorCommand = null;
        public ICommand ChangeColorCmd => _changeColorCommand ?? (_changeColorCommand = new ChangeColorCommand());

        private ICommand _addCarCommand = null;
        public ICommand AddCarCmd => _addCarCommand ?? (_addCarCommand = new AddCarCommand());

        private RelayCommand<Inventory> _deleteCarCommand = null;
        public RelayCommand<Inventory> DeleteCarCmd => _deleteCarCommand ?? (_deleteCarCommand = new RelayCommand<Inventory>(DeleteCar, CanDeleteCar));

        private bool CanDeleteCar(Inventory car)
        {
            return car != null;
        }

        private void DeleteCar(Inventory car)
        {
            _cars.Remove(car);
        }
    }
}
