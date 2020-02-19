using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game0
{
    public class DamageEffect : StatusEffect
    {
        private int damage;
        private int rounds;

        public void Use(Mob mob)
        {
            mob.Health -= this.Damage;
            this.Rounds -= 1;
            if (this.Rounds <= 0)
            {
                mob.RemoveStatusEffect(this);
            }
        }
        public int Rounds
        {
            get { return this.rounds; }
            set { this.rounds = value; }
        }
        public int Damage
        {
            get { return this.damage; }
            set { this.damage = value; }
        }
    }
}
