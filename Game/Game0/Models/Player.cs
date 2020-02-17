using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game0
{
    sealed class Player
    {
        private int level = 0;
        private string name = "n/a";
        private static readonly Player thePlayer;
        private IWeapon weapon;
        //public static Player instance { get; set; }
        private Player()
        {
        }
        static Player()
        {
            Player player = new Player();
            Player.thePlayer = player;
        }
        public void PlayerMaker(int lvl, string pname)
        {
            this.level = lvl;
            this.name = pname;
        }

        public int Level
        {
            get { return this.level; }
            set { this.level = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public static Player ThePlayer
        {
            get
            {
                return Player.thePlayer;
            }
        }
        public IWeapon Weapon
        {
            get { return this.weapon; }
            set { this.weapon = value; }
        }
    }

}
