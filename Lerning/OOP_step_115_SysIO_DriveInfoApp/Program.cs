using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_115_SysIO_DriveInfoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==== Fun with DriveInfo ====\n");

            DriveInfo[] myDrives = DriveInfo.GetDrives();

            foreach (DriveInfo d in myDrives)
            {
                Console.WriteLine($"Name: {d.Name}");
                Console.WriteLine($"Type: {d.DriveType}");

                if (d.IsReady)
                {
                    Console.WriteLine($"Free space: {d.TotalFreeSpace}");
                    Console.WriteLine($"Format: {d.DriveFormat}");
                    Console.WriteLine($"Label: {d.VolumeLabel}");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
