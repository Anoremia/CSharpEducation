namespace Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<Student> studentQueue = new Queue<Student>();

            int choice = -1;

            while (choice != 0)
            {
                Console.WriteLine("Меню:");
                Console.WriteLine("1. Добавить студента в очередь");
                Console.WriteLine("2. Убрать следующего в очереди студента");
                Console.WriteLine("3. Узнать, кто следующий в очереди");
                Console.WriteLine("0. Выход");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Введите имя студента:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Введите возраст студента:");
                        int age = Convert.ToInt32(Console.ReadLine());
                        Student newStudent = new Student(name, age);
                        studentQueue.Enqueue(newStudent);
                        Console.WriteLine("Студент успешно добавлен в очередь.");
                        break;
                    case 2:
                        if (studentQueue.Count > 0)
                        {
                            Student nextStudent = studentQueue.Dequeue();
                            Console.WriteLine("Студент " + nextStudent.Name + " удален из очереди.");
                        }
                        else
                        {
                            Console.WriteLine("Очередь пуста.");
                        }
                        break;
                    case 3:
                        if (studentQueue.Count > 0)
                        {
                            Student nextStudent = studentQueue.Peek();
                            Console.WriteLine("Следующий в очереди студент: " + nextStudent.Name);
                        }
                        else
                        {
                            Console.WriteLine("Очередь пуста.");
                        }
                        break;
                    case 0:
                        Console.WriteLine("Программа завершена.");
                        break;
                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте снова.");
                        break;
                }
            }
        }
    }
    public class Student
    {
        public string Name { get; }
        public int Age { get; }

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}

