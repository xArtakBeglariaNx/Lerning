using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_152_WPF_WpfViewModel.Models
{
    public class EntityBase : INotifyDataErrorInfo
    {
        private readonly Dictionary<string, IList<string>> _errors = new Dictionary<string, IList<string>>();

        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        public bool HasErrors => _errors.Count != 0;

        public IEnumerable GetErrors(string propertyName)
        {
            if (string.IsNullOrEmpty(propertyName))
            {
                return _errors.Values;
            }
            return _errors.ContainsKey(propertyName) ? _errors[propertyName] : null;
        }

        protected void OnErrorsChanged(string propertyNamde)
        {
            ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyNamde));
        }

        protected void AddError(string propertyName, string error)
        {
            AddErrors(propertyName, new List<string>() { error });
        }

        protected void AddErrors(string propertyName, IList<string> errors)
        {
            var changed = false;
            if(errors == null || errors.Count == 0)
            {
                return;
            }
            if (!_errors.ContainsKey(propertyName))
            {
                _errors.Add(propertyName, new List<string>());
                changed = true;
            }
            foreach (var err in errors)
            {
                if (_errors[propertyName].Contains(err)) continue;
                _errors[propertyName].Add(err);
                changed = true;
            }
            if (changed)
            {
                OnErrorsChanged(propertyName);
            }
        }

        protected void ClearErrors(string propertyName = "")
        {
            if (string.IsNullOrEmpty(propertyName))
            {
                _errors.Clear();
            }
            else
            {
                _errors.Remove(propertyName);
            }
            OnErrorsChanged(propertyName);
        }

        protected string[] GetErrorsFromAnnotations<T>(string propertyName, T value)
        {
            var vResult = new List<ValidationResult>();
            var vContext = new ValidationContext(this, null, null) { MemberName = propertyName };
            var isValid = Validator.TryValidateProperty(value, vContext, vResult);
            return (isValid) ? null : Array.ConvertAll(vResult.ToArray(), o => o.ErrorMessage);
        }
    }
}
