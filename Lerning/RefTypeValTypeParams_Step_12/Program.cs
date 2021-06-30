using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefTypeValTypeParams_Step_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====Passing Person object by value=====");
            Person fred = new Person("Fred", 55);
            Console.WriteLine("\nBefore by value call, Person is: ");
            fred.Display();
            Person.SendAPersonByValue(fred);
            Console.WriteLine("\nAfter by value call, Person is:");
            fred.Display();
            Person.SendAPersonByValueRef(ref fred);
            Console.WriteLine("\nAfter by value call Ref, Person is:");
            fred.Display();
            Console.ReadLine();
        }        
    }

    class Person
    {
        public string personName;
        public int personAge;

        public Person(string name, int age)
        {
            personAge = age;
            personName = name;
        }
        public Person() { }

        public void Display()
        {
            Console.WriteLine("Name: {0}, Age: {1}", personName, personAge);
        }

        public static void SendAPersonByValue(Person p)
        {
            p.personAge = 39;
            p.personName = "Andy";
            
            p = new Person("Nikki", 99);
        }
        public static void SendAPersonByValueRef(ref Person p)
        {
            p.personAge = 39;
            p.personName = "Andy";

            p = new Person("Nikki", 99);
        }
    }
}
