namespace p03.SearchForANumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class StartUp
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            List<int> takenNums = new List<int>();

            takenNums = numbers;

            for (int i = 0; i < nums[0]; i++)
            {
                while (nums[1] > 0)
                {
                    nums[1]--;
                    takenNums.RemoveAt(0);
                }
            }
            if (takenNums.Contains(nums[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
