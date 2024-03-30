using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    public class NoCardState : IATMState
    {
        private ATMMachine machine;

        public NoCardState(ATMMachine machine)
        {
            this.machine = machine;
        }

        public void EnterPincode()
        {
            Console.WriteLine("No card has been inserted");
        }

        public void InsertCard()
        {
            Console.WriteLine("Card has been inserted");
            machine.SetMachineState(machine.GetCardPresentState());
        }

        public void RejectCard()
        {
            Console.WriteLine("No card has been inserted");
        }

        public void WithdrawCash()
        {
            Console.WriteLine("No card has been inserted");
        }
    }
}
