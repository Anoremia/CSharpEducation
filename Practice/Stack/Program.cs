namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<Student> students = new Stack<Student>();
            students.Push(new Student("Иванов", 20));
            students.Push(new Student("Петров", 22));
            students.Push(new Student("Сидоров", 21));

            Student foundStudent = FindStudentByNameAndAge(students, "Сидоров", 21);

            if (foundStudent != null)
            {
                Console.WriteLine($"Найден студент {foundStudent.Name}, возраст {foundStudent.Age}.");
            }
            else
            {
                Console.WriteLine("Студент не найден.");
            }
        }

        static Student FindStudentByNameAndAge(Stack<Student> students, string name, int age)
        {
            Stack<Student> tempStack = new Stack<Student>();

            Student foundStudent = null;

            foreach (var student in students)
            {
                tempStack.Push(student);
                if (student.Name == name && student.Age == age)
                {
                    foundStudent = student;
                    break;
                }
            }

            // Восстанавливаем исходный порядок элементов в стеке students
            while (tempStack.Count > 0)
            {
                students.Push(tempStack.Pop());
            }

            return foundStudent;
        }
    }
    

    internal class Student
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

