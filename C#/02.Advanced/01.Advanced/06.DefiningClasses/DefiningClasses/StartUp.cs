using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> peopleOlderThanThirty = new List<Person>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];
                int age = int.Parse(input[1]);

                Person person = new Person(name, age);
                if (30 < person.Age)
                {
                    peopleOlderThanThirty.Add(person);
                }
            }

            peopleOlderThanThirty = peopleOlderThanThirty
                .OrderBy(p => p.Name)
                .ToList();

            foreach (var person in peopleOlderThanThirty)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
