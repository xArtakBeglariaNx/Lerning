using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_117_SysIO_FileStreamApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Fun with FileStreams ---");

            //Get obj FileStream
            using (FileStream fStream = File.Open(@"C:\Users\artge\source\repos\GitReps\Lerning\OOP_step_117_SysIO_FileStreamApp\myMessage.dat", FileMode.Create))
            {
                //Encoding string in Array of bytes
                string msg = "Hello";
                byte[] msgAsByteArray = Encoding.Default.GetBytes(msg);

                //Whrite byte[] in file
                fStream.Write(msgAsByteArray, 0, msgAsByteArray.Length);

                //Reset the internal("внутренняя") position of the stream
                fStream.Position = 0;

                //reed byte[] from file and show on console
                Console.Write("Your message as an array of bytes: ");
                byte[] bytesFromFile = new byte[msgAsByteArray.Length];

                for (int i = 0; i < msgAsByteArray.Length; i++)
                {
                    bytesFromFile[i] = (byte)fStream.ReadByte();
                    Console.Write(bytesFromFile[i]);
                }

                //show decoded message
                Console.Write("\nDecoded message: ");
                Console.WriteLine(Encoding.Default.GetString(bytesFromFile));
            }
            Console.ReadLine();
        }
    }
}