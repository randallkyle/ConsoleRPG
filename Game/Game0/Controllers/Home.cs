using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game0.Views;
using Game0.Models;

namespace Game0
{
    class Home
    {
        //this is the main progam loop
        static void Main(string[] args)
        {
            // setup the environment:

            // Create the Player singleton object
            Player aPlayer1 = Player.ThePlayer;
            //using the scene object:
            Scene scene = new Scene();
            scene.SceneLevel = 25;

            //  ------------------------------------------ BEGIN TESTING CODE ----------------------------------------

            PlayerViewer.View();
            PlayerViewer.View("Enter a name:");
            //Change player name and level to match input and test case
            aPlayer1.PlayerMaker(1, Console.ReadLine());
            aPlayer1.Weapon = new FireStaff();

            PlayerViewer.View("Enemies Nearby: ");
            // use the scene object:
            // create new list of mobs
            scene.spawnMobs();
            //using the required print method: (I also can use views, see below)
            scene.ListMonsters();
  
            // test the attack and defense methods
            foreach (Mob mob in scene.MobList)
            {
                while (mob.Alive)
                {
                    aPlayer1.Weapon.Use(mob);
                    PlayerViewer.View(mob.ToString());
                }
            }
            
            //PlayerViewer.View("Testing a New Level:");
            //increase the player level
            //aPlayer1.PlayerMaker(25, aPlayer1.Name);
            //increase the scene level
            //scene.SceneLevel = 25;
            // create new mobs
            //scene.spawnMobs();
            //print the mobs using the view instead of the other method
            //MobViewer.View(scene.MobList);
            
            //  -------------------------------------------- END TESTING CODE ----------------------------------------


            // Exit code
            PlayerViewer.View("Any a Key to Exit: ");
            if (Console.ReadKey().Key == ConsoleKey.Enter){

                //Add skyrim code here later
                PlayerViewer.View("Ralof: Hey, you. You're finally awake.");
                System.Threading.Thread.Sleep(3000);
                PlayerViewer.View("You were trying to cross the border, right? Walked right into that Imperial ambush, same as us, and that thief over there.");
                System.Threading.Thread.Sleep(4000);
                PlayerViewer.View(" Lokir: Damn you Stormcloaks. Skyrim was fine until you came along. Empire was nice and lazy. If they hadn't been looking for you, I could've stolen that horse and been half way to Hammerfell.");
                System.Threading.Thread.Sleep(4000);
                PlayerViewer.View("You there. You and me -- we should be here. It's these Stormcloaks the Empire wants.");
                System.Threading.Thread.Sleep(3000);
                PlayerViewer.View("Ralof: We're all brothers and sisters in binds now, thief.");
                System.Threading.Thread.Sleep(3000);
                PlayerViewer.View("Lokir: And what's wrong with him? ");
                System.Threading.Thread.Sleep(3000);
                PlayerViewer.View("Ralof: Watch your tongue! You're speaking to Ulfric Stormcloak, the true High King.");
                System.Threading.Thread.Sleep(3000);
                PlayerViewer.View("Lokir: Ulfric? The Jarl of Windhelm? You're the leader of the rebellion. But if they captured you... Oh gods, where are they taking us?");
                System.Threading.Thread.Sleep(3000);
                PlayerViewer.View("Ralof: I don't know where we're going, but Sovngarde awaits.");
                System.Threading.Thread.Sleep(3000);
                PlayerViewer.View("Lokir: No, this can't be happening. This isn't happening. ");
                System.Threading.Thread.Sleep(3000);
                PlayerViewer.View("Ralof: Hey, what village are you from, horse thief? ");
                System.Threading.Thread.Sleep(3000);
                PlayerViewer.View("Lokir: Why do you care? ");
                System.Threading.Thread.Sleep(3000);
                PlayerViewer.View("Ralof: A Nord's last thoughts should be of home. ");
                System.Threading.Thread.Sleep(3000);
            }
            //I might add XML later to make this a parametric 80's style text adventure
        }
    }
}
