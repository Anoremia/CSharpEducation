namespace Task27
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person Egor = new Person();
            Egor.age = 10;
            Console.WriteLine(Egor.CheckIsAdult());
        }
    }
}
