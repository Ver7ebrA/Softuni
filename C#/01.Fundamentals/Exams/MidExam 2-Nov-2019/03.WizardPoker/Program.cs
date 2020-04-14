using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.WizardPoker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> arsenal = Console.ReadLine().Split(":").ToList();
            List<string> deck = new List<string>();

            string command = Console.ReadLine();

            while (command != "Ready")
            {
                string[] commandArr = command.Split().ToArray();

                if (commandArr[0] == "Add")
                {
                    if (arsenal.Contains(commandArr[1]))
                    {
                        deck.Add(commandArr[1]);
                    }
                    else
                    {
                        Console.WriteLine("Card not found.");
                    }
                }
                else if (commandArr[0] == "Insert")
                {
                    int index = int.Parse(commandArr[2]);

                    if (arsenal.Contains(commandArr[1]) && 0 <= index && index < arsenal.Count - 1)
                    {
                        deck.Insert(index, commandArr[1]);
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                }
                else if (commandArr[0] == "Remove")
                {
                    if (deck.Contains(commandArr[1]))
                    {
                        deck.Remove(commandArr[1]);
                    }
                    else
                    {
                        Console.WriteLine("Card not found.");
                    }
                }
                else if (commandArr[0] == "Swap")
                {
                    string firstCard = commandArr[1];
                    string secondCard = commandArr[2];

                    int indexFirstCard = deck.FindIndex(s => s.Contains(firstCard));
                    int indexSecondCard = deck.FindIndex(s => s.Contains(secondCard));

                    deck[indexFirstCard] = secondCard;
                    deck[indexSecondCard] = firstCard;
                }
                else if (commandArr[0] == "Shuffle")
                {
                    deck.Reverse();
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ", deck));
        }
    }
}
