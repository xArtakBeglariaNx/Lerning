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
        public bool IsChanged { get; set; }
        public int CarId { get; set; }
        public string Make { get; set; }
        public string Color { get; set; }
        public string PetName { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
