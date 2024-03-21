namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5, 6, 7 };
            string[] stringArray = { "mom", "dad", "oleg", "son", "jopa" };

            int targetInt = 5;
            string targetString = "oleg";

            Console.WriteLine($"Линейный поиск для числа: {Search.LinearSearch(intArray, targetInt)}");
            Console.WriteLine($"Бинарный поиск для числа: {Search.BinarySearch(intArray, targetInt)}");
            Console.WriteLine($"Бинарный поиск для текста: {Search.BinarySearch(stringArray, targetString)}");
        }
    }
}

