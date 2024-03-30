using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class BowAndArrowBehavior : IWeaponBehaviour
    {
        public void UseWeapon()
        {
            Console.WriteLine($"Shooting an arrow with a bow");
        }
    }
}
