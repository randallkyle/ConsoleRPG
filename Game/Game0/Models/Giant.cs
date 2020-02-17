using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game0.Models
{
    class Giant : Mob
    {
        public Giant()
        {
            this.MobType = "Giant";
            this.Health = 500;
            this.Level = 40;
            this.ArmorLevel = this.Level;
            this.ArmourHealth = 250;

        }
    }
}
