using System;

namespace Lesson1
{
    internal class CustomPrinter
    {
        public static void PrintInTheCenter(string message)
        {
            Console.Clear();
            int xPosition = (Console.WindowWidth / 2) - (message.Length / 2);
            int yPosition = (Console.WindowHeight / 2) - (message.Split("\n").Length / 2);
            Console.SetCursorPosition(xPosition, yPosition);
            Console.Write(message);
        }

        public static void PrintInTheCoord(string message, int x, int y)
        {
            Console.Clear();
            Console.SetCursorPosition(x, y);
            Console.Write(message);
        }
    }
}
