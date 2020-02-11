using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game0.Models
{
    public abstract class Mob
    {
        private int health;
        private int level;
        private string mobType;
        public string Attack() {
            return "Attacking: "+ this.Level +" Damage Done!";

        }
        public string Defend() { 
            return "Defending: "+ this.Level +" Damage Blocked!";
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


    }
}
