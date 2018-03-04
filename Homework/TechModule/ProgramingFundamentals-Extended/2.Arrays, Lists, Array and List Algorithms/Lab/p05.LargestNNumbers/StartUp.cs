namespace p05.LargestNNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int n = int.Parse(Console.ReadLine());

            List<int> largestNElements = new List<int>(n);

            nums.Sort();
            nums.Reverse();

            for (int i = 0; i < n; i++)
            {
                largestNElements.Add(nums[i]);
            }

            Console.WriteLine(string.Join(" ", largestNElements));
        }
    }
}
