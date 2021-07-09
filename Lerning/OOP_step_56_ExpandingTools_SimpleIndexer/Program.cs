using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_56_ExpandingTools_SimpleIndexer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Fun with Indexers =====\n");

            PersonCollection myPeople = new PersonCollection();
            myPeople[0] = new Person("Homer", "Simpson", 40);
            myPeople[1] = new Person("Marge", "Simpson", 38);
            myPeople[2] = new Person("Lisa", "Simpson", 9);
            myPeople[3] = new Person("Bart", "Simpson", 7);
            myPeople[4] = new Person("Maggie", "Simpson", 2);

            for (int i = 0; i < myPeople.Count; i++)
            {
                Console.Write($"Person number: N{i + 1}\tName: {myPeople[i].FirstName} {myPeople[i].LastName}\tAge: {myPeople[i].Age}\n");
            }

            Console.WriteLine("===========================");

            UseGenericListOfPeople();

            Console.WriteLine("===========================");

            PersonCollectionTwo myPeopleTwo = new PersonCollectionTwo();
            myPeopleTwo["Homer"] = new Person("Homer", "Simpson", 40);
            myPeopleTwo["Marge"] = new Person("Marge", "Simpson", 38);

            Person homer = myPeopleTwo["Homer"];

            Console.WriteLine(myPeopleTwo["Marge"]);
            Console.WriteLine(homer.ToString());

            Console.WriteLine("===========================");

            MultiIndexerWithDataTable();

            Console.ReadLine();
        }

        static void UseGenericListOfPeople()
        {
            List<Person> myPeople = new List<Person>();
            myPeople.Add(new Person("Lisa", "Simpson", 9));
            myPeople.Add(new Person("Bart", "Simpson", 7));

            myPeople[0] = new Person("Maggie", "Simpson", 2);  // изменяем первый объект в списке

            for (int i = 0; i < myPeople.Count; i++)
            {
                Console.Write($"Person number: N{i + 1}\tName: {myPeople[i].FirstName} {myPeople[i].LastName}\tAge: {myPeople[i].Age}\n");
            }
            Console.WriteLine();
        }

        static void MultiIndexerWithDataTable()
        {
            //Create simple object with three columns
            DataTable myTable = new DataTable();
            myTable.Columns.Add(new DataColumn("First Name"));
            myTable.Columns.Add(new DataColumn("Last Name"));
            myTable.Columns.Add(new DataColumn("Age"));
            //Add Row int table
            myTable.Rows.Add("Amily", "Appleby", 60);
            //Use MultiIndexer for to display first row on console
            Console.WriteLine($"First Name: {myTable.Rows[0][0]}");
            Console.WriteLine($"Last Name: {myTable.Rows[0][1]}");
            Console.WriteLine($"Age: {myTable.Rows[0][2]}");
            Console.WriteLine();
        }
    }
}
