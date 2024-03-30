using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    public class SimpleMP3Display : IObserver
    {
        private IObservable simplePlayer;

        public SimpleMP3Display(IObservable simplePlayer)
        {
            this.simplePlayer = simplePlayer;
            simplePlayer.AddObserver(this);
        }
        public void Update(Song song)
        {
            Console.WriteLine($"Simple display: {song.Artist} - {song.Title}");
        }
    }
}
