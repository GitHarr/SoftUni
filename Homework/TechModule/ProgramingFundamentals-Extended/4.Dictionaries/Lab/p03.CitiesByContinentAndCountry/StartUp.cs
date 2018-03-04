namespace p03.CitiesByContinentAndCountry
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StartUp
    {
        public static void Main()
        {
            var countries = new Dictionary<string, Dictionary<string, List<string>>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var continent = tokens[0];
                var country = tokens[1];
                var city = tokens[2];

                if (!countries.ContainsKey(continent))
                {
                    countries[continent] = new Dictionary<string, List<string>>();
                }

                var currentContinent = countries[continent];
                if (!countries[continent].ContainsKey(country))
                {
                    currentContinent[country] = new List<string>();
                }

                var currentCountry = currentContinent[country];
                currentCountry.Add(city);
            }

            foreach (var continent in countries)
            {
                Console.WriteLine(continent.Key + ":");

                foreach (var country in continent.Value)
                {
                    Console.Write("  " + country.Key + " -> ");
                    Console.WriteLine(string.Join(", ", country.Value));                    
                }
            }
        }
    }
}
