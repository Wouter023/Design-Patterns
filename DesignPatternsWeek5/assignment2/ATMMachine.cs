using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    public class ATMMachine
    {
        private int amountInMachine;
        private IATMState cardPresent;
        private IATMState machineState;
        private IATMState correctPinCode;
        private IATMState noCard;
        private IATMState noCash;

        public int AmountInMachine { get { return amountInMachine; } }

        public ATMMachine(int amountInMachine)
        {
            this.amountInMachine = amountInMachine;
            cardPresent = new CardPresentState(this);
            correctPinCode = new CorrectPinState(this);
            noCard = new NoCardState(this);
            noCash = new NoCashState(this);

            if (amountInMachine > 0)
            {
                machineState = noCard;
            }
            else
            {
                machineState = noCash;
            }
        }

        public void EnterPincode()
        {
            machineState.EnterPincode();
        }

        public IATMState GetCardPresentState()
        {
            return cardPresent;
        }

        public IATMState GetCorrectPinState()
        {
            return correctPinCode;
        }

        public IATMState GetNoCashState()
        {
            return noCash;
        }

        public IATMState GetNoCardState()
        {
            return noCard;
        }

        public void InsertCard()
        {
            machineState.InsertCard();
        }

        public void RejectCard()
        {
            machineState.RejectCard();
        }

        public void SetAmountInMachine(int amountInMachine)
        {
            this.amountInMachine = amountInMachine;
        }

        public void SetMachineState(IATMState machineState)
        {
            this.machineState = machineState;
        }

        public void WithdrawCash()
        {
            machineState.WithdrawCash();
        }
    }
}
