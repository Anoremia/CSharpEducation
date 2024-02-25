namespace Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            
            Console.WriteLine("Введение значение от 1 до 5");
            number = int.Parse(Console.ReadLine());
            if (number > 5 || number < 1) 
            {
                Console.WriteLine("Введите значение ОТ ОДНОГО ДО ПЯТИ");
            }
            else if (number == 5) 
            {
                Console.WriteLine("Отлично");
            }
            else if (number == 4)
            {
                Console.WriteLine("Хорошо");
            }
            else if (number == 3)
            {
                Console.WriteLine("Удовлетворительно");
            }
            else if (number == 2)
            {
                Console.WriteLine("Неудовлетворительно");
            }
            else if (number == 1)
            {
                Console.WriteLine("Ужасно");
            }
            else
            {
                Console.WriteLine("Ошибка");
            }
           
        }
    }
}
