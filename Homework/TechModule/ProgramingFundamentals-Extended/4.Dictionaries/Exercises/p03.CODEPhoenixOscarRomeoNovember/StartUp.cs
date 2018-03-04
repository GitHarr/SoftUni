namespace p03.CODEPhoenixOscarRomeoNovember
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
            string input = Console.ReadLine();

            Dictionary<string, HashSet<string>> creatures = new Dictionary<string, HashSet<string>>();
            List<string> check = new List<string>();

            while (input != "Blaze it!")
            {
                string[] data = input.Split("-> ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                string creature = data[0];
                string squadMate = data[1];

                check.Add(squadMate + "" + creature);

                if (!creatures.ContainsKey(creature))
                {
                    creatures.Add(creature, new HashSet<string>());
                }

                if (creature == squadMate  || check.Contains(creature + "" + squadMate))
                {
                    creatures[squadMate].Remove(creature);
                    input = Console.ReadLine();
                    continue;
                }

                creatures[creature].Add(squadMate);

                input = Console.ReadLine();
            }

            foreach (var item in creatures.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{item.Key} : {item.Value.Count}");
            }
        }
    }
}
