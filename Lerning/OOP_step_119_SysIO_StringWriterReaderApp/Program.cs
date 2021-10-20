using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_119_SysIO_StringWriterReaderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Fun with StringWriter / StringReader ---");

            //Create obj StringWriter and write symbols data in memory
            using (StringWriter stWriter = new StringWriter())
            {
                stWriter.WriteLine("Don't forget Mother's day");

                //get copy stWriter (saved in memory) and display on console
                Console.WriteLine($"Contents of StringWriter: {stWriter}");

                //Get inside object StringBuilder
                StringBuilder sb = stWriter.GetStringBuilder();
                sb.Insert(0, "Hey!!");
                Console.WriteLine($"->{sb}");
                sb.Remove(0, "Hey!!".Length);
                Console.WriteLine($"->{sb}");

                //Read data from object StringWriter
                using (StringReader stReader = new StringReader(stWriter.ToString()))
                {
                    string input = null;
                    while ((input = stReader.ReadLine()) != null)
                    {
                        Console.WriteLine(input);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
