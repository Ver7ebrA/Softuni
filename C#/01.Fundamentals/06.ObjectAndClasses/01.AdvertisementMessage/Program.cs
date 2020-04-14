using System;
using System.Collections.Generic;

namespace _01.AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfMessages = int.Parse(Console.ReadLine());

            List<string> phrases = new List<string>
            { "Excellent product."
            , "Such a great product."
            , "I allways use that product."
            , "Best product of it's category."
            , "Exceptional product"
            , "I can't live without this product." };

            List<string> events = new List<string>
            { "Now I feel good."
            , "I have succeeded with this product."
            , "Makes miracles. I am happy of the results!"
            , "I cannot believe but now I feel awesome."
            , "Try it yourself, I am very satisfied."
            , "I feel great!" };

            List<string> authors = new List<string>
            { "Diana"
            , "Petya"
            , "Stella"
            , "Elena"
            , "Katya"
            , "Iva"
            , "Annie"
            , "Eva" };

            List<string> cities = new List<string>
            { "Burgas"
            , "Sofia"
            , "Plovdiv"
            , "Varna"
            , "Ruse" };

            Random phraseIndex = new Random();
            Random eventIndex = new Random();
            Random authorIndex = new Random();
            Random cityIndex = new Random();

            for (int i = 0; i < numberOfMessages; i++)
            {
                string randomPhrase = phrases[phraseIndex.Next(phrases.Count - 1)];
                string randomEvent = events[eventIndex.Next(events.Count - 1)];
                string randomAuthor = authors[authorIndex.Next(authors.Count - 1)];
                string randomCity = cities[cityIndex.Next(cities.Count - 1)];

                Console.Write($"{randomPhrase} {randomEvent} {randomAuthor} - {randomCity}");
                Console.WriteLine();
            }
        }
    }




}       