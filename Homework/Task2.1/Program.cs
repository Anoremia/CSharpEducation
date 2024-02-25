namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];

            Console.WriteLine("Введите 5 чисел");

            for (int i = 0; i < numbers.Length; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                numbers[i] = number;
            }
            foreach (int number in numbers)
            {
                Console.WriteLine("Вы ввели числа: "+number);
            }

        }
       
    }

}
