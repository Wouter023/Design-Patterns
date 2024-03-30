using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    public class Adapter : IAttacker
    {
        private Robot robot;

        public Adapter(Robot robot)
        {
            this.robot = robot;
        }

        public string Driver { get => robot.Person; }

        public void AssignDriver(string driver)
        {
            robot.MoveByPerson(driver);
        }

        public void DriveForward()
        {
            robot.WalkForward();
        }

        public void UseWeapon()
        {
            robot.BashWithHands();
        }
    }
}
