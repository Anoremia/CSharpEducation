namespace Task22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 7;

            Console.WriteLine("Исходное значение числа: " + number);

            ChangeSign(ref number);

            Console.WriteLine("Число после изменения знака: " + number);
        }

        static void ChangeSign(ref int num)
        {
            num = -num;
        }
    }
    
}
