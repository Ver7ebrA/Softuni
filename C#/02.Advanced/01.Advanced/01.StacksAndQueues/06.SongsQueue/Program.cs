using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> songs = new Queue<string>(Console.ReadLine()
                .Split(", "));

            while (songs.Any())
            {
                string[] command = Console.ReadLine().Split(new[] { ' ' }, 2);

                if (command[0] == "Play")
                {
                    songs.Dequeue();
                }
                else if (command[0] == "Show")
                {
                    Console.WriteLine(String.Join(", ", songs));
                }
                else if (command[0] == "Add")
                {
                    if (songs.Contains(command[1]))
                    {
                        Console.WriteLine($"{command[1]} is already contained!");
                    }
                    else
                    {
                        songs.Enqueue(command[1]);
                    }
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}
