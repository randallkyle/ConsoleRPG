using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game0.Models
{
    class WereWolf : Mob
    {
        public WereWolf()
        {
            this.MobType = "WereWolf";
            this.Health=150;
            this.Level=25;
            this.ArmorLevel = this.Level;
            this.ArmourHealth = 25;

        }
    }
}
