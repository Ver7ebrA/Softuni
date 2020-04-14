using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> regular = new HashSet<string>();
            HashSet<string> vip = new HashSet<string>();

            string input = Console.ReadLine();

            while (input != "PARTY")
            {
                if (Char.IsDigit(input, 0))
                {
                    vip.Add(input);
                }
                else
                {
                    regular.Add(input);
                }

                input = Console.ReadLine();
            }

            string guest = Console.ReadLine();

            while (guest != "END")
            {
                if (Char.IsDigit(guest, 0) && vip.Contains(guest))
                {
                    vip.Remove(guest);
                }
                else if (!Char.IsDigit(guest, 0) && regular.Contains(guest))
                {
                    regular.Remove(guest);
                }

                guest = Console.ReadLine();
            }

            Console.WriteLine(vip.Count + regular.Count);

            if (vip.Count != 0)
            {
                foreach (var item in vip)
                {
                    Console.WriteLine(item);
                }
            }

            if (regular.Count != 0)
            {
                foreach (var item in regular)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
