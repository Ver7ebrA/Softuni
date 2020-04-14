using System;
using System.Collections.Generic;

namespace _06.Students2._0
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

                if (IsStudentExisting(students, firstName, lastName))
                {
                    Student student = GetStudent(students, firstName, lastName);

                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.City = city;
                }
                else
                {
                    Student student = new Student()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        City = city
                    };

                    students.Add(student);
                }
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

        static bool IsStudentExisting(List<Student> students, string firstName, string lastName)
        {
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }

            return false;
        }

        static Student GetStudent(List<Student> students, string firstName, string lastName)
        {
            Student existingStuden = null;

            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    existingStuden = student;
                }
            }

            return existingStuden;
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
