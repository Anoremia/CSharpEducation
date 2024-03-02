using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task5._1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Student student = new Student;
            //student.name = "Оло";
            //student.surname= "Ололошова";
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

            Student FindOldestStudent = students[0];
            Student FindYoungestStudent = students[0];

            foreach (Student student in students)
            {
                if (student.age > FindOldestStudent.age)
                {
                    FindOldestStudent = student;
                }

                if (student.age < FindYoungestStudent.age)
                {
                    FindYoungestStudent = student;
                }
            }

            Console.WriteLine($"\nСамый молодой студент: {FindYoungestStudent.name} {FindYoungestStudent.surname}, Возраст: {FindYoungestStudent.age}");
            Console.WriteLine($"Самый старший студент: {FindOldestStudent.name} {FindOldestStudent.surname}, Возраст: {FindOldestStudent.age}");

        }
    }


    
}


