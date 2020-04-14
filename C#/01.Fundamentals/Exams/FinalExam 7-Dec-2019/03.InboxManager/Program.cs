using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.InboxManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> emails = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "Statistics")
            {
                string[] inputArr = input.Split("->").ToArray();
                string command = inputArr[0];
                string username = inputArr[1];

                if (command == "Add")
                {
                    if (emails.ContainsKey(username))
                    {
                        Console.WriteLine($"{username} is already registered");
                    }
                    else
                    {
                        emails.Add(username, new List<string>());
                    }
                }
                else if (command == "Send")
                {
                    if (emails.ContainsKey(username))
                    {
                        string email = inputArr[2];
                        emails[username].Add(email);
                    }
                }
                else if (command == "Delete")
                {
                    if (emails.ContainsKey(username))
                    {
                        emails.Remove(username);
                    }
                    else
                    {
                        Console.WriteLine($"{username} not found!");
                    }
                }

                input = Console.ReadLine();
            }

            emails = emails.OrderByDescending(kvp => kvp.Value.Count)
                .ThenBy(kvp => kvp.Key)
                .ToDictionary(k => k.Key, v => v.Value);

            Console.WriteLine($"Users count: {emails.Count}");

            foreach (var user in emails)
            {
                Console.WriteLine(user.Key);
                foreach (string email in emails[user.Key])
                {
                    Console.WriteLine($" - {email}");
                }
            }
        }
    }
}
