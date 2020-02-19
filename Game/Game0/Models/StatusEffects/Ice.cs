using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game0
{
    public class Ice : StatusEffect
    {
        //this enables paralysis on a mob for N rounds
        private int rounds;

        public Ice()
        {
            this.Rounds = 3;
        }

        //this constructor sets the rounds aka level 
        public Ice(int rounds)
        {
            this.Rounds = rounds;
        }

        //apply effect and decrement rounds
        public void Use(Mob mob)
        {
            mob.Paralyzed=true;
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
    }
}
