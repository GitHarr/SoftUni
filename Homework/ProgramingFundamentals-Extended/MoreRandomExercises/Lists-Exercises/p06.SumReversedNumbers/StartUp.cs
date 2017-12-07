namespace p06.SumReversedNumbers
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
            List<string> nums = Console.ReadLine().Split(' ').ToList();

            List<int> solution = new List<int>(nums.Count);

            for (int i = 0; i < nums.Count; i++)
            {
                string temp = nums[i];
                char[] arr = temp.ToCharArray();
                Array.Reverse(arr);
                string strToInt = new string(arr);
                int toInts = int.Parse(strToInt);
                solution.Add(toInts);
            }

            Console.WriteLine(solution.Sum());
        }
    }
}
