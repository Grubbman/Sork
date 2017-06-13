using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Sork
{
    class Combat
    {

        public string Name { get; set; }
        public string ActionText { get; set; }
        public Enemy Dammage { get; set; }
        public List<string> Aliases { get; set; }


        public bool IsCommand(string input)
        {
            return input == this.Name.ToUpper() || (Aliases != null && Aliases.Contains(input.ToLower()));
        }
    }
}

/*
(CurrentCommand == "FIGHT")
    {
    do
    {
        Console.Clear();
        header.Print(character, enemy);
        battle.Print(character, enemy);
        CurrentCommand = Console.ReadLine();
        if (CurrentCommand == "1")
        {
            dicerolled = Diceroll.Next(1, character.Attack + AttackBonus + 1);
            if (dicerolled >= 1)
            {
                Console.SetCursorPosition(3, 15);
                Console.WriteLine("Using your {0} to hit the {1} and dealt {2} damage.", character.Weapon, enemy.Name, dicerolled);
                enemy.CurrentHP = enemy.CurrentHP - dicerolled;
            }
            else
            {
                Console.SetCursorPosition(3, 15);
                Console.WriteLine("You missed!");
            }
        }
        if (CurrentCommand == "2")
        {
            dicerolled = Diceroll.Next(1, character.Defence + DefenceBonus + 1);
            if (dicerolled >= enemy.Attack / dicerolled)
            {
                Console.SetCursorPosition(3, 15);
                Console.WriteLine("You blocked {0} attack {1} damage.", enemy.Name, dicerolled);
                enemy.CurrentHP = enemy.CurrentHP - dicerolled;
            }
            else
            {
                Console.SetCursorPosition(3, 15);
                Console.WriteLine("{0} attack succeded and dealt {1} damage.", enemy.Name, dicerolled);
                character.CurrentHP = character.CurrentHP - dicerolled;
            }
        }
        if (CurrentCommand == "3")
        {
            dicerolled = Diceroll.Next(1, character.Agility + AgilityBonus + 1);
            if (dicerolled >= 1)
            {
                Console.SetCursorPosition(3, 15);
                Console.WriteLine("{0} dodged {1} attack then countered causing {2} damage.", character.Name, enemy.Name, dicerolled);
                enemy.CurrentHP = enemy.CurrentHP - dicerolled;
            }
            else
            {
                Console.SetCursorPosition(3, 15);
                Console.WriteLine("{0} attack succeded and dealt {1} damage.", enemy.Name, dicerolled);
                character.CurrentHP = character.CurrentHP - dicerolled;
            }
        }
        if (CurrentCommand == "4")
        {
            dicerolled = Diceroll.Next(1, character.Sneak + SneakBonus + 1);
            if (dicerolled >= 1)
            {
                Console.SetCursorPosition(3, 15);
                Console.WriteLine("{0} was able to flee from {1} damage.", character.Name, enemy.Name);
            }
            else
            {
                Console.SetCursorPosition(3, 15);
                Console.WriteLine("You failed to flee {0} dealt you {1} damage!", enemy.Name, dicerolled);
            }
        }
    } while ((enemy.CurrentHP <= 0 && character.CurrentHP >= 1) || (enemy.CurrentHP >= 1 && character.CurrentHP <= 0));*/
