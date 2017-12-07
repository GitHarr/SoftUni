namespace p02.AnonymousVox
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class StartUp
    {
        public static void Main()
        {
            string text = Console.ReadLine();

            //string[] placeholders = Console.ReadLine()
            //    .Split("{}"
            //    .ToCharArray(), StringSplitOptions.RemoveEmptyEntries);       -> different way

            //string[] placeholders = Console.ReadLine()
            //.Split(new char[] { '{', '}' }
            //, StringSplitOptions.RemoveEmptyEntries);             -> the same thing, different way

            string[] placeholders = Regex.Split(Console.ReadLine(), "[{}]")
                .Where(e => e != "")
                .ToArray();

            string pattern = @"([a-zA-Z]+)(.*)(\1)";

            MatchCollection matches = Regex.Matches(text, pattern);

            int count = 0;

            foreach (Match item in matches)
            {
                string newValue = item.Groups[1] + placeholders[count++] + item.Groups[3];
                text = text.Replace(item.Value, newValue);
            }

            Console.WriteLine(text);
        }
    }
}
