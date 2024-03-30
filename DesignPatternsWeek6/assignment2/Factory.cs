using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    abstract class Factory
    {
        public abstract IHardDisk GetHardDisk();

        public abstract IMonitor GetMonitor();

        public abstract IProcessor GetProcessor();
    }
}
