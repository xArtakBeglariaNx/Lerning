using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_72_ObjectsLifeTime_LazyObjectInstantiation
{
    /// <summary>
    /// Ленивое сознаие объектов
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Fun with Lazy Instantiation =====");

            //После использования типа Lazy<> в этом случае перестает выделяться память под данный обеъкт
            MediaPlayer mediaPlayer = new MediaPlayer();
            mediaPlayer.Play();

            //в данном случае выделяется память под объект т.к вызвался метод GetAllTracks после объявления типа Lazy<>
            MediaPlayer yourPlayer = new MediaPlayer();
            yourPlayer.GetAllTracks();

            Console.ReadLine();
        }
    }
}
