using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace OOP_step_149_WPF_WpfNotifications.Models
{
    public class Inventory : INotifyPropertyChanged
    {
        private int _carId;
        public int CarId
        {
            get { return _carId; }
            set {
                if (value == _carId) return;
                _carId = value;
                OnPropertyChanged();
            }
        }

        private string _make;
        public string Make
        {
            get { return _make; }
            set {
                if(value == _make) return;
                _make = value;
                OnPropertyChanged(nameof(Make));
            }
        }

        private string _color;
        public string Color
        {
            get { return _color; }
            set {
                if(value == _color) return;
                _color = value;
                OnPropertyChanged(nameof(Color));
            }
        }

        private string _petName;
        public string PetName
        {
            get => _petName;
            set {
                if (value == _petName) return;
                _petName = value;
                OnPropertyChanged(nameof(PetName));
            }
        }

        private bool _isChanged;
        public bool IsChanged
        {
            get => _isChanged;
            set {
                if (value == _isChanged) return;
                _isChanged = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if(propertyName != nameof(IsChanged))
            {
                IsChanged = true;
            }
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
