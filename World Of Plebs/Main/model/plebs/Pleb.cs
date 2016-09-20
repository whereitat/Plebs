using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.model.plebs
{
    class Pleb
    {
        private string name;
        private int level = 1;
        private int xp = 1;
        private int attack = 1;
        private int defense = 1;
        private List<Item> items = new List<Item>();

        //Constructors
        public Pleb(string name)
        {
            this.name = name + "the Pleb";
        }

        //Properties
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        public int Level
        {
            get
            {
                return level;
            }

            set
            {
                level = value;
            }
        }
        public int Xp
        {
            get
            {
                return xp;
            }

            set
            {
                xp += value;
                Level = 1 * xp * xp;
            }
        }
        public int Attack
        {
            get
            {
                return attack;
            }

            set
            {
                attack = value;
            }
        }
        public int Defense
        {
            get
            {
                return defense;
            }

            set
            {
                defense = value;
            }
        }
        public List<Item> Items
        {
            get
            {
                return items;
            }

            set
            {
                items = value;
            }
        }

        //Functions
        public void GainXp(int xo)
        {

        }

    }
}
