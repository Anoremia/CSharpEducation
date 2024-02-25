namespace Task2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int q = numbers.Length; 
            int w = q / 2;         
            int o;              
            for (int i = 0; i < w; i++)
            {
                o = numbers[i];
                numbers[i] = numbers[q - i - 1];
                numbers[q - i - 1] = o;
            }
            foreach (int i in numbers)
            {
                Console.Write($"{i} \t");
            }
        }
    }
}
