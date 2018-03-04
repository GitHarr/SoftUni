namespace p01.ConvertFromBase_10ToBase_N
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Numerics;

    public class StartUp
    {
        public static void Main()
        { 
            BigInteger[] numbers = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();

            BigInteger baseN = (numbers[0]);
            BigInteger baseTenNum = (numbers[1]);

            BigInteger result = baseTenNum;
            BigInteger reminder = 0;

            StringBuilder sb = new StringBuilder();

            while (result != 0)
            {
                reminder = result % baseN;
                result = result / baseN;
                
                sb.Append(reminder);
            }

            Console.WriteLine(sb.ToString().ToCharArray().Reverse().ToArray());
        }
    }
}
