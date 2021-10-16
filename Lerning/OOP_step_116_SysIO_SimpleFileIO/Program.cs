using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_116_SysIO_SimpleFileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==== Simple I/O with File Type ====\n");

            string[] myTasks = { "Fix bathroom sink", "Call Dave", "Call Mom and Dad", "Play XBOX One"};

            File.WriteAllLines(@"C:\Users\artge\source\repos\GitReps\Lerning\OOP_step_116_SysIO_SimpleFileIO\tasks.txt", myTasks);

            foreach (string tasks in File.ReadLines (@"C:\Users\artge\source\repos\GitReps\Lerning\OOP_step_116_SysIO_SimpleFileIO\tasks.txt") )
            {
                Console.WriteLine($"TODO: {tasks}");
            }
            Console.ReadLine();
        }
    }
}
