using System;

namespace Lesson3.Tasks
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
                Console.WriteLine("==================================");
                Console.WriteLine("=             TASK 1             =");
                Console.WriteLine("==================================");
                Console.WriteLine("[1] - Demonstrate complex class");
                Console.WriteLine("[2] - Demonstrate complex struct");
                Console.WriteLine("[0] - Close task");
                Console.WriteLine("==================================");

                ConsoleKey input = Console.ReadKey().Key;
                switch (input)
                {
                    case ConsoleKey.D1:
                        CallDemonstrateComplexClass();
                        break;
                    case ConsoleKey.D2:

                        break;
                    case ConsoleKey.D0:
                        isMainMenu = false;
                        break;
                }
            }
        }
        private void CallDemonstrateComplexClass()
        {
            bool isDemonstrateComplexClass = true;

            ComplexClass complexA = new ComplexClass(0.0d, 0.0d);
            ComplexClass complexB = new ComplexClass(0.0d, 0.0d);

            while (isDemonstrateComplexClass == true)
            {
                Console.Clear();
                Console.WriteLine("==================================");
                Console.WriteLine("=   DEMONSTRATE COMPLEX CLASS    =");
                Console.WriteLine("==================================");
                Console.WriteLine($"= Complex A = {complexA}");
                Console.WriteLine($"= Complex B = {complexB}");
                Console.WriteLine("==================================");
                Console.WriteLine("[1] - Change real part of complex A");
                Console.WriteLine("[2] - Change real imaginary of complex A");
                Console.WriteLine("[3] - Change real part of complex B");
                Console.WriteLine("[4] - Change real imaginary of complex B");
                Console.WriteLine("[0] - Close demonstration complex class");

                ConsoleKey input = Console.ReadKey().Key;
                switch (input)
                {
                    case ConsoleKey.D1:
                        complexA.RealPart = EnterNumber("Enter new real part for complex A: ");
                        break;
                    case ConsoleKey.D2:
                        complexA.ImaginaryPart = EnterNumber("Enter new imaginary part for complex A: ");
                        break;
                    case ConsoleKey.D3:
                        complexB.RealPart = EnterNumber("Enter new real part for complex B: ");
                        break;
                    case ConsoleKey.D4:
                        complexB.ImaginaryPart = EnterNumber("Enter new imaginary part for complex B: ");
                        break;
                    case ConsoleKey.D0:
                        isDemonstrateComplexClass = false;
                        break;
                }
            }
        }

        private double EnterNumber(string message)
        {
            while (true)
            {
                Console.Clear();
                Console.Write(message);
                if (double.TryParse(Console.ReadLine(), out double result))
                {
                    return result;
                }
            }
        }
    }
}
