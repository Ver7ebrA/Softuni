using System;
using System.Text.RegularExpressions;

namespace _02.Registrations
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([U][$])([A-Z][a-z]{2,})(\1)([P][@][$])([A-Za-z]{5,}[\d]+)(\4)";
            Regex registration = new Regex(pattern);
            int count = 0;

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                Match match = registration.Match(input);

                if (match.Success)
                {                   
                    count++;
                    string username = match.Groups[2].Value;
                    string password = match.Groups[5].Value;
                    Console.WriteLine("Registration was successful");
                    Console.WriteLine($"Username: {username}, Password: {password}");
                }
                else
                {
                    Console.WriteLine("Invalid username or password");
                }
            }

            Console.WriteLine($"Successful registrations: {count}");
        }
    }
}
