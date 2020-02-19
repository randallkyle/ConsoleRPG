using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game0
{
    public interface StatusEffect
    {
        void Use(Mob mob);

        int Rounds
        {
            get;
        }
    }
}
