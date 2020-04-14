using System;

namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            SmartPhone smartPhone = new SmartPhone();
            StationaryPhone stationaryPhone = new StationaryPhone();

            string[] phoneNumbers = Console.ReadLine().Split();
            string[] sites = Console.ReadLine().Split();

            foreach (var phoneNumber in phoneNumbers)
            {
                if (phoneNumber.Length == 10)
                {
                    smartPhone.Call(phoneNumber);
                }
                else
                {
                    stationaryPhone.Call(phoneNumber);
                }
            }

            foreach (var site in sites)
            {
                smartPhone.Browse(site);
            }
        }
    }
}
