using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_72_ObjectsLifeTime_LazyObjectInstantiation
{
    class AllTracks
    {
        private Song[] allSongs = new Song[10000];
                
        public AllTracks()
        {
            //заполняем массив
            Console.WriteLine("Filling up the songs");
        }
    }
}
