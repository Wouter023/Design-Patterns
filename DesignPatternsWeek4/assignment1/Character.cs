using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public abstract class Character
    {
        private IWeaponBehaviour weapon;

        public IWeaponBehaviour Weapon
        {
            get { return weapon; }
            set { weapon = value; }
        }

        public Character()
        {
             
        }
        public void Fight()
        {
            Weapon.UseWeapon();
        }
    }
}
