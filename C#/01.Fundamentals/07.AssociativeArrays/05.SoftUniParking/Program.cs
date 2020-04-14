﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var users = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                List<string> directions = Console.ReadLine().Split().ToList();
                string name = directions[1];
                if (directions[0] == "register")
                {
                    string license = directions[2];

                    if (users.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {users[name]}");
                    }
                    else
                    {
                        users.Add(name, license);
                        Console.WriteLine($"{name} registered {license} successfully");
                    }
                }
                else if (directions[0] == "unregister")
                {
                    if (users.ContainsKey(name))
                    {
                        users.Remove(name);
                        Console.WriteLine($"{name} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                }
            }
            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}