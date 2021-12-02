namespace CustomArrayLibrary
{
    public class CustomArray
    {
        private int[] array = null;
        public int Sum
        {
            get
            {
                int result = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    result += array[i];
                }
                return result;
            }
        }

        public int MaxCount
        {
            get
            {
                int maxValue = int.MinValue;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > maxValue)
                    {
                        maxValue = array[i];
                    }
                }

                int result = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == maxValue)
                    {
                        result++;
                    }
                }

                return result;
            }
        }

        private CustomArray(int[] array)
        {
            this.array = array;
        }

        public CustomArray(int size, int startValue, int step)
        {
            array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = startValue + step * i;
            }
        }

        public CustomArray Inverse()
        {
            int[] result = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                result[i] = array[array.Length - 1 - i];
            }

            return new CustomArray(result);
        }

        public void Multi(int multiplicator)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= multiplicator;
            }
        }

        public override string ToString()
        {
            string result = "";
            result += $"[";
            for (int i = 0; i < array.Length; i++)
            {
                result += array[i];
                if (i < array.Length - 1)
                {
                    result += ", ";
                }
            }
            result += "]";

            return result;
        }
    }
}
