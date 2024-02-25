namespace Task2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] array = new double[,]
        {
            { 1.1, 2.2, 3.3 },
            { 4.4, 5.5, 6.6 },
        };

            double[] sums = new double[array.GetLength(0)];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                double sum = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    double square = array[i, j] * array[i, j];
                    sum += square;
                }
                sums[i] = sum;
            }

            for (int i = 0; i < sums.Length; i++)
            {
                Console.WriteLine("Сумма квадратов подмассива " + i + ": " + sums[i]);
            }
        }
    }
}

