using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Sork
{
    public class Armor
    {
        // Helmet, Cuirass, Gauntlets, Greaves, Boots, Shield
        public string Name { get; set; }
        public string Description { get; set; }
        public int Durability { get; set; }
        public int LevelRequirment { get; set; }

        public int AttackBonus { get; set; } = 0;
        public int DefenceBonus { get; set; } = 0;
        public int AgilityBonus { get; set; } = 0;
        public int SneakBonus { get; set; } = 0;
    }
}
