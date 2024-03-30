using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    public class Computer
    {
        public IHardDisk hardDisk { get; set; }
        public IMonitor monitor { get; set; }
        public IProcessor processor { get; set; }

        public void Test()
        {
            processor.PerformOperation();
            hardDisk.StoreData();
            monitor.Display();
        }
    }
}
