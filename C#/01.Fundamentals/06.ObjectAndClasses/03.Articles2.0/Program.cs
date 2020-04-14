﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Articles2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfArticles = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>(numberOfArticles);

            for (int i = 0; i < numberOfArticles; i++)
            {
                string[] input = Console.ReadLine().Split(", ").ToArray();

                Article article = new Article(input[0], input[1], input[2]);

                articles.Add(article);
            }

            string order = Console.ReadLine();

            if (order == "title")
            {
                articles = articles.OrderBy(s => s.Title).ToList();
            }
            else if (order == "content")
            {
                articles = articles.OrderBy(s => s.Content).ToList();
            }
            else if (order == "author")
            {
                articles = articles.OrderBy(s => s.Author).ToList();
            }

            Console.WriteLine(String.Join(Environment.NewLine, articles));
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
