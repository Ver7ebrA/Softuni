using System;
using System.Collections.Generic;

namespace _05.Students
{

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] inputArr = input.Split();

                string firstName = inputArr[0];
                string lastName = inputArr[1];
                int age = int.Parse(inputArr[2]);
                string city = inputArr[3];

                Student student = new Student()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    City = city
                };

                students.Add(student);
                input = Console.ReadLine();
            }

            string filterCity = Console.ReadLine();
            foreach (Student student in students)
            {
                if (student.City == filterCity)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }

    class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string City { get; set; }
    }
}
