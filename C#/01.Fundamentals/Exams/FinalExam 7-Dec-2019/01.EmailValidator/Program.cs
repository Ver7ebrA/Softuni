using System;
using System.Text;
using System.Linq;

namespace _01.EmailValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Complete")
            {
                string[] commandArr = command.Split();

                if (commandArr[0] == "Make")
                {
                    if (commandArr[1] == "Upper")
                    {
                        email = email.ToUpper();
                    }
                    else if (commandArr[1] == "Lower")
                    {
                        email = email.ToLower();
                    }

                    Console.WriteLine(email);
                }
                else if (commandArr[0] == "GetDomain")
                {
                    int count = int.Parse(commandArr[1]);
                    string subStr = email.Substring(email.Length - count);
                    Console.WriteLine(subStr);
                }
                else if (commandArr[0] == "GetUsername")
                {
                    if (email.Contains('@'))
                    {
                        int index = email.IndexOf('@');
                        string subStr = email.Substring(0, index);
                        Console.WriteLine(subStr);
                    }
                    else
                    {
                        Console.WriteLine($"The email {email} doesn't contain the @ symbol.");
                    }
                }
                else if (commandArr[0] == "Replace")
                {
                    string charToReplace = commandArr[1];
                    email = email.Replace(charToReplace, "-");
                    Console.WriteLine(email);
                }
                else if (commandArr[0] == "Encrypt")
                {
                    foreach (char letter in email)
                    {
                        int num = (int)letter;
                        Console.Write(num + " ");
                    }
                }

                command = Console.ReadLine();
            }
        }
    }
}
