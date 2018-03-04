namespace p05.PokemonEvolution
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string input;

            Dictionary<string, List<string>> pokemons = new Dictionary<string, List<string>>();

            while ("wubbalubbadubdub" != (input = Console.ReadLine()))
            {
                string[] tokens = input.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Length > 1)
                {
                    if (!pokemons.ContainsKey(tokens[0]))
                    {
                        pokemons.Add(tokens[0], new List<string>());
                    }

                    string typeIndex = tokens[1] + " <-> " + tokens[2];

                    pokemons[tokens[0]].Add(typeIndex);
                }

                else if (pokemons.ContainsKey(tokens[0]))
                {
                    Console.WriteLine($"# {tokens[0]}");
                    pokemons[tokens[0]].ForEach(Console.WriteLine);
                }
            }

            foreach (var item in pokemons)
            {
                Console.WriteLine($"# {item.Key}");

                var ordered = item.Value.OrderByDescending(a => int.Parse(a.Split(new[] { " <-> " },
                        StringSplitOptions.RemoveEmptyEntries)[1]));

            foreach (var output in ordered)
                {
                    Console.WriteLine(output);
                }
            }
        }
    }
}
