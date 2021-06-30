using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_27_SystemObject_ObjectOverrides
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Fun with System.Object =====\n");

            ObjectActions();
            
            DisplayInfo("Ehhhhh");
            DisplayInfo(32);

            Console.ReadLine();
        }

        static void ObjectActions()
        {
            Person p1 = new Person("Homer", "Simpson", 50, "213-snr-321");
            Person p2 = new Person("Homer", "Simpson", 60, "213-snr-321");


            Console.WriteLine("ToString: {0}", p1.ToString());
            Console.WriteLine("ToString: {0}", p2.ToString());
            DisplayInfo();

            Console.WriteLine("GetHashCode: {0}", p1.GetHashCode());
            Console.WriteLine("GetHashCode: {0}", p2.GetHashCode());
            DisplayInfo();

            Console.WriteLine("GetType: {0}", p1.GetType());
            Console.WriteLine("GetType: {0}\n", p2.GetType());
            DisplayInfo();

            Console.WriteLine("Equals p1 = p2?: {0}", p1.Equals(p2));
            DisplayInfo();

            Person p3 = new Person("Shally", "Lon", 32, "12-mng-545");
            Person p4 = new Person("Shally", "Lon", 32, "12-mng-545");            

            Console.WriteLine("GetHashCode: {0}", p3.GetHashCode());
            Console.WriteLine("GetHashCode: {0}", p4.GetHashCode());
            DisplayInfo();

            Console.WriteLine("Static Equals [compare to states] p3 & p4: {0}", object.Equals(p3, p4));
            Console.WriteLine("Static RefEquals [compare to references] p3 & p4: {0}", object.ReferenceEquals(p3, p4));
            DisplayInfo();

            /*Person p2 = p1;
            object o = p2;
            if (o.Equals(p1) && p2.Equals(o))
            {
                Console.WriteLine("Same instance");
            }*/
            Console.WriteLine();
        }

        static void DisplayInfo()
        {
            Console.WriteLine("*****************************************\n");
        }
        static void DisplayInfo(string x)
        {
            Console.WriteLine(x);
        }
        static void DisplayInfo(int x)
        {
            Console.WriteLine(x);
        }
    }
}
