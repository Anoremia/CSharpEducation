namespace Task9c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double metrvsec, kilometrvchas;

            Console.WriteLine("Введите значение в метрах в секунду");

            metrvsec = double.Parse(Console.ReadLine());

            kilometrvchas = metrvsec / 3.6;

            Console.WriteLine("Длина равна: " + kilometrvchas + " км/ч");
        }
    }
}
