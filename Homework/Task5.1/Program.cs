using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Student student = new Student;
            //student.name = "Егор";
            //student.surname= "Егоров";
            //student.age = 20;
            //student.university = "Университет Ололоша";

            //student.IntroduceYourself(); // это к 3-4 заданию

            Student[] students = new Student[3];
            students[0] = new Student("Егор", "Егоров", 20, "Университет Ололоша");
            students[1] = new Student("Анна", "Иоанновна", 22, "Университет Корпорации Монсторов");
            students[2] = new Student("Иван", "Грозный", 19, "Университет убийц");

            Console.WriteLine("Список студентов:");
            foreach (Student student1 in students)
            {
                Console.WriteLine($"{student1.name} {student1.surname}, Возраст: {student1.age}, Университет: {student1.university}");
            }

            Console.WriteLine("\nСтуденты старше 21 года:");
            foreach (Student student1 in students)
            {
                if (student1.age > 21)
                {
                    Console.WriteLine($"{student1.name} {student1.surname}, Возраст: {student1.age}");
                }
            }

            Student oldestStudent = students.OrderByDescending(s => s.age).First();
            Student youngestStudent = students.OrderBy(s => s.age).First();

            Console.WriteLine($"\nСамый молодой студент: {youngestStudent.name} {youngestStudent.surname}, Возраст: {youngestStudent.age}");
            Console.WriteLine($"Самый старший студент: {oldestStudent.name} {oldestStudent.surname}, Возраст: {oldestStudent.age}");
        }
    }

}
