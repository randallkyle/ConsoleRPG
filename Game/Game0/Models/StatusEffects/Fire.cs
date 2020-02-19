using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game0
{
    public class Fire : DamageEffect
    {
        // another damage type 
        public Fire()
        {
            this.Damage = 10;
            this.Rounds = 2;
        }
      
    }
}
