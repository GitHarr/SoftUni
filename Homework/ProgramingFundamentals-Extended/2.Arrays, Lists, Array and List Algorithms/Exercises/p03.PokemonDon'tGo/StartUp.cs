namespace p03.PokemonDon_tGo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            int sumRemovedElems = 0;
            int copy = 0;
            int sumElems = nums.Sum();

            while (sumElems > 0)
            {
                int index = int.Parse(Console.ReadLine());

                if (index < 0)
                {
                    copy = nums.First();
                    nums[0] = nums[nums.Count - 1];
                }

                else if (index > nums.Count - 1)
                {
                    copy = nums.Last();
                    nums.RemoveAt(nums.Count - 1);
                    nums.Add(nums[0]);
                }

                else
                {
                    copy = nums[index];
                    nums.RemoveAt(index);
                }

                sumRemovedElems += copy;

                List<int> numsAfter = new List<int>(); 

                for (int i = 0; i < nums.Count; i++)
                {
                    int currentElem = nums[i];

                    if (currentElem <= copy)
                    {
                        currentElem = currentElem + copy;
                    }

                    else
                    {
                        currentElem = currentElem - copy;
                    }

                    numsAfter.Add(currentElem);
                }

                nums.Clear();
                nums = numsAfter;
                sumElems = nums.Sum();
            }

            Console.WriteLine(sumRemovedElems);
        }
    }
}
