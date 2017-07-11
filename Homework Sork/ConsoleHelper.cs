using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Sork
{
    public class ConsoleHelper
    {
        const int STARTING_LINE = 6;
        const int MARGIN_LENGTH = 5;
        const int COMMAND_LINE = 23;
        const int COMMAND_LENGTH = 10;
        const int ITEM_LINE = 23;
        const int ITEM_LENGTH = 35;
        public const int CURRENT_COMMAND_LINE = 28;
        public const int CURRENT_COMMAND_LENGTH = 0;

        public void WriteMultipleLines(params string[] lines)
        {
            Console.Clear();
            
            for (int index = 0; index <= lines.GetUpperBound(0); index++)
            {
                Console.SetCursorPosition(MARGIN_LENGTH, STARTING_LINE + (index * 2));
                Console.WriteLine(lines[index]);
            }
        }

        public void WriteItems(params string[] lines)
        {
            for (int index = 0; index <= lines.GetUpperBound(0); index++)
            {
                Console.SetCursorPosition((ITEM_LENGTH), (ITEM_LINE) + (index));
                Console.WriteLine(lines[index]);
            }
        }

        public void WriteCommands(params string[] lines)
        {
            for (int index = 0; index <= lines.GetUpperBound(0); index++)
            {
                Console.SetCursorPosition((COMMAND_LENGTH), (COMMAND_LINE) + (index));
                Console.WriteLine(lines[index].ToUpper());
            }

        }
        public string ReadInput(params string[] lines)
        {
            Console.SetCursorPosition(CURRENT_COMMAND_LENGTH, CURRENT_COMMAND_LINE);
            return Console.ReadLine().ToUpper();
        }
    }
}
