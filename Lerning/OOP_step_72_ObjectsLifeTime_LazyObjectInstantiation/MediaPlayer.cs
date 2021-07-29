using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_72_ObjectsLifeTime_LazyObjectInstantiation
{
    class MediaPlayer
    {
        public void Play() { }
        public void Stop() { }
        public void Pause() { }

        private Lazy<AllTracks> allSongs = new Lazy<AllTracks>(() =>
        {
            Console.WriteLine("Creating AllTracks");
            return new AllTracks();
        } );

        public AllTracks GetAllTracks()
        {
            return allSongs.Value;
        }
    }
}
