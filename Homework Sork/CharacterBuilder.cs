using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Sork
{
    public class CharacterBuilder
    {
        public void CreateCharacter(Character character)
        {
            //Charactor Naming and Intro
            Console.Clear();
            Console.SetCursorPosition(Console.WindowWidth / 2 - 2, Console.WindowHeight / 2 - 3);
            Console.Write("What is your name?  ");
            character.Name = Console.ReadLine();
            Console.Clear();

            Console.SetCursorPosition(Console.WindowWidth / 2 - 2, Console.WindowHeight / 2 - 3);
            Console.Write("What is your profession?  ");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 2, Console.WindowHeight / 2 - 5);
            Console.Write("Warrior");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 2, Console.WindowHeight / 2 - 7);
            Console.Write("Hunter");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 2, Console.WindowHeight / 2 - 9);
            Console.Write("Thief");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 2, Console.WindowHeight / 2 - 1);
            character.Profession = Console.ReadLine();
            Console.Clear();
        }
    }
}
