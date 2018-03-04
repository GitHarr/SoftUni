namespace p02.OddOccurrences
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine().ToLower();
            string[] words = input.Split(' ');

            var counts = new Dictionary<string, int>();

            foreach (var word in words)

                if (counts.ContainsKey(word))
                {
                    counts[word]++;
                }

                else
                {
                    counts[word] = 1;
                }

            var results = new List<string>();

            foreach (var pair in counts)
            {
                if (pair.Value % 2 != 0)
                {
                    results.Add(pair.Key);
                }
            }

            Console.WriteLine(string.Join(", ", results));
        }
    }
}
