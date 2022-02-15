using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using OOP_step_152_WPF_WpfViewModel.Cmds;
using OOP_step_152_WPF_WpfViewModel.Models;

namespace OOP_step_152_WPF_WpfViewModel.ViewModels
{
    public class MainWindowViewModel
    {
        public IList<Inventory> Cars { get; } = new ObservableCollection<Inventory>();

        public MainWindowViewModel()
        {
            Cars.Add(new Inventory {CarId = 1, Color = "Blue", Make = "Chevy", PetName = "Kit", IsChanged = false});
            Cars.Add(new Inventory {CarId = 2, Color = "Red", Make = "Ford", PetName = "Red rider", IsChanged = false});
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