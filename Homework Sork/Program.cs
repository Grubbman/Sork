using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Sork
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Stopwatch sw = new Stopwatch();
            //sw.Start();
            //while(true)
            //{
            //    System.Threading.SpinWait(100000);
            //    if (sw.ElapsedMilliseconds > 5000)
            //        break;
            //}
            //sw.Stop();

            //Console.WriteLine("boo");
            //Console.ReadLine();

            // var battleBuddy = new CombatHelper();

            var game = new Game();
            
            //var enemy = new Enemy();
            //var profession = new Profession();
            //var battle = new Battle();

            

            if (game.Character.Name.ToUpper() == "OVERLORD")
            {
                DumpTheGraph(game.CurrentRoom);
            }

            do
            {
                game.CurrentRoom = game.CurrentRoom.Display(game);
            } while (game.CurrentRoom != null);
        }



        // old code
        private static void other()

        {/*
            var consoleHelper = new ConsoleHelper();
            var character = new Character();
            var header = new Header();
            var enemy = new Enemy();
            var profession = new Profession();
            var battle = new Battle();
            //int RestingTime;
            int GameOver = 0;
            //Weapon bonus
            int AttackBonus = 0;
            int DefenceBonus = 0;
            int AgilityBonus = 0;
            int SneakBonus = 0;
            //Strings:
            string CurrentCommand;
            //randon
            Random Diceroll = new Random();
            int dicerolled = Diceroll.Next(1, 3);
            //Arrays:
            string[,] Inventory = new string[10, 20];
            character = new CharacterBuilder().CreateCharacter(character);


            var currentRoom = new World().Create();

            if (character.Name.ToUpper() == "OVERLORD")
            {
                DumpTheGraph(currentRoom);
            }

            do
            {
                currentRoom = currentRoom.Display(character);
            } while (currentRoom != null);

            return;
            do
            {
                header.Print(character);
                //Count EXP
                if (character.CurrentExperience >= character.FullExperience)
                {
                    character.CurrentExperience = Convert.ToInt32(character.CurrentExperience - character.FullExperience);
                    character.CurrentLevel ++;
                    character.FullExperience = character.FullExperience * 1.20;
                }
                if (character.CurrentHP > character.MaxHP)
                {
                    character.CurrentHP = character.MaxHP;
                }
                if (character.CurrentHP <= 0)
                {
                    GameOver = 1;
                }
                //Inv Test Fill
                for (int a = 0; a <= 19; a++)
                {
                    for (int b = 0; b <= 9; b++)
                    {
                        Inventory[b, a] = "abc";
                    }
                }
                //Foe:
                    enemy.Name = "Bridge Troll";
                    enemy.CurrentHP = 20;
                    enemy.MaxHP = 20;
                    enemy.Attack = 5;

                    //Combat:
                    if (CurrentCommand == "FIGHT")
                    {
                    do
                    {
                        Console.Clear();
                        header.Print(character);
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
                    } while ((enemy.CurrentHP <= 0 && character.CurrentHP >= 1) || (enemy.CurrentHP >= 1 && character.CurrentHP <= 0));
                }
                
                if (dicerolled == 1)
                /*if (CurrentCommand == "SEARCH")
                {

                }
                //Command Options Default:
                CurrentCommand = Console.ReadLine().ToUpper();
                if (CurrentCommand == "INVENTORY" || CurrentCommand == "INV")
                {
                    Console.Clear();
                //Inventory setup
                for (int a = 0; a <= 19; a++)
                {
                    for (int b = 0; b <= 9; b++)
                    {
                        if (b <= 9)
                        {
                            Console.SetCursorPosition(b * 7 + 5, 5 + a);
                            Console.Write("{0}", Inventory[b, a]);
                        }
                        else { }
                    }
                }
                Console.SetCursorPosition(2, 26);
                Console.Write("< Back");
                CurrentCommand = Console.ReadLine().ToUpper();
                if (CurrentCommand == "BACK" || CurrentCommand == "<")
                {
                    Console.Clear();
                }
                else { }
            }
                    //rest setup
                    /*
                    CurrentCommand = Console.ReadLine().ToUpper();
                    if (CurrentCommand == "SLEEP" || CurrentCommand == "NAP" || CurrentCommand == "REST")
                    {
                        Console.Clear();
                        Console.SetCursorPosition(Console.WindowWidth / 2 - 5, Console.WindowHeight / 2 - 3);
                        Console.Write("For how long?");
                        RestingTime = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        Console.SetCursorPosition(Console.WindowWidth / 2 - 5, Console.WindowHeight / 2 - 3);
                        Console.Write("Resting:");
                        RestingTime = (RestingTime * 3) * 1000;
                        System.Threading.Thread.Sleep(RestingTime);
                        Console.Clear();

                        CharHpCurrent = CharHpCurrent + ((RestingTime / 1000) / 3) * 15;
                    }
                    */
         /*
     CurrentCommand = Console.ReadLine().ToUpper();
     if (CurrentCommand == "STATUS" || CurrentCommand == "HOW AM I DOING")
     {
         if (character.CurrentHP < character.MaxHP * 0.60)
         {
         character.Status = "you have felt better..";
         }
         if (character.CurrentHP < character.MaxHP * 0.50)
         {
         character.Status = "You feel pretty bad, but able to go on.";
         }
         if (character.CurrentHP < character.MaxHP * 0.10)
         {
         character.Status = "You are bleeding from many places and feel death waiting to enbrace you.";
         }
         else { }
         Console.SetCursorPosition(Console.WindowWidth / 2 - 5, Console.WindowHeight / 2 - 3);
         Console.Write(character.Status);
     }
         Console.SetCursorPosition(2, 26);
         Console.Write("< Back");
         CurrentCommand = Console.ReadLine().ToUpper();
         if (CurrentCommand == "BACK" || CurrentCommand == "<")
         {
             Console.Clear();
         }
         else { }
 } while (GameOver == 0);*/
        }


        public static void DumpTheGraph(Room room)
        {
            var visited = new List<Room>();
            using (var writer = File.CreateText(".\\map.dot"))
            {
                writer.WriteLine("digraph map {");

                DumpTheRoom(writer, room, visited);

                writer.WriteLine("}");
            }
        }

        public static void DumpTheRoom(StreamWriter writer, Room room, List<Room> visited)
        {
            if (room != null && visited.Contains(room) == false)
            {
                visited.Add(room);
                var nodeName = room.Name.Replace(" ", "");
                writer.WriteLine($"\t{nodeName} [label=\"{room.Name}\"]"); // Write The Node

                foreach (var exit in room.Exits)
                {
                    if (exit.Destination == null) continue;
                    var exitNodeName = exit.Destination.Name.Replace(" ", "");
                    writer.WriteLine($"\t{nodeName} -> {exitNodeName} [label=\"{exit.Name}\"]"); // Write The Edge
                }
                writer.WriteLine();

                foreach (var exit in room.Exits)
                {
                    DumpTheRoom(writer, exit.Destination, visited);
                }
            }
        }
    }
}
