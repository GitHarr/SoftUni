namespace p15.FastPrimeChecker
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i <= num; i++)
            {
                bool isPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
            
                }
                if (i <= 1)
                {
                    continue;
                }
                Console.WriteLine($"{i} -> {isPrime}");
            }
        }
    }
}
