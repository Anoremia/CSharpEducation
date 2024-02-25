namespace Task24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { -1, -2, 3, -4, 5, -6 };
            int removedCount;

            int[] result = RemoveNegativeNumbers(numbers, out removedCount);

            Console.WriteLine("Исходный массив:");
            PrintArray(numbers);

            Console.WriteLine("\nМассив после удаления отрицательных чисел:");
            PrintArray(result);

            Console.WriteLine($"\nКоличество удаленных отрицательных чисел: {removedCount}");
        }

        static int[] RemoveNegativeNumbers(int[] array, out int removedCount)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    count++;
                }
            }

            int[] result = new int[array.Length - count];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    result[index] = array[i];
                    index++;
                }
            }

            removedCount = count;
            return result;
        }

        static void PrintArray(int[] array)
        {
            foreach (var num in array)
            {
                Console.Write(num + " ");
            }
        }
    }
}
