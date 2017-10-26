namespace p07.PrimesInGivenRange
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            var primes = FindPrimesInRange(startNum, endNum);
            Console.WriteLine(string.Join(", ", primes));
        }

        static bool isPrime(int n)
        {
            bool prime = true;

            if (n == 0 || n == 1)
            {
                prime = false;
            }

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    prime = false;
                }
               
            }

            return prime;
        }

        private static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            var primes = new List<int>();
            for (int currentNum = startNum; currentNum <= endNum; currentNum++)
            {
                if (isPrime(currentNum))
                {
                    primes.Add(currentNum);
                }
            }

            return primes;
        }
    }
}
