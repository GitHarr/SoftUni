namespace p03.EnglishNameOfLastDigit
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            long number = Math.Abs(long.Parse(Console.ReadLine()));

            Console.WriteLine(GetLastDigitString(number));
        }

        static string GetLastDigitString(long number)
        {
            long lastDigit = 0;
            string str = null;
            lastDigit = number % 10;
            switch (lastDigit)
            {
                case 0: str = "zero"; break;
                case 1: str = "one"; break;
                case 2: str = "two"; break;
                case 3: str = "three"; break;
                case 4: str = "four"; break;
                case 5: str = "five"; break;
                case 6: str = "six"; break;
                case 7: str = "seven"; break;
                case 8: str = "eight"; break;
                case 9: str = "nine"; break;
                default: break;
            }

            return str;
        }
    }
}
