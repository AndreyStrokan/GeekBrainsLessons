using Lesson4.Common;
using System;

namespace Lesson4.Tasks.Task2
{
    internal class Task2 : Task
    {
        private const string FileName = "Numbers";
        private const int MinValue = -10000;
        private const int MaxValue = 10000;
        private const int ArraySize = 20;

        public override void Run()
        {
            CallMainMenu();
        }
        private void CallMainMenu()
        {
            int[] numbers = ArrayUtils.GenerateRandomArray(MinValue, MaxValue, ArraySize);

            bool isMainMenu = true;
            while (isMainMenu == true)
            {
                Console.Clear();
                Console.WriteLine("=================================");
                Console.WriteLine("=             TASK 2            =");
                Console.WriteLine("=================================");
                ArrayUtils.PrintArray("Array", numbers);
                Console.WriteLine("=================================");
                Console.WriteLine("[1] - Print the number of pairs of array elements in which only one number is divisible by 3");
                Console.WriteLine("[2] - Save to file");
                Console.WriteLine("[3] - Load from file");
                Console.WriteLine("[0] - Close task");
                Console.WriteLine("==================================");

                ConsoleKey input = Console.ReadKey().Key;
                switch (input)
                {
                    case ConsoleKey.D1:
                        int[] indicesOfPairs = StaticClass.GetIndicesOfPairs(numbers);
                        Console.WriteLine();
                        PrintPairs(indicesOfPairs, numbers);
                        Console.WriteLine("\nPlease press enter for continue...");
                        Console.ReadLine();
                        break;
                    case ConsoleKey.D2:
                        StaticClass.SaveToFile(FileName, numbers);
                        Console.WriteLine("\nPlease press enter for continue...");
                        Console.ReadLine();
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine();
                        int[] bufferNumbers = StaticClass.LoadFromFile(FileName);
                        if (bufferNumbers == null)
                        {
                            Console.WriteLine("File with saved data does not exist");
                        }
                        else
                        {
                            numbers = bufferNumbers;
                            Console.WriteLine("Data read successfully");
                        }
                        Console.WriteLine("Please press enter for continue...");
                        Console.ReadLine();
                        break;
                    case ConsoleKey.D0:
                        isMainMenu = false;
                        break;
                }
            }
        }

        private void PrintPairs(int[] indicesOfPairs, int[] array)
        {
            for (int i = 0; i < indicesOfPairs.Length; i++)
            {
                Console.WriteLine($"Pair [{i + 1}]: ({array[indicesOfPairs[i]]},{array[indicesOfPairs[i] + 1]})");
            }
            Console.WriteLine($"Number of pairs: {indicesOfPairs.Length}");
        }
    }
}
