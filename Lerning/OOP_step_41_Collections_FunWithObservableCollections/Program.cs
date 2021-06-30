using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_41_Collections_FunWithObservableCollections
{
    class Program
    {
        
        static void Main(string[] args)
        {
            ObservableCollection<Person> people = new ObservableCollection<Person>()
            {
                new Person("Peter", "Murphy", 35),
                new Person("Kane", "Stone", 23),
                new Person("Stephan", "Linch", 23)
            };
            DisplayCurrentCollection(people);
            Console.WriteLine("************************************");

            people.CollectionChanged += People_CollectionChanged;

            people.Add(new Person("Krisy", "Necromancer", 200));
            DisplayCurrentCollection(people);
            Console.WriteLine("************************************");
            people.Remove(people[0]);
            people.Remove(people[1]);
            Console.WriteLine("************************************");
            DisplayCurrentCollection(people);


            Console.ReadLine();
        }

        private static void People_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            Console.WriteLine($"Action for this event: {e.Action}");

            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
            {
                Console.WriteLine($"This items is removed from collection: ");
                foreach (Person p in e.OldItems)
                {
                    Console.WriteLine($"{p}");
                    Console.WriteLine();
                }
            }

            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
            {
                Console.WriteLine("New item is add: ");
                foreach (Person p in e.NewItems)
                {
                    Console.WriteLine($"{p}");
                }
            }
        }

        static void DisplayCurrentCollection(ObservableCollection<Person> observableCollec)
        {
            Console.WriteLine();
            foreach (Person p in observableCollec)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine();
        }
    }
}
