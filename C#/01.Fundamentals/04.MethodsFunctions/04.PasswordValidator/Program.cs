using System;

namespace _04.PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string passLength = "Password must be between 6 and 10 characters";
            string passLettersOrDigits = "Password must consist only of letters and digits";
            string passContainTwoDigits = "Password must have at least 2 digits";
            string validPass = "Password is valid";

            if (PasswordLength(input) == false || input == "")
            {
                Console.WriteLine(passLength);
            }

            if (PasswordIsAllLettersOrDigits(input) == false || input == "")
            {
                Console.WriteLine(passLettersOrDigits);
            }

            if (PasswordContainsTwoDigits(input) == false || input == "")
            {
                Console.WriteLine(passContainTwoDigits);
            }

            if (PasswordLength(input) == true &&
                PasswordIsAllLettersOrDigits(input) == true &&
                PasswordContainsTwoDigits(input) == true)
            {
                Console.WriteLine(validPass);
            }
        }

        static bool PasswordLength(string password)
        {
            if (6 <= password.Length && password.Length <= 10)
            {
                return true;
            }

            return false;
        }

        static bool PasswordIsAllLettersOrDigits(string password)
        {
            foreach (char c in password)
            {
                if (!Char.IsLetterOrDigit(c))
                {
                    return false;
                }
            }

            return true;
        }

        static bool PasswordContainsTwoDigits(string password)
        {
            int count = 0;

            foreach (char c in password)
            {
                if (Char.IsDigit(c))
                {
                    count++;
                }
            }

            if (2 <= count)
            {
                return true;
            }

            return false;
        }
    }
}
