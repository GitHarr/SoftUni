namespace p06.PrimeChecker1
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            long num = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(num));
        }

        static bool IsPrime(long num)
        {
            bool isPrime = true;

            for (long i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                }
            }

            if (num <= 1)
            {
                isPrime = false;
            }

            return isPrime;
        }
    }
}
