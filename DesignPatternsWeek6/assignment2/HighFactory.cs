using assignment2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    class HighFactory : Factory
    {
        public override IHardDisk GetHardDisk()
        {
            return new ExpensiveHDD();
        }

        public override IMonitor GetMonitor()
        {
            return new ExpensiveMonitor();
        }

        public override IProcessor GetProcessor()
        {
            return new ExpensiveProcessor();
        }
    }
}
