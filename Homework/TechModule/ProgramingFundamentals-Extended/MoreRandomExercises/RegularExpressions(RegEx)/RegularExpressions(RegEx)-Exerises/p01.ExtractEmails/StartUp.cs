namespace p01.ExtractEmails
{
    using System;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            string toRegex = @"(?<=\s)[a-z0-9]+([-.]\w*)*@[a-z]+([-.]\w*)*(\.[a-z]+)";

            var regexShmegex = new Regex(toRegex);

            string textToMatch = Console.ReadLine();

            var contains = regexShmegex.Matches(textToMatch);

            foreach (Match mail in contains)
            {
                Console.WriteLine(mail);
            }
        }
    }
}
