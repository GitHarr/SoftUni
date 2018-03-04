namespace p02.ConvertFromBase_NToBase_10
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            string[] lineOfDigits = Console.ReadLine().Split();
            BigInteger baseToConvert = BigInteger.Parse(lineOfDigits[0]);
            char[] charredDigit = lineOfDigits[1].ToCharArray();
            List<string> reversedIntList = new List<string>();
            BigInteger sum = 0;

            for (int cycle2 = charredDigit.Length - 1; cycle2 >= 0; cycle2--)
            {
                reversedIntList.Add(charredDigit[cycle2].ToString());
            }

            for (int cycle = 0; cycle < reversedIntList.Count; cycle++)
            {
                BigInteger digitToMultiply = BigInteger.Parse(reversedIntList[cycle]);
                sum += digitToMultiply * (BigInteger)Math.Pow((double)baseToConvert, cycle);
            }

            Console.WriteLine(sum);
        }
    }
}
