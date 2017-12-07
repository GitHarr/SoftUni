namespace p03.ArrayContainsElement
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            int n = int.Parse(Console.ReadLine());

            if (nums.Contains(n))
            {
                Console.WriteLine("yes");
            }

            else
            {
                Console.WriteLine("no");
            }

            //bool isContained = false;

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] == n)
            //    {
            //        isContained = true;
            //        break;
            //    }
            //}

            //if (isContained == false)
            //{
            //    Console.WriteLine("no");
            //}

            //else
            //{
            //    Console.WriteLine("yes");
            //}
        }
    }
}
