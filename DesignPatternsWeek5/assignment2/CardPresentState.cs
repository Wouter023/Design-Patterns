using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    public class CardPresentState : IATMState
    {
        private ATMMachine machine;
        public CardPresentState(ATMMachine machine)
        {
            this.machine = machine;
        }

        public void EnterPincode()
        {
            Console.WriteLine($"Enter you pincode: ");
            int pinCode = int.Parse(Console.ReadLine());
            if(pinCode == 1234)
            {
                Console.WriteLine("You have entered the correct pincode");
                machine.SetMachineState(machine.GetCorrectPinState());
            }
            else
            {
                Console.WriteLine("Invalid pincode");
            }
        }

        public void InsertCard()
        {
            Console.WriteLine("A card has been inserted already");
        }

        public void RejectCard()
        {
            Console.WriteLine("Your card has been rejected");
            machine.SetMachineState(machine.GetNoCardState());
        }

        public void WithdrawCash()
        {
            Console.WriteLine("Please enter pincode first");
        }
    }
}
