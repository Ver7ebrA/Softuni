using System;
using System.Linq;

namespace _02.Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputArr = input.Split(", ");

            Article article = new Article(inputArr[0], inputArr[1], inputArr[2]);

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(":")
                    .Select(s => s.Trim())
                    .ToArray();

                if (command[0] == "Edit")
                {
                    article.Content = command[1];
                }
                else if (command[0] == "ChangeAuthor")
                {
                    article.Author = command[1];
                }
                else if (command[0] == "Rename")
                {
                    article.Title = command[1];
                }
            }

            Console.WriteLine(article.ToString());
        }
    }

    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }

    }
}
