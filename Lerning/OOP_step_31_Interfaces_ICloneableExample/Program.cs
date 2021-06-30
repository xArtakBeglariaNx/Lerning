using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_31_Interfaces_ICloneableExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First Look at a Interfaces\n");

            string str = "Hello";
            OperatingSystem unixOS = new OperatingSystem(PlatformID.Unix, new Version());
            System.Data.SqlClient.SqlConnection sqlConnection =
                new System.Data.SqlClient.SqlConnection();
            CloneMe(str);
            CloneMe(unixOS);
            CloneMe(sqlConnection);
            Console.ReadLine();
        }

        private static void CloneMe(ICloneable c)
        {
            object theClone = c.Clone();
            Console.WriteLine($"Your clone is a: {theClone.GetType().Name}");
        }
    }
}
