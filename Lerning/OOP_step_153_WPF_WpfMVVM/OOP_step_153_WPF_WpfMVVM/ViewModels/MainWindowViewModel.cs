using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using OOP_step_153_WPF_WpfMvvm.Cmds;
using OOP_step_129_ADO.NET_EF_AutoLotDAL.Models;
using OOP_step_129_ADO.NET_EF_AutoLotDAL.Repos;

namespace OOP_step_153_WPF_WpfMvvm.ViewModels
{
    public class MainWindowViewModel
    {
        public IList<Inventory> Cars { get; }

        public MainWindowViewModel()
        {
            Cars = new ObservableCollection<Inventory>(new InventoryRepo().GetAll());
        }
        
        private ICommand _changeColorCommand;
        public ICommand ChangeColorCmd => _changeColorCommand ?? (_changeColorCommand = new ChangeColorCommand());

        private ICommand _addCarCommand;
        public ICommand AddCarCmd => _addCarCommand ?? (_addCarCommand = new AddCarCommand());
        

        private RelayCommand<Inventory> _deleteCarCommand;
        public RelayCommand<Inventory> DeleteCarCmd => _deleteCarCommand ?? (_deleteCarCommand = new RelayCommand<Inventory>(DeleteCar, CanDeleteCar));

        private bool CanDeleteCar(Inventory car)
        {
            return car != null;
        }

        private void DeleteCar(Inventory car)
        {
            Cars.Remove(car);
        }
    }
}