namespace p03.HornetAssault
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var beehives = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();

            var hornets = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(long.Parse)
                 .ToList();

            List<long> aliveBeehives = new List<long>();

            foreach (var beehive in beehives)
            {
                if (hornets.Count == 0)
                {
                    aliveBeehives.Add(beehive);
                    continue;
                }
                var power = hornets.Sum();

                if (power >= beehive)
                {
                    if (power == beehive)
                    {
                        hornets.RemoveAt(0);
                    }
                }

                else
                {
                    aliveBeehives.Add(beehive - power);
                    hornets.RemoveAt(0);
                }
            }

            if (aliveBeehives.Count != 0)
            {
                Console.WriteLine(string.Join(" ", aliveBeehives));
            }

            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
        }
    }
}
