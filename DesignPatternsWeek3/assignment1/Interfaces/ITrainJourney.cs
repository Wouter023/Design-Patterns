using assignment1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1.Interfaces
{
    public interface ITrainJourney
    {
        void NextStation();
        TrainStation CurrentStation {  get; }
        void AddObserver(ITrainDisplay trainDisplay);
        void RemoveObserver(ITrainDisplay trainDisplay);
    }
}
