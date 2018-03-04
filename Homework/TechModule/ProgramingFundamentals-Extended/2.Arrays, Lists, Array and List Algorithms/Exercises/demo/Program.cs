using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            int number = 5;

            foreach (var num in nums)
            {
                if (number >= nums[num])
                {
                    nums[num] += number;
                }

                else
                {
                    nums[num] -= number;
                }
            }
        }
    }
}
