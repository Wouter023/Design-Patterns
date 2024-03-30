using assignment2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    class CheapFactory : Factory
    {
        public override IHardDisk GetHardDisk()
        {
            return new CheapHDD();
        }

        public override IMonitor GetMonitor()
        {
            return new CheapMonitor();
        }

        public override IProcessor GetProcessor()
        {
            return new CheapProcessor();
        }
    }
}
