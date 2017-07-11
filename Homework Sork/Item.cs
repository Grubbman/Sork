using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Sork
{
    public class Item
    {
        public string Name { get; set; }


        public bool IsCommand(string input)
        {
            return input == this.Name.ToUpper();
        }

        //      Item List
        //var = new Item();
        //.Name = " ";
        //.Description = " ";
        //.UseDescription = " ";
        //.Weight = 0;
        //.StackMax = 0;
        //.Duration = 0;
        //.AttackBuff = 0;
        //.DefenceBuff = 0;
        //.AgilityBuff = 0;
        //.SneakBuff = 0;
        //.HPBuff
        //.Healing = 0;
    }
}
