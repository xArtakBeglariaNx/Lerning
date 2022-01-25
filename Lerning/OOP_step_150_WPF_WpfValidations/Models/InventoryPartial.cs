using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_150_WPF_WpfValidations.Models
{
    public partial class Inventory :  EntityBase, IDataErrorInfo
    {        
        public string this[string columnName]
        {
            get {
                bool hasError = false;
                switch (columnName)
                {
                    case nameof(CarId):
                        AddErrors(nameof(CarId), GetErrorsFromAnnotations(nameof(CarId), CarId));
                        break;
                    case nameof(Make):
                        hasError = CheckMakeAndColor();
                        if (Make == "ModelT")
                        {
                            AddError(nameof(Make), $"Too Old");
                            hasError = true;
                        }
                        if (!hasError)
                        {
                            ClearErrors(nameof(Make));
                            ClearErrors(nameof(Color));
                        }
                        AddErrors(nameof(Make), GetErrorsFromAnnotations(nameof(Make), Make));
                        break;
                    case nameof(Color):
                        hasError = CheckMakeAndColor();
                        //if (IsChanged)
                        //{
                        //    AddError(nameof(Color), $"{Color} not match in data base with {Make}");
                        //    hasError = true;
                        //}
                        if (!hasError)
                        {
                            ClearErrors(nameof(Make));
                            ClearErrors(nameof(Color));
                        }
                        AddErrors(nameof(Color), GetErrorsFromAnnotations(nameof(Color), Color));
                        break;
                    case nameof(PetName):
                        AddErrors(nameof(PetName), GetErrorsFromAnnotations(nameof(PetName), PetName));
                        break;
                }
                return Error;
            }
        }

        internal bool CheckMakeAndColor()
        {
            if(Make == "Chevy" && Color == "Pink")
            {
                AddError(nameof(Make), $"{Make}'s dont come in {Color}");
                AddError(nameof(Color), $"{Make}'s dont come in {Color}");
                return true;
            }
            return false;
        }

        public string Error => string.Empty;

        //protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        //{
        //    if (propertyName != nameof(IsChanged))
        //    {
        //        IsChanged = true;
        //    }
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(string.Empty));
        //}
    }
}
