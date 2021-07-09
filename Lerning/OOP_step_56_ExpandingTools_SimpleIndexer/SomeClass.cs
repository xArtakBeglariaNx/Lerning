using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_56_ExpandingTools_SimpleIndexer
{
    class SomeClass : IStringContainer
    {
        private List<string> myStrings = new List<string>();
        public string this[int index]
        {
            get => myStrings[index]; 
            set => myStrings.Insert(index, value);
        }
    }
}
