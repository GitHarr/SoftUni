namespace _01.Trainegram
{
    using System;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"^(<\[[^a-zA-Z0-9\n]*]\.)(\.\[[a-zA-Z0-9]*]\.)*$";
            while (input != "Traincode!")
            {
                if (Regex.IsMatch(input, pattern))
                {
                    Console.WriteLine(input);
                }
                input = Console.ReadLine();
            }
        }
    }
}
