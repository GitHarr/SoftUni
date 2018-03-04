namespace p03.SearchForANumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int[] items = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int elementsToTake = items[0];
            int elementsToDelete = items[1];
            int searchNum = items[2];

            var afterMath = nums.Take(elementsToTake).ToList();

            afterMath.RemoveRange(0, elementsToDelete);

            if (afterMath.Contains(searchNum))
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
