using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    public class MP3Player : IObservable
    {
        Random random = new Random();
        private List<Song> songs;
        private List<IObserver> observers;
        public Song CurrentSong { get; private set; }

        public MP3Player()
        {
            songs = new List<Song>();
            observers = new List<IObserver>();

            FillSongs();
        }

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void NextSong() 
        {
            CurrentSong = songs[random.Next(0, songs.Count)];

            NotifyObservers();
        }

        public void NotifyObservers()
        {
            foreach(IObserver observer in observers)
            {
                observer.Update(CurrentSong);
            }
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        private void FillSongs()
        {
            songs.Add(new Song("Papillon", "Editors", new TimeSpan(0, 5, 24)));
            songs.Add(new Song("Wish You Were Here", "Pink Floyd", new TimeSpan(0, 5, 39)));
            songs.Add(new Song("Dazed and Confused", "Led Zeppelin", new TimeSpan(0, 6, 26)));
            songs.Add(new Song("Billionaire", "Bruno Mars", new TimeSpan(0, 3, 31)));
        }
    }
}
