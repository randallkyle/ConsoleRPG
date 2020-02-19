using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game0.Models
{
    class Sword : IWeapon
    {
        public int armourDamage;
        private int damage;

        public Sword()
        {
            this.armourDamage = 10 + Player.ThePlayer.Level;
            this.damage = 15 + Player.ThePlayer.Level;
        }


        public void Use(Mob mob)
        {
            //handle the logic to do damage to health and armor here. 
            // I am going to do damage to both health and armor, but health is reduced by the amount of armor
            // when the armor is 0 a bonus takes effect i guess
            mob.ArmourDamageReceived = this.ArmourDamage;
            mob.DamageReceived = this.Damage;
        }


        //accessor methods
        public int Damage
        {
            get { return this.damage; }
        }
        public int ArmourDamage
        {
            get { return this.armourDamage; }
        }
    }
}
