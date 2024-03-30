using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    public class Tank : IAttacker
    {
        public string Driver { get; private set; }

        public void AssignDriver(string driver)
        {
            Console.WriteLine($"{driver} is steering the tank");
            Driver = driver;
        }

        public void DriveForward()
        {
            Console.WriteLine("Tank moves forward");
        }

        public void UseWeapon()
        {
            Console.WriteLine($"Tank causes damage with weapon");
        }
    }
}
