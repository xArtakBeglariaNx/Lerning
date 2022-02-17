using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_step_129_ADO.NET_EF_AutoLotDAL.Models.Base;

namespace OOP_step_129_ADO.NET_EF_AutoLotDAL.Models
{
	public partial class Inventory : EntityBase, IDataErrorInfo
	{
        public override string ToString()
        {
            // Since the PetName column could be empty, supply
            // the default name of **No Name**.
            return $"{this.PetName ?? "**No Name**"} is a {this.Color} {this.Make} with ID {this.Id}.";
        }
        [NotMapped]
        public string MakeColor => $"{Make} + ({Color})";

        private string _error;
        public string Error => _error;

        public string this[string columnName]
        {
            get {
                bool hasError = false;
                switch (columnName)
                {
                    case nameof(Id):
                        AddErrors(nameof(Id), GetErrorsFromAnnotations(nameof(Id), Id));
                        break;
                    case nameof(Make):
                        hasError = CheckMakeAndColor();
                        if (Make == "ModelT")
                        {
                            AddError(nameof(Make), "Too Old");
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
                return String.Empty;
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
    }
}
