using System;

namespace Lesson1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            RunTask1();
            RunTask2();
            RunTask3();
            RunTask4();
            RunTask5();
        }

        private static void RunTask1()
        {
            Console.Clear();

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Clear();

            Console.Write("Enter your surname: ");
            string surname = Console.ReadLine();

            Console.Clear();

            Console.Write("Enter your age: ");
            string age = Console.ReadLine();

            Console.Clear();

            Console.Write("Enter your height: ");
            string height = Console.ReadLine();

            Console.Clear();

            Console.Write("Enter your weigth: ");
            string weigth = Console.ReadLine();

            Console.Clear();

            Console.WriteLine($"{name}, {surname}, {age}, {height}, {weigth}");
            Console.WriteLine(name + ", " + surname + ", " + age + ", " + height + ", " + weigth);
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}", name, surname, age, height, weigth);

            Console.Write("\nPlease press Enter to continue...");
            Console.ReadLine();
        }

        private static void RunTask2()
        {
            Console.Clear();

            Console.Write("Enter your weight (kg) : ");
            int weight = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.Write("Enter your height (m): ");
            int height = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.Write($"Body mass index: {weight / (height * height)}");

            Console.Write("\nPlease press Enter to continue...");
            Console.ReadLine();
        }

        private static void RunTask3()
        {
            Console.Clear();

            Vector2 vectorA = new Vector2();

            Console.Write("Enter a.x: ");
            vectorA.x = int.Parse(Console.ReadLine());

            Console.Write("Enter a.y: ");
            vectorA.y = int.Parse(Console.ReadLine());

            Console.Clear();

            Vector2 vectorB = new Vector2();

            Console.Write("Enter b.x: ");
            vectorB.x = int.Parse(Console.ReadLine());

            Console.Write("Enter b.y: ");
            vectorB.y = int.Parse(Console.ReadLine());

            Console.Write($"Distance between A{vectorA} and B{vectorB} = {string.Format("{0:0.00}", Vector2.Distance(vectorA, vectorB))}");

            Console.Write("\nPlease press Enter to continue...");
            Console.ReadLine();
        }

        private static void RunTask4()
        {
            Console.Clear();

            Console.Write("Enter a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("\nEnter b: ");
            int b = int.Parse(Console.ReadLine());

            a = a * b;
            b = a / b;
            a = a / b;

            Console.Write($"\na: {a}, b: {b}");
        }

        private static void RunTask5()
        {
            Console.Clear();

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Clear();

            Console.Write("Enter your surname: ");
            string surname = Console.ReadLine();

            Console.Clear();

            Console.Write("Enter your city: ");
            string city = Console.ReadLine();

            string resultString = $"Name: {name}, Surname: {surname}, City: {city}";

            CustomPrinter.PrintInTheCoord(resultString, 12, 50);

            Console.Write("\nPlease press Enter to continue...");
            Console.ReadLine();

            CustomPrinter.PrintInTheCenter(resultString);

            Console.Write("\nPlease press Enter to continue...");
            Console.ReadLine();
        }
    }
}
