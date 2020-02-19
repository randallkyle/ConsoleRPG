using System;
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

        private Stack<Mob> mobPool;

        public Stack<Mob> _zombiePool;
        public Stack<Mob> _wereWolfPool;
        public Stack<Mob> _giantPool;
        private int sceneLevel;
        private MobFactory _factory;
        public Scene()
        {
            this.player = Player.ThePlayer;
            this.sceneLevel = 0;
            this.mobList = new List<Mob>();


            this._zombiePool = new Stack<Mob>();
            this._wereWolfPool = new Stack<Mob>();
            this._giantPool = new Stack<Mob>();
            this._factory = new MobFactory();
        }

        public void spawnMobs()
        {
            this._factory.PreLoadMobs(this.sceneLevel);
            this.createList();
        }
        public void createList()
        {
            //add the zombies
            while (this._zombiePool.Count > 0)
            {
                this.mobList.Add(this._zombiePool.Pop());
            }
            //add the werewolves
            while (this._wereWolfPool.Count > 0)
            {
                this.mobList.Add(this._wereWolfPool.Pop());
            }
            //add the giants
            while (this._giantPool.Count > 0)
            {
                this.mobList.Add(this._giantPool.Pop());
            }
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
        public Stack<Mob> MobPool
        {
            get
            {
                return this.mobPool;
            }
        }
        public Stack<Giant> GiantPool
        {
            get
            {
                return this._factory.GiantPool;
            }
        }
        public Stack<Zombie> ZombiePool
        {
            get
            {
                return this._factory.ZombiePool;
            }
        }
        public Stack<WereWolf> WereWolfPool
        {
            get
            {
                return this._factory.WereWolfPool;
            }
        }
    }
}
