namespace p04.SumMinMaxAverage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<int> list = new List<int>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("Sum = " + list.Sum());
            Console.WriteLine("Min = " + list.Min());
            Console.WriteLine("Max = " + list.Max());
            Console.WriteLine("Average = " + list.Average());
        }
    }
}
