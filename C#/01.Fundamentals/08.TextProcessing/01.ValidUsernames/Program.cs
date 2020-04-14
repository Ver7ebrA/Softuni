using System;

namespace _01.ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");

            foreach (string username in usernames)
            {
                if (username.Length < 3 || 16 < username.Length )
                {
                    continue;
                }

                bool isValid = true;
                foreach (char ch in username)
                {
                    if (!(char.IsLetterOrDigit(ch) || ch == '-' || ch == '_'))
                    {
                        isValid = false;
                        break;
                    }
                }

                if (isValid)
                {
                    Console.WriteLine(username);
                }
            }
        }
    }
}
