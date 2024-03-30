using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    public class NoCashState : IATMState
    {
        private ATMMachine machine;

        public NoCashState(ATMMachine machine)
        {
            this.machine = machine;
        }

        public void EnterPincode()
        {
            Console.WriteLine("Not enough cash available");
        }

        public void InsertCard()
        {
            Console.WriteLine("Not enough cash available");
        }

        public void RejectCard()
        {
            Console.WriteLine("Not enough cash available");
        }

        public void WithdrawCash()
        {
            Console.WriteLine("Not enough cash available");
        }
    }
}
