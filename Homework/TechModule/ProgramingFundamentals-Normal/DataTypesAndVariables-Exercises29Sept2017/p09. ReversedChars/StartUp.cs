namespace p09.ReversedChars
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            char firstL = char.Parse(Console.ReadLine());
            char secondL = char.Parse(Console.ReadLine());
            char thirdL = char.Parse(Console.ReadLine());

            Console.WriteLine($"{thirdL}{secondL}{firstL}");
        }
    }
}
