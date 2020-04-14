using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < studentsCount; i++)
            {
                string[] input = Console.ReadLine().Split();

                Student student = new Student()
                {
                    FirstName = input[0],
                    LastName = input[1],
                    Grade = double.Parse(input[2])
                };

                students.Add(student);
            }

            students = students.OrderByDescending(d => d.Grade).ToList();

            Console.WriteLine(String.Join(Environment.NewLine, students));
        }
    }

    class Student
    {
        public Student()
        {

        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:f2}";
        }
    }
}
