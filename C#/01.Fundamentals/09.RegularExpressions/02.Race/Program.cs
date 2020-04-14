using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace _02.Race
{
    class Program
    {
        static void Main(string[] args)
        {            
            string namePattern = "[A-Za-z]+";
            Regex nameRegex = new Regex(namePattern);

            string digitPattern = @"\d";
            Regex digitRegex = new Regex(digitPattern);

            List<string> participants = Regex.Split(Console.ReadLine(), ",\\s+").ToList();

            Dictionary<string, int> participantsDict = new Dictionary<string, int>();

            string input = Console.ReadLine();
            while (input != "end of race")
            {
                MatchCollection charsCollection = nameRegex.Matches(input);
                string name = String.Join("", charsCollection);

                if (participants.Contains(name))
                {
                    MatchCollection digitsCollection = digitRegex.Matches(input);
                    int distance = 0;
                    foreach (Match match in digitsCollection)
                    {
                        int digit = int.Parse(match.Value);
                        distance += digit;
                    }

                    if (!participantsDict.ContainsKey(name))
                    {
                        participantsDict.Add(name, 0);
                    }

                    participantsDict[name] += distance;
                }


                input = Console.ReadLine();
            }

            participantsDict = participantsDict.OrderByDescending(p => p.Value).ToDictionary(x => x.Key, y => y.Value);

            int counter = 1;
            foreach (KeyValuePair<string, int> kvp in participantsDict)
            {
                string text = counter == 1 ? "st" : counter == 2 ? "nd" : "rd";
                Console.WriteLine($"{counter++}{text} place: {kvp.Key}");
                if (counter == 4)
                {
                    break;
                }
            }
        }
    }
}
