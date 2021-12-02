using Lesson5.Tasks;
using Lesson5.Tasks.Task2;
using System;

namespace Lesson5
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            MainMenu();
        }

        private static void MainMenu()
        {
            bool isMainMenu = true;

            while (isMainMenu == true)
            {
                Console.Clear();
                Console.WriteLine("==================================");
                Console.WriteLine("=          SELECT TASK           =");
                Console.WriteLine("==================================");
                Console.WriteLine("[1] - Task 1");
                Console.WriteLine("[2] - Task 2");
                Console.WriteLine("[0] - Close programm");

                ConsoleKey input = Console.ReadKey().Key;
                switch (input)
                {
                    case ConsoleKey.D1:
                        Task1 task1 = new Task1();
                        task1.Run();
                        break;
                    case ConsoleKey.D2:
                        Task2 task2 = new Task2();
                        task2.Run();
                        break;
                    case ConsoleKey.D0:
                        isMainMenu = false;
                        break;
                }
            }
        }
    }
}
