using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    public interface IAttacker
    {
        public string Driver { get; }
        void AssignDriver(string driver);
        void DriveForward();
        void UseWeapon();
    }
}
