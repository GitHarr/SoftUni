namespace p04.SieveOfEratosthenes
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
            var n = int.Parse(Console.ReadLine());
            bool[] primes = new bool[n + 1];

            for (int i = 0; i <= n; i++)
            {
                primes[i] = true;
            }
            primes[0] = false;
            primes[1] = false;

            for (int p = 0; p < n; p++)
            {
                if (primes[p])
                {
                    for (int j = 2; j * p <= n; j++)
                    {
                        primes[j * p] = false;
                    }
                }
            }

            for (int i = 0; i < primes.Length; i++)
            {
                if (primes[i])
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
