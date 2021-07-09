using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_56_ExpandingTools_SimpleIndexer
{
    public interface IStringContainer
    {
        string this[int index] { get; set; }
    }
}
