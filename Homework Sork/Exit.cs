using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Sork
{
    public class Exit
    {
        public string Name { get; set; }
        public string OnTravel { get; set; }
        public string EnemyIntro { get; set; }
        public Room Destination { get; set; }
        public List<string> Aliases { get; set; }

        
        public bool IsCommand(string input)
        {
            return input == this.Name.ToUpper() || (Aliases != null && Aliases.Contains(input.ToLower()));
        }

        
        
    }
}
