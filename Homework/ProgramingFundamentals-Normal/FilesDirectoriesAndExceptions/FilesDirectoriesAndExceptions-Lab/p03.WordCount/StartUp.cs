namespace p03.WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string[] allWords = File.ReadAllText("text.txt").ToLower()
                .Split(new char[] { ' ', '.', ',', '!', '?', '\r', '\n', '-' },
                StringSplitOptions.RemoveEmptyEntries);

            string[] words = File.ReadAllText("words.txt").Split(' ').Select(w => w.Trim()).ToArray();

            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach (var w in allWords)
            {

                if (dict.ContainsKey(w))
                {
                    dict[w]++;
                }
                else
                {
                    dict[w] = 1;
                }
            }
            File.WriteAllText("results.txt", "");

            foreach (var wordAndCount in dict.OrderByDescending(w => w.Value))
            {
                if (words.Contains(wordAndCount.Key))
                {
                    File.AppendAllText("results.txt", wordAndCount.Key + " -> " + wordAndCount.Value
                        + Environment.NewLine);
                }
            }
        }
    }
}

