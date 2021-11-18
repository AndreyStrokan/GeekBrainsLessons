using System;
using System.Threading.Tasks;

namespace Lesson2
{
    internal class Program
    {
        private static int Min(int a, int b, int c)
        {
            int minFromTwo = (a < b) ? a : b;
            return (minFromTwo < c) ? minFromTwo : c;
        }

        private static void RunTask1()
        {
            int intA = 0;
            while (true)
            {
                Console.Clear();
                Console.Write("Enter a: ");
                string stringA = Console.ReadLine();
                if (int.TryParse(stringA, out intA))
                {
                    break;
                }
            }

            int intB = 0;
            while (true)
            {
                Console.Clear();
                Console.Write("Enter b: ");
                string stringA = Console.ReadLine();
                if (int.TryParse(stringA, out intB))
                {
                    break;
                }
            }

            int intC = 0;
            while (true)
            {
                Console.Clear();
                Console.Write("Enter c: ");
                string stringA = Console.ReadLine();
                if (int.TryParse(stringA, out intC))
                {
                    break;
                }
            }

            Console.WriteLine($"Minimal number is: {Min(intA, intB, intC)}");

            Console.Write("\nPlease press Enter to continue...");
            Console.ReadLine();
        }

        private static int CountNumbers(int number)
        {
            return number.ToString().Length;
        }

        private static void RunTask2()
        {
            int intInput = 0;
            while (true)
            {
                Console.Clear();
                Console.Write("Enter number: ");
                string stringA = Console.ReadLine();
                if (int.TryParse(stringA, out intInput))
                {
                    break;
                }
            }
            Console.WriteLine($"Count numbers in {intInput} is: {CountNumbers(intInput)}");

            Console.Write("\nPlease press Enter to continue...");
            Console.ReadLine();
        }

        private static void RunTask3()
        {
            int oddPositiveNumbers = 0;
            while(true)
            {
                Console.Clear();
                Console.WriteLine($"Odd positive numbers: {oddPositiveNumbers}");
                Console.Write("Enter number (0 - for exit): ");
                string stringInput = Console.ReadLine();

                int intInput;
                if (int.TryParse(stringInput, out intInput))
                {
                    if (intInput >= 0 && intInput % 2 == 0)
                    {
                        oddPositiveNumbers++;
                        if (intInput == 0)
                        {
                            break;
                        }
                    }
                }
            }

            Console.WriteLine($"Odd positive numbers: {oddPositiveNumbers}");

            Console.Write("\nPlease press Enter to continue...");
            Console.ReadLine();
        }


        private static bool CheckLoginAndPassword(string login, string password)
        {
            return login.Equals("root") && password.Equals("GeekBrains");
        }

        private static void RunTask4()
        {
            string inputLogin = null;
            string inputPassword = null;
            do
            {
                Console.Clear();
                Console.Write("Enter login: ");
                inputLogin = Console.ReadLine();
                Console.Write("Enter password: ");
                inputPassword = Console.ReadLine();
            } while (!CheckLoginAndPassword(inputLogin, inputPassword));
            Console.WriteLine("Login and password is correctly!");

            Console.Write("\nPlease press Enter to continue...");
            Console.ReadLine();
        }

        private static void RunTask5()
        {
            int weight;
            while (true)
            {
                Console.Clear();
                Console.Write("Enter your weight (kg) : ");
                string stringInput = Console.ReadLine();
                if (int.TryParse(stringInput, out weight))
                {
                    break;
                }
            }

            float height;
            while (true)
            {
                Console.Clear();
                Console.Write("Enter your height (m) : ");
                string stringInput = Console.ReadLine();
                if (float.TryParse(stringInput, out height))
                {
                    break;
                }
            }

            float bodyMassIndex = weight / (height * height);

            Console.WriteLine($"Weight: {weight} (kg)");
            Console.WriteLine($"Height: {height} (m)");
            Console.WriteLine($"Body mass index: {bodyMassIndex}");

            if (bodyMassIndex < 16.0f)
            {
                Console.WriteLine("Significant underweight");
            }
            else if (bodyMassIndex >= 16.0f && bodyMassIndex < 18.5f)
            {
                Console.WriteLine("Underweight");
            }
            else if (bodyMassIndex >= 18.5f && bodyMassIndex < 25.0f)
            {
                Console.WriteLine("Norm");
            }
            else if (bodyMassIndex >= 25.0f && bodyMassIndex < 30.0f)
            {
                Console.WriteLine("Excess weight");
            }
            else if (bodyMassIndex >= 30.0f && bodyMassIndex < 35.0f)
            {
                Console.WriteLine("First degree obesity");
            }
            else if (bodyMassIndex >= 35.0f && bodyMassIndex < 40.0f)
            {
                Console.WriteLine("Second degree obesity");
            }
            else
            {
                Console.WriteLine("Obesity of the third degree");
            }

            Console.Write("\nPlease press Enter to continue...");
            Console.ReadLine();
        }

        private static void RunTask6()
        {
            Console.Clear();
            Console.WriteLine("Task 6");
            DateTime firstTime = DateTime.Now;
            int countGoodElements = 0;
            for (int i = 1; i <= 1000000; i++)
            {
                int currentNumber = i;
                int summNumbers = 0;
                do
                {
                    summNumbers += currentNumber % 10;
                    currentNumber /= 10;
                } while (currentNumber != 0);

                if(i % summNumbers == 0)
                {
                    countGoodElements++;
                }
            }
            DateTime lastTime = DateTime.Now;

            Console.WriteLine($"Count good elements: {countGoodElements}");
            Console.WriteLine($"Algorithm running time: {(lastTime - firstTime).TotalMilliseconds} (ms)");
            Console.Write("\nPlease press Enter to continue...");
            Console.ReadLine();
        }

        private static void Main(string[] args)
        {
            RunTask1();
            RunTask2();
            RunTask3();
            RunTask4();
            RunTask5();
            RunTask6();
        }
    }
}
