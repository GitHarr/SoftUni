namespace p09.MatchNumbers
{
    using System;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            var regex = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";

            var numberStrings = Console.ReadLine();

            var numbers = Regex.Matches(numberStrings, regex);

            foreach (Match number in numbers)
            {
                Console.Write(number.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
