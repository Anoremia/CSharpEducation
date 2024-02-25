namespace Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double metr, kilometr;

            Console.WriteLine("Введите значение в метрах");
            
            metr = double.Parse(Console.ReadLine());

            kilometr = metr / 1000;

            Console.WriteLine("Длина равна: " + kilometr + " км");

        }
    }
}
