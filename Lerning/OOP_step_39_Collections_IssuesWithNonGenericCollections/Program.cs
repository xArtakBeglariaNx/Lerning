using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//код для примера не запускать!!!!

namespace OOP_step_39_Collections_IssuesWithNonGenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkWithArraylist();
            Console.WriteLine("=========");
            ArrayListOfRandomObjects();
            Console.WriteLine("=========");
            UsePersonCollection();
            Console.WriteLine("=========");
            UseGenericCollection();
            Console.ReadLine();
        }

        #region Simple boxing/unboxing
        private void SimpleBoxingUnboxing()
        {
            int myInt = 25;
            object boxedInt = myInt;

            try
            {
                long longUnboxed = (long)boxedInt;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        #endregion

        #region ArrayList boxing/unboxing
        static void WorkWithArraylist()
        {
            ArrayList myInts = new ArrayList();
            myInts.Add(15);
            myInts.Add(5);
            myInts.Add(25);
            myInts.Add(35);

            int i = (int)myInts[0];

            Console.WriteLine($"Value in myInts: {i}");
        }
        #endregion

        #region ArrayList can hold anything
        static void ArrayListOfRandomObjects()
        {
            ArrayList allObjects = new ArrayList();
            allObjects.Add(true);
            allObjects.Add(new OperatingSystem(PlatformID.MacOSX, new Version(10, 0)));
            allObjects.Add(66);
            allObjects.Add(3.14);

            for (int i = 0; i < allObjects.Count; i++)
            {
                Console.WriteLine(allObjects[i]);
            }
        }
        #endregion

        #region Use custom generic class
        static void UsePersonCollection()
        {
            PersonCollection myPeople = new PersonCollection();
            myPeople.Addperson(new Person("Homer", "Simpson", 40));
            myPeople.Addperson(new Person("Marge", "Simpson", 38));
            myPeople.Addperson(new Person("Bart ", "Simpson", 7));
            myPeople.Addperson(new Person("Lisa ", "Simpson", 9));
            myPeople.Addperson(new Person("Maggi", "Simpson", 2));

            foreach (Person p in myPeople)
            {
                Console.WriteLine(p);
            }
        }
        #endregion

        #region Use heneric list
        static void UseGenericCollection()
        {
            List<Person> people = new List<Person>();
            people.Add(new Person("Frank", "Black", 32));

            Console.WriteLine(people[0]);

            List<int> myInt = new List<int>();
            myInt.Add(2);
            myInt.Add(23);
            myInt.Add(myInt[0] + myInt[1]);
            Console.WriteLine($"myInt[0] = {myInt[0]}\nmyInt[1] = {myInt[1]}\nmyInt[2] = {myInt[2]}");
        }
        #endregion

    }
}
