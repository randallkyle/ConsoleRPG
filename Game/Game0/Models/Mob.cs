using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game0
{
    public abstract class Mob
    {
        private int health;
        private int level;
        private string mobType;
        private int armorLevel;
        private bool paralyzed = false;
        private bool alive = true;
        // the violence stuff
        private int fireDamage = 0;
        private int armourHealth;
        private int roundsParalyzed = 0;
        private int damageReceived = 0;


        public string Attack() {
            return "Attacking: " + this.Level + " Damage Done!";

        }
        public string Defend() {
            return "Defending: " + this.Level + " Damage Blocked!";
        }

        public override string ToString()
        {
            return "Level " + this.Level + " " + this.MobType + " Health: " + this.Health;
        }

        public int Level
        {
            get { return this.level; }
            set { this.level = value; }
        }
        public int Health
        {
            get { return this.health; }
            set { this.health = value; }
        }
        public string MobType
        {
            get { return this.mobType; }
            set { this.mobType = value; }
        }
        public int ArmorLevel
        {
            get { return this.armorLevel; }
            set { this.armorLevel = value; }
        }
        public bool Paralyzed
        {
            get { return this.paralyzed; }
            set { this.paralyzed = value; }
        }
        public bool Alive
        {
            get { return this.alive; }
            set { this.alive = value; }
        }
        public int FireDamage
        {
            get { return this.fireDamage; }
            set { this.fireDamage = value; }
        }
        public int ArmourHealth
        {
            get { return this.armourHealth; }
            set { this.armourHealth = value; }
        }
        public int RoundsParalyzed
        {
            get { return this.roundsParalyzed; }
            set { this.roundsParalyzed = value; }
        }
        public int DamageReceived
        {
            set {
                if (this.armourHealth == 0)
                {
                    //double damage if no armor health left
                    this.Health -= value*2;
                }
                else
                {
                    // the damage is reduced by the mob's armor level
                    this.Health -= (value*((100-armorLevel)/100));
                }
                //apply fire damage
                this.Health -= this.FireDamage;
                this.FireDamage = 0;

                //kill the mob if their health drops below 0:
                if (this.Health <= 0)
                {
                    this.Alive = false;
                }
            }
            
        }
        public int ArmourDamageReceived
        {
            set
            {
                if (this.armourHealth > value)
                {
                    this.armourHealth -= value;
                }
                else
                {
                    this.armourHealth = 0;
                }
                
            }
        }

    }
}
