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
                        CallDemonstrateComplexStruct();
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
            ComplexClass complexC = new ComplexClass(0.0d, 0.0d);

            while (isDemonstrateComplexClass == true)
            {
                Console.Clear();
                Console.WriteLine("==================================");
                Console.WriteLine("=   DEMONSTRATE COMPLEX CLASS    =");
                Console.WriteLine("==================================");
                Console.WriteLine($"= Complex A = {complexA}");
                Console.WriteLine($"= Complex B = {complexB}");
                Console.WriteLine($"= Complex C = {complexC}");
                Console.WriteLine("==================================");
                Console.WriteLine("[1] - Change real part of complex A");
                Console.WriteLine("[2] - Change real imaginary of complex A");
                Console.WriteLine("[3] - Change real part of complex B");
                Console.WriteLine("[4] - Change real imaginary of complex B");
                Console.WriteLine("[5] - c = a");
                Console.WriteLine("[6] - c = b");
                Console.WriteLine("[7] - Help");
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
                    case ConsoleKey.D5:
                        complexC = complexA;
                        break;
                    case ConsoleKey.D6:
                        complexC = complexB;
                        break;
                    case ConsoleKey.D7:
                        Console.WriteLine("\nWhen you assign a class to a class, a reference is placed in the variable pointing to the memory area. As a result, both variables will point to the same thing, therefore, when one changes, the other will change.");
                        Console.WriteLine("\n  IF:");
                        Console.WriteLine("    a = 23+54i");
                        Console.WriteLine("    c = a");
                        Console.WriteLine("    c.RealPart = 111");
                        Console.WriteLine("\n  RESULT:");
                        Console.WriteLine("    a == 111+54i [TRUE]");
                        Console.WriteLine("    c == 111+54i [TRUE]");
                        Console.WriteLine("\nPlease press enter for continue...");
                        Console.ReadLine();
                        break;
                    case ConsoleKey.D0:
                        isDemonstrateComplexClass = false;
                        break;
                }
            }
        }

        private void CallDemonstrateComplexStruct()
        {
            bool isDemonstrateComplexStruct = true;

            ComplexStruct complexA = new ComplexStruct(0.0d, 0.0d);
            ComplexStruct complexB = new ComplexStruct(0.0d, 0.0d);
            ComplexStruct complexC = new ComplexStruct(0.0d, 0.0d);

            while (isDemonstrateComplexStruct == true)
            {
                Console.Clear();
                Console.WriteLine("==================================");
                Console.WriteLine("=   DEMONSTRATE COMPLEX STRUCT    =");
                Console.WriteLine("==================================");
                Console.WriteLine($"= Complex A = {complexA}");
                Console.WriteLine($"= Complex B = {complexB}");
                Console.WriteLine($"= Complex C = {complexC}");
                Console.WriteLine("==================================");
                Console.WriteLine("[1] - Change real part of complex A");
                Console.WriteLine("[2] - Change real imaginary of complex A");
                Console.WriteLine("[3] - Change real part of complex B");
                Console.WriteLine("[4] - Change real imaginary of complex B");
                Console.WriteLine("[5] - c = a");
                Console.WriteLine("[6] - c = b");
                Console.WriteLine("[7] - Help");
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
                    case ConsoleKey.D5:
                        complexC = complexA;
                        break;
                    case ConsoleKey.D6:
                        complexC = complexB;
                        break;
                    case ConsoleKey.D7:
                        Console.WriteLine("\nWhen you assign a class to a class, a reference is placed in the variable pointing to the memory area. As a result, both variables will point to the same thing, therefore, when one changes, the other will change.");
                        Console.WriteLine("\n  IF:");
                        Console.WriteLine("    a = 23+54i");
                        Console.WriteLine("    c = a");
                        Console.WriteLine("    c.RealPart = 111");
                        Console.WriteLine("\n  RESULT:");
                        Console.WriteLine("    a == 23+54i [TRUE]");
                        Console.WriteLine("    c == 111+54i [TRUE]");
                        Console.WriteLine("\nPlease press enter for continue...");
                        Console.ReadLine();
                        break;
                    case ConsoleKey.D0:
                        isDemonstrateComplexStruct = false;
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
