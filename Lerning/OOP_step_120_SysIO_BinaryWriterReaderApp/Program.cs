using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_120_SysIO_BinaryWriterReaderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Fun with Binary Writer / Readers ---");

            //open binary writing tool to a file
            FileInfo file = new FileInfo(@"C:\Users\artge\source\repos\GitReps\Lerning\OOP_step_120_SysIO_BinaryWriterReaderApp\BinaryFile.dat");
            using (BinaryWriter binaryWriter = new BinaryWriter(file.OpenWrite()))
            {
                //display on console BaseStream
                //(System.IO.FileStream in this case)
                Console.WriteLine($"Base Stream  is: {binaryWriter.BaseStream}");

                //Create data for saving in file
                double aDouble = 1234.67;
                int aInt = 132;
                string aString = "A, B, C";

                //Write data in file
                binaryWriter.Write(aDouble);
                binaryWriter.Write(aInt);
                binaryWriter.Write(aString);

                Console.WriteLine("Done!\n");
                binaryWriter.Close();

                //Read from binary file
                Console.WriteLine("Reading data in BinaryFile.dat");
                using (BinaryReader binaryReader = new BinaryReader(file.OpenRead()))
                {
                    Console.WriteLine(binaryReader.ReadDouble());
                    Console.WriteLine(binaryReader.ReadInt32());
                    Console.WriteLine(binaryReader.ReadString());
                }
            }

            Console.ReadLine();
        }
    }
}
