namespace p02.ExtractSentencesByKeyword
{
    using System;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            string wordSeparator = Console.ReadLine();
            string text = Console.ReadLine();

            string pattern = $@"\b[^?.!]*\b{wordSeparator}\b[^?.!]*";

            var matches = Regex.Matches(text, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }

            Console.WriteLine();
        }
    }
}
