namespace Task20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5; // Размер массива

            int[] emptyArray = CreateEmptyArray(n);

            Console.WriteLine("Содержимое массива:");

            foreach (int num in emptyArray)
            {
                Console.WriteLine(num);
            }
        }

        static int[] CreateEmptyArray(int n)
        {
            int[] newArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                newArray[i] = i + 1; // Заполнение массива значениями от 1 до n
            }

            return newArray;
        }
    }
}
