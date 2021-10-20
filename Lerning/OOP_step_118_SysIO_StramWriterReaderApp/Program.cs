using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_118_SysIO_StramWriterReaderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Fun with StreamWriter / StreamReader ---");

            //get object StreamWriter and write lines data
            using (StreamWriter writer = File.CreateText(@"C:\Users\artge\source\repos\GitReps\Lerning\OOP_step_118_SysIO_StramWriterReaderApp\remiders.txt"))
            {
                writer.WriteLine("Dont forget mothers day in this year");
                writer.WriteLine("Dont forget fathers day in this year");
                writer.WriteLine("Dont forget this numbers: ");
                for (int i = 0; i < 10; i++)
                {
                    writer.Write(i + "|");
                }
                writer.Write(writer.NewLine);
            }
            Console.WriteLine("Created file and wrote some thoughts...\n");

            //Read data from file
            Console.WriteLine("Here are your thoughts:");
            using(StreamReader reader = File.OpenText(@"C:\Users\artge\source\repos\GitReps\Lerning\OOP_step_118_SysIO_StramWriterReaderApp\remiders.txt"))
            {
                string input = null;
                while ((input = reader.ReadLine()) != null)
                {
                    Console.WriteLine(input);
                }
            }
            Console.ReadLine();
        }
    }
}
