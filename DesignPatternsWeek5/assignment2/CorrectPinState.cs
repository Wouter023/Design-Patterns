using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    public class CorrectPinState : IATMState
    {
        private ATMMachine machine;
        public CorrectPinState(ATMMachine machine)
        {
            this.machine = machine;
        }
        public void EnterPincode()
        {
            Console.WriteLine("Pincode has already been entered");
        }

        public void InsertCard()
        {
            Console.WriteLine("A card has been inserted already");
        }

        public void RejectCard()
        {
            Console.WriteLine("Your card has been rejected");
        }

        public void WithdrawCash()
        {
            Console.WriteLine("Please enter amount of cash: ");
            int amount = int.Parse(Console.ReadLine());

            if(machine.AmountInMachine < amount)
            {
                Console.WriteLine("Not enough cash available in machine");
                Console.WriteLine("Your card has been rejected");
                machine.SetMachineState(machine.GetNoCashState());
            }
            else
            {
                Console.WriteLine($"{amount} withdrawn from machine");
                machine.SetAmountInMachine(amount - machine.AmountInMachine);
                Console.WriteLine("Your card has been rejected");
                machine.SetMachineState(machine.GetNoCardState());
            }
        }
    }
}
