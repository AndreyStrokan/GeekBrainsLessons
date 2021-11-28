using System;
using System.Collections.Generic;

namespace Lesson5.Tasks.Task2
{
    internal class Task2 : Task
    {
        public override void Run()
        {
            CallMainMenu();
        }

        private void CallMainMenu()
        {
            bool isMainMenu = true;
            while (isMainMenu == true)
            {
                Console.Clear();
                Console.WriteLine("=================================");
                Console.WriteLine("=             TASK 2            =");
                Console.WriteLine("=================================");
                Console.WriteLine("[1] - Get words no longer than N");
                Console.WriteLine("[2] - Get words which not end in");
                Console.WriteLine("[0] - Close task");
                Console.WriteLine("==================================");

                ConsoleKey input = Console.ReadKey().Key;
                switch (input)
                {
                    case ConsoleKey.D1:
                        {
                            Console.WriteLine("\nEnter text:");
                            string inputText = Console.ReadLine();
                            int limitation = EnterNumber("\nEnter limitation: ", minValue: 0);

                            Message.PrintWords(Message.GetWordsNoLongerThan(inputText, limitation));
                            Console.ReadLine();
                            break;
                        }
                    case ConsoleKey.D2:
                        {
                            Console.WriteLine("\nEnter text:");
                            string inputText = Console.ReadLine();
                            char endSymbol = EnterChar("\nEnter end symbol: ");
                            Message.PrintWords(Message.GetWordsWhichNotEndIn(inputText, endSymbol));
                            Console.ReadLine();
                            break;
                        }
                    case ConsoleKey.D0:
                        isMainMenu = false;
                        break;
                }
            }
        }

        private int EnterNumber(string message, int minValue = int.MinValue, int maxValue = int.MaxValue)
        {
            while (true)
            {
                Console.Clear();
                Console.Write(message);
                if (int.TryParse(Console.ReadLine(), out int result) && result >= minValue && result <= maxValue)
                {
                    return result;
                }
            }
        }

        private char EnterChar(string message)
        {
            while (true)
            {
                Console.Clear();
                Console.Write(message);
                if (char.TryParse(Console.ReadLine(), out char result))
                {
                    return result;
                }
            }
        }
    }
}
