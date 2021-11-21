using Lesson4.Common;
using System.IO;

namespace Lesson4.Tasks.Task2
{
    internal class StaticClass
    {
        public static int[] GetIndicesOfPairs(int[] array)
        {
            int[] result = new int[0];

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] % 3 == 0 && array[i + 1] % 3 != 0 ||
                    array[i] % 3 != 0 && array[i + 1] % 3 == 0)
                {
                    ArrayUtils.AddNumberToArray(ref result, i);
                }
            }

            return result;
        }

        public static void SaveToFile(string fileName, int[] array)
        {
            using (StreamWriter streamWriter = new StreamWriter(fileName))
            {
                for (int i = 0; i < array.Length; i++)
                {
                    streamWriter.WriteLine(array[i]);
                }
            }
        }

        public static int[] LoadFromFile(string fileName)
        {
            if (File.Exists(fileName) == false)
            {
                return null;
            }

            int[] result = new int[0];
            using (StreamReader streamReader = new StreamReader(fileName))
            {
                string currentLine;
                while ((currentLine = streamReader.ReadLine()) != null)
                {
                    if (int.TryParse(currentLine, out int currentValue))
                    {
                        ArrayUtils.AddNumberToArray(ref result, currentValue);
                    }
                }
            }

            return result;
        }
    }
}
