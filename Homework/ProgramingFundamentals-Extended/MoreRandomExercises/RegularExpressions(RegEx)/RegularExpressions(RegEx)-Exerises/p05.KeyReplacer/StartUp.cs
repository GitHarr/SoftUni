﻿namespace p05.KeyReplacer
{
    using System;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            string keyInput = Console.ReadLine();
            string textInput = Console.ReadLine();

            string patern = $@"^([a-zA-Z]+)[\\|\\<\\\\](.+)[\\|\\<\\\\]([a-zA-Z]+)$";
            Regex regex = new Regex(patern);

            Match match = regex.Match(keyInput);
            string start = match.Groups[1].Value;
            string end = match.Groups[3].Value;

            string wordPattern = $@"{start}(?!{end})(.*?){end}";
            MatchCollection matchCollection = Regex.Matches(textInput, wordPattern);

            if (matchCollection.Count > 0)
            {
                foreach (Match item in matchCollection)
                {
                    Console.Write(item.Groups[1].Value);
                }
                Console.WriteLine();
            }

            else
            {
                Console.WriteLine("Empty result");
            }
        }
    }
}