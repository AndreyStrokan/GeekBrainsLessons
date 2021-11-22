using System;

namespace Lesson4.Tasks.Task4
{
    internal class Task4 : Task
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
                bool isDBExists = AccountFileDB.DBExists();
                Console.Clear();
                Console.WriteLine("=================================");
                Console.WriteLine("=             TASK 4            =");
                Console.WriteLine("=================================");
                Console.WriteLine("[1] - Create account");
                if (isDBExists == true)
                {
                    Console.WriteLine("[2] - Get all accounts");
                    Console.WriteLine("[3] - Try authorize");
                }
                Console.WriteLine("[0] - Close task");
                Console.WriteLine("==================================");

                ConsoleKey input = Console.ReadKey().Key;
                switch (input)
                {
                    case ConsoleKey.D1:
                        CreateAccount();
                        break;
                    case ConsoleKey.D2:
                        if (isDBExists == true)
                        {
                            PrintAllAccounts();
                        }
                        break;
                    case ConsoleKey.D3:
                        if (isDBExists == true)
                        {
                            TryAuthorize();
                        }
                        break;
                    case ConsoleKey.D0:
                        isMainMenu = false;
                        break;
                }
            }
        }

        private void CreateAccount()
        {
            Console.Clear();

            string login = InputString("Enter login: ");
            string password = InputString("Enter password: ");

            bool isCreated = AccountFileDB.CreateAccount(login, password);
            if (isCreated == true)
            {
                Console.WriteLine("Account created successfully");
            }
            else
            {
                Console.WriteLine("Failed to create account");
            }
            Console.WriteLine("\nPlease press enter for continue...");
            Console.ReadLine();
        }

        private void PrintAllAccounts()
        {
            Console.Clear();

            Account[] allAccounts = AccountFileDB.GetAllAccounts();
            for (int i = 0; i < allAccounts.Length; i++)
            {
                Console.WriteLine($"[{i + 1}] {allAccounts[i]}");
            }
            Console.WriteLine("\nPlease press enter for continue...");
            Console.ReadLine();
        }

        private void TryAuthorize()
        {
            Console.Clear();
            string login = InputString("Enter login: ");
            string password = InputString("Enter password: ");
            bool isAuthorized = AccountFileDB.TryAuthorize(login, password);
            if (isAuthorized == true)
            {
                Console.WriteLine("You have successfully logged in");
            }
            else
            {
                Console.WriteLine("Login failed");
            }
            Console.WriteLine("\nPlease press enter for continue...");
            Console.ReadLine();
        }

        private string InputString(string message)
        {
            string result;
            do
            {
                Console.Clear();
                Console.WriteLine(message);
                result = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(result) == true);
            return result;
        }
    }
}
