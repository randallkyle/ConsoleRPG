using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game0.Models
{
    class Zombie : Mob
    {
        public Zombie()
        {
            this.MobType = "Zombie";
            this.Health = 75;
            this.Level = 1;
        }
    }
}
