﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E7_Gear_Optimizer
{
    public class Item
    {
        public string ID { get; }
        private ItemType type;
        private Set set;
        private Grade grade;
        private int iLvl;
        private int enhance;
        private Stat main;
        private Stat[] subStats;
        public bool Locked { get; set; }
        public Hero Equipped { get; set; }

        public Item(string id, ItemType type, Set set, Grade grade, int iLvl, int enhance, Stat main, Stat[] subStats, Hero equipped, bool locked)
        {
            ID = id;
            this.type = type;
            this.set = set;
            this.grade = grade;
            this.iLvl = iLvl;
            this.enhance = enhance;
            this.main = main;
            this.subStats = subStats;
            Equipped = equipped;
            Locked = locked;
        }

        public Item() { }


        public ItemType Type { get => type; set => type = value; }
        public Set Set { get => set; set => set = value; }
        public Grade Grade { get => grade; set => grade = value; }
        public int ILvl
        {
            get => iLvl;
            set
            {
                if (value > 0)
                {
                    iLvl = value;
                }
            }
        }
        public int Enhance
        {
            get => enhance;
            set
            {
                if (value > -1 && value < 16)
                {
                    enhance = value;
                }
            }
        }
        public Stat Main { get => main; set => main = value; }
        public Stat[] SubStats { get => subStats; set => subStats = value; }


    }
}
