using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_114_SysIO_DirectoryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==== Fun with DirectoryInfo ====\n");
            ShowWindowsDirectoryInfo();
            DisplayImageFiles();
            ModifyAppDirectory();
            FunWithDirectoryType();
            Console.ReadLine();
        }

        static void ShowWindowsDirectoryInfo()
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Windows");
            Console.WriteLine("=== Directory Info ====");
            Console.WriteLine($"FullName: {dir.FullName}");
            Console.WriteLine($"Name: {dir.Name}");
            Console.WriteLine($"Parent: {dir.Parent}");
            Console.WriteLine($"Creation: {dir.CreationTime}");
            Console.WriteLine($"Attributes: {dir.Attributes}");
            Console.WriteLine($"Root: {dir.Root}");
            Console.WriteLine("===============================");
        }

        static void DisplayImageFiles()
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\artge\Desktop\ScreenShots");

            FileInfo[] imageFiles = dir.GetFiles("*.png", SearchOption.AllDirectories);

            Console.WriteLine($"Found {imageFiles.Length}.png files\n");

            foreach (FileInfo f in imageFiles)
            {
                Console.WriteLine("----------------------");
                Console.WriteLine($"File name: {f.Name}");
                Console.WriteLine($"File length: {f.Length}");
                Console.WriteLine($"Creation: {f.CreationTime}");
                Console.WriteLine($"Attributes: {f.Attributes}");
                Console.WriteLine("----------------------");
            }
        }

        static void ModifyAppDirectory()
        {
            DirectoryInfo dir = new DirectoryInfo(@"D:\My Files");
                        
            dir.CreateSubdirectory(@"DontTouch");
            dir.CreateSubdirectory(@"DontTouch\VD");

            DirectoryInfo dirVD = new DirectoryInfo(@"D:\My Files\DontTouch\VD");
            Console.WriteLine($"Creation: {dirVD.CreationTime}");

            DirectoryInfo dirTest = new DirectoryInfo(@"D:\");
            dirTest.CreateSubdirectory(@"Test");
            dirTest.CreateSubdirectory(@"Test2\Data");
        }

        static void FunWithDirectoryType()
        {
            string[] drives = Directory.GetLogicalDrives();
            Console.WriteLine("Here are your drives: \n");
            foreach (string s in drives)
            {
                Console.WriteLine($"--> {s}");
            }
            Console.WriteLine("Press Enter to delete directories");
            Console.ReadLine();
            try
            {
                Directory.Delete(@"D:\Test");
                Directory.Delete(@"D:\Test2", true);
            }
            catch (IOException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
        }
    }
}
