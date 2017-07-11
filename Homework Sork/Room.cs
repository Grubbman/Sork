using Homework_Sork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Sork
{
    public class Room
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string EnemyIntro { get; set; }
        public Enemy Enemy { get; set; }
        public List<Exit> Exits { get; set; }
        public Item Item { get; set; }
        public List<Item> Items { get; set; } = new List<Item>();



        

        public Room Display(Game game)
        {
            var helper = new ConsoleHelper();
            var header = new Header();
            var battle = new Battle();
            var enemy = new Enemy();
            var inventory = new Inventory();

            helper.WriteMultipleLines(this.Description);
            header.Print(game.Character, Enemy);

            var items = new List<string>();
            foreach (var item in this.Items)
            {
                items.Add(item.Name);
            }

            helper.WriteItems(items.ToArray());



            var exits = new List<string>();
            foreach (var exit in this.Exits)
            {
                exits.Add(exit.Name);
            }

            helper.WriteCommands(exits.ToArray());

            var currentCommand = helper.ReadInput();

            foreach (var exit in this.Exits)
            {
                if (exit.EnemyIntro != null && exit.IsCommand(currentCommand))
                {
                    Console.SetCursorPosition(6, 20);
                    Console.WriteLine(exit.EnemyIntro);
                    var numberOfWords = exit.EnemyIntro.Split(' ').GetUpperBound(0) + 1;
                    var wordsPerSecond = .20;
                    game.StopTimerTick();
                    System.Threading.Thread.Sleep((int)Math.Round(numberOfWords * wordsPerSecond * 500 /* ms per sec */));
                    game.StartTimerTick();

                    return exit.Destination;
                }
                if (exit.EnemyIntro == null && exit.IsCommand(currentCommand))
                {
                    Console.SetCursorPosition(6, 20);
                    Console.WriteLine(exit.OnTravel);
                    var numberOfWords = exit.OnTravel.Split(' ').GetUpperBound(0) + 1;
                    var wordsPerSecond = .20;
                    game.StopTimerTick();
                    System.Threading.Thread.Sleep((int)Math.Round(numberOfWords * wordsPerSecond * 500 /* ms per sec */));
                    game.StartTimerTick();

                    return exit.Destination;
                }
            }

            return this;
        }
    }
}
