using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();
            SortedDictionary<string, Dictionary<string, int>> candidates = new SortedDictionary<string, Dictionary<string, int>>();

            string contestsInput = Console.ReadLine();

            while (contestsInput != "end of contests")
            {
                string[] contestsInputArr = contestsInput.Split(":", StringSplitOptions.RemoveEmptyEntries);
                contests[contestsInputArr[0]] = contestsInputArr[1];

                contestsInput = Console.ReadLine();
            }

            string submission = Console.ReadLine();

            while (submission != "end of submissions")
            {
                string[] submissionArr = submission.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string contest = submissionArr[0];
                string password = submissionArr[1];
                string username = submissionArr[2];
                int points = int.Parse(submissionArr[3]);

                if (contests.ContainsKey(contest))
                {
                    if (contests[contest] == password)
                    {
                        if (!candidates.ContainsKey(username))
                        {
                            candidates[username] = new Dictionary<string, int>();
                            candidates[username].Add(contest, points);
                        }

                        if (!candidates[username].ContainsKey(contest))
                        {
                            candidates[username].Add(contest, points);
                        }

                        if (candidates[username][contest] < points)
                        {
                            candidates[username][contest] = points;
                        }                      
                    }
                }

                submission = Console.ReadLine();
            }

            Dictionary<string, int> candidatesTotalpoints = new Dictionary<string, int>();
            foreach (var kvp in candidates)
            {
                candidatesTotalpoints[kvp.Key] = kvp.Value.Values.Sum();
            }

            int maxPoints = candidatesTotalpoints
                .Values
                .Max();

            foreach (var kvp in candidatesTotalpoints)
            {
                if (kvp.Value == maxPoints)
                {
                    Console.WriteLine($"Best candidate is {kvp.Key} with total {kvp.Value} points.");
                }
            }

            Console.WriteLine("Ranking:");
            foreach (var kvp in candidates)
            {
                Console.WriteLine(kvp.Key);
                Console.WriteLine(string.Join(Environment.NewLine, kvp.Value
                    .OrderByDescending(v => v.Value).
                    Select(a => $"#  {a.Key} -> {a.Value}")));
            }
        }
    }
}
