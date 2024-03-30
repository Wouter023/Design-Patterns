using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    class ComputerShop
    {
        private Factory _Factory;

        public ComputerShop(Factory Factory)
        {
            _Factory = Factory;
        }

        public Computer AssebleComputer()
        {
            Computer computer = new Computer();
            computer.processor = _Factory.GetProcessor();
            computer.monitor = _Factory.GetMonitor();
            computer.hardDisk = _Factory.GetHardDisk();
            return computer;
        }
    }
}
