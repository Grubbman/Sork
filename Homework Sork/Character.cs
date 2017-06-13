using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Sork
{
    public class Character
    {

        public int CurrentHP { get; set; } = 95;
        public int MaxHP { get; set; } = 100;
        public int CurrentExperience { get; set; } = 10;
        public double FullExperience { get; set; } = 100;
        public int CurrentLevel { get; set; } = 1;
        public int Attack { get; set; } = 5;
        public int Defence { get; set; } = 1;
        public int Agility { get; set; } = 1;
        public int Sneak { get; set; } = 1;

        public int TickCount { get; set; } = 0;

        public string Name { get; set; } = "";

        private string profession;
        public string Profession
        {
            get
            {
                return profession;
            }

            set
            {
                profession = value;
                switch (profession)
                {
                    case "Hunter":
                        this.Attack = 6;
                        this.Defence = 4;
                        this.Agility = 7;
                        this.Sneak = 6;
                        break;
                    case "Warror":
                        this.Attack = 9;
                        this.Defence = 9;
                        this.Agility = 4;
                        this.Sneak = 1;
                        break;
                    case "Thief":
                        this.Attack = 6;
                        this.Defence = 6;
                        this.Agility = 8;
                        this.Sneak = 10;
                        break;
                    case "Shaman":
                        this.Attack = 6;
                        this.Defence = 5;
                        this.Agility = 5;
                        this.Sneak = 4;
                        break;
                }
            }
        }
        

        public string Status { get; set; } = "";

        public string Weapon { get; set; } = "fists";
    }

    
}

