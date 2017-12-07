namespace p01.ExtractEmails
{
    using System;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            string pattern = @"(^|(?<=\s))[a-z0-9]+[\.\-_]?[a-z0-9]+@[a-z]+[\-]?[a-z]+\.[a-z]+[\.[a-z]+]?\b";

            string text = Console.ReadLine();

            var matchEmails = Regex.Matches(text, pattern);

            foreach (Match match in matchEmails)
            {
                Console.WriteLine(match.Value);
            }

            Console.WriteLine();
        }
    }
}
