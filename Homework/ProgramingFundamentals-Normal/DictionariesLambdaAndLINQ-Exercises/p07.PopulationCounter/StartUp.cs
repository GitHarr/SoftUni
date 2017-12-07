namespace p07.PopulationCounter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class StartUp
    {
        public static void Main()
        {
            var countries = new Dictionary<string, Dictionary<string, long>>();
            var input = Console.ReadLine().Split('|').ToList();
            while (input[0] != "report")
            {
                var city = input[0];
                var country = input[1];
                var population = long.Parse(input[2]);

                if (!countries.ContainsKey(country))
                {
                    countries.Add(country, new Dictionary<string, long>());
                }
                countries[country].Add(city, population);


                input = Console.ReadLine().Split('|').ToList();
            }
            var sorted = countries
                .OrderByDescending(n => n.Value.Values.Sum())
                .ToDictionary(x => x.Key, y => y.Value);

            foreach (var KvP in sorted)
            {
                Console.WriteLine($"{KvP.Key} (total population: {KvP.Value.Values.Sum()})");
                foreach (var cityAndPop in KvP.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{cityAndPop.Key}: {cityAndPop.Value}");
                }
            }
        }
    }
    
}
