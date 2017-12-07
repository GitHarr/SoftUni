namespace p03.PokePower
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
            int pokePower = int.Parse(Console.ReadLine());
            int distancebetweenTargets = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            int targetCount = 0;
            int originalPokePower = pokePower;

            while (pokePower >= distancebetweenTargets)
            {
                pokePower -= distancebetweenTargets;
                targetCount++;

                if (pokePower == originalPokePower * 50 / 100.0 && exhaustionFactor != 0)
                {
                        pokePower = pokePower / exhaustionFactor;
                }
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(targetCount);
        }
    }
}
