namespace p02.ExtractSentencesByKeyword
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            string keyWord = Console.ReadLine();
            string pattern = $@"\b[^?.!]*\b{keyWord}\b[^?.!]*"; 
            Regex regex = new Regex(pattern);

            string text = Console.ReadLine();

            var matches = regex.Matches(text)
                .Cast<Match>()
                .Select(m => m.Value)
                .ToArray();

            for (int i = 0; i < matches.Length; i++)
            {
                string sentence = matches[i].Trim();
                Console.WriteLine(sentence);
            }
        }
    }
}

