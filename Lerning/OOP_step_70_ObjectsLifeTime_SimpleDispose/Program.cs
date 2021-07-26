using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_70_ObjectsLifeTime_SimpleDispose
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======= Use IDisposeable =======\n");

            MyResourceWrapper rw = new MyResourceWrapper();
            try
            {
                //использовать rw
                Console.WriteLine($"{rw.GetType().Name}");
            }
            finally
            {
                rw.Dispose();
            }

            DisposeFileStream();
            ToUseUsing();
            Console.ReadLine();
        }

        static void DisposeFileStream()
        {
            Console.WriteLine("\nDiospose in FileStream");
            FileStream fs = new FileStream("myFile.txt", FileMode.OpenOrCreate);
            fs.Close();
            var flag = fs as IDisposable; //пример проверки на использвание интерфейса IDisposable
            if (fs is IDisposable) //пример проверки на использвание интерфейса IDisposable
            {
                Console.WriteLine("Down in If");
                fs.Dispose();
                Console.WriteLine("Dispose FileStream complet");
            }
            else
            {
                Console.WriteLine("FileStream cannot use interface IDosposable");
            }
        }

        static void ToUseUsing()
        {
            Console.WriteLine("\nDispose with using");
            //При использование using метод Dispose() вызывается автоматичкески
            //при выходе за пределы области действия using
            using (MyResourceWrapper rw = new MyResourceWrapper(),
                rw2 = new MyResourceWrapper())
            {
                //использовать объект rw
                Console.WriteLine(rw.GetType().Name.ToString()); //прото для примера
                Console.WriteLine(rw2.GetType().Name.ToString()); //прото для примера
            }
        }
    }
}
