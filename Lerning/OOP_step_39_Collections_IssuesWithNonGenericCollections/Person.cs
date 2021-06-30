using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_39_Collections_IssuesWithNonGenericCollections
{
    class Person
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person() { }
        public Person(string firstname, string lastname, int age)
        {
            Age = age;
            FirstName = firstname;
            LastName = lastname;
        }

        public override string ToString()
        {
            return $"Name: {FirstName} {LastName}    Age:{Age}";
        }
    }
}
