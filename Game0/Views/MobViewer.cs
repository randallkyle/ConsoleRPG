using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game0.Models;

namespace Game0.Views
{
    class MobViewer : ConsoleViewer
    {
        public static void View(Mob mob)
        {
            MobViewer.View(mob.MobType + " Health: " + mob.Health + "; "+mob.MobType+" Level: " + mob.Level);
        }

        public static void View(List<Mob> MobList)
        {
            foreach (Mob monster in MobList)
            {
                MobViewer.View(monster);
            }
        }
    }
}
