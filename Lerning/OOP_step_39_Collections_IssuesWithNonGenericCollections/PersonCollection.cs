using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_39_Collections_IssuesWithNonGenericCollections
{
    class PersonCollection : IEnumerable
    {
        private ArrayList arPeople = new ArrayList();

        public Person GetPerson(int pos) => (Person)arPeople[pos];

        public void Addperson(Person p)
        {
            arPeople.Add(p);
        }
        public void ClearPeople()
        {
            arPeople.Clear();
        }
        public int Count => arPeople.Count;

        public IEnumerator GetEnumerator() => arPeople.GetEnumerator();
    }
}
