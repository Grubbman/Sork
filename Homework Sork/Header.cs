using Homework_Sork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Sork
{
    public class Header
    {
        public void Print(Character character, Enemy enemy)
        {
            int currentLine = Console.CursorTop;
            int currentPosition = Console.CursorLeft;

            Console.SetCursorPosition(0, 0);
            Console.WriteLine(" +--------------------------------------------------------------------------------------------------------------------+ ");
            Console.SetCursorPosition(17, 1);
            Console.WriteLine("Name: {0}", character.Name);
            Console.SetCursorPosition(47, 1);
            Console.WriteLine("HP: {0}/{1}", character.CurrentHP, character.MaxHP);
            Console.SetCursorPosition(77, 1);
            Console.WriteLine("EXP: {0}/{1}", character.CurrentExperience, character.FullExperience);
            Console.SetCursorPosition(102, 1);
            Console.WriteLine("Level: {0}", character.CurrentLevel);
            Console.SetCursorPosition(0, 2);
            Console.WriteLine(" +--------------------------------------------------------------------------------------------------------------------+ ");
            Console.SetCursorPosition(1, 1);
            Console.WriteLine("|");
            Console.SetCursorPosition(118, 1);
            Console.WriteLine("|");

            if (enemy != null)
            {
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
            }
            else
            {
                Console.SetCursorPosition(1, 3);
                Console.WriteLine(new String(Enumerable.Repeat(' ', 119).ToArray()));
                Console.SetCursorPosition(1, 4);
                Console.WriteLine(new String(Enumerable.Repeat(' ', 119).ToArray()));
            }

            // Debug Code
            Console.SetCursorPosition(114, 1);
            Console.Write(character.TickCount);
            Console.SetCursorPosition(currentPosition, currentLine);      
        }
    }
}
