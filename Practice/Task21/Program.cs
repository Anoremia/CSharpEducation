namespace Task21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] originalArray = { 1, 2, 3, 4, 5 };

            int[] reversedArray = ReverseArray(originalArray);

            Console.WriteLine("Исходный массив:");
            PrintArray(originalArray);

            Console.WriteLine("\nИнвертированный массив:");
            PrintArray(reversedArray);
        }

        static int[] ReverseArray(int[] array)
        {
            int[] reversed = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                reversed[i] = array[array.Length - 1 - i];
            }

            return reversed;
        }

        static void PrintArray(int[] array)
        {
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
        }
    }
}
