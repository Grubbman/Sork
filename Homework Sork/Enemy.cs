using Homework_Sork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Sork
{
    public class Enemy
    {


        public string Name { get; set; }
        public string Description { get; set; }
        public string AttackDescription { get; set; }
        public int CurrentHP { get; set; } = 1;
        public int GainedExperience { get; set; }
        public int Attack { get; set; } = 1;
        public int Defence { get; set; } = 1;
        public int Agility { get; set; } = 1;

        //public List<Combat> Combats { get; set; }

        //foreach (var combat in this.Combats)
        //{
        //    battles.Add(combat.Name);
        //}

        // var currentCommand = combatHelper.WriteCommands(battles.ToArray());

        //foreach (var combat in this.Combats)
        //{
        /*
        Task.Delay(100000).Wait(10000);
        if (enemy.currentHP >=1)
            console.writeline($"Your hesitation has cost you. The {enemy.name} attacks.
            console.writeline($"Hitting you for {this.Attack}")
            character.CurrentHP = character.CurrentHP - this.Attack


        if (enemy <= 0)



        // */
        //if (Room.EnemyIntro != null)
        //{
        //    combatHelper.WriteMultipleLines(Room.EnemyIntro);
        //    battle.Print(character, enemy);
        //    header.Print(character);

        //    Console.SetCursorPosition(6, 20);
        //    Console.WriteLine(EnemyIntro);
        //    var numberOfWords = EnemyIntro.Split(' ').GetUpperBound(0) + 1;
        //    var wordsPerSecond = .25;
        //    System.Threading.Thread.Sleep((int)Math.Round(numberOfWords * wordsPerSecond * 600 /* ms per sec */));

        //    Task.Delay(10).Wait(25);



        //    return Exit.Destination;
        //}
        //}

        //Enemy.Name = "Bridge Troll";
        //enemy.CurrentHP = 20;
        //enemy.MaxHP = 20;
        //enemy.Attack = 5;

    }
}

