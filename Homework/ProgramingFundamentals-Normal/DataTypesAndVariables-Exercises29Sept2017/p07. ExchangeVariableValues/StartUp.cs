namespace p07.ExchangeVariableValues
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            int a = 5;
            int b = 10;

            int copyOldA = a;
            a = b;
            b = copyOldA;

            Console.WriteLine($"Before:\na = {b}\nb = {a}");
            Console.WriteLine($"After:\na = {a}\nb = {b}");
        }
    }
}
