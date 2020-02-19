using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game0.Models
{
    class FireStaff : IWeapon
    {
        //TODO add radius
        //public int fireDamage;
        //this is the weapon's base damage
        private int damage;

        public FireStaff()
        {
            //scale weapons to the player level
            //this.fireDamage = 10 + Player.ThePlayer.Level;

            // might reduce the damage or add mode
            this.damage = 4;// 5 + Player.ThePlayer.Level;
        }


        public void Use(Mob mob)
        {
            //handle the logic to do damage to health and armor here. 
            // fire damage ignores armor
            mob.AddStatusEffect(new Fire()); // fix the creation to be from a pool?
            //mob.FireDamage = this.FireDamage;
            mob.DamageReceived = this.Damage;
        }


        //accessor methods
        public int Damage
        {
            get { return this.damage; }
        }
        /*public int FireDamage
        {
            get { return this.fireDamage; }
        }
        */
    }
}
