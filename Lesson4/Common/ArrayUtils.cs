using System;

namespace Lesson4.Common
{
    internal class ArrayUtils
    {
        public static int[] GenerateRandomArray(int minValue, int maxValue, int arraySize)
        {
            int[] result = new int[arraySize];

            Random random = new Random();

            for (int i = 0; i < arraySize; i++)
            {
                result[i] = random.Next(minValue, maxValue + 1);
            }

            return result;
        }

        public static void PrintArray(string arrayName, int[] array)
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

        public static void AddNumberToArray(ref int[] array, int number)
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
    }
}
