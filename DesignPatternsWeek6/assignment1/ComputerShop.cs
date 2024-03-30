using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public abstract class ComputerShop
    {
        public Computer AssebleComputer()
        {
            Computer computer = new Computer();
            computer.processor = CreateProcessor();
            computer.monitor = CreateMonitor();
            computer.hardDisk = CreateHardDisk();
            return computer;
        }

        public abstract IProcessor CreateProcessor();
        public abstract IMonitor CreateMonitor();
        public abstract IHardDisk CreateHardDisk();
    }
}
