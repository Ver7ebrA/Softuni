using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courseInfo = new Dictionary<string, List<string>>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }

                string[] tokens = command.Split(" : ");
                string course = tokens[0];
                string student = tokens[1];

                if (!courseInfo.ContainsKey(course))
                {
                    courseInfo.Add(course, new List<string>());
                    courseInfo[course].Add(student);
                }
                else
                {
                    courseInfo[course].Add(student);

                }
            }

            foreach (var course in courseInfo.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count()}");
                foreach (var name in course.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {name}");
                }
            }
        }
    }
}