using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game0.Models
{
    class FireStaff : IWeapon
    {
        public int fireDamage;
        private int damage;

        public FireStaff()
        {
            //scale weapons to the player level
            this.fireDamage = 10 + Player.ThePlayer.Level;
            this.damage = 5 + Player.ThePlayer.Level;
        }


        public void Use(Mob mob)
        {
            //handle the logic to do damage to health and armor here. 
            // fire damage ignores armor
            mob.FireDamage = this.FireDamage;
            mob.DamageReceived = this.Damage;
        }


        //accessor methods
        public int Damage
        {
            get { return this.damage; }
        }
        public int FireDamage
        {
            get { return this.fireDamage; }
        }
    }
}
