using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game0.Models
{
    // Create Mobs based on their type. Zombie if inccorrectly specified as I am lazy and wont throw exceptions
    public class MobFactory
    {
        public static List<Mob> CreateList(int SceneLevel)
        {
            List<Mob> moblist = new List<Mob>();

            //creates 10 mobs, picks their types based on player and scene level
            Random rndm = new Random();
            
            foreach (int i in Enumerable.Range(1, SceneLevel*10))
            {
                //random mob spawn level based on 5 levels below the player level, and 10 above their level
                int spawnLevel = rndm.Next(Math.Abs(Math.Min(Player.ThePlayer.Level, SceneLevel) - 10), Math.Max(Player.ThePlayer.Level, SceneLevel) + 20);

                if (spawnLevel < 25)
                {
                    moblist.Add(MobFactory.Create("Zombie"));
                }
                else if (spawnLevel < 40)
                {
                    moblist.Add(MobFactory.Create("WereWolf"));
                }
                else if (spawnLevel >= 40)
                {
                    moblist.Add(MobFactory.Create("Giant"));
                }
            }
            return moblist;
        }

        public static Mob Create(string type)
        {
            if (type == "Zombie")
            {
                return new Zombie();
            }
            else if (type == "WereWolf")
            {
                return new WereWolf();
            }
            else if (type == "Giant")
            {
                return new Giant();
            }
            else
            {
                return new Zombie();
            }
        }
    }
}
