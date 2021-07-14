using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_59_ExtendingTools_ExtensionMethods
{
    static class MyExtensions
    {
        //This method allows an object of any type
        //to display the assembly in which it is located

        public static void DisplayDifiningAssambly(this object obj)
        {
            Console.WriteLine($"{obj.GetType().Name} lives here: => {Assembly.GetAssembly(obj.GetType()).GetName().Name}");
        }

        //This method allows any integer value to reverse the order

        public static int ReverseDigits(this int i)
        {
            char[] digits = i.ToString().ToCharArray();

            //change to reverse the order
            Array.Reverse(digits);

            //insert back to the string
            string newDigits = new string(digits);

            //return the modified string how int
            return int.Parse(newDigits);
        }
    }
}
