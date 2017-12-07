namespace _p14.FactorialTrailingZeroes
{
    using System;
    using System.Numerics;
    public class StartUp
    {
        public static void Main()
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger factorial = GetFactorial(n);
            Console.WriteLine(GetTrailingZeroes(factorial));
        }

        static BigInteger GetFactorial(BigInteger n)
        {
            BigInteger factorial = 1;

            do
            {
                factorial = factorial * n;
                n--;
            } while (n > 1);

            return factorial;
        }

        static BigInteger GetTrailingZeroes(BigInteger num)
        {

            BigInteger countZero = 0;
            while (num % 10 == 0)
            {
                num /= 10;
                countZero++;
            }

            return countZero;
        }    
    }
}
