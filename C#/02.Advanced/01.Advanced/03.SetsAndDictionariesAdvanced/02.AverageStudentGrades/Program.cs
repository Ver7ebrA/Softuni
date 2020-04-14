using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> studentGrades = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                double grade = double.Parse(input[1]);

                if (studentGrades.ContainsKey(name))
                {
                    studentGrades[name].Add(grade);
                }
                else
                {
                    studentGrades[name] = new List<double>();
                    studentGrades[name].Add(grade);
                }
            }

            foreach (var kvp in studentGrades)
            {
                string student = kvp.Key;
                var grades = kvp.Value;
                double averageGrade = grades.Average();

                Console.Write($"{student} -> ");
                foreach (var item in grades)
                {
                    Console.Write($"{item:f2} ");
                }
                Console.WriteLine($"(avg: {averageGrade:f2})");
            }
        }
    }
}
