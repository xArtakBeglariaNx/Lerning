using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_56_ExpandingTools_SimpleIndexer
{
    class PersonCollectionTwo : IEnumerable
    {
        private Dictionary<string, Person> listPeople = new Dictionary<string, Person>();

        public void ClearPeople()
        {
            listPeople.Clear();
        }
        public int Count => listPeople.Count;

        IEnumerator IEnumerable.GetEnumerator() => listPeople.GetEnumerator();

        public Person this[string name]
        {
            get => (Person)listPeople[name];
            set => listPeople[name] = value;
        }
    }
}
