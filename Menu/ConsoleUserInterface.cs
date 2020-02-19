using System;
using Interfaces;

namespace Menu
{
    public class ConsoleUserInterface : IGraphicUserInterface
    {
        public void PrintMessage(string message)
        {
            Console.Write(message);
        }

        public void PrintMessageOnLine(string message)
        {
            Console.WriteLine(message);
        }

        public string ReadInput()
        {
            Console.Write("Your selection: ");
            String userInput;
            userInput = Console.ReadLine();
            return userInput;
        }

        public int ReadInputInteger()
        {
            int value = -1;
            if (int.TryParse(ReadInput(), out value))
            {
                return value;
            }

            return 0;
        }

        public void ClearScreen()
        {
            Console.Clear();
        }
    }
}
