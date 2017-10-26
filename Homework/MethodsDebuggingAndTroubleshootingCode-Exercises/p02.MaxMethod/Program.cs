namespace p02.MaxMethod
{
    using System;
    public class Program
    {
        public static void Main()
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int maxOfFirstCouple = GetMax(first, second);
            int maxOfSecondCouple = GetMax(second, third);

            if (maxOfFirstCouple > maxOfSecondCouple)
            {
                Console.WriteLine(maxOfFirstCouple);
            }
            else
            {
                Console.WriteLine(maxOfSecondCouple);
            }
        }

        static int GetMax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}
