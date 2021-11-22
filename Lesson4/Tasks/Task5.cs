﻿using CustomTwoDimensionalArrayLibrary;
using System;
using System.IO;

namespace Lesson4.Tasks
{
    internal class Task5 : Task
    {
        public override void Run()
        {
            CallMainMenu();
        }

        private void CallMainMenu()
        {
            CustomTwoDimensionalArray сustomTwoDimensionalArray = null;

            bool isMainMenu = true;
            while (isMainMenu == true)
            {
                Console.Clear();
                Console.WriteLine("=================================");
                Console.WriteLine("=             TASK 5            =");
                Console.WriteLine("=================================");
                Console.WriteLine(сustomTwoDimensionalArray);
                Console.WriteLine("=================================");
                Console.WriteLine("[1] - Create array");
                Console.WriteLine("[2] - Try load array");
                if (сustomTwoDimensionalArray != null)
                {
                    Console.WriteLine("[3] - Get sum");
                    Console.WriteLine("[4] - Get sum where value is greater than");
                    Console.WriteLine("[5] - Min value");
                    Console.WriteLine("[6] - Max value");
                    Console.WriteLine("[7] - Max index");
                    Console.WriteLine("[8] - Save in file");
                }
                Console.WriteLine("[0] - Close task");
                Console.WriteLine("=================================");

                ConsoleKey input = Console.ReadKey().Key;
                switch (input)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine();
                        int arrayRowCount = EnterNumber("Enter row count: ", minValue: 0);
                        int arrayColumnCount = EnterNumber("Enter column count: ", minValue: 0);
                        int arrayMinValue = EnterNumber("Enter min value: ");
                        int arrayMaxValue = EnterNumber("Enter max value: ", minValue: arrayMinValue);
                        сustomTwoDimensionalArray = new CustomTwoDimensionalArray(arrayRowCount, arrayColumnCount, arrayMinValue, arrayMaxValue);
                        Console.WriteLine("\nPlease press enter for continue...");
                        Console.ReadLine();
                        break;


                    case ConsoleKey.D2:
                        Console.WriteLine();
                        try
                        {
                            сustomTwoDimensionalArray = new CustomTwoDimensionalArray();
                            Console.WriteLine("Array loaded successfully");
                        }
                        catch (IOException ioe)
                        {
                            Console.WriteLine("Failed to load array");
                        }
                        Console.WriteLine("\nPlease press enter for continue...");
                        Console.ReadLine();
                        break;

                    case ConsoleKey.D3:
                        if (сustomTwoDimensionalArray != null)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"Sum {сustomTwoDimensionalArray.Sum()}");
                            Console.WriteLine("\nPlease press enter for continue...");
                            Console.ReadLine();
                        }
                        break;

                    case ConsoleKey.D4:
                        if (сustomTwoDimensionalArray != null)
                        {
                            Console.WriteLine();
                            int greaterThan = EnterNumber($"Get sum where value is greater than: ");
                            Console.WriteLine($"Sum where value is greater than {greaterThan}: {сustomTwoDimensionalArray.SumWhereValueIsGreaterThan(greaterThan)}");
                            Console.WriteLine("\nPlease press enter for continue...");
                            Console.ReadLine();
                        }
                        break;

                    case ConsoleKey.D5:
                        if (сustomTwoDimensionalArray != null)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"Min value {сustomTwoDimensionalArray.MinValue}");
                            Console.WriteLine("\nPlease press enter for continue...");
                            Console.ReadLine();
                        }
                        break;

                    case ConsoleKey.D6:
                        if (сustomTwoDimensionalArray != null)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"Max value {сustomTwoDimensionalArray.MaxValue}");
                            Console.WriteLine("\nPlease press enter for continue...");
                            Console.ReadLine();
                        }
                        break;

                    case ConsoleKey.D7:
                        if (сustomTwoDimensionalArray != null)
                        {
                            Console.WriteLine();
                            int maxRowIndex;
                            int maxColumnIndex;
                            сustomTwoDimensionalArray.GetMaxValueIndex(out maxRowIndex, out maxColumnIndex);
                            Console.WriteLine($"Max index [{maxRowIndex}, {maxColumnIndex}]");
                            Console.WriteLine("\nPlease press enter for continue...");
                            Console.ReadLine();
                        }
                        break;

                    case ConsoleKey.D8:
                        if (сustomTwoDimensionalArray != null)
                        {
                            Console.WriteLine();
                            сustomTwoDimensionalArray.SaveInFile();
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
                Console.Write(message);
                if (int.TryParse(Console.ReadLine(), out int result) && result >= minValue && result <= maxValue)
                {
                    return result;
                }
            }
        }
    }
}