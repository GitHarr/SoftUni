namespace p13.VowelOrDigit
{
    using System;
    class StartUp
    {
        static void Main()
        {
            char symbol = char.Parse(Console.ReadLine());

            if (symbol == 'a' || symbol == 'o' || symbol == 'u' || symbol == 'e' || symbol == 'i' || symbol == 'y')
            {
                Console.WriteLine("vowel");
            }
            else if (symbol == '0' || symbol == '1' || symbol == '2' || symbol == '3' || symbol == '4' || symbol == '5' || symbol == '6' || symbol == '7' || symbol == '8' || symbol == '9')
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
