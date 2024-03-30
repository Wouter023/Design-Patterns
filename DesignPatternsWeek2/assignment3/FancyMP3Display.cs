using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    class FancyMP3Display : IObserver
    {
        private IObservable fancyPlayer;

        public FancyMP3Display(IObservable fancyPlayer)
        {
            this.fancyPlayer = fancyPlayer;
            fancyPlayer.AddObserver(this);
        }

        public void Update(Song song)
        {
            Console.WriteLine($"Fancy display: {song.Title} by {song.Artist} ({song.Duration:mm\\:s})");
        }
    }
}
