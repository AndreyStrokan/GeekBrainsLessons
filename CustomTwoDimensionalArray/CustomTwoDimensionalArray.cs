using System;

namespace CustomTwoDimensionalArrayLibrary
{
    public class CustomTwoDimensionalArray
    {
        private int[,] array = null;
        public int MaxValue
        {
            get
            {
                int result = int.MinValue;
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (array[i, j] > result)
                        {
                            result = array[i, j];
                        }
                    }
                }
                return result;
            }
        }

        public int MinValue
        {
            get
            {
                int result = int.MaxValue;
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (array[i, j] < result)
                        {
                            result = array[i, j];
                        }
                    }
                }
                return result;
            }
        }

        public CustomTwoDimensionalArray(int countRow, int countColumns, int minValue, int maxValue)
        {
            Random random = new Random();
            array = new int[countRow, countColumns];
            for (int i = 0; i < countRow; i++)
            {
                for (int j = 0; j < countColumns; j++)
                {
                    array[i, j] = random.Next(minValue, maxValue + 1);
                }
            }
        }

        public void GetMaxValueIndex(out int maxValueRowIndex, out int maxValueColumnIndex)
        {
            maxValueRowIndex = 0;
            maxValueColumnIndex = 0;

            int maxValue = int.MinValue;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > maxValue)
                    {
                        maxValueRowIndex = i;
                        maxValueColumnIndex = j;
                        maxValue = array[i, j];
                    }
                }
            }
        }

        public int Sum()
        {
            int result = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    result += array[i, j];
                }
            }

            return result;
        }

        public int SumWhereValueIsGreaterThan(int value)
        {
            int result = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > value)
                    {
                        result += array[i, j];
                    }
                }
            }

            return result;
        }

        public override string ToString()
        {
            string result = "[\n";

            for (int i = 0; i < array.GetLength(0); i++)
            {
                result += "[";
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    result += array[i, j];
                    if (j < array.GetLength(1) - 1)
                    {
                        result += ", ";
                    }
                }
                result += "]";
                if (i < array.GetLength(0) - 1)
                {
                    result += "\n";
                }
            }
            result += "\n]";
            return result;
        }
    }
}
