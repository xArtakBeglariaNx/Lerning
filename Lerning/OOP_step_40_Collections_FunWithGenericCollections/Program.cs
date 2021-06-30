using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_40_Collections_FunWithGenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Fun with Generic Collections ======");
            UseGenericList();
            Console.WriteLine("************************************");
            UseGenericStack();
            Console.WriteLine("************************************");
            UseGenericQueue();
            Console.WriteLine("************************************");
            UseSortedSet();
            Console.WriteLine("************************************");
            UseDictionary();
            Console.WriteLine("************************************");
            Console.ReadLine();
        }

        #region Generic Collection List<T>
        static void UseGenericList()
        {
            List<Person> people = new List<Person>()
            {
                new Person("Homer", "Simpson", 50),
                new Person("Marge", "Simpson", 48),
                new Person("Lisa", "Simpson", 9),
                new Person("Bart", "Simpson", 7)
            };

            Console.WriteLine($"List Person have {people.Count} elemenst\n");

            foreach (Person p in people)
            {
                Console.WriteLine(p);
            }


            Console.WriteLine("\n-> Inserting new persons in collections"); // Insert: Add new element in index place
            people.Insert(4, new Person("Maggie", "Simpson", 2));
            people.Insert(5, new Person("Fabio", "Simpson", 1));

            foreach (Person p in people)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine($"List Person have {people.Count} elemenst\n");

            try
            {
                ArgumentOutOfRangeException exx = new ArgumentOutOfRangeException($"\nElement which you trying to add have not right index");
                throw exx;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}\n");
            }

            Console.WriteLine($"Items in List<Person> {people.Count}");

            //Copy data to new Array

            Person[] peopleOfArray = people.ToArray();

            foreach (Person p in peopleOfArray)
            {
                Console.WriteLine($"First name: {p.FirstName}");
            }
            Console.WriteLine($"peopleOfArray have type: {peopleOfArray.GetType().Name}");
        }
        #endregion

        #region Generic Collection Stack<T>
        static void UseGenericStack()
        {
            Stack<Person> stackOfPeople = new Stack<Person>();
            stackOfPeople.Push(new Person("Homer", "Simpson", 50));
            stackOfPeople.Push(new Person("Marge", "Simpson", 48));
            stackOfPeople.Push(new Person("Lisa", "Simpson", 9));
            //Watch alepets and execute item after this
            Console.WriteLine($"First item: {stackOfPeople.Peek()}");
            Console.WriteLine($"Poped off: {stackOfPeople.Pop()}");
            Console.WriteLine($"\nFirst person is: {stackOfPeople.Peek()}");
            Console.WriteLine($"Poped off: {stackOfPeople.Pop()}");
            Console.WriteLine($"\nFirst person: {stackOfPeople.Peek()}");
            Console.WriteLine($"Poped off: {stackOfPeople.Pop()}");

            try
            {
                Console.WriteLine($"\nFirst person: {stackOfPeople.Peek()}");
                Console.WriteLine($"Poped off: {stackOfPeople.Pop()}");
            }
            catch (InvalidOperationException ex)
            {

                Console.WriteLine($"\n{ex.Message}");
            }
        }
        #endregion

        #region Generic Collection Queue<T>
        static void GetCoffee(Person p)
        {
            Console.WriteLine($"{p.FirstName} got coffee");
        }

        static void UseGenericQueue()
        {
            Queue<Person> queueOfPeople = new Queue<Person>();
            queueOfPeople.Enqueue(new Person("Homer", "Simpson", 50));
            queueOfPeople.Enqueue(new Person("Marge", "Simpson", 48));
            queueOfPeople.Enqueue(new Person("Bart", "Simpson", 7));

            Console.WriteLine($"First in queue: {queueOfPeople.Peek().FirstName}");
            GetCoffee(queueOfPeople.Dequeue());
            GetCoffee(queueOfPeople.Dequeue());
            GetCoffee(queueOfPeople.Dequeue());

            try
            {
                GetCoffee(queueOfPeople.Dequeue());
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error! {ex.Message}");
            }
        }
        #endregion

        #region Generic Collection SortedSet<T>
        static void UseSortedSet()
        {
            SortedSet<Person> sortedSetOfPeople = new SortedSet<Person>(new SortPeopleByAge())
            {
                new Person{ FirstName = "Homer", LastName = "Simpson", Age = 48},
                new Person{ FirstName = "Marge", LastName = "Simpson", Age = 45},
                new Person{ FirstName = "Lisa", LastName = "Simpson", Age = 9},
                new Person{ FirstName = "Bart", LastName = "Simpson", Age = 7}
            };

            foreach (Person p in sortedSetOfPeople)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("================");

            sortedSetOfPeople.Add(new Person() { FirstName = "Saske", LastName = "Kazama", Age = 16 });
            sortedSetOfPeople.Add(new Person() { FirstName = "Naruto", LastName = "Shinpuden", Age = 14 });

            foreach (Person p in sortedSetOfPeople)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("================");

            sortedSetOfPeople.Remove(sortedSetOfPeople.Min);

            foreach (Person p in sortedSetOfPeople)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine(sortedSetOfPeople.Count);
        }
        #endregion

        #region Generic Collection Dictionary<TKey, TValue>
        static void UseDictionary()
        {
            Dictionary<string, Person> peopleA = new Dictionary<string, Person>();
            peopleA.Add("Homer", new Person("Homer", "Simpson", 35));
            peopleA.Add("Marge", new Person("Marge", "Simpson", 33));
            peopleA.Add("Lisa", new Person("Lisa", "Simpson", 10));

            Person homer = peopleA["Homer"];
            Console.WriteLine(homer);

            Dictionary<string, Person> peopleB = new Dictionary<string, Person>()
            {
                { "Homer", new Person{FirstName = "Homer", LastName = "Simpson", Age = 35 } },
                { "Marge", new Person{FirstName = "Marge", LastName = "Simpson", Age = 33 } },
                { "Bart", new Person{FirstName = "Bart", LastName = "Simpson", Age = 12 } }
            };
            Person bart = peopleB["Bart"];
            Console.WriteLine(bart);
            

            Dictionary<string, Person> peopleC = new Dictionary<string, Person>()
            {
                ["Homer"] = new Person{ FirstName = "Homer", LastName = "Simpson", Age = 35 },
                ["Marge"] = new Person{ FirstName = "Marge", LastName = "Simpson", Age = 33 },
                ["Lisa"] = new Person{ FirstName = "Lisa", LastName = "Simpson", Age = 10 },
            };

            peopleC.Remove("Marge");

            try
            {
                Person marge = peopleC["Marge"];
                Console.WriteLine(marge);
            }
            catch (KeyNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine($"{peopleC["Lisa"]}");

        }
        #endregion
    }
}
