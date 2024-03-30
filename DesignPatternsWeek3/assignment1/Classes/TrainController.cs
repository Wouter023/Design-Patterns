using assignment1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1.Classes
{
    public class TrainController : ITrainController
    {
        private ITrainJourney trainJourney;

        public TrainController(TrainJourney trainJourney)
        {
            this.trainJourney = trainJourney;
        }
        public void NextStation()
        {
            trainJourney.NextStation();
        }
    }
}
