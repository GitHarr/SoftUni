namespace p12.MasterNumber
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int num = 1; num <= number; num++)
            {
                if (isPalindrome(num) && (SumOfDigits(num) % 7 == 0) && CheckForEvenDigit(num))
                {
                    Console.WriteLine(num);
                }
            }
        }

        public static bool isPalindrome(int num)
        {
            string digits = "" + num;

            for (int i = 0; i < digits.Length / 2; i++)
            {
                if (digits[i] != digits[digits.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        public static int SumOfDigits(int num)
        {
            int sum = 0;

            while (num > 0)
            {
                sum += num % 10;
                num = num / 10;
            }
            return sum;
        }

       public static bool CheckForEvenDigit(int num)
        {
            string digits = "" + num;

            for (int i = 0; i < digits.Length; i++)
            {
                int digit = digits[i] - '0';

                if (digit % 2 == 0)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
