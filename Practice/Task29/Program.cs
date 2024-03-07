namespace Task29
{
    public class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book ("Голодные игры", "С.Коллинз", 2008,"Роман и т.д.");
            Book book2 = new Book("Преступление и наказание", "Ф.М. Достоевский", 1866, "Роман");
            Book book3 = new Book("Мальчик в полосатой пижаме", "Д.Бойн", 2006, "Роман");

            Console.WriteLine($"Количество книг: {Book.BooksCount}");
        }
    }
}
