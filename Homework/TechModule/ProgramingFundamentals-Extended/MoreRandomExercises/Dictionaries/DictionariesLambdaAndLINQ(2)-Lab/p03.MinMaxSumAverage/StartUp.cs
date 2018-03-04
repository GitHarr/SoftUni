namespace p03.MinMaxSumAverage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<int> nums = new List<int>(n);

            for (int i = 0; i < n; i++)
            {
                int inputNum = int.Parse(Console.ReadLine());
                nums.Add(inputNum);
            }

            Console.WriteLine($"Sum = {nums.Sum()}");
            Console.WriteLine($"Min = {nums.Min()}");
            Console.WriteLine($"Max = {nums.Max()}");
            Console.WriteLine($"Average = {nums.Average()}");
        }
    }
}
