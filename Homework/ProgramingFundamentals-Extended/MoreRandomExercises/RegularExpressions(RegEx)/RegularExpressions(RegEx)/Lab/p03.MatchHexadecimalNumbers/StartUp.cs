namespace p03.MatchHexadecimalNumbers
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            string pattern = @"\b(?:0x)?([0-9A-F]+)\b";

            var numbersString = Console.ReadLine();

            var numbers = Regex.Matches(numbersString, pattern)
                .Cast<Match>()
                .Select(a => a.Value)
                .ToArray();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
