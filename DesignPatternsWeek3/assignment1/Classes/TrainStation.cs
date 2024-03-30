using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1.Classes
{
    public class TrainStation
    {
        public string name;
        public string track;
        private TimeSpan arrivalTime;
        private TimeSpan depatureTime;

        public TrainStation(string name, string track, TimeSpan arrivalTime, TimeSpan depatureTime)
        {
            this.name = name;
            this.track = track;
            this.arrivalTime = arrivalTime;
            this.depatureTime = depatureTime;
        }
    }
}
