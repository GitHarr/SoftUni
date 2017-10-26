namespace p04.NumbersInReversedOrder
{
    using System;
    class SartUp
    {
        static void Main()
        {
            string input = Console.ReadLine();
            PrintDigitsInReverce(input);
        }

        static void PrintDigitsInReverce(string input)
        {
            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.Write(input[i]);
            }
            Console.WriteLine();
        }
    }
}
