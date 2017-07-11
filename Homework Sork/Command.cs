using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Sork
{
    public abstract class Command
    {
        public string Name { get; set; }


        public List<string> Aliases { get; set; }


        public bool IsCommand(string input)
        {
            return input == this.Name.ToUpper() || (Aliases != null && Aliases.Contains(input.ToLower()));
        }
    }
}
