using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Sork
{
    class Combat
    {
        public string ActionText { get; set; }
        public Enemy Damage { get; set; }
        public List<string> Aliases { get; set; }
        private DiceBag diceBag;
        private Game game;

        public Combat()
        {
            diceBag = new DiceBag();
            game = new Game();

            var g = game;
            
            if (diceBag.EnemyAttackChance(DiceBag.Dice.D20) + g.CurrentRoom.Enemy.Attack > g.Character.Agility /*weapon bonus*/)
            {
                Console.SetCursorPosition(32, 5);
                Console.WriteLine($"{g.CurrentRoom.Enemy.Name} {g.CurrentRoom.Enemy.AttackDescription} {g.Character.Name}");
                g.Character.CurrentHP -= diceBag.EnemyAttackDamage(DiceBag.Dice.D6);
            }

            if (diceBag.CharAttackChance(DiceBag.Dice.D20) > g.CurrentRoom.Enemy.Agility)
            {
                g.CurrentRoom.Enemy.CurrentHP -= diceBag.CharAttackDamage(DiceBag.Dice.D6);
            }
        }

    }
}
/*      ref for cursor position
    
             Console.SetCursorPosition(17, 3);
                Console.WriteLine("Enemy Name: {0}", enemy.Name);
                Console.SetCursorPosition(47, 3);
                Console.WriteLine("Enemy HP: {0}", enemy.CurrentHP.ToString().PadRight(5));
                Console.SetCursorPosition(0, 4);
                Console.WriteLine(" +--------------------------------------------------------------------------------------------------------------------+ ");
                Console.SetCursorPosition(1, 3);
                Console.WriteLine("|");
                Console.SetCursorPosition(118, 3);
                Console.WriteLine("|"); 

        const int STARTING_LINE = 6;
        const int MARGIN_LENGTH = 5;
        const int COMMAND_LINE = 24;
        const int COMMAND_LENGTH = 10;
        public const int CURRENT_COMMAND_LINE = 28;
        public const int CURRENT_COMMAND_LENGTH = 0;
             */
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
