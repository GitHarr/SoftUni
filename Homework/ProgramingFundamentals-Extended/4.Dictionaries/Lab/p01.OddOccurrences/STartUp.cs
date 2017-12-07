namespace p01.OddOccurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string[] words = Console.ReadLine().Split().Select(x => x.ToLower()).ToArray();

            Dictionary<string, int> count = new Dictionary<string, int>();

            foreach (var item in words)
            {
                if (count.ContainsKey(item))
                {
                    count[item]++;
                }

                else
                {
                    count[item] = 1;
                }
            }

            List<string> result = new List<string>();

            foreach (var item in count)
            {
                if (item.Value % 2 != 0)
                {
                    result.Add(item.Key);
                }
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
