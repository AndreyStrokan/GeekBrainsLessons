using CustomArrayLibrary;
using System;

namespace Lesson4.Tasks
{
    internal class Task3 : Task
    {
        public override void Run()
        {
            CallMainMenu();
        }

        private void CallMainMenu()
        {
            CustomArray customArray = null;

            bool isMainMenu = true;
            while (isMainMenu == true)
            {
                Console.Clear();
                Console.WriteLine("=================================");
                Console.WriteLine("=             TASK 3            =");
                Console.WriteLine("=================================");
                Console.WriteLine($"Custom array: {customArray}");
                Console.WriteLine("=================================");
                Console.WriteLine("[1] - Create array");
                if (customArray != null)
                {
                    Console.WriteLine("[2] - Get sum");
                    Console.WriteLine("[3] - Inverse");
                    Console.WriteLine("[4] - Multi");
                    Console.WriteLine("[5] - Max count");
                }
                Console.WriteLine("[0] - Close task");
                Console.WriteLine("==================================");

                ConsoleKey input = Console.ReadKey().Key;
                switch (input)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine();
                        int arraySize = EnterNumber("Enter array size: ", minValue: 0);
                        int startValue = EnterNumber("Enter startValue: ");
                        int step = EnterNumber("Enter step: ");
                        customArray = new CustomArray(arraySize, startValue, step);
                        Console.WriteLine("\nPlease press enter for continue...");
                        Console.ReadLine();
                        break;
                    case ConsoleKey.D2:
                        if (customArray != null)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"Custom array sum {customArray.Sum}");
                            Console.WriteLine("\nPlease press enter for continue...");
                            Console.ReadLine();
                        }
                        break;
                    case ConsoleKey.D3:
                        if (customArray != null)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"Custom array Inverse: {customArray.Inverse()}");
                            Console.WriteLine("\nPlease press enter for continue...");
                            Console.ReadLine();
                        }
                        break;
                    case ConsoleKey.D4:
                        if (customArray != null)
                        {
                            Console.WriteLine();
                            int multiplicator = EnterNumber("Enter multiplicator: ");
                            customArray.Multi(multiplicator);
                            Console.WriteLine("\nPlease press enter for continue...");
                            Console.ReadLine();
                        }
                        break;
                    case ConsoleKey.D5:
                        if (customArray != null)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"Custom array Max count: {customArray.MaxCount}");
                            Console.WriteLine("\nPlease press enter for continue...");
                            Console.ReadLine();
                        }
                        break;
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
    }
}
