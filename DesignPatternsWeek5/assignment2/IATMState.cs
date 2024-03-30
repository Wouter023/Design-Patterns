using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    public interface IATMState
    {
        void EnterPincode();
        void InsertCard();
        void RejectCard();
        void WithdrawCash();
    }
}
