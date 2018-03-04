namespace p11.EqualSums
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StartUp
    {
        public static void Main()
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int leftSum = 0;
            int rightSum = 0;
            int indexValue = 0;
            bool foundEqualSums = false;

            for (int i = 0; i < nums.Length; i++)
            {
                indexValue = nums[i];

                for (int j = 0; j < i; j++)
                {
                    leftSum += nums[j];
                }

                for (int k = i + 1; k < nums.Length; k++)
                {
                    rightSum += nums[k];
                }

                if (leftSum == rightSum)
                {
                    foundEqualSums = true;
                    Console.WriteLine(i);
                    break;
                }

                //if (leftSum == 0 && rightSum == 0)
                //{
                //    foundEqualSums = true;
                //    Console.WriteLine("0");
                //    break;
                //}

                leftSum = 0;
                rightSum = 0;
            }

            if (!foundEqualSums)
            {
                Console.WriteLine("no");
            }
        }
    }
}
