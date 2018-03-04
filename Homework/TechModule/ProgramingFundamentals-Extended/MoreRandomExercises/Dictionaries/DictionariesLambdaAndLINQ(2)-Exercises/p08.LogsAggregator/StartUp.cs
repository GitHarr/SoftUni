namespace p08.LogsAggregator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var namesIpsDurations = new SortedDictionary<string, SortedDictionary<string, int>>();

            var count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                var line = Console.ReadLine();

                var tokens = line.Split();

                var name = tokens[1];
                var ip = tokens[0];
                var duration = int.Parse(tokens[2]);

                if (!namesIpsDurations.ContainsKey(name))
                {
                    namesIpsDurations[name] = new SortedDictionary<string, int>();
                }

                if (!namesIpsDurations[name].ContainsKey(ip))
                {
                    namesIpsDurations[name][ip] = 0;
                }

                namesIpsDurations[name][ip] += duration;
            }

            foreach (var nameIpsDuratins in namesIpsDurations)
            {
                var name = nameIpsDuratins.Key;
                var ipsDurations = nameIpsDuratins.Value;

                var totalDurations = ipsDurations.Sum(a => a.Value);
                var ips = ipsDurations.Keys;

                Console.WriteLine($"{name}: {totalDurations} [{string.Join(", ", ips)}]");
            }
        }
    }
}
