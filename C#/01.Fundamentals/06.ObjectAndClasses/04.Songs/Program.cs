using System;
using System.Collections.Generic;


namespace _04.Songs
{
    class Song
    {
        public string Type { get; set; }

        public string Name { get; set; }

        public string Length { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            

            int numberOfSongs = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] input = Console.ReadLine().Split("_");

                string type = input[0];
                string name = input[1];
                string length = input[2];

                Song song = new Song();

                song.Type = type;
                song.Name = name;
                song.Length = length;

                songs.Add(song);
            }

            string typeToPrint = Console.ReadLine();

            if (typeToPrint == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in songs)
                {
                    if (song.Type == typeToPrint)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }
}
