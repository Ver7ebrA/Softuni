﻿using System;

namespace _03.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int courses = people / capacity;

            if (people % capacity != 0)
            {
                courses += 1;
            }

            Console.WriteLine(courses);
        }
    }
}
