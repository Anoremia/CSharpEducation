namespace Task23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 20;

            Console.WriteLine($"Исходные значения: num1 = {num1}, num2 = {num2}");

            SwapNumbers(ref num1, ref num2);

            Console.WriteLine($"Числа после замены: num1 = {num1}, num2 = {num2}");
        }

        static void SwapNumbers(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
   
}
