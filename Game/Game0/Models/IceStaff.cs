using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game0.Models
{
    class IceStaff : IWeapon
    {
        public int roundsParalyzed;
        private int damage;

        public IceStaff()
        {
            //scale weapons to the player level
            this.roundsParalyzed = 5 + Player.ThePlayer.Level;
            this.damage = 10 + Player.ThePlayer.Level;
        }


        public void Use(Mob mob)
        {
            // handle the logic to do damage to health and armor here. 
            // No damage done to armor but the effect is not reduced
            mob.RoundsParalyzed = this.RoundsParalyzed;
            mob.DamageReceived = this.Damage;
        }


        //accessor methods
        public int Damage
        {
            get { return this.damage; }
        }
        public int RoundsParalyzed
        {
            get { return this.roundsParalyzed; }
        }
    }
}
