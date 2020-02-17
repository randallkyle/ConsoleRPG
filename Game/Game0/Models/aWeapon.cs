using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game0.Models
{
    public abstract class aWeapon : IWeapon
    {
        // Ignore this class, i do not use it currently
        private int damage_level;
        public int Damage
        {
            get { return this.damage_level; }
        }
        public void Use(Mob mob)
        {
            //handle the logic to do damage to health and armor here. 
            // I am going to do damage to both health and armor, but health is reduced by the amount of armor
            // when the armor is 0 a bonus takes effect i guess
            mob.DamageReceived = this.Damage;
        }
    }
}
