using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Telephony
{
    public class StationaryPhone : ICaller
    {
        public void Call(string phoneNumber)
        {
            if (phoneNumber.Any(char.IsLetter))
            {
                Console.WriteLine("Invalid number!");
            }
            else
            {
                Console.WriteLine($"Dialing... {phoneNumber}");
            }
        }
    }
}
