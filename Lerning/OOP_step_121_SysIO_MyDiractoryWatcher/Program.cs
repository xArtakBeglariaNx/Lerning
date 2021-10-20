using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_121_SysIO_MyDiractoryWatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- The Amazing File Watcher App ---");

            //Set the path to the directory that will be monitored
            FileSystemWatcher watcher = new FileSystemWatcher();
            try
            {
                watcher.Path = @"C:\Users\artge\source\repos\GitReps\Lerning\OOP_step_121_SysIO_MyDiractoryWatcher\MyFolder";
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            //Set target for monitoring
            watcher.NotifyFilter = NotifyFilters.LastAccess
                | NotifyFilters.LastWrite
                | NotifyFilters.FileName
                | NotifyFilters.DirectoryName;

            //To target only .txt files
            watcher.Filter = "*.txt";

            //add an event handler
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += (s, e) =>
            {
                Console.WriteLine($"File: --{e.FullPath}-- \n{e.ChangeType}!");
            };
            watcher.Deleted += (s, e) =>
            {
                Console.WriteLine($"File: --{e.FullPath}-- \n{e.ChangeType}!");
            };
            watcher.Renamed += new RenamedEventHandler(OnRanamed);

            //Start monitoring that folder
            watcher.EnableRaisingEvents = true;

            //Wait for the user to quit the program.
            Console.WriteLine(@"Press 'q' to quit app");
            while (Console.Read() != 'q') ;
        }

        static void OnChanged(object sourse, FileSystemEventArgs e)
        {
            Console.WriteLine($"File: --{e.FullPath}-- \n{e.ChangeType}!");
        }

        static void OnRanamed(object sourse, RenamedEventArgs e)
        {
            Console.WriteLine($"File: --{e.OldFullPath}-- ranamed to \n{e.FullPath}");
        }
    }
}
