using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_27_SystemObject_ObjectOverrides
{
    class Person
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public int Age { get; set; }
        public string SSN { get; set; } = "";

        public Person(string firstName, string lastName, int age, string ssn)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            SSN = ssn;
        }
        public Person() { }

        public override string ToString()
        {
            return $"[First Name: {FirstName}; Last Name: {LastName}; Age: {Age};]";
        }

        /*public override bool Equals(object obj)
        {
            if (obj is Person && obj != null)
            {
                Person temp;
                temp = (Person)obj;
                if (temp.FirstName == this.FirstName
                        && temp.LastName == this.LastName
                        && temp.Age == this.Age)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }*/
        public override bool Equals(object obj) => obj?.ToString() == ToString();

        public override int GetHashCode() => SSN.GetHashCode();
    }

}
