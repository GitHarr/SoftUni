namespace demo
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
            int[] inputArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int middleStartIndex = (inputArr.Length / 2) / 2;
            int middleEndIndex = middleStartIndex + inputArr.Length / 2;

            int summingIndex = middleStartIndex - 1;

            for (int i = middleStartIndex; i < middleEndIndex; i++)
            {
                int sum = inputArr[i] + inputArr[summingIndex];

                Console.Write($"{sum} ");

                summingIndex--;

                if (summingIndex < 0)
                {
                    summingIndex = inputArr.Length - 1;
                }
            }
        }
    }
}
