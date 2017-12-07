namespace p01.ReverseString
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string toReverse = Console.ReadLine();
            var reversedCharArray = toReverse.ToCharArray().Reverse();
            Console.WriteLine(string.Join("", reversedCharArray));
        }
    }
}
