namespace p04.HornetAssault
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
            List<long> beehives = Console.ReadLine().Split(' ').Select(long.Parse).ToList();

            List<long> hornets = Console.ReadLine().Split(' ').Select(long.Parse).ToList();

            long hornetPower = hornets.Sum();

            for (int i = 0; i < beehives.Count; i++)
            {

                if (hornets.Count == 0)
                {
                    break;
                }

                if (beehives[i] < hornetPower)
                {
                    beehives[i] = 0;
                }

                else
                {
                    beehives[i] -= hornetPower;
                    hornetPower -= hornets[0];
                    hornets.RemoveAt(0);
                }
            }

            if (beehives.Sum() > 0)
            {
                Console.WriteLine(string.Join(" ", beehives.Where(e => e != 0)));
            }

            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
        }
    }
}
