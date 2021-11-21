using Lesson4.Common;
using System;

namespace Lesson4.Tasks
{
    internal class Task1 : Task
    {
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
                Console.WriteLine("=             TASK 1            =");
                Console.WriteLine("=================================");
                ArrayUtils.PrintArray("Array", numbers);
                Console.WriteLine("=================================");
                Console.WriteLine("[1] - Print the number of pairs of array elements in which only one number is divisible by 3");
                Console.WriteLine("[0] - Close task");
                Console.WriteLine("==================================");

                ConsoleKey input = Console.ReadKey().Key;
                switch (input)
                {
                    case ConsoleKey.D1:
                        int[] indicesOfPairs = GetIndicesOfPairs(numbers);
                        Console.WriteLine();
                        PrintPairs(indicesOfPairs, numbers);
                        Console.WriteLine("\nPlease press enter for continue...");
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
                Console.WriteLine($"Pair [{i+1}]: ({array[indicesOfPairs[i]]},{array[indicesOfPairs[i] + 1]})");
            }
            Console.WriteLine($"Number of pairs: {indicesOfPairs.Length}");
        }

        private int[] GetIndicesOfPairs(int[] array)
        {
            int[] result = new int[0];

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] % 3 == 0 && array[i + 1] % 3 != 0 ||
                    array[i] % 3 != 0 && array[i + 1] % 3 == 0)
                {
                    ArrayUtils.AddNumberToArray(ref result, i);
                }
            }

            return result;
        }
    }
}
