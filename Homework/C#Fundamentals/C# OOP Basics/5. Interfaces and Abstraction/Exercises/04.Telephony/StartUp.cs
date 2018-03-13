using System;

namespace _04.Telephony
{
    public class StartUp
    {
        public static void Main()
        {
            string[] phoneNums = Console.ReadLine().Split();
            string[] urls = Console.ReadLine().Split();

            ICallable numbersToCall = new Smartphone();

            foreach (var phoneNum in phoneNums)
            {
                try
                {
                    numbersToCall.PhoneNumber = phoneNum;
                    Console.WriteLine($"Calling... {numbersToCall.PhoneNumber}");
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            IBrowsable sites = new Smartphone(); 

            foreach (var url in urls)
            {
                try
                {
                    sites.URL = url;
                    Console.WriteLine($"Browsing: {sites.URL}!");
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
