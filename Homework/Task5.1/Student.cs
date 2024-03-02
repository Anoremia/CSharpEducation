using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task5._1
{
    public class Student
    {
        public string name;
        public string surname;
        public int age;
        public string university;


        public void IntroduceYourself()
        {
            Console.WriteLine("Привет! Меня зовут " + name);
        }

        public Student(string firstName, string lastName, int age1, string university1)
        {
            name = firstName;
            surname = lastName;
            age = age1;
            university = university1;
        }
    }
    }
