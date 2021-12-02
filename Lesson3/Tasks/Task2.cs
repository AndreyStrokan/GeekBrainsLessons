using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson3.Tasks
{
    internal class Task2 : Task
    {
        public override void Run()
        {
            CallMainMenu();
        }

        private void CallMainMenu()
        {
            int[] numbers = new int[0];

            bool isMainMenu = true;
            while (isMainMenu == true)
            {
                Console.Clear();
                Console.WriteLine("=================================");
                Console.WriteLine("=             TASK 2            =");
                Console.WriteLine("=================================");
                PrintArray("Numbers", numbers);
                Console.WriteLine("=================================");
                Console.WriteLine("[1] - Add number");
                Console.WriteLine("[2] - The sum of all odd positive numbers");
                Console.WriteLine("[0] - Close task");
                Console.WriteLine("==================================");

                ConsoleKey input = Console.ReadKey().Key;
                switch (input)
                {
                    case ConsoleKey.D1:
                        AddNumberToArray(ref numbers, EnterNumber("Enter new number: "));
                        break;
                    case ConsoleKey.D2:
                        int[] allPositiveOddNumbers = GetAllOddPositiveNumbers(numbers);
                        Console.WriteLine();
                        PrintArray("All positive odd numbers", allPositiveOddNumbers);
                        Console.WriteLine($"\nSum of all odd positive numbers = {SumOfAllNumbers(allPositiveOddNumbers)}");
                        Console.WriteLine("\nPlease press enter for continue...");
                        Console.ReadLine();
                        break;
                    case ConsoleKey.D0:
                        isMainMenu = false;
                        break;
                }
            }
        }

        private void PrintArray(string arrayName, int[] array)
        {
            Console.Write($"{arrayName}: [");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i < array.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]");
        }

        private int[] GetAllOddPositiveNumbers(int[] array)
        {
            int[] result = new int[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0 && array[i] % 2 != 0)
                {
                    AddNumberToArray(ref result, array[i]);
                }
            }
            return result;
        }

        private int SumOfAllNumbers(int[] array)
        {
            int result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                result += array[i];
            }
            return result;
        }

        private void AddNumberToArray(ref int[] array, int number)
        {
            int[] bufferNumbers = new int[array.Length];
            for (int i = 0; i < bufferNumbers.Length; i++)
            {
                bufferNumbers[i] = array[i];
            }
            array = new int[bufferNumbers.Length + 1];
            for (int i = 0; i < bufferNumbers.Length; i++)
            {
                array[i] = bufferNumbers[i];
            }
            array[^1] = number;
        }

        private int EnterNumber(string message)
        {
            while (true)
            {
                Console.Clear();
                Console.Write(message);
                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    return result;
                }
            }
        }
    }
}
