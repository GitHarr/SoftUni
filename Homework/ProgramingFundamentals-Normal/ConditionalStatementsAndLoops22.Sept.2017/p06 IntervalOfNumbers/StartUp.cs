

namespace p06_IntervalOfNumbers
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            int lineOne = int.Parse(Console.ReadLine());
            int lineTwo = int.Parse(Console.ReadLine());

            if (lineOne < lineTwo)
            {
                for (int i = lineOne; i <= lineTwo; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                for (int i = lineTwo; i <= lineOne; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
