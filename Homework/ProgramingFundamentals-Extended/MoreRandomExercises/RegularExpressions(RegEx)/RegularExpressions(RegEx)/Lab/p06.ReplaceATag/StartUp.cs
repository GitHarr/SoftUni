namespace p06.ReplaceATag
{
    using System;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            string text = Console.ReadLine();

            string pattern = @"<a.*?href.*?=(.*)>(.*?)<\/a>";

            string replacement = @"[URL href=$1]$2[/URL]";

            while (text != "end")
            {
                string replaced = Regex.Replace(text, pattern, replacement);

                Console.WriteLine(replaced);

                text = Console.ReadLine();
            }
        }
    }
}
