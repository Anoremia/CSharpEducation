using System;

namespace Task9d
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double gC, gF;

            Console.WriteLine("Введите значение в градусах по Цельсию");

            gC = double.Parse(Console.ReadLine());

            gF = gC * 9/5 + 32;

            Console.WriteLine("Градусов: " + gF + " по Ференгейту");
        }
    }
}
