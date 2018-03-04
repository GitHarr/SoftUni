namespace p01.CountRealNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            double[] input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            SortedDictionary<double, int> counts = new SortedDictionary<double, int>();

            foreach (var i in input)
            {
                if (counts.ContainsKey(i))
                {
                    counts[i]++;
                }

                else
                {
                    counts[i] = 1;
                }
            }

            foreach (var item in counts)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
