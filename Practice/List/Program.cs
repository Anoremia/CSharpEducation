using System.Xml.Linq;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Меню:");
                Console.WriteLine("1. Добавить студента");
                Console.WriteLine("2. Удалить студента");
                Console.WriteLine("3. Вывести список студентов");
                Console.WriteLine("0. Выход");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Введите имя студента:");
                        string name = Console.ReadLine();

                        Console.WriteLine("Введите возраст студента:");
                        int age = int.Parse(Console.ReadLine());

                        Student newStudent = new Student(name, age);
                        students.Add(newStudent);

                        Console.WriteLine("Студент добавлен.");
                        break;

                    case "2":
                        Console.WriteLine("Введите номер студента для удаления:");
                        int index = int.Parse(Console.ReadLine());
                        if (index >= 0 && index < students.Count)
                        {
                            students.RemoveAt(index);
                            Console.WriteLine("Студент удален.");
                        }
                        else
                        {
                            Console.WriteLine("Неверный номер студента.");
                        }
                        break;

                    case "3":
                        Console.WriteLine("Список студентов:");
                        for (int i = 0; i < students.Count; i++)
                        {
                            Console.WriteLine($"Студент {i}: {students[i].Name}, {students[i].Age} лет");
                        }
                        break;

                    case "0":
                        isRunning = false;
                        break;

                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте снова.");
                        break;
                }
            }
        }
    }
    

    internal class Student
    {
        public string Name { get; }
        public int Age { get; }

        public Student(string name, int age)
        {
            Name = name;
            Age =  age;
        }

    }
}
