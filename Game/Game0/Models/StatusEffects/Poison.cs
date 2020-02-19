using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game0
{
    public class Poison : DamageEffect
    {
        // this uses damage effect class, does X damage over N rounds
        Poison()
        {
            this.Damage = 5;
            this.Rounds = 10;
        }
    }
}
