﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game0.Views;
using Game0.Models;

namespace Game0
{
    public class Scene
    {
        /*
        * 3.)	A Scene Object
        * a.	That has a private property Player, that holds an Object of type Player
        * b.	A method that is passed in a player’s level and generates a list of monsters based on the level, e.g. monsters should be stronger and more numerous as player level increases
        * c.	A method that prints out all of the monsters in the level, i.e. print out the type, level and health of the monsters
        * d.	Also, the scene should have a sceneLevel variable which also modifies the monsters generated.
        */

        private Player player;
        private List<Mob> mobList;
        private int sceneLevel;
        public Scene()
        {
            this.player = Player.ThePlayer;
            this.sceneLevel = 0;
            this.mobList = new List<Mob>();
            
        }

        public void spawnMobs()
        {
            this.mobList = MobFactory.CreateList(this.SceneLevel);
        }

        //should pass the mob list to the viewer, kept this method for the sake of the requirements
        public void ListMonsters()
        {
            foreach (Mob monster in this.MobList)
            {
                MobViewer.View(monster);
            }
        }

        // this is used with the MobViewer
        public List<Mob> MobList
        {
            get
            {
                return this.mobList;
            }
        }
        public int SceneLevel
        {
            get { return this.sceneLevel; }
            set { this.sceneLevel = value; }
        }
    }
}
