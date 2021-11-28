using System;
using System.Text.RegularExpressions;

namespace Lesson5.Tasks
{
    internal class Task1 : Task
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
                Console.WriteLine("=             TASK 1            =");
                Console.WriteLine("=================================");
                Console.WriteLine("[1] - Check login without regex");
                Console.WriteLine("[2] - Check login with regex");
                Console.WriteLine("[0] - Close task");
                Console.WriteLine("==================================");

                ConsoleKey input = Console.ReadKey().Key;
                switch (input)
                {
                    case ConsoleKey.D1:
                        {
                            string login;
                            do
                            {
                                Console.Clear();
                                Console.Write("Input login: ");
                                login = Console.ReadLine();
                            } while (CheckLoginWithoutRegex(login) == false);
                            Console.WriteLine($"Login {login}[{login.Length}] correct!");
                            Console.WriteLine("Press Enter to continue...");
                            Console.ReadLine();
                            break;
                        }
                    case ConsoleKey.D2:
                        {
                            string login;
                            do
                            {
                                Console.Clear();
                                Console.Write("Input login: ");
                                login = Console.ReadLine();
                            } while (CheckLoginWithRegex(login) == false);
                            Console.WriteLine($"Login {login}[{login.Length}] correct!");
                            Console.WriteLine("Press Enter to continue...");
                            Console.ReadLine();
                            break;
                        }
                    case ConsoleKey.D0:
                        isMainMenu = false;
                        break;
                }
            }
        }

        private bool CheckLoginWithoutRegex(string login)
        {
            if (login == null)
            {
                return false;
            }

            if (2 > login.Length || login.Length > 10)
            {
                return false;
            }

            if (char.IsNumber(login[0]) == true)
            {
                return false;
            }

            return true;
        }

        private bool CheckLoginWithRegex(string login)
        {
            return new Regex(@"^([^0-9])(\S{1,9})$").IsMatch(login);
        }
    }
}
