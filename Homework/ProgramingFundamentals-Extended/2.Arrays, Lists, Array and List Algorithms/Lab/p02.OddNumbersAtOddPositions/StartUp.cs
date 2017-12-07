namespace p02.OddNumbersAtOddPositions
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                if (i % 2 != 0 && nums[i] % 2 != 0)
                {
                    Console.WriteLine($"Index {i} -> {nums[i]}");
                }
            }
        }
    }
}
