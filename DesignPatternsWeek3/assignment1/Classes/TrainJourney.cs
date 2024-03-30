using assignment1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1.Classes
{
    public class TrainJourney : ITrainJourney
    {
        private List<ITrainDisplay> displays;
        private TrainStation currentStation;
        private List<TrainStation> stations;
        private int kutStationCount;

        public List<ITrainDisplay> Displays { get { return displays; } }
        public TrainStation CurrentStation { get { return Stations[KutStationCount]; } }
        public List<TrainStation> Stations { get { return stations; } } 
        public int KutStationCount { get { return kutStationCount; } }

        public void NextStation()
        {
            kutStationCount++;

            if(KutStationCount >= Stations.Count)
            {
                kutStationCount = 1;
                Stations.Reverse();
            }

            UpdateDisplays();
        }

        private void UpdateDisplays()
        {
            foreach (ITrainDisplay trainDisplay in Displays)
            {
                trainDisplay.Update(CurrentStation);
            }
        }

        public TrainJourney()
        {
            displays = new List<ITrainDisplay>();
            stations = new List<TrainStation>()
            {
                new TrainStation("Den Helder", "3", new TimeSpan(12, 34, 00), new TimeSpan(12, 34, 00)),
                new TrainStation("Den Helder Zuid", "1", new TimeSpan(12, 38, 00), new TimeSpan(12, 38, 00)),
                new TrainStation("Anna Paulowna", "1", new TimeSpan(12, 44, 00), new TimeSpan(12, 45, 00)),
                new TrainStation("Schagen", "1", new TimeSpan(12, 52, 00), new TimeSpan(12, 52, 00)),
                new TrainStation("Heerhugowaard", "1", new TimeSpan(13, 01, 00), new TimeSpan(13, 01, 00)),
                new TrainStation("Alkmaar Noord", "1", new TimeSpan(13, 07, 00), new TimeSpan(13, 07, 00)),
                new TrainStation("Alkmaar", "5", new TimeSpan(13, 11, 00), new TimeSpan(13, 14, 00)),
                new TrainStation("Heiloo", "2", new TimeSpan(13, 19, 00), new TimeSpan(13, 19, 00)),
                new TrainStation("Castricum", "2", new TimeSpan(13, 25, 00), new TimeSpan(13, 25, 00)),
                new TrainStation("Zaandam", "4", new TimeSpan(13, 38, 00), new TimeSpan(13, 38, 00)),
                new TrainStation("Amsterdam Sloterdijk", "5", new TimeSpan(13, 45, 00), new TimeSpan(13, 45, 00)),
                new TrainStation("Amsterdam Centraal", "4b", new TimeSpan(13, 51, 00), new TimeSpan(13, 54, 00)),
                new TrainStation("Amsterdam Amstel", "4", new TimeSpan(14, 02, 00), new TimeSpan(14, 03, 00)),
                new TrainStation("Utrecht Centraal", "19", new TimeSpan(14, 21, 00), new TimeSpan(14, 23, 00)),
                new TrainStation("Driebergen-Zeist", "2", new TimeSpan(14, 31, 00), new TimeSpan(14, 31, 00)),
                new TrainStation("Ede-Wageningen", "5", new TimeSpan(14, 47, 00), new TimeSpan(14, 49, 00)),
                new TrainStation("Arnhem Centraal", "8", new TimeSpan(14, 59, 00), new TimeSpan(15, 05, 00)),
                new TrainStation("Nijmegen", "3", new TimeSpan(15, 17, 00), new TimeSpan(15, 17, 00)),
            };
        }
        public void AddObserver(ITrainDisplay trainDisplay)
        {
            Displays.Add(trainDisplay);
            trainDisplay.Update(CurrentStation);
        }

        public void RemoveObserver(ITrainDisplay trainDisplay)
        {
            Displays.Remove(trainDisplay);
        }


    }
}
