using Lesson4.Tasks;
using Lesson4.Tasks.Task2;
using Lesson4.Tasks.Task4;
using System;

namespace Lesson4
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
                Console.WriteLine("[3] - Task 3");
                Console.WriteLine("[4] - Task 4");
                Console.WriteLine("[5] - Task 5");
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
                    case ConsoleKey.D3:
                        Task3 task3 = new Task3();
                        task3.Run();
                        break;
                    case ConsoleKey.D4:
                        Task4 task4 = new Task4();
                        task4.Run();
                        break;
                    case ConsoleKey.D5:
                        Task5 task5 = new Task5();
                        task5.Run();
                        break;
                    case ConsoleKey.D0:
                        isMainMenu = false;
                        break;
                }
            }
        }
    }
}
