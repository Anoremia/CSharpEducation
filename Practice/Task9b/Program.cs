namespace Task9b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double kilometr, santimetr;

            Console.WriteLine("Введите значение в сантиметрах");

            kilometr = double.Parse(Console.ReadLine());

            santimetr = kilometr / 100000;

            Console.WriteLine("Длина равна: " + santimetr + " см");
        }
    }
}
