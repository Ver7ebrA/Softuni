using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Telephony
{
    public class SmartPhone : ICaller, IBrowser
    {
        public void Call(string phoneNumber)
        {
            if (phoneNumber.Any(char.IsLetter))
            {
                Console.WriteLine("Invalid number!");
            }
            else
            {
                Console.WriteLine($"Calling... {phoneNumber}");
            }
        }

        public void Browse(string siteName)
        {
            if (siteName.Any(char.IsDigit))
            {
                Console.WriteLine("Invalid URL!");
            }
            else
            {
                Console.WriteLine($"Browsing: {siteName}!");
            }
        }
    }
}
