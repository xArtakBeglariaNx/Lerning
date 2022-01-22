using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_150_WPF_WpfValidations.Models
{
    public partial class Inventory : IDataErrorInfo
    {
        private string _error;

        public string this[string columnName]
        {
            get {
                switch (columnName)
                {
                    case nameof(CarId):
                        break;
                    case nameof(Make):
                        if(Make == "ModelT")
                        {
                            return "To old";
                        }
                        return CheckMakeAndColor();
                    case nameof(Color):
                        return CheckMakeAndColor();
                    case nameof(PetName):
                        break;
                }
                return string.Empty;
            }
        }

        private string CheckMakeAndColor()
        {
            if (Make == "Chevy" && Color == "Pink")
            {
                return $"{Make}'s is dont come in {Color}";
            }
            return string.Empty;
        }

        public string Error => _error;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (propertyName != nameof(IsChanged))
            {
                IsChanged = true;
            }
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(string.Empty));
        }
    }
}
